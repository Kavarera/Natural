using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Natural_1.Manager
{
    public class managerHelper
    {

        public static string generateStruk(SqlConnection con)
        {
            string struk = Karyawan.Nama.Substring(0, 1);
            struk += DateTime.Now.ToString("dd");
            struk += DateTime.Now.ToString("MM");
            struk += DateTime.Now.ToString("yy");
            struk += DateTime.Now.ToString("fff").Substring(1, 2);
            struk += "pll";

            return struk.ToUpper();
        }

        public static void loadData(SqlConnection con, DataGridView dgv, string Tipe, string karyawan)
        {
            
        }

    }
}
