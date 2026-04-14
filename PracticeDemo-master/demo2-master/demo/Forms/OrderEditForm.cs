using demo.Models;

namespace demo.Forms
{
    public partial class OrderEditForm : Form
    {
        private Order _order;
        private bool _isEditMode;
        public static bool IsOpen = false;

        public OrderEditForm(Order order = null)
        {
            InitializeComponent();
            Font = new Font("Times New Roman", 10);

            if (IsOpen)
            {
                throw new Exception("Окно редактирования заказа уже открыто");
            }
            IsOpen = true;
            FormClosed += (s, e) => IsOpen = false;

            _order = order ?? new Order();
            _isEditMode = order != null;

            LoadStatuses();
            LoadPickupPoints();
            LoadData();
        }

        private void LoadStatuses()
        {
            using DemoDbContext db = new DemoDbContext();
            List<string> statuses = db.Orders.Select(o => o.OrderStatus).Where(s => s != null).Distinct().ToList();
            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(statuses.ToArray());

            if (cbStatus.Items.Count == 0)
            {
                cbStatus.Items.AddRange(new string[] { "Новый", "В обработке", "Доставлен", "Выполнен", "Отменён" });
            }
            cbStatus.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void LoadPickupPoints()
        {
            using DemoDbContext db = new DemoDbContext();
            List<PickupPoint> points = db.PickupPoints.ToList();
            cbPickupPoint.DisplayMember = "Address";
            cbPickupPoint.ValueMember = "Id";
            cbPickupPoint.DataSource = points;
            cbPickupPoint.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadData()
        {
            if (_isEditMode)
            {
                Text = "Редактирование заказа";
                lblIdTitle.Visible = true;
                lblIdValue.Visible = true;
                lblIdValue.Text = _order.Id.ToString();

                txtOrderNumber.Text = _order.OrderNumber.ToString();
                cbStatus.Text = _order.OrderStatus;

                cbPickupPoint.SelectedValue = _order.PickupPointId;


                dtpOrderDate.Value = _order.OrderDate.ToDateTime(TimeOnly.MinValue);

                if (_order.DeliveryDate.HasValue)
                {
                    dtpDeliveryDate.Value = (DateTime)(_order.DeliveryDate?.ToDateTime(TimeOnly.MinValue));
                    chkHasDeliveryDate.Checked = true;
                    dtpDeliveryDate.Enabled = true;
                }
                else
                {
                    chkHasDeliveryDate.Checked = false;
                    dtpDeliveryDate.Enabled = false;
                }

                txtCustomerName.Text = _order.CustomerFullName;
                txtPickupCode.Text = _order.PickupCode;
                txtOrderArticles.Text = _order.OrderArticles;
            }
            else
            {
                Text = "Добавление заказа";
                lblIdTitle.Visible = false;
                lblIdValue.Visible = false;

                dtpOrderDate.Value = DateTime.Now;
                chkHasDeliveryDate.Checked = false;
                dtpDeliveryDate.Enabled = false;
                cbStatus.SelectedIndex = 0;

                if (cbPickupPoint.Items.Count > 0)
                {
                    cbPickupPoint.SelectedIndex = 0;
                }
            }
        }

        private void chkHasDeliveryDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDeliveryDate.Enabled = chkHasDeliveryDate.Checked;
            if (!chkHasDeliveryDate.Checked)
            {
                dtpDeliveryDate.Value = DateTime.Now;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text))
            {
                MessageBox.Show("Введите артикул заказа", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbPickupPoint.SelectedValue == null)
            {
                MessageBox.Show("Выберите пункт выдачи", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (DemoDbContext db = new DemoDbContext())
                {
                    Order orderToSave;

                    if (_isEditMode)
                    {
                        orderToSave = db.Orders.Find(_order.Id);
                        if (orderToSave == null)
                        {
                            MessageBox.Show("Заказ не найден в базе данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        orderToSave = new Order();
                        db.Orders.Add(orderToSave);
                    }

                    orderToSave.OrderNumber = Convert.ToInt32(txtOrderNumber.Text.Trim());
                    orderToSave.OrderStatus = cbStatus.Text.Trim();
                    orderToSave.PickupPointId = (int)cbPickupPoint.SelectedValue;
                    orderToSave.OrderDate = DateOnly.FromDateTime(dtpOrderDate.Value);
                    orderToSave.DeliveryDate = chkHasDeliveryDate.Checked ? DateOnly.FromDateTime(dtpDeliveryDate.Value) : null;
                    orderToSave.CustomerFullName = txtCustomerName.Text.Trim();
                    orderToSave.PickupCode = txtPickupCode.Text.Trim();
                    orderToSave.OrderArticles = txtOrderArticles.Text.Trim();

                    db.SaveChanges();
                }

                MessageBox.Show(_isEditMode ? "Заказ успешно обновлен" : "Заказ успешно добавлен",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
                return;
            }

            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить заказ {_order.OrderNumber}?\nЭто действие нельзя отменить.",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using DemoDbContext db = new DemoDbContext();
                    Order? orderToDelete = db.Orders.Find(_order.Id);
                    if (orderToDelete != null)
                    {
                        db.Orders.Remove(orderToDelete);
                        db.SaveChanges();

                        MessageBox.Show("Заказ успешно удален", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Заказ не найден в базе данных", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}