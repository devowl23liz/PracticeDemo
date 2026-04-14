namespace demo.Forms
{
    partial class ProductListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAddProduct;

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
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // flpProducts
            this.flpProducts.AutoScroll = true;
            this.flpProducts.BackColor = System.Drawing.Color.White;
            this.flpProducts.Location = new System.Drawing.Point(12, 80);
            this.flpProducts.Size = new System.Drawing.Size(960, 500);
            this.flpProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProducts.WrapContents = false;

            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSearch.Location = new System.Drawing.Point(12, 50);
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.PlaceholderText = "Поиск...";
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.FilterChanged);

            // cbSupplier
            this.cbSupplier.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbSupplier.Location = new System.Drawing.Point(220, 50);
            this.cbSupplier.Size = new System.Drawing.Size(150, 23);
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.Visible = false;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);

            // cbSort
            this.cbSort.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cbSort.Location = new System.Drawing.Point(380, 50);
            this.cbSort.Size = new System.Drawing.Size(150, 23);
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.Items.AddRange(new object[] { "Без сортировки", "Количество по возрастанию", "Количество по убыванию" });
            this.cbSort.SelectedIndex = 0;
            this.cbSort.Visible = false;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);

            // lblUserInfo
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblUserInfo.Location = new System.Drawing.Point(700, 15);
            this.lblUserInfo.Size = new System.Drawing.Size(100, 16);
            this.lblUserInfo.Text = "Пользователь";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(127, 255, 0);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnLogout.Location = new System.Drawing.Point(850, 10);
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // btnOrders
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(127, 255, 0);
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnOrders.Location = new System.Drawing.Point(12, 10);
            this.btnOrders.Size = new System.Drawing.Size(100, 30);
            this.btnOrders.Text = "Заказы";
            this.btnOrders.Visible = false;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);

            // btnAddProduct
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(0, 250, 154);
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnAddProduct.Location = new System.Drawing.Point(120, 10);
            this.btnAddProduct.Size = new System.Drawing.Size(120, 30);
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.Visible = false;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);

            // ProductListForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnAddProduct);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список товаров - Обувной магазин";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}