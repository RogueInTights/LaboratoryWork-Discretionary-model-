using System;
using System.Windows.Forms;

namespace Permissions
{
    partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            // Создание пользователей:

            User admin = new User("admin", "5151");
            admin.CanChange = true;
            admin.CanResolve = true;

            User gull = new User("йфяу9", "9999");
            User otherGull = new User("лсдуз", "9999");

            Random random = new Random((int)DateTime.Now.Ticks);

            foreach (User user in new User[]{ gull, otherGull })
            {
                user.CanRead = random.Next(0, 2) > 0;
                user.CanChange = random.Next(0, 2) > 0;
                user.CanResolve = random.Next(0, 2) > 0;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (User.Instances.ContainsKey(login) && User.Instances[login].Password == password)
            {
                MainForm mainForm = new MainForm(this, User.Instances[login]);
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Не существует такой пары логин-пароль.");

                loginTextBox.Text = null;
                passwordTextBox.Text = null;
            }
        }
    }
}
