namespace demo.Forms
{
    partial class ProductEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Label lblIdTitle;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.NumericUpDown numStockQuantity;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pbPhoto = new PictureBox();
            btnSelectPhoto = new Button();
            lblIdTitle = new Label();
            lblIdValue = new Label();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblManufacturer = new Label();
            cbManufacturer = new ComboBox();
            lblSupplier = new Label();
            txtSupplier = new TextBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblStockQuantity = new Label();
            numStockQuantity = new NumericUpDown();
            lblDiscount = new Label();
            numDiscount = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            SuspendLayout();
            // 
            // pbPhoto
            // 
            pbPhoto.BackColor = Color.LightGray;
            pbPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbPhoto.Location = new Point(12, 40);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(300, 200);
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoto.TabIndex = 0;
            pbPhoto.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            btnSelectPhoto.BackColor = Color.FromArgb(127, 255, 0);
            btnSelectPhoto.FlatStyle = FlatStyle.Flat;
            btnSelectPhoto.Location = new Point(12, 250);
            btnSelectPhoto.Name = "btnSelectPhoto";
            btnSelectPhoto.Size = new Size(300, 30);
            btnSelectPhoto.TabIndex = 1;
            btnSelectPhoto.Text = "Выбрать изображение";
            btnSelectPhoto.UseVisualStyleBackColor = false;
            btnSelectPhoto.Click += btnSelectPhoto_Click;
            // 
            // lblIdTitle
            // 
            lblIdTitle.AutoSize = true;
            lblIdTitle.Location = new Point(330, 45);
            lblIdTitle.Name = "lblIdTitle";
            lblIdTitle.Size = new Size(67, 16);
            lblIdTitle.TabIndex = 2;
            lblIdTitle.Text = "ID товара:";
            // 
            // lblIdValue
            // 
            lblIdValue.AutoSize = true;
            lblIdValue.Location = new Point(410, 45);
            lblIdValue.Name = "lblIdValue";
            lblIdValue.Size = new Size(0, 16);
            lblIdValue.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(330, 75);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(101, 16);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Наименование:*";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(460, 72);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(250, 23);
            txtProductName.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(330, 105);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 16);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Категория:";
            // 
            // cbCategory
            // 
            cbCategory.Location = new Point(460, 102);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(250, 23);
            cbCategory.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(330, 135);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 16);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Описание:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(460, 132);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 60);
            txtDescription.TabIndex = 9;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(330, 200);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(98, 16);
            lblManufacturer.TabIndex = 10;
            lblManufacturer.Text = "Производитель:";
            // 
            // cbManufacturer
            // 
            cbManufacturer.Location = new Point(460, 197);
            cbManufacturer.Name = "cbManufacturer";
            cbManufacturer.Size = new Size(250, 23);
            cbManufacturer.TabIndex = 11;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(330, 230);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(76, 16);
            lblSupplier.TabIndex = 12;
            lblSupplier.Text = "Поставщик:";
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(460, 227);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(250, 23);
            txtSupplier.TabIndex = 13;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(330, 260);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 16);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Цена:";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(460, 257);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 15;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(600, 260);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(94, 16);
            lblUnit.TabIndex = 16;
            lblUnit.Text = "Ед. измерения:";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(710, 257);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(100, 23);
            txtUnit.TabIndex = 17;
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(330, 290);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(139, 16);
            lblStockQuantity.TabIndex = 18;
            lblStockQuantity.Text = "Количество на складе:";
            // 
            // numStockQuantity
            // 
            numStockQuantity.Location = new Point(460, 287);
            numStockQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numStockQuantity.Name = "numStockQuantity";
            numStockQuantity.Size = new Size(120, 23);
            numStockQuantity.TabIndex = 19;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(600, 290);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(79, 16);
            lblDiscount.TabIndex = 20;
            lblDiscount.Text = "Скидка (%):";
            // 
            // numDiscount
            // 
            numDiscount.DecimalPlaces = 2;
            numDiscount.Location = new Point(710, 287);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(100, 23);
            numDiscount.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 250, 154);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(460, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 35);
            btnSave.TabIndex = 22;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Chartreuse;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(660, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 35);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 400);
            Controls.Add(pbPhoto);
            Controls.Add(btnSelectPhoto);
            Controls.Add(lblIdTitle);
            Controls.Add(lblIdValue);
            Controls.Add(lblProductName);
            Controls.Add(txtProductName);
            Controls.Add(lblCategory);
            Controls.Add(cbCategory);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblManufacturer);
            Controls.Add(cbManufacturer);
            Controls.Add(lblSupplier);
            Controls.Add(txtSupplier);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(lblUnit);
            Controls.Add(txtUnit);
            Controls.Add(lblStockQuantity);
            Controls.Add(numStockQuantity);
            Controls.Add(lblDiscount);
            Controls.Add(numDiscount);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Font = new Font("Times New Roman", 10F);
            Name = "ProductEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование товара";
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}