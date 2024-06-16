using Horizons.Context;
using Horizons.UI.Common;
using Horizons.UI.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Horizons.UI
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new HorizonsDbContext())
            {
                var authorizator = new Authorizator();

                var users = db.Users.Where(x => x.Salt == string.Empty).ToList();
                foreach (var user in users)
                {
                    var salt = authorizator.CreateSalt(16);
                    var hashPassword = authorizator.GenerateSHA256Hash(user.Password, salt);

                    user.Password = hashPassword;
                    user.Salt = salt;
                }

                db.SaveChanges();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TransfersForm());
        }
    }
}
