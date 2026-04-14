namespace demo.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;

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
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnGuest = new Button();
            lblLogin = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(100, 27);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(150, 23);
            txtLogin.TabIndex = 2;
            txtLogin.Text = "someone";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 67);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "1234";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 250, 154);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(100, 110);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(127, 255, 0);
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(100, 150);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 30);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(30, 30);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(47, 16);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 70);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(52, 16);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Пароль:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 220);
            Controls.Add(lblLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnGuest);
            Font = new Font("Times New Roman", 10F);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}