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
using System.Drawing.Printing;

namespace Natural_1.Admin.UC
{
    public partial class uc_pelanggan : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public uc_pelanggan()
        {
            InitializeComponent();
            adminHelper.loadData(con, "Pelanggan", pelanggan_DGV);
        }

        private void pelanggan_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pelanggan_DGV.SelectedRows.Count > 0)
            {
                if (pelanggan_DGV.SelectedRows[0].Cells[6].Value.ToString() == "Active")
                {
                    aktifBTN.Enabled = false;
                    if (pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString() != "Non-Member")
                    {
                        ubahBTN.Enabled = true;
                        transaksiBTN.Enabled = true;
                        nonaktifBTN.Enabled = true;
                    }
                }
                else if (pelanggan_DGV.SelectedRows[0].Cells[6].Value.ToString() == "Inactive")
                {
                    nonaktifBTN.Enabled = true;
                    if (pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString() != "Non-Member")
                    {
                        ubahBTN.Enabled = true;
                        transaksiBTN.Enabled = true;
                        aktifBTN.Enabled = true;
                    }
                }
            }
        }

        private void pelanggan_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (pelanggan_DGV.SelectedRows.Count > 0)
            {
                if (pelanggan_DGV.SelectedRows[0].Cells[6].Value.ToString() == "Active")
                {
                    aktifBTN.Enabled = false;
                    if (pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString() != "Non-Member")
                    {
                        ubahBTN.Enabled = true;
                        transaksiBTN.Enabled = true;
                        nonaktifBTN.Enabled = true;
                    }
                }
                else if (pelanggan_DGV.SelectedRows[0].Cells[6].Value.ToString() == "Inactive")
                {
                    nonaktifBTN.Enabled = false;
                    if (pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString() != "Non-Member")
                    {
                        ubahBTN.Enabled = true;
                        transaksiBTN.Enabled = true;
                        aktifBTN.Enabled = true;
                    }
                }
            }
        }

        private void ubahBTN_Click(object sender, EventArgs e)
        {
            id_TB.ReadOnly = true;
            bonus_TB.ReadOnly = true;
            baruBTN.Enabled = false;
            simpanBTN.Enabled = true;
            nonaktifBTN.Enabled = false;
            ubahBTN.Enabled = false;
            aktifBTN.Enabled = false;
            transaksiBTN.Enabled = false;

            // Id_Pelanggan as ID, Nama, No_Telp as Telepon, Alamat, Bonus, Area, Status 

            id_TB.Text = pelanggan_DGV.SelectedRows[0].Cells[0].Value.ToString();
            nama_TB.Text = pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString();
            telep_TB.Text = pelanggan_DGV.SelectedRows[0].Cells[2].Value.ToString();
            alamat_TB.Text = pelanggan_DGV.SelectedRows[0].Cells[3].Value.ToString();
            bonus_TB.Text = pelanggan_DGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void nonaktifBTN_Click(object sender, EventArgs e)
        {
            if(pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString()!="Non-Member")
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Pelanggan SET Status ='Inactive' WHERE Id_Pelanggan = '{pelanggan_DGV.SelectedRows[0].Cells[0].Value.ToString()}'", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    pelanggan_DGV.Columns.Clear();
                    adminHelper.loadData(con, "Pelanggan", pelanggan_DGV);
                }
                catch(Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message + "\nnonaktifbtnClick", "uc_pelanggan.cs - nonaktifbtn click error");
                }
                finally
                {
                    con.Close();
                    MessageBox.Show("Pelanggan telah dinonaktifkan.");
                }
            }
        }

        private void aktifBTN_Click(object sender, EventArgs e)
        {
            if (pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString() != "Non-Member")
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Pelanggan SET Status ='Active' WHERE Id_Pelanggan = '{pelanggan_DGV.SelectedRows[0].Cells[0].Value.ToString()}'", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    pelanggan_DGV.Columns.Clear();
                    adminHelper.loadData(con, "Pelanggan", pelanggan_DGV);
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message + "\nnonaktifbtnClick", "uc_pelanggan.cs - nonaktifbtn click error");
                }
                finally
                {
                    con.Close();
                    MessageBox.Show("Pelanggan telah Diaktifkan.");
                }
            }
        }

        private void simpanBTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"UPDATE Pelanggan SET Nama = '{nama_TB.Text}' , No_Telp = '{telep_TB.Text}' , Alamat = '{alamat_TB.Text}' WHERE Id_Pelanggan = '{id_TB.Text}'", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message + "\n simpanBTNClick failed Error", "uc_pelanggan.cs - simpanBtn Click Error");
            }
            finally
            {
                con.Close();
                simpanBTN.Enabled = false;
                id_TB.Clear();
                nama_TB.Clear();
                alamat_TB.Clear();
                telep_TB.Clear();
                bonus_TB.Clear();
                bonus_TB.ReadOnly = false;
                baruBTN.Enabled = true;
                ubahBTN.Enabled = false;
                nonaktifBTN.Enabled = false;
                aktifBTN.Enabled = false;
                transaksiBTN.Enabled = false;
                pelanggan_DGV.Columns.Clear();
                adminHelper.loadData(con, "Pelanggan", pelanggan_DGV);
            }
        }

        private void baruBTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO Pelanggan(Id_Pelanggan, Nama, No_Telp, Alamat, Area) " +
                $"VALUES ('{Kasir.kasirHelper.GenerateNoPelanggan(con, "PA")}', '{nama_TB.Text}' , '{telep_TB.Text}' , '{alamat_TB.Text}','{alamat_TB.Text}' ", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message + "baruBTNClic error", "uc_pelanggan.cs - baruBTN_Click ERROR");
            }
            finally
            {
                con.Close();
                id_TB.Clear();
                nama_TB.Clear();
                telep_TB.Clear();
                alamat_TB.Clear();
                bonus_TB.Clear();
            }
        }

        private void transaksiBTN_Click(object sender, EventArgs e)
        {
            if (pelanggan_DGV.SelectedRows.Count > 0)
            {
                adminHelper.loadData(con, "TP", transaksiPelanggan_DGV, pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString());
                mulaiDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
                selesaiDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";

                namatTB.Enabled = true;
                telepontTB.Enabled = true;
                cetakBTN.Enabled = true;
                voidBTN.Enabled = true;
                cariTB.Enabled = true;
                totalTB.ReadOnly = true;
                totalTB.Enabled = true;
                namatTB.ReadOnly = true;
                namatTB.Text = pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString();
                telepontTB.ReadOnly = true;
                telepontTB.Text = pelanggan_DGV.SelectedRows[0].Cells[2].Value.ToString();
                bukaBTN.Enabled = true;
                mulaiDTP.Enabled = true;
                selesaiDTP.Enabled = true;


                //counting total jumlah in transaksi
                int totalPenjualan = 0;
                for (int i = 0; i < transaksiPelanggan_DGV.RowCount; i++)
                {
                    totalPenjualan += Int32.Parse(transaksiPelanggan_DGV.Rows[i].Cells[3].Value.ToString());
                }
                totalTB.Text = totalPenjualan.ToString();
            }
        }

        private void transaksiPelanggan_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (transaksiPelanggan_DGV.SelectedRows.Count > 0)
            {

            }
        }

        private void bukaBTN_Click(object sender, EventArgs e)
        {
            transaksiPelanggan_DGV.Columns.Clear();
            SqlCommand cmd = new SqlCommand($"SELECT TanggalJam as 'Tgl & Jam' , Operator , Kegiatan as Kategori, Pemasukan as Jumlah  , Struk as 'No Struk' , Status , TglUbah as 'Tgl Ubah' " +
                $"FROM TransactionLog WHERE TanggalJam BETWEEN '{mulaiDTP.Value.ToString("MM/dd/yyyy hh:mm tt")}' AND '{selesaiDTP.Value.ToString("MM/dd/yyyy hh:mm tt")}' AND " +
                $"NamaPelanggan = '{namatTB.Text}' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                transaksiPelanggan_DGV.DataSource = dt.DefaultView;
                transaksiPelanggan_DGV.Columns[0].Width = 250; //tgljam
                transaksiPelanggan_DGV.Columns[1].Width = 230; // operator
                transaksiPelanggan_DGV.Columns[2].Width = 190; // kategori
                transaksiPelanggan_DGV.Columns[3].Width = 180; // jumlah
                transaksiPelanggan_DGV.Columns[4].Width = 250; // nostruk
                transaksiPelanggan_DGV.Columns[5].Width = 180; //status
                transaksiPelanggan_DGV.Columns[6].Width = 250; // tgl ubah
                dt.Dispose();
                sda.Dispose();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message + "\nBukaBTNClick error", "uc_pelanggan.cs - bukabtnclick error");
            }
            finally
            {
                con.Close();
            }
        }

        private void voidBTN_Click(object sender, EventArgs e)
        {
            if (transaksiPelanggan_DGV.SelectedRows.Count > 0)
            {
                if (transaksiPelanggan_DGV.SelectedRows[0].Cells[5].Value.ToString() != "Void")
                {
                    SqlCommand cmd = new SqlCommand($"UPDATE TransactionLog SET Status = 'Void' , " +
                    $"TglUbah = '{DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}' WHERE Struk = '{transaksiPelanggan_DGV.SelectedRows[0].Cells[4].Value.ToString()}' ", con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        transaksiBTN.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message + "\nvoidbtnclick updating status", "uc_pelanggan.cs - voidbtnclick error");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data transaksi terlebih dahulu!");
            }
        }

        private void cariPelangganTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cariPelangganTB.Text != "")
                {
                    SqlCommand cmd = new SqlCommand($"SELECT Id_Pelanggan as ID, Nama, No_Telp as Telepon, Alamat, Bonus, Area, Status" +
                        $" FROM Pelanggan WHERE Id_Pelanggan = '{cariPelangganTB.Text}'",con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        pelanggan_DGV.DataSource = dt.DefaultView;
                        dt.Dispose();
                        sda.Dispose();
                    }
                    catch(Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message, "uc_pelanggan - caripelangganTB error");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else if (cariPelangganTB.Text == "")
                {
                    adminHelper.loadData(con, "Pelanggan", pelanggan_DGV);
                }
            }
        }

        private void cariTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cariTB.Text != "")
                {
                    SqlCommand cmd = new SqlCommand($"TanggalJam as 'Tgl & Jam' , Operator , Kegiatan as Kategori, Pemasukan as Jumlah  , Struk as 'No Struk' , Status , TglUbah as 'Tgl Ubah' " +
                        $"FROM TransactionLog WHERE Struk ='{cariTB.Text}'", con);
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        transaksiPelanggan_DGV.DataSource = dt.DefaultView;
                        dt.Dispose();
                        sda.Dispose();
                    }
                    catch(Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message, "uc_pelanggan.cs - cariTBtext keysup error");
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                else if (cariTB.Text == "")
                {
                    adminHelper.loadData(con, "TP", transaksiPelanggan_DGV, pelanggan_DGV.SelectedRows[0].Cells[1].Value.ToString());
                }
            }
        }

        private void cetakBTN_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("paper", 215, 600);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font regular = new Font(FontFamily.GenericSansSerif, 8.0f, FontStyle.Regular);
            Font bold = new Font(FontFamily.GenericSansSerif, 20.0f, FontStyle.Bold);

            e.Graphics.DrawString("NATURAL", bold, Brushes.Black, new Point(35, 0));
            e.Graphics.DrawString("AIR MINUM ISI ULANG", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(60, 30));
            e.Graphics.DrawLine(new Pen(Color.Black, 3), new PointF(0f, 43f), new PointF(600f, 43f));
            e.Graphics.DrawString("No Struk :\t" + transaksiPelanggan_DGV.SelectedRows[0].Cells[4].Value.ToString(), regular, Brushes.Black, new Point(5, 45));
            e.Graphics.DrawString("Date : " + transaksiPelanggan_DGV.SelectedRows[0].Cells[0].Value.ToString(), regular, Brushes.Black, new Point(5, 60));

            e.Graphics.DrawString("STRUK CETAK ULANG", new Font(FontFamily.GenericSansSerif,10.0f,FontStyle.Bold),Brushes.Black, new Point(15, 95));

            e.Graphics.DrawString("TOTAL HARGA : ", regular, Brushes.Black, new Point(5, 125));
            e.Graphics.DrawString($"{totalTB.Text}", regular, Brushes.Black, new Point(100,125));
            e.Graphics.DrawString("========== TERIMA KASIH ==========", regular, Brushes.Black, new Point(5, 145));

        }
    }
}
