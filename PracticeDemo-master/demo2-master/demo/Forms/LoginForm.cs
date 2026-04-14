using demo.Models;

namespace demo.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using DemoDbContext db = new DemoDbContext();
            Employee? user = db.Employees.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user != null)
            {
                Session.CurrentUser = user;
                Hide();
                ProductListForm productForm = new ProductListForm();
                productForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Session.CurrentUser = null;
            Hide();
            ProductListForm productForm = new ProductListForm();
            productForm.ShowDialog();
            Close();
        }
    }
}