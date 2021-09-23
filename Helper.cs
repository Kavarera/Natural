﻿using System;
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

        public static void setLogin(string jobname)
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
                    break;

                default:
                    System.Windows.MessageBox.Show("Job Tidak Terdaftar");
                    break;
            }
        }

    }
}
