namespace demo.Forms
{
    partial class OrderEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblIdTitle;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.CheckBox chkHasDeliveryDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbAdditional;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPickupCode;
        private System.Windows.Forms.TextBox txtPickupCode;
        private System.Windows.Forms.Label lblOrderArticles;
        private System.Windows.Forms.TextBox txtOrderArticles;
        private System.Windows.Forms.Label lblPickupPoint;
        private System.Windows.Forms.ComboBox cbPickupPoint;

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
            lblIdTitle = new Label();
            lblIdValue = new Label();
            lblOrderNumber = new Label();
            txtOrderNumber = new TextBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            lblPickupPoint = new Label();
            cbPickupPoint = new ComboBox();
            lblOrderDate = new Label();
            dtpOrderDate = new DateTimePicker();
            lblDeliveryDate = new Label();
            dtpDeliveryDate = new DateTimePicker();
            chkHasDeliveryDate = new CheckBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            gbAdditional = new GroupBox();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblPickupCode = new Label();
            txtPickupCode = new TextBox();
            lblOrderArticles = new Label();
            txtOrderArticles = new TextBox();
            gbAdditional.SuspendLayout();
            SuspendLayout();
            // 
            // lblIdTitle
            // 
            lblIdTitle.AutoSize = true;
            lblIdTitle.Font = new Font("Times New Roman", 10F);
            lblIdTitle.Location = new Point(12, 15);
            lblIdTitle.Name = "lblIdTitle";
            lblIdTitle.Size = new Size(66, 16);
            lblIdTitle.TabIndex = 0;
            lblIdTitle.Text = "ID заказа:";
            // 
            // lblIdValue
            // 
            lblIdValue.AutoSize = true;
            lblIdValue.Font = new Font("Times New Roman", 10F);
            lblIdValue.Location = new Point(90, 15);
            lblIdValue.Name = "lblIdValue";
            lblIdValue.Size = new Size(0, 16);
            lblIdValue.TabIndex = 1;
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Times New Roman", 10F);
            lblOrderNumber.Location = new Point(12, 50);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(106, 16);
            lblOrderNumber.TabIndex = 2;
            lblOrderNumber.Text = "Артикул заказа:*";
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Font = new Font("Times New Roman", 10F);
            txtOrderNumber.Location = new Point(130, 47);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(200, 23);
            txtOrderNumber.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 10F);
            lblStatus.Location = new Point(12, 85);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(90, 16);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Статус заказа:";
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Times New Roman", 10F);
            cbStatus.Location = new Point(130, 82);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(200, 23);
            cbStatus.TabIndex = 5;
            // 
            // lblPickupPoint
            // 
            lblPickupPoint.AutoSize = true;
            lblPickupPoint.Font = new Font("Times New Roman", 10F);
            lblPickupPoint.Location = new Point(12, 120);
            lblPickupPoint.Name = "lblPickupPoint";
            lblPickupPoint.Size = new Size(98, 16);
            lblPickupPoint.TabIndex = 6;
            lblPickupPoint.Text = "Пункт выдачи:*";
            // 
            // cbPickupPoint
            // 
            cbPickupPoint.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPickupPoint.Font = new Font("Times New Roman", 10F);
            cbPickupPoint.Location = new Point(130, 117);
            cbPickupPoint.Name = "cbPickupPoint";
            cbPickupPoint.Size = new Size(350, 23);
            cbPickupPoint.TabIndex = 7;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Times New Roman", 10F);
            lblOrderDate.Location = new Point(12, 155);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(78, 16);
            lblOrderDate.TabIndex = 8;
            lblOrderDate.Text = "Дата заказа:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Font = new Font("Times New Roman", 10F);
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(130, 152);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(120, 23);
            dtpOrderDate.TabIndex = 9;
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Font = new Font("Times New Roman", 10F);
            lblDeliveryDate.Location = new Point(12, 190);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(94, 16);
            lblDeliveryDate.TabIndex = 10;
            lblDeliveryDate.Text = "Дата доставки:";
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Enabled = false;
            dtpDeliveryDate.Font = new Font("Times New Roman", 10F);
            dtpDeliveryDate.Format = DateTimePickerFormat.Short;
            dtpDeliveryDate.Location = new Point(130, 215);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new Size(120, 23);
            dtpDeliveryDate.TabIndex = 12;
            // 
            // chkHasDeliveryDate
            // 
            chkHasDeliveryDate.AutoSize = true;
            chkHasDeliveryDate.Font = new Font("Times New Roman", 10F);
            chkHasDeliveryDate.Location = new Point(130, 188);
            chkHasDeliveryDate.Name = "chkHasDeliveryDate";
            chkHasDeliveryDate.Size = new Size(157, 20);
            chkHasDeliveryDate.TabIndex = 11;
            chkHasDeliveryDate.Text = "Указать дату доставки";
            chkHasDeliveryDate.CheckedChanged += chkHasDeliveryDate_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSpringGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 10F);
            btnSave.Location = new Point(130, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 14;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumSpringGreen;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 10F);
            btnDelete.Location = new Point(240, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Chartreuse;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 10F);
            btnCancel.Location = new Point(350, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // gbAdditional
            // 
            gbAdditional.Controls.Add(lblCustomerName);
            gbAdditional.Controls.Add(txtCustomerName);
            gbAdditional.Controls.Add(lblPickupCode);
            gbAdditional.Controls.Add(txtPickupCode);
            gbAdditional.Controls.Add(lblOrderArticles);
            gbAdditional.Controls.Add(txtOrderArticles);
            gbAdditional.Font = new Font("Times New Roman", 10F);
            gbAdditional.Location = new Point(12, 250);
            gbAdditional.Name = "gbAdditional";
            gbAdditional.Size = new Size(470, 130);
            gbAdditional.TabIndex = 13;
            gbAdditional.TabStop = false;
            gbAdditional.Text = "Дополнительная информация";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(20, 25);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(89, 16);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "ФИО клиента:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(130, 22);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(320, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // lblPickupCode
            // 
            lblPickupCode.AutoSize = true;
            lblPickupCode.Location = new Point(20, 55);
            lblPickupCode.Name = "lblPickupCode";
            lblPickupCode.Size = new Size(97, 16);
            lblPickupCode.TabIndex = 2;
            lblPickupCode.Text = "Код получения:";
            // 
            // txtPickupCode
            // 
            txtPickupCode.Location = new Point(130, 52);
            txtPickupCode.Name = "txtPickupCode";
            txtPickupCode.Size = new Size(320, 23);
            txtPickupCode.TabIndex = 3;
            // 
            // lblOrderArticles
            // 
            lblOrderArticles.AutoSize = true;
            lblOrderArticles.Location = new Point(20, 85);
            lblOrderArticles.Name = "lblOrderArticles";
            lblOrderArticles.Size = new Size(92, 16);
            lblOrderArticles.TabIndex = 4;
            lblOrderArticles.Text = "Состав заказа:";
            // 
            // txtOrderArticles
            // 
            txtOrderArticles.Location = new Point(130, 82);
            txtOrderArticles.Multiline = true;
            txtOrderArticles.Name = "txtOrderArticles";
            txtOrderArticles.Size = new Size(320, 40);
            txtOrderArticles.TabIndex = 5;
            // 
            // OrderEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 450);
            Controls.Add(lblIdTitle);
            Controls.Add(lblIdValue);
            Controls.Add(lblOrderNumber);
            Controls.Add(txtOrderNumber);
            Controls.Add(lblStatus);
            Controls.Add(cbStatus);
            Controls.Add(lblPickupPoint);
            Controls.Add(cbPickupPoint);
            Controls.Add(lblOrderDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(lblDeliveryDate);
            Controls.Add(chkHasDeliveryDate);
            Controls.Add(dtpDeliveryDate);
            Controls.Add(gbAdditional);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Font = new Font("Times New Roman", 10F);
            Name = "OrderEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование заказа";
            gbAdditional.ResumeLayout(false);
            gbAdditional.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}