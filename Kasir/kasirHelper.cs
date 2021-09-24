using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace Natural_1.Kasir
{
    public class kasirHelper
    {

        public static int totalHarga { get; set; }

        public static int getBarangID(SqlConnection con, string NamaBarang)
        {
            SqlCommand cmd = new SqlCommand($"SELECT ID FROM Barang WHERE Nama='{NamaBarang}'", con);
            try
            {
                con.Open();
                Barang.ID= Int32.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError at getBarangNoID", "kasirHelper.cs - getBarangNoID Error");
            }
            finally
            {
                con.Close();
            }
            return Barang.ID;
        }

        public static void getBarangDetail(SqlConnection con, string Namabarang)
        {
            SqlCommand cmd = new SqlCommand($"SELECT Nama, Jumlah,Harga_pcs, Bonus_per, Status , Satuan FROM Barang WHERE ID = {getBarangID(con,Namabarang)}",con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Barang.NamaBarang = sdr["Nama"].ToString();
                    Barang.Jumlah = Int32.Parse(sdr["Jumlah"].ToString());
                    Barang.Harga_PCS=Int32.Parse(sdr["Harga_pcs"].ToString());
                    Barang.Bonus_PER=Int32.Parse(sdr["Bonus_per"].ToString());
                    Barang.Status=sdr["Status"].ToString();
                    Barang.Satuan = sdr["Satuan"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError at getBarangDetail", "kasirHelper.cs - getBarangDetail ERROR");
            }
            finally
            {
                con.Close();
            }
        }

        public static string getNoStruk(SqlConnection con,string namaKaryawan)
        {
            SqlCommand cmd = new SqlCommand($"SELECT MAX(Id) AS ID FROM TransactionLog",con);
            string struk;
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\ngetNoStruk", "kasirHelper.cs - getNoStruk");
            }
            struk = namaKaryawan.Substring(0,3).ToUpper();
            struk += DateTime.Now.ToString("ddd").ToLower();
            struk += DateTime.Now.ToString("dd");
            if (cmd.ExecuteScalar() == null)
            {
                struk += "0";
                con.Close();
                return struk;
            }
            else
            {
                struk += cmd.ExecuteScalar().ToString();
                con.Close();
                return struk;
            }
        }

        public static bool checkTextBox(CheckBox nonMmember,TextBox namaTB, TextBox alamatTB, TextBox areaTB,TextBox nopel,TextBox notel)
        {

            if(namaTB.Text!=null&&alamatTB.Text!=null&&areaTB.Text!=null)
            {

                if (nonMmember.Checked == true)
                {
                    return true;
                }
                else
                {
                    if(nopel.Text!=null && notel.Text != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            else
            {
                return false;
            }
        }

        public static ComboBox loadCBX(ComboBox combobox,string table, string item, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand($"SELECT {item} FROM {table}", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    combobox.Items.Add(sdr[item]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError at loadCBX Method.", "kasirHelper.cs - loadCBX");
            }
            finally
            {
                con.Close();
                combobox.SelectedIndex = 0;
            }
            return combobox;
        }
    }
}
