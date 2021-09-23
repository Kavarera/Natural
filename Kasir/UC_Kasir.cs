using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Natural_1.Kasir
{
    public partial class UC_Kasir : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public UC_Kasir()
        {
            InitializeComponent();

        }

        private void noPelanggan_TB_Enter(object sender, EventArgs e)
        {
            noPelanggan_TB.Text = "";
        }

        private void noPelanggan_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (noPelanggan_TB.Text != null && pelangganBaru_CB.Checked==false)
                {
                    namaPelanggan_TB.Enabled = true;
                    noTelepon_TB.Enabled = true;
                    alamatPelanggan_TB.Enabled = true;
                    areaPelanggan_TB.Enabled = true;
                    bonusPelanggan_TB.Enabled = true;

                    SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
                    try
                    {
                        SqlCommand cmdd = new SqlCommand($"SELECT Nama , No_Telp, Alamat,Area , Bonus FROM Pelanggan WHERE Id_Pelanggan ='{noPelanggan_TB.Text}' ", con);
                        con.Open();
                        SqlDataReader sdr = cmdd.ExecuteReader();
                        while (sdr.Read())
                        {
                            Pelanggan.Nama = sdr["Nama"].ToString();
                            Pelanggan.Telepon = sdr["No_Telp"].ToString();
                            Pelanggan.Alamat = sdr["Alamat"].ToString();
                            Pelanggan.Area = sdr["Area"].ToString();
                            Pelanggan.Bonus = sdr["Bonus"].ToString();
                        }
                        con.Close();
                        if (Pelanggan.Nama != null)
                        {
                            namaPelanggan_TB.Text = Pelanggan.Nama.ToString();
                            noTelepon_TB.Text = Pelanggan.Telepon.ToString();
                            alamatPelanggan_TB.Text = Pelanggan.Alamat.ToString();
                            areaPelanggan_TB.Text = Pelanggan.Area.ToString();
                            bonusPelanggan_TB.Text = Pelanggan.Bonus.ToString();
                            Pelanggan.Clear();
                        }
                        else
                        {
                            namaPelanggan_TB.Enabled = false;
                            noTelepon_TB.Enabled = false;
                            alamatPelanggan_TB.Enabled = false;
                            areaPelanggan_TB.Enabled = false;
                            bonusPelanggan_TB.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void noPelanggan_TB_Leave(object sender, EventArgs e)
        {
           
        }

        private void baru_BTN_Click(object sender, EventArgs e)
        {
        }
    }
}
