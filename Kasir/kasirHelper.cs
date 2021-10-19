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

     
        public static string GenerateNoPelanggan(SqlConnection connection,string noPelanggan="P")
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT MAX(ID) AS ID FROM Pelanggan", connection);
                connection.Open();
                noPelanggan += cmd.ExecuteScalar()+2.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nGenerateNoPelanggan", "kasirHelper.cs - Generate No Pelanggan ERROR");
            }
            finally
            {
                connection.Close();
            }
            return noPelanggan;
        }
        
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

        public static string getNoStruk(string modul,string namaKaryawan, int totalTransaksi)
        {
            string struk ="";
            struk += namaKaryawan.Substring(0, 1);
            struk += DateTime.Now.ToString("dd");
            struk += DateTime.Now.ToString("MM");
            struk += DateTime.Now.ToString("yy");
            struk += DateTime.Now.ToString("fff").Substring(1,2);
            if (modul == "Distributor")
            {
                struk += "D";
                struk += totalTransaksi.ToString();
                return struk;
            }
            else
            {
                struk += "P";
                struk += totalTransaksi.ToString();
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
                    if (sdr[item] != null)
                    {
                        combobox.Items.Add(sdr[item]);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError at loadCBX Method.", "kasirHelper.cs - loadCBX");
            }
            finally
            {
                con.Close();
                if (combobox.Items.Count > 0)
                {
                    combobox.SelectedIndex = 0;
                }
            }
            return combobox;
        }
    }
}
