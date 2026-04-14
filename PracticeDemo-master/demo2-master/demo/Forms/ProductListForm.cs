using demo.Controls;
using demo.Models;

namespace demo.Forms
{
    public partial class ProductListForm : Form
    {
        private List<Product> _allProducts;
        private List<string> _suppliers;

        public ProductListForm()
        {
            InitializeComponent();
            LoadProducts();
            LoadSuppliers();

            if (Session.IsAdmin || Session.IsManager)
            {
                txtSearch.Visible = true;
                cbSupplier.Visible = true;
                cbSort.Visible = true;
                btnOrders.Visible = true;
            }

            if (Session.IsAdmin)
            {
                btnAddProduct.Visible = true;
            }

            if (Session.IsAuthenticated)
            {
                lblUserInfo.Text = Session.CurrentUser.FullName;
            }
            else
            {
                lblUserInfo.Text = "Гость";
            }
        }

        private void LoadProducts()
        {
            using (DemoDbContext db = new DemoDbContext())
            {
                _allProducts = db.Products.ToList();
            }
            RefreshProductList();
        }

        private void LoadSuppliers()
        {
            using (DemoDbContext db = new DemoDbContext())
            {
                _suppliers = db.Products.Select(p => p.Supplier).Where(s => s != null).Distinct().ToList();
            }
            cbSupplier.Items.Clear();
            cbSupplier.Items.Add("Все поставщики");
            cbSupplier.Items.AddRange(_suppliers.ToArray());
            cbSupplier.SelectedIndex = 0;
        }

        private void RefreshProductList()
        {
            flpProducts.Controls.Clear();

            IEnumerable<Product> filtered = _allProducts.AsEnumerable();

            if ((Session.IsAdmin || Session.IsManager) && !string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                string searchText = txtSearch.Text.Trim().ToLower();
                filtered = filtered.Where(p =>
                    (p.ProductName != null && p.ProductName.ToLower().Contains(searchText)) ||
                    (p.Category != null && p.Category.ToLower().Contains(searchText)) ||
                    (p.Description != null && p.Description.ToLower().Contains(searchText)) ||
                    (p.Manufacturer != null && p.Manufacturer.ToLower().Contains(searchText)) ||
                    (p.Supplier != null && p.Supplier.ToLower().Contains(searchText)));
            }

            if ((Session.IsAdmin || Session.IsManager) && cbSupplier.SelectedItem != null && cbSupplier.SelectedItem.ToString() != "Все поставщики")
            {
                string supplier = cbSupplier.SelectedItem.ToString();
                filtered = filtered.Where(p => p.Supplier == supplier);
            }

            if ((Session.IsAdmin || Session.IsManager) && cbSort.SelectedIndex != 0)
            {
                if (cbSort.SelectedIndex == 1)
                    filtered = filtered.OrderBy(p => p.StockQuantity);
                else if (cbSort.SelectedIndex == 2)
                    filtered = filtered.OrderByDescending(p => p.StockQuantity);
            }

            foreach (Product? product in filtered)
            {
                ProductCard card = new ProductCard(product);
                if (Session.IsAdmin)
                {
                    card.EditClicked += Card_EditClicked;
                }
                flpProducts.Controls.Add(card);
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            RefreshProductList();
        }

        private void Card_EditClicked(object sender, EventArgs e)
        {
            ProductCard? card = sender as ProductCard;
            if (card != null)
            {
                if (ProductEditForm.IsOpen)
                {
                    MessageBox.Show("Окно редактирования уже открыто. Закройте его перед открытием нового.",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProductEditForm editForm = new ProductEditForm(card.GetProduct());
                editForm.ShowDialog();
                LoadProducts();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.CurrentUser = null;
            Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderListForm ordersForm = new OrderListForm();
            ordersForm.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (ProductEditForm.IsOpen)
            {
                MessageBox.Show("Окно редактирования уже открыто. Закройте его перед открытием нового.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductEditForm editForm = new ProductEditForm(null);
            editForm.ShowDialog();
            LoadProducts();
        }
    }
}