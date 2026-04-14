using demo.Models;

namespace demo.Controls
{
    public partial class OrderCard : UserControl
    {
        private Order _order;

        public OrderCard(Order order)
        {
            InitializeComponent();
            _order = order;
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            lblOrderNumber.Text = _order.OrderNumber.ToString();
            lblStatus.Text = _order.OrderStatus ?? "Не указан";

            string address = _order.PickupPoint?.Address ?? "Не указан";
            lblPickupAddress.Text = address;

            lblOrderDate.Text = _order.OrderDate.ToString("dd.MM.yyyy");

            lblDeliveryDate.Text = _order.DeliveryDate.HasValue ?
                _order.DeliveryDate.Value.ToString("dd.MM.yyyy") : "Не указана";

            if (_order.OrderStatus?.ToLower() == "выполнен" || _order.OrderStatus?.ToLower() == "completed")
            {
                BackColor = Color.FromArgb(46, 139, 87);
            }
            else if (_order.OrderStatus?.ToLower() == "отменён" || _order.OrderStatus?.ToLower() == "cancelled")
            {
                BackColor = Color.LightGray;
            }
        }

        public event EventHandler EditClicked;

        private void OrderCard_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ChildControl_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        public Order GetOrder() => _order;
    }
}