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
        public static void loadData(SqlConnection con, DataGridView dgv, string Tipe, string karyawan)
        {
            if (Tipe == "Penjualan")
            {
                SqlCommand cmd = new SqlCommand($"select Struk as 'No Struk' , TanggalJam as 'Tanggal & Jam' , NamaPelanggan as 'Customer/Distributor', " +
                $"Modul, Pemasukan as 'Jumlah' , Keterangan, TglUbah as 'Tanggal Ubah' from TransactionLog where Modul = 'Kasir' and " +
                $"Operator = '{karyawan}'", con);
                try
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    sda.Fill(dt);
                    dgv.DataSource = dt.DefaultView;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "managerHelper-loadData Error");
                }
                finally
                {
                    con.Close();
                }
            }

            else if (Tipe == "Pembelian")
            {
            }
        }

    }
}
