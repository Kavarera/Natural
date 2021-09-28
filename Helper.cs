using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Windows.Forms;

namespace Natural_1
{
    public class Helper
    {
        Configuration config;

        public static string getConnection(string connectionName)
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public Helper()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public void SaveConnection(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }

        public static void setLogin(string jobname, string status)
        {
            if (status == "Active")
            {
                switch (jobname)
                {
                    case "Kasir":
                        Form kasir = new Kasir.KasirForm();
                        kasir.Show();
                        break;

                    case "Manager":
                        break;

                    case "Admin":
                        Form admin = new Admin.AdminForm();
                        admin.Text = "Admin Natural";
                        admin.Show();
                        break;

                    default:
                        System.Windows.MessageBox.Show("Job Tidak Terdaftar");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Akun terdaftar tetapi anda tidak bisa masuk.\nHubungi admin anda", "Akses Ditolak");
            }
        }

    }
}
