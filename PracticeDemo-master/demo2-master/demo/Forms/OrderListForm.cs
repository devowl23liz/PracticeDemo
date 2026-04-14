using demo.Controls;
using demo.Models;
using Microsoft.EntityFrameworkCore;

namespace demo.Forms
{
    public partial class OrderListForm : Form
    {
        private List<Order> _allOrders;

        public OrderListForm()
        {
            InitializeComponent();
            Font = new Font("Times New Roman", 10);
            LoadOrders();

            if (Session.IsAdmin)
            {
                btnAddOrder.Visible = true;
            }
        }

        private void LoadOrders()
        {
            using (DemoDbContext db = new DemoDbContext())
            {
                _allOrders = db.Orders
                    .Include(o => o.PickupPoint)
                    .ToList();
            }
            RefreshOrderList();
        }

        private void RefreshOrderList()
        {
            flpOrders.Controls.Clear();

            IEnumerable<Order> filtered = _allOrders.AsEnumerable();

            if ((Session.IsAdmin || Session.IsManager) && !string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                filtered = filtered.Where(o =>
                    (o.OrderNumber != null && o.OrderNumber.ToString().ToLower().Contains(searchText)) ||
                    (o.CustomerFullName != null && o.CustomerFullName.ToLower().Contains(searchText)) ||
                    (o.OrderStatus != null && o.OrderStatus.ToLower().Contains(searchText)) ||
                    (o.PickupPoint != null && o.PickupPoint.Address != null && o.PickupPoint.Address.ToLower().Contains(searchText)));
            }

            if ((Session.IsAdmin || Session.IsManager) && cbStatus.SelectedItem != null && cbStatus.SelectedItem.ToString() != "Все статусы")
            {
                string status = cbStatus.SelectedItem.ToString();
                filtered = filtered.Where(o => o.OrderStatus == status);
            }

            if ((Session.IsAdmin || Session.IsManager))
            {
                if (cbSort.SelectedIndex == 1)
                    filtered = filtered.OrderBy(o => o.OrderDate);
                else if (cbSort.SelectedIndex == 2)
                    filtered = filtered.OrderByDescending(o => o.OrderDate);
            }

            foreach (Order? order in filtered)
            {
                OrderCard card = new OrderCard(order);
                if (Session.IsAdmin)
                {
                    card.EditClicked += Card_EditClicked;
                }
                flpOrders.Controls.Add(card);
            }
        }

        private void LoadStatuses()
        {
            using DemoDbContext db = new DemoDbContext();
            List<string> statuses = db.Orders.Select(o => o.OrderStatus).Where(s => s != null).Distinct().ToList();
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Все статусы");
            cbStatus.Items.AddRange(statuses.ToArray());
            cbStatus.SelectedIndex = 0;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            RefreshOrderList();
        }

        private void Card_EditClicked(object sender, EventArgs e)
        {
            OrderCard? card = sender as OrderCard;
            if (card != null)
            {
                if (OrderEditForm.IsOpen)
                {
                    MessageBox.Show("Окно редактирования заказа уже открыто. Закройте его перед открытием нового.",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OrderEditForm editForm = new OrderEditForm(card.GetOrder());
                editForm.ShowDialog();
                LoadOrders();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (OrderEditForm.IsOpen)
            {
                MessageBox.Show("Окно редактирования заказа уже открыто. Закройте его перед открытием нового.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OrderEditForm editForm = new OrderEditForm(null);
            editForm.ShowDialog();
            LoadOrders();
        }
    }
}