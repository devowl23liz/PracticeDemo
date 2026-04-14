namespace demo.Controls
{
    partial class ProductCard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel pnlSeparator;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pbPhoto = new PictureBox();
            lblCategory = new Label();
            lblProductName = new Label();
            lblDescription = new Label();
            lblManufacturer = new Label();
            lblSupplier = new Label();
            lblUnit = new Label();
            lblStock = new Label();
            lblOriginalPrice = new Label();
            lblFinalPrice = new Label();
            lblDiscount = new Label();
            pnlSeparator = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbPhoto
            // 
            pbPhoto.Location = new Point(10, 10);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(195, 210);
            pbPhoto.TabIndex = 0;
            pbPhoto.TabStop = false;
            pbPhoto.Click += ChildControl_Click;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Times New Roman", 9F, FontStyle.Italic);
            lblCategory.Location = new Point(211, 3);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(200, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Категория";
            lblCategory.Click += ChildControl_Click;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            lblProductName.Location = new Point(211, 23);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(250, 25);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Наименование товара";
            lblProductName.Click += ChildControl_Click;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Times New Roman", 9F);
            lblDescription.Location = new Point(211, 48);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(250, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Описание:";
            lblDescription.Click += ChildControl_Click;
            // 
            // lblManufacturer
            // 
            lblManufacturer.Font = new Font("Times New Roman", 9F);
            lblManufacturer.Location = new Point(211, 68);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(250, 20);
            lblManufacturer.TabIndex = 4;
            lblManufacturer.Text = "Производитель:";
            lblManufacturer.Click += ChildControl_Click;
            // 
            // lblSupplier
            // 
            lblSupplier.Font = new Font("Times New Roman", 9F);
            lblSupplier.Location = new Point(211, 88);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(250, 20);
            lblSupplier.TabIndex = 5;
            lblSupplier.Text = "Поставщик:";
            lblSupplier.Click += ChildControl_Click;
            // 
            // lblUnit
            // 
            lblUnit.Font = new Font("Times New Roman", 9F);
            lblUnit.Location = new Point(211, 173);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(250, 20);
            lblUnit.TabIndex = 6;
            lblUnit.Text = "Ед. измерения:";
            lblUnit.Click += ChildControl_Click;
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Times New Roman", 9F);
            lblStock.Location = new Point(211, 200);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(180, 20);
            lblStock.TabIndex = 7;
            lblStock.Text = "Количество на складе:";
            lblStock.Click += ChildControl_Click;
            // 
            // lblOriginalPrice
            // 
            lblOriginalPrice.Font = new Font("Times New Roman", 10F);
            lblOriginalPrice.Location = new Point(211, 115);
            lblOriginalPrice.Name = "lblOriginalPrice";
            lblOriginalPrice.Size = new Size(180, 20);
            lblOriginalPrice.TabIndex = 8;
            lblOriginalPrice.Click += ChildControl_Click;
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblFinalPrice.Location = new Point(211, 142);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(180, 25);
            lblFinalPrice.TabIndex = 9;
            lblFinalPrice.Click += ChildControl_Click;
            // 
            // lblDiscount
            // 
            lblDiscount.Font = new Font("Times New Roman", 10F);
            lblDiscount.Location = new Point(26, 107);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(180, 20);
            lblDiscount.TabIndex = 10;
            lblDiscount.Text = "Скидка: 0%";
            lblDiscount.TextAlign = ContentAlignment.MiddleCenter;
            lblDiscount.Click += ChildControl_Click;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.Gray;
            pnlSeparator.Location = new Point(10, 230);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(680, 1);
            pnlSeparator.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblDiscount);
            panel1.Location = new Point(467, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 221);
            panel1.TabIndex = 12;
            // 
            // ProductCard
            // 
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(pbPhoto);
            Controls.Add(lblCategory);
            Controls.Add(lblProductName);
            Controls.Add(lblDescription);
            Controls.Add(lblManufacturer);
            Controls.Add(lblSupplier);
            Controls.Add(lblUnit);
            Controls.Add(lblStock);
            Controls.Add(lblOriginalPrice);
            Controls.Add(lblFinalPrice);
            Controls.Add(pnlSeparator);
            Name = "ProductCard";
            Size = new Size(699, 238);
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel panel1;
    }
}