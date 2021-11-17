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

        public static string GenerateNoPelanggan(SqlConnection connection, string noPelanggan = "P",string Table="User")
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT MAX(ID) AS ID FROM {Table} ", connection);
                connection.Open();
                noPelanggan += cmd.ExecuteScalar() + 1.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nGenerateNoPelanggan", "kasirHelper.cs - Generate No Pelanggan ERROR");
            }
            finally
            {
                connection.Close();
            }
            return noPelanggan;
        }


        public static void loadData(SqlConnection con, string tipe, DataGridView dgv , string idp = "-")
        {
            con.Close();
            if (tipe == "User")
            {
                SqlCommand cmd = new SqlCommand($"SELECT Username , Nama , No_Telepon AS Telepon , Alamat , Role , Status FROM Karyawan", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable("userDT");
                    sda.Fill(dt);
                    dgv.DataSource = dt.DefaultView;
                    //dgv.Columns[0].Width = 80; //id
                    //dgv.Columns[1].Width = 130; // username
                    //dgv.Columns[2].Width = 250; // nama
                    //dgv.Columns[3].Width = 250; // telepon
                    //dgv.Columns[4].Width = 250; // alamat
                    //dgv.Columns[5].Width = 130; //role
                    //dgv.Columns[6].Width = 160; //status
                    dt.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nloadDataGrid type User" , "adminHelper.cs - LoadDataGrid");
                }
                finally
                {
                    con.Close();
                }
            }

            if(tipe == "Pelanggan")
            {
                SqlCommand cmd = new SqlCommand($"SELECT Id_Pelanggan as ID, Nama, No_Telp as Telepon, Alamat, Bonus, Area, Status FROM Pelanggan", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt.DefaultView;
                    //dgv.Columns[0].Width = 80; //id
                    //dgv.Columns[1].Width = 130; // Nama
                    //dgv.Columns[2].Width = 250; // Telepon
                    //dgv.Columns[3].Width = 250; // alamat
                    //dgv.Columns[4].Width = 250; // Bonus
                    //dgv.Columns[5].Width = 150; //area
                    //dgv.Columns[6].Width = 60; // status
                    dt.Dispose();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nloadDataGrid type Pelanggan", "adminHelper.cs - LoadDataGrid");
                }
                finally
                {
                    con.Close();
                }
            }

            if (tipe == "TP")
            {
                /*
                 * SqlCommand cmd = new SqlCommand($"SELECT TanggalJam as 'Tgl & Jam',BarangLog.NamaBarang , Operator , Kegiatan as Kategori, " +
                    $"BarangLog.Pengurangan as Jumlah, BarangLog.totalHarga  , TransactionLog.Struk as 'No Struk', " +
                    $"Status ,TglUbah as 'Tgl Ubah'  FROM TransactionLog INNER JOIN BarangLog ON TransactionLog.Struk = BarangLog.Struk " +
                    $"WHERE NamaPelanggan  = '{idp}' ", con);
                */
                SqlCommand cmd = new SqlCommand($"SELECT TanggalJam as 'Tgl & Jam' , Operator , Kegiatan as Kategori, Pemasukan as Jumlah  , Struk as 'No Struk' , Status , TglUbah as 'Tgl Ubah' FROM TransactionLog WHERE NamaPelanggan  = '{idp}' ", con);
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt.DefaultView;
                    sda.Dispose();
                    dt.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n LoadData error", "adminHelper.cs - loadData type TP eror");
                }
                finally
                {
                    con.Close();


                    dgv.Columns[0].Width = 250; //tgljam
                    dgv.Columns[1].Width = 230; // operator
                    dgv.Columns[2].Width = 190; // kategori
                    dgv.Columns[3].Width = 180; // jumlah
                    dgv.Columns[4].Width = 250; // nostruk
                    dgv.Columns[5].Width = 180; //status
                    dgv.Columns[6].Width = 250; // tgl ubah
                }

            }

            if (tipe == "Distributor")
            {
                SqlCommand cmd = new SqlCommand($"SELECT No_Distributor as 'Id_Distributor' , Nama_Toko as 'Nama' , No_Telp as 'Telepon'," +
                    $" Alamat, Status, Keterangan FROM Distributor", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt.DefaultView;
                    //dgv.Columns[0].Width = 80; //id
                    //dgv.Columns[1].Width = 130; // Nama
                    //dgv.Columns[2].Width = 250; // Telepon
                    //dgv.Columns[3].Width = 250; // alamat
                    //dgv.Columns[4].Width = 250; // status
                    //dgv.Columns[5].Width = 150; //keterangan
                    dt.Dispose();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "adminHelper - loadData -Distributor");
                }
                finally
                {
                    con.Close();
                }
            }

            if (tipe == "TD")
            {
                SqlCommand cmd = new SqlCommand($"select TanggalJam as 'Tgl & Jam', Operator,Kegiatan as 'Kategori', Pengeluaran as 'Jumlah', Struk as 'No Struk', Status, TglUbah as 'Tgl Ubah'" +
                    $" From TransactionLog where NamaPelanggan = (select Nama_Toko from Distributor where No_Distributor='{idp}')", con);
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt.DefaultView;
                    sda.Dispose();
                    dt.Dispose();
                    dgv.Columns[0].Width = 250; //tgljam
                    dgv.Columns[1].Width = 230; // operator
                    dgv.Columns[2].Width = 190; // kategori
                    dgv.Columns[3].Width = 180; // jumlah
                    dgv.Columns[4].Width = 250; // nostruk
                    dgv.Columns[5].Width = 180; //status
                    dgv.Columns[6].Width = 250; // tgl ubah
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "adminHelper - loadData TD");
                }
                finally
                {
                    con.Close();

                }
            }

            if (tipe == "Items")
            {
                SqlCommand cmd = new SqlCommand($"select ID, Nama, distributor, Jumlah, Harga_pcs, Bonus_per, Status from Barang",con);
                DataTable dt = new DataTable();
                try
                {
                    con.Close();
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    sda.Fill(dt);
                    dgv.DataSource = dt.DefaultView;
                    sda.Dispose();
                    dt.Dispose();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "adminHelper, Items LoadData Error");
                }
                finally
                {
                    con.Close();
                }
            }

            if (tipe == "Log")
            {
                SqlCommand cmd = new SqlCommand($"select top 50 Tanggal, Jam, Operator, Kegiatan, Modul, Target, Nama_Target as 'Nama Target', " +
                    $"Id_Target as 'Id Target', Keterangan from Log order by ID desc", con);

                try
                {
                    con.Close();
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt.DefaultView;
                    dt.Dispose();
                    sda.Dispose();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Log-LoadData");
                }
                finally
                {
                    con.Close();
                }

            }


        }

        public static string genNoDis(SqlConnection connection,string text="D")
        {
            SqlCommand cmd = new SqlCommand($"select Count(ID) from Distributor", connection);
            try
            {
                connection.Close();
                connection.Open();
                text += (Int32.Parse(cmd.ExecuteScalar().ToString()) + 1).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "adminHelper, genNoDis");
            }
            finally
            {
                connection.Close();
            }
            return text;
        }
    }
}
