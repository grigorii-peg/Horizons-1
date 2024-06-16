using Horizons.Context;
using Horizons.Context.Models;
using Horizons.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizons.UI.Forms
{
    public partial class RegistrationForm : Form
    {        
        public User User { get; set; }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        public RegistrationForm(User user)
        {
            InitializeComponent();
            this.User = user;
            this.Text = "Изменение пользователя";
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\d\b]"))
            {
                e.Handled = true;
            }
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            if (this.User != null)
            {
                fullNameTextBox.Text = User.Fullname;
                loginTextBox.Text = User.Login;
                //passwordTextBox.Text = "скрыто";
                //passwordTextBox.Enabled = false;
                return;
            }

            this.User = new User()
            {
                Id = -1,
            };
        }    

        private void buttonOk_Click(object sender, EventArgs e)
        {
            using (var db = new HorizonsDbContext())
            {
                var isExist = db.Users.Where(x => x.Login == loginTextBox.Text.Trim()).Any();
                var isEditedUser = User?.Login == loginTextBox.Text.Trim();

                if (isExist && !isEditedUser)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return;
                }
            }

            if (!Regex.IsMatch(loginTextBox.Text,
                @"^[a-zA-Z\d]{3,15}$"))
            {
                var tooltip = new ToolTip();

                tooltip.SetToolTip(loginTextBox, "");
                tooltip.ToolTipTitle = "Логин должен состоять из:";
                tooltip.Show("- строчных и прописных латинских букв\n" +
                             "- цифр\n" +
                             "- от 3 до 15 символов\n"
                             , loginTextBox, 2000);
                return;
            }

            if (!Regex.IsMatch(passwordTextBox.Text,
                "^[a-zA-Z\\d-_.+=<>@#$%^*()\\/&!?]{3,15}$")
                && passwordTextBox.Text != "скрыто")
            {
                var tooltip = new ToolTip();

                tooltip.SetToolTip(passwordTextBox, "");
                tooltip.ToolTipTitle = "Пароль должен состоять из:";
                tooltip.Show("- строчных и прописных латинских букв\n" +
                             "- цифр\n" +
                             "- специальных символов\n" +
                             "- от 3 до 15 символов\n"
                             , passwordTextBox, 2000);
                return;
            }

            if (this.User.Id == -1)
            {
                var authorizator = new Authorizator();
                var salt = authorizator.CreateSalt(16);
                var hashPassword = authorizator.GenerateSHA256Hash(passwordTextBox.Text.Trim(), salt);

                this.User.Password = hashPassword;
                this.User.Salt = salt;
            }

            this.User.Fullname = fullNameTextBox.Text.Trim();
            this.User.Login = loginTextBox.Text.Trim();
            this.User.RoleId = 2;
            DialogResult = DialogResult.OK;
        }

        private void textBoxFullname_TextChanged(object sender, EventArgs e)
        {
            registrationButton.Enabled = !string.IsNullOrWhiteSpace(fullNameTextBox.Text)
                                && !string.IsNullOrWhiteSpace(loginTextBox.Text)
                                && !string.IsNullOrWhiteSpace(passwordTextBox.Text);
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\d\b-_.+=<>@#$%^*()\\/&!?]")
                || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

    }
}
