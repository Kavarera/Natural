using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Natural_1.Admin
{
    public class adminHelper
    {
        public static void loadData(SqlConnection con, string tipe, DataGridView dgv)
        {
            if (tipe == "User")
            {
                SqlCommand cmd = new SqlCommand($"SELECT Id_Karyawan AS ID , Username , Nama , No_Telepon AS Telepon , Alamat , Role , Status FROM Karyawan", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable("userDT");
                    sda.Fill(dt);
                    dgv.DataSource = dt.DefaultView;
                    dgv.Columns[0].Width = 80; //id
                    dgv.Columns[1].Width = 130; // username
                    dgv.Columns[2].Width = 250; // nama
                    dgv.Columns[3].Width = 250; // telepon
                    dgv.Columns[4].Width = 250; // alamat
                    dgv.Columns[5].Width = 130; //role
                    dgv.Columns[6].Width = 160; //status
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }
    }
}
