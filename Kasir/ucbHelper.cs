using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
namespace Natural_1.Kasir
{
    class ucbHelper
    {
        public static void getDistributorDetail(SqlConnection con, string namaToko)
        {
            SqlCommand cmd = new SqlCommand($"SELECT No_Distributor AS NoDis, Nama_Toko AS Nama,No_Telp AS Telp, Alamat, Status, Keterangan", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Distributor.NoDistributor = sdr["NoDis"].ToString();
                    Distributor.NamaToko = sdr["Nama"].ToString();
                    Distributor.NoTelp = sdr["Telp"].ToString();
                    Distributor.Alamat = sdr["Alamat"].ToString();
                    Distributor.Status = sdr["Status"].ToString();
                    Distributor.Keterangan = sdr["Keterangan"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\ngetDistributorDetail", "ucbHelper.cs -getDistributorDetail ERROR");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
