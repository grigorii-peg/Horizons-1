using Horizons.Context;
using Horizons.UI.Forms;
using System.Linq;
using System.Windows.Forms;

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
                CurrentUser.User = db.Users.FirstOrDefault(x => x.RoleId == 2);
            }

            MainForm mf = new MainForm();
            mf.ShowDialog();
        }
    }
}
