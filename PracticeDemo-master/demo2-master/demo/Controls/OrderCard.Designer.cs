namespace demo.Controls
{
    partial class OrderCard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOrderNumberTitle;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPickupAddressTitle;
        private System.Windows.Forms.Label lblPickupAddress;
        private System.Windows.Forms.Label lblOrderDateTitle;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Panel pnlSeparator;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblOrderNumberTitle = new Label();
            lblOrderNumber = new Label();
            lblStatusTitle = new Label();
            lblStatus = new Label();
            lblPickupAddressTitle = new Label();
            lblPickupAddress = new Label();
            lblOrderDateTitle = new Label();
            lblOrderDate = new Label();
            pnlSeparator = new Panel();
            lblDeliveryDate = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrderNumberTitle
            // 
            lblOrderNumberTitle.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lblOrderNumberTitle.Location = new Point(10, 10);
            lblOrderNumberTitle.Name = "lblOrderNumberTitle";
            lblOrderNumberTitle.Size = new Size(100, 20);
            lblOrderNumberTitle.TabIndex = 0;
            lblOrderNumberTitle.Text = "Артикул заказа:";
            lblOrderNumberTitle.Click += ChildControl_Click;
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.Font = new Font("Times New Roman", 10F);
            lblOrderNumber.Location = new Point(120, 10);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(200, 20);
            lblOrderNumber.TabIndex = 1;
            lblOrderNumber.Click += ChildControl_Click;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lblStatusTitle.Location = new Point(10, 35);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(100, 20);
            lblStatusTitle.TabIndex = 2;
            lblStatusTitle.Text = "Статус заказа:";
            lblStatusTitle.Click += ChildControl_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Times New Roman", 10F);
            lblStatus.Location = new Point(120, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(200, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Click += ChildControl_Click;
            // 
            // lblPickupAddressTitle
            // 
            lblPickupAddressTitle.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lblPickupAddressTitle.Location = new Point(10, 60);
            lblPickupAddressTitle.Name = "lblPickupAddressTitle";
            lblPickupAddressTitle.Size = new Size(100, 20);
            lblPickupAddressTitle.TabIndex = 4;
            lblPickupAddressTitle.Text = "Адрес пункта выдачи:";
            lblPickupAddressTitle.Click += ChildControl_Click;
            // 
            // lblPickupAddress
            // 
            lblPickupAddress.Font = new Font("Times New Roman", 10F);
            lblPickupAddress.Location = new Point(110, 60);
            lblPickupAddress.Name = "lblPickupAddress";
            lblPickupAddress.Size = new Size(430, 20);
            lblPickupAddress.TabIndex = 5;
            lblPickupAddress.Click += ChildControl_Click;
            // 
            // lblOrderDateTitle
            // 
            lblOrderDateTitle.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lblOrderDateTitle.Location = new Point(10, 85);
            lblOrderDateTitle.Name = "lblOrderDateTitle";
            lblOrderDateTitle.Size = new Size(90, 20);
            lblOrderDateTitle.TabIndex = 6;
            lblOrderDateTitle.Text = "Дата заказа:";
            lblOrderDateTitle.Click += ChildControl_Click;
            // 
            // lblOrderDate
            // 
            lblOrderDate.Font = new Font("Times New Roman", 10F);
            lblOrderDate.Location = new Point(110, 85);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(150, 20);
            lblOrderDate.TabIndex = 7;
            lblOrderDate.Click += ChildControl_Click;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.Gray;
            pnlSeparator.Location = new Point(10, 108);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(570, 1);
            pnlSeparator.TabIndex = 11;
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.Font = new Font("Times New Roman", 10F);
            lblDeliveryDate.Location = new Point(-2, 38);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(150, 20);
            lblDeliveryDate.TabIndex = 10;
            lblDeliveryDate.TextAlign = ContentAlignment.MiddleCenter;
            lblDeliveryDate.Click += ChildControl_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblDeliveryDate);
            panel1.Location = new Point(431, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 92);
            panel1.TabIndex = 12;
            // 
            // OrderCard
            // 
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(lblOrderNumberTitle);
            Controls.Add(lblOrderNumber);
            Controls.Add(lblStatusTitle);
            Controls.Add(lblStatus);
            Controls.Add(lblPickupAddressTitle);
            Controls.Add(lblPickupAddress);
            Controls.Add(lblOrderDateTitle);
            Controls.Add(lblOrderDate);
            Controls.Add(pnlSeparator);
            Name = "OrderCard";
            Size = new Size(600, 115);
            Click += OrderCard_Click;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Label lblDeliveryDate;
        private Panel panel1;
    }
}