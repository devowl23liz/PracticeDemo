using demo.Models;

namespace demo.Controls
{
    public partial class ProductCard : UserControl
    {
        private Product _product;

        public ProductCard(Product product)
        {
            InitializeComponent();
            _product = product;
            LoadProductData();
            ApplyStyleByDiscount();
        }

        private void LoadProductData()
        {
            if (!string.IsNullOrEmpty(_product.PhotoUrl) && File.Exists(_product.PhotoUrl))
            {
                try
                {
                    pbPhoto.Image = Image.FromFile(_product.PhotoUrl);
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

            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;

            lblCategory.Text = _product.Category ?? "Без категории";
            lblProductName.Text = _product.ProductName ?? "Без названия";
            lblDescription.Text = $"Описание: {_product.Description ?? "Нет описания"}";
            lblManufacturer.Text = $"Производитель: {_product.Manufacturer ?? "Не указан"}";
            lblSupplier.Text = $"Поставщик: {_product.Supplier ?? "Не указан"}";
            lblUnit.Text = $"Ед. измерения: {_product.UnitOfMeasure ?? "шт."}";
            lblStock.Text = $"Количество на складе: {_product.StockQuantity}";

            decimal finalPrice = (decimal)(_product.Price * (1 - (_product.CurrentDiscount / 100)));

            if (_product.CurrentDiscount > 0)
            {
                lblOriginalPrice.Text = $"{_product.Price:F2} руб.";
                lblOriginalPrice.ForeColor = Color.Red;
                lblOriginalPrice.Font = new Font(Font, FontStyle.Strikeout);
                lblFinalPrice.Text = $"{finalPrice:F2} руб.";
                lblFinalPrice.ForeColor = Color.Black;
            }
            else
            {
                lblOriginalPrice.Text = "";
                lblFinalPrice.Text = $"{_product.Price:F2} руб.";
                lblFinalPrice.ForeColor = Color.Black;
            }

            lblDiscount.Text = $"Скидка: {_product.CurrentDiscount}%";
        }

        private void ApplyStyleByDiscount()
        {
            if (_product.CurrentDiscount > 15)
            {
                BackColor = Color.FromArgb(46, 139, 87);
            }
        }

        public event EventHandler EditClicked;

        private void ProductCard_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ChildControl_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        public Product GetProduct() => _product;
    }
}