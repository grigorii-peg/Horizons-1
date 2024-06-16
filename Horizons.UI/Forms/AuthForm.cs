using Horizons.Context;
using Horizons.UI.Forms;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Horizons.UI.Common;

namespace Horizons.UI
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, System.EventArgs e)
        {
                using (var db = new HorizonsDbContext())
                {
                    var user = db.Users.Include(x => x.Role)
                                       .FirstOrDefault(x => x.Login == loginTextBox.Text);

                    if (user == null)
                    {
                        MessageBox.Show("Введенные данные неверны!",
                            "Пользователь не существует!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    var hashPassword = new Authorizator()
                        .GenerateSHA256Hash(passwordTextBox.Text, user.Salt);

                    if (hashPassword != user.Password)
                    {
                        MessageBox.Show("Введенные данные неверны!",
                        "Пользователь не существует!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                        return;
                    }
                    MessageBox.Show($"Добро пожаловать, {user.Fullname}", "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CurrentUser.User = user;

                   

                    var mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    CurrentUser.User = null;
                    loginTextBox.Clear();
                    passwordTextBox.Clear();
                    this.Show();
                }
            }

        private void registrationButton_Click(object sender, System.EventArgs e)
        {
            var editUserForm = new RegistrationForm();

            if (editUserForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new HorizonsDbContext())
                {
                    db.Users.Add(editUserForm.User);

                    db.SaveChanges();
                };

                MessageBox.Show($"Менеджер {editUserForm.User.Fullname} был добавлен", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void passwordCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordCheckBox.Checked;
        }
    }
}
