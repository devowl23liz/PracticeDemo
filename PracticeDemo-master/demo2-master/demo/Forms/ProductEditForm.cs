using demo.Models;

namespace demo.Forms
{
    public partial class ProductEditForm : Form
    {
        private Product _product;
        private bool _isEditMode;
        private string _oldPhotoPath;
        public static bool IsOpen = false;

        public ProductEditForm(Product product = null)
        {
            InitializeComponent();

            if (IsOpen)
            {
                throw new Exception("Окно редактирования уже открыто");
            }
            IsOpen = true;
            FormClosed += (s, e) => IsOpen = false;

            _product = product ?? new Product();
            _isEditMode = product != null;

            LoadCategories();
            LoadManufacturers();
            LoadData();
        }

        private void LoadCategories()
        {
            using DemoDbContext db = new DemoDbContext();
            List<string?> categories = db.Products.Select(p => p.Category).Where(c => c != null).Distinct().ToList();
            cbCategory.Items.Clear();
            cbCategory.Items.AddRange(categories.ToArray());
            cbCategory.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void LoadManufacturers()
        {
            using DemoDbContext db = new DemoDbContext();
            List<string?> manufacturers = db.Products.Select(p => p.Manufacturer).Where(m => m != null).Distinct().ToList();
            cbManufacturer.Items.Clear();
            cbManufacturer.Items.AddRange(manufacturers.ToArray());
            cbManufacturer.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void LoadData()
        {
            if (_isEditMode)
            {
                Text = "Редактирование товара";
                lblIdTitle.Visible = true;
                lblIdValue.Visible = true;
                lblIdValue.Text = _product.Id.ToString();

                txtProductName.Text = _product.ProductName;
                cbCategory.Text = _product.Category;
                txtDescription.Text = _product.Description;
                cbManufacturer.Text = _product.Manufacturer;
                txtSupplier.Text = _product.Supplier;
                numPrice.Value = _product.Price;
                txtUnit.Text = _product.UnitOfMeasure;
                numStockQuantity.Value = (decimal)_product.StockQuantity;
                numDiscount.Value = (decimal)_product.CurrentDiscount;

                if (!string.IsNullOrEmpty(_product.PhotoUrl) && File.Exists(_product.PhotoUrl))
                {
                    try
                    {
                        pbPhoto.Image = Image.FromFile(_product.PhotoUrl);
                        _oldPhotoPath = _product.PhotoUrl;
                    }
                    catch
                    {
                        MemoryStream ms = new MemoryStream(Properties.Resources.pic);
                        pbPhoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MemoryStream ms = new MemoryStream(Properties.Resources.pic);
                    pbPhoto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                Text = "Добавление товара";
                lblIdTitle.Visible = false;
                lblIdValue.Visible = false;
                MemoryStream ms = new MemoryStream(Properties.Resources.pic);
                pbPhoto.Image = Image.FromStream(ms);
                numPrice.Value = 0;
                numStockQuantity.Value = 0;
                numDiscount.Value = 0;
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Выберите изображение товара";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbPhoto.Image = Image.FromFile(ofd.FileName);
                    _selectedPhotoPath = ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string _selectedPhotoPath;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Введите наименование товара", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numPrice.Value < 0)
            {
                MessageBox.Show("Цена не может быть отрицательной", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numStockQuantity.Value < 0)
            {
                MessageBox.Show("Количество на складе не может быть отрицательным", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numDiscount.Value < 0 || numDiscount.Value > 100)
            {
                MessageBox.Show("Скидка должна быть от 0 до 100 процентов", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (DemoDbContext db = new DemoDbContext())
                {
                    Product productToSave;

                    if (_isEditMode)
                    {
                        productToSave = db.Products.Find(_product.Id);
                        if (productToSave == null)
                        {
                            MessageBox.Show("Товар не найден в базе данных", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        productToSave = new Product();
                        db.Products.Add(productToSave);
                    }

                    productToSave.ProductName = txtProductName.Text.Trim();
                    productToSave.Category = cbCategory.Text.Trim();
                    productToSave.Description = txtDescription.Text.Trim();
                    productToSave.Manufacturer = cbManufacturer.Text.Trim();
                    productToSave.Supplier = txtSupplier.Text.Trim();
                    productToSave.Price = numPrice.Value;
                    productToSave.UnitOfMeasure = txtUnit.Text.Trim();
                    productToSave.StockQuantity = (int)numStockQuantity.Value;
                    productToSave.CurrentDiscount = numDiscount.Value;

                    if (!string.IsNullOrEmpty(_selectedPhotoPath))
                    {
                        string appFolder = Application.StartupPath;
                        string photosFolder = Path.Combine(appFolder, "Photos");
                        if (!Directory.Exists(photosFolder))
                            Directory.CreateDirectory(photosFolder);

                        string newFileName = $"{Guid.NewGuid()}{Path.GetExtension(_selectedPhotoPath)}";
                        string newFilePath = Path.Combine(photosFolder, newFileName);

                        File.Copy(_selectedPhotoPath, newFilePath, true);

                        if (_isEditMode && !string.IsNullOrEmpty(_oldPhotoPath) && File.Exists(_oldPhotoPath))
                        {
                            if (_oldPhotoPath != newFilePath)
                                File.Delete(_oldPhotoPath);
                        }

                        productToSave.PhotoUrl = newFilePath;
                    }
                    else if (!_isEditMode)
                    {
                        productToSave.PhotoUrl = "";
                    }

                    db.SaveChanges();
                }

                MessageBox.Show(_isEditMode ? "Товар успешно обновлен" : "Товар успешно добавлен",
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}