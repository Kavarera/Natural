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
        public static void loadData(SqlConnection con, string tipe, DataGridView dgv , string idp = "-")
        {
            con.Close();
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
                    dgv.Columns[0].Width = 80; //id
                    dgv.Columns[1].Width = 130; // Nama
                    dgv.Columns[2].Width = 250; // Telepon
                    dgv.Columns[3].Width = 250; // alamat
                    dgv.Columns[4].Width = 250; // Bonus
                    dgv.Columns[5].Width = 150; //area
                    dgv.Columns[6].Width = 60; // status
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
                SqlCommand cmd = new SqlCommand($"SELECT TanggalJam as 'Tgl & Jam' , Operator , Kegiatan as Kategori, Pemasukan as Jumlah  , Struk as 'No Struk' , Status , TglUbah as 'Tgl Ubah' FROM TransactionLog WHERE NamaPelanggan = '{idp}' ", con);
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
                catch(Exception ex)
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

        }
    }
}
