namespace demo.Forms
{
    partial class OrderListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flpOrders;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddOrder;

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
            flpOrders = new FlowLayoutPanel();
            txtSearch = new TextBox();
            cbStatus = new ComboBox();
            cbSort = new ComboBox();
            btnBack = new Button();
            btnAddOrder = new Button();
            SuspendLayout();
            // 
            // flpOrders
            // 
            flpOrders.AutoScroll = true;
            flpOrders.BackColor = Color.White;
            flpOrders.FlowDirection = FlowDirection.TopDown;
            flpOrders.Location = new Point(12, 80);
            flpOrders.Name = "flpOrders";
            flpOrders.Size = new Size(960, 500);
            flpOrders.TabIndex = 0;
            flpOrders.WrapContents = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 10F);
            txtSearch.Location = new Point(12, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск по заказам...";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += FilterChanged;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Times New Roman", 10F);
            cbStatus.Location = new Point(220, 50);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(150, 23);
            cbStatus.TabIndex = 2;
            cbStatus.SelectedIndexChanged += FilterChanged;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Times New Roman", 10F);
            cbSort.Items.AddRange(new object[] { "Без сортировки", "Дата заказа (сначала старые)", "Дата заказа (сначала новые)" });
            cbSort.Location = new Point(380, 50);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(180, 23);
            cbSort.TabIndex = 3;
            cbSort.SelectedIndexChanged += FilterChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(127, 255, 0);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Times New Roman", 10F);
            btnBack.Location = new Point(12, 10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 30);
            btnBack.TabIndex = 4;
            btnBack.Text = "Назад к товарам";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.FromArgb(0, 250, 154);
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("Times New Roman", 10F);
            btnAddOrder.Location = new Point(161, 10);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(120, 30);
            btnAddOrder.TabIndex = 5;
            btnAddOrder.Text = "Добавить заказ";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Visible = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // OrderListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 620);
            Controls.Add(flpOrders);
            Controls.Add(txtSearch);
            Controls.Add(cbStatus);
            Controls.Add(cbSort);
            Controls.Add(btnBack);
            Controls.Add(btnAddOrder);
            Font = new Font("Times New Roman", 10F);
            Name = "OrderListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список заказов - Обувной магазин";
            ResumeLayout(false);
            PerformLayout();


        }
    }
}