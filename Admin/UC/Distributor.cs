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
    public partial class Distributor : UserControl
    {
        /*mulaiDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
                selesaiDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
        */
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public Distributor()
        {
            InitializeComponent();
            adminHelper.loadData(con, "Distributor", Distributor_DGV);
            mulaiDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            selesaiDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            idTB.Text = adminHelper.genNoDis(con);
        }

        private void Distributor_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ubahBTN.Enabled = true;
            nonaktifBTN.Enabled = true;
            aktifBTN.Enabled = true;
            transaksiBTN.Enabled = true;
            if (Distributor_DGV.SelectedRows[0].Cells[4].Value.ToString() == "Active")
            {
                nonaktifBTN.Enabled = true;
                aktifBTN.Enabled = false;
            }
            if (Distributor_DGV.SelectedRows[0].Cells[4].Value.ToString() == "Inactive")
            {
                nonaktifBTN.Enabled = false;
                aktifBTN.Enabled = true;
            }
        }

        private void ubahBTN_Click(object sender, EventArgs e)
        {
            baruBTN.Enabled = false;
            simpanBTN.Enabled = true;
            aktifBTN.Enabled = false;
            nonaktifBTN.Enabled = false;
            transaksiBTN.Enabled = false;
            if (Distributor_DGV.SelectedRows.Count > 0)
            {
                idTB.Text = Distributor_DGV.SelectedRows[0].Cells[0].Value.ToString();
                namaTB.Text= Distributor_DGV.SelectedRows[0].Cells[1].Value.ToString();
                teleponTB.Text= Distributor_DGV.SelectedRows[0].Cells[2].Value.ToString();
                alamatTB.Text= Distributor_DGV.SelectedRows[0].Cells[3].Value.ToString();
                keteranganTB.Text= Distributor_DGV.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void nonaktifBTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"update Distributor set status = 'Inactive'" +
                $"where No_Distributor = '{Distributor_DGV.SelectedRows[0].Cells[0].Value.ToString()}' ", con);


            SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                   $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Non-Aktif', 'Distributor', 'Pelanggan','{Distributor_DGV.SelectedRows[0].Cells[1].Value.ToString()}'," +
                   $" '{Distributor_DGV.SelectedRows[0].Cells[0].Value.ToString()}') ", con);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Distributor, nonaktifBTN");
            }
            finally
            {
                con.Close();
                adminHelper.loadData(con, "Distributor", Distributor_DGV);
            }
        }

        private void aktifBTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"update Distributor set status = 'Active'" +
                $"where No_Distributor = '{Distributor_DGV.SelectedRows[0].Cells[0].Value.ToString()}' ", con);


            SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                   $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Aktif', 'Distributor', 'Pelanggan','{Distributor_DGV.SelectedRows[0].Cells[1].Value.ToString()}'," +
                   $" '{Distributor_DGV.SelectedRows[0].Cells[0].Value.ToString()}') ", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distributor, nonaktifBTN");
            }
            finally
            {
                con.Close();
                adminHelper.loadData(con, "Distributor", Distributor_DGV);
            }
        }

        private void simpanBTN_Click(object sender, EventArgs e)
        {
            idTB.ReadOnly = true;
            if (namaTB.Text != "" && teleponTB.Text != "" && alamatTB.Text != "" && keteranganTB.Text != "")
            {
                SqlCommand cmd = new SqlCommand($"update Distributor set Nama_Toko = '{namaTB.Text}', " +
                    $"No_Telp = '{teleponTB.Text}', Alamat ='{alamatTB.Text}' , Keterangan='{keteranganTB.Text}' " +
                    $"where No_Distributor = '{idTB.Text}' ", con);

                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                   $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Ubah', 'Distributor', 'Pelanggan','{namaTB.Text}'," +
                   $" '{idTB.Text}') ", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Distributor - simpanBtn");
                }
                finally
                {
                    con.Close();
                    adminHelper.loadData(con, "Distributor", Distributor_DGV);
                    MessageBox.Show("Data berhasil Diubah");
                    idTB.Clear();
                    namaTB.Clear();
                    teleponTB.Clear();
                    alamatTB.Clear();
                    keteranganTB.Clear();
                    //disabling button and activating button;
                    simpanBTN.Enabled = false;
                    baruBTN.Enabled = true;
                    ubahBTN.Enabled = false;
                    aktifBTN.Enabled = false;
                    nonaktifBTN.Enabled = false;
                    transaksiBTN.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Isi semua kolom terlebih dahulu!!!!!");
            }
        }

        private void baruBTN_Click(object sender, EventArgs e)
        {
            if (namaTB.Text != "" && teleponTB.Text != "" && alamatTB.Text != "" && keteranganTB.Text != "")
            {
                string[] arrtext = alamatTB.Text.ToString().Split('/');
                if (arrtext.Length > 1)
                {
                    SqlCommand cmd = new SqlCommand($"insert into Distributor(No_Distributor, Nama_Toko, No_Telp, Alamat, Keterangan,Area) " +
                    $"values('{idTB.Text}', '{namaTB.Text}', '{teleponTB.Text}', '{arrtext[0]}', '{keteranganTB.Text}', '{arrtext[1]}' )", con);


                    SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                   $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Simpan', 'Distributor', 'Pelanggan','{namaTB.Text}'," +
                   $" '{idTB.Text}') ", con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Distributor -baruBTN");
                    }
                    finally
                    {
                        con.Close();
                        MessageBox.Show("Data berhasil ditambahkan");
                        adminHelper.loadData(con, "Distributor", Distributor_DGV);
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand($"insert into Distributor(No_Distributor, Nama_Toko, No_Telp, Alamat, Keterangan) " +
                    $"values('{idTB.Text}', '{namaTB.Text}', '{teleponTB.Text}', '{alamatTB.Text}', '{keteranganTB.Text}' ", con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Distributor -baruBTN");
                    }
                    finally
                    {
                        con.Close();
                        MessageBox.Show("Data berhasil ditambahkan");
                    }
                }
            }
        }

        private void cariTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cariTB.Text == "")
                {
                    adminHelper.loadData(con, "Distributor", Distributor_DGV);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand($"SELECT No_Distributor as 'Id_Distributor' , Nama_Toko as 'Nama' , No_Telp as 'Telepon'," +
                    $" Alamat, Status, Keterangan FROM Distributor WHERE No_Distributor = '{cariTB.Text}' ", con);
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        Distributor_DGV.Columns.Clear();
                        DataTable dt = new DataTable();
                        cmd.ExecuteNonQuery();
                        sda.Fill(dt);
                        Distributor_DGV.DataSource = dt.DefaultView;
                        dt.Dispose();
                        sda.Dispose();
                        // set size
                        Distributor_DGV.Columns[0].Width = 80; //id
                        Distributor_DGV.Columns[1].Width = 130; // Nama
                        Distributor_DGV.Columns[2].Width = 250; // Telepon
                        Distributor_DGV.Columns[3].Width = 250; // alamat
                        Distributor_DGV.Columns[4].Width = 250; // status
                        Distributor_DGV.Columns[5].Width = 150; //keterangan
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Distributor - cariEnter");
                        Distributor_DGV.Columns.Clear();
                        adminHelper.loadData(con, "Distributor", Distributor_DGV);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void transaksiBTN_Click(object sender, EventArgs e)
        {
            if (Distributor_DGV.SelectedRows.Count > 0)
            {
                adminHelper.loadData(con, "TD", distTran_DGV, Distributor_DGV.SelectedRows[0].Cells[0].Value.ToString());
                namaTransTB.Enabled = true;
                namaTransTB.ReadOnly = true;
                namaTransTB.Text = Distributor_DGV.SelectedRows[0].Cells[1].Value.ToString();
                telTransTB.Enabled = true;
                telTransTB.ReadOnly = true;
                telTransTB.Text = Distributor_DGV.SelectedRows[0].Cells[2].Value.ToString();
                cetakBTN.Enabled = true;
                refundBTN.Enabled = true;
                cariTransTB.Enabled = true;

                int totalPenjualan = 0;
                for (int i = 0; i < distTran_DGV.RowCount; i++)
                {
                    totalPenjualan += Int32.Parse(distTran_DGV.Rows[i].Cells[3].Value.ToString());
                }
                totalJmlh.Text = totalPenjualan.ToString();

            }
        }

        private void bukaBTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"SELECT TanggalJam as 'Tgl & Jam', Operator,Kegiatan as 'Kategori', Pemasukam as 'Jumlah', Struk as 'No Struk', Status, TglUbah as 'Tgl Ubah'" +
                $" from TransactionLog WHERE TanggalJam BETWEEN '{mulaiDTP.Value.ToString()}' and '{selesaiDTP.Value.ToString()}' " +
                $"and Nama_Toko = '{namaTransTB.Text}' and Kegiatan = 'Distributor' ", con);
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Dispose();
                distTran_DGV.Columns.Clear();
                distTran_DGV.DataSource = dt.DefaultView;
                dt.Dispose();

                distTran_DGV.Columns[0].Width = 250; //tgljam
                distTran_DGV.Columns[1].Width = 230; // operator
                distTran_DGV.Columns[2].Width = 190; // kategori
                distTran_DGV.Columns[3].Width = 180; // jumlah
                distTran_DGV.Columns[4].Width = 250; // nostruk
                distTran_DGV.Columns[5].Width = 180; //status
                distTran_DGV.Columns[6].Width = 250; // tgl ubah


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribut-bukaTRANSAKSI");
            }
            finally
            {
                con.Close();
            }
        }

        private void refundBTN_Click(object sender, EventArgs e)
        {
            if (distTran_DGV.SelectedRows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand($"update TransactionLog set status = 'Refunded' , " +
                    $"TglUbah = '{DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}' where Struk = '{distTran_DGV.SelectedRows[0].Cells[4].Value.ToString()}'", con);

                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                   $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Refund', 'Distributor', 'Pelanggan','{namaTransTB.Text}'," +
                   $" (select No_Distributor from Distributor where Nama_Toko = '{namaTransTB.Text}' and No_Telp='{telTransTB.Text}')) ", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Distributor-RefundBTN");
                }
                finally
                {
                    con.Close();
                    adminHelper.loadData(con, "TD", distTran_DGV, Distributor_DGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void cariTransTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cariTransTB.Text != "")
                {
                    SqlCommand cmd = new SqlCommand($"select TanggalJam as 'Tgl & Jam' , Operator , Kegiatan as 'Kategori' , Pemasukan as 'Jumlah' , " +
                        $"Struk , Status , TglUbah as 'Tgl Ubah' from TransactionLog where Struk = '{cariTransTB.Text}' and Kegiatan = 'Distributor' ", con);
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        distTran_DGV.DataSource = dt.DefaultView;
                        dt.Dispose();
                        sda.Dispose();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Distributor-cariTrans-Enter");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    adminHelper.loadData(con, "TD", distTran_DGV, Distributor_DGV.SelectedRows[0].Cells[0].Value.ToString()) ;
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
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"SELECT TanggalJam, Operator, BarangLog.NamaBarang as 'Nama_Barang' " +
                $", BarangLog.Pengurangan as 'Jumlah' , BarangLog.totalHarga as 'Total' from TransactionLog " +
                $"inner join BarangLog on TransactionLog.Struk = BarangLog.Struk" +
                $" WHERE TransactionLog.Struk = '{distTran_DGV.SelectedRows[0].Cells[4].Value.ToString()}' ", con);

            try
            {
                con.Close();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                sda.Fill(dt);

                Font regular = new Font(FontFamily.GenericSansSerif, 8.0f, FontStyle.Regular);
                Font bold = new Font(FontFamily.GenericSansSerif, 20.0f, FontStyle.Bold);

                e.Graphics.DrawString("NATURAL", bold, Brushes.Black, new Point(35, 0));
                e.Graphics.DrawString("AIR MINUM ISI ULANG", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(60, 30));
                e.Graphics.DrawLine(new Pen(Color.Black, 3), new PointF(0f, 43f), new PointF(600f, 43f));
                e.Graphics.DrawString("No Struk :\t" + distTran_DGV.SelectedRows[0].Cells[4].Value.ToString(), regular, Brushes.Black, new Point(5, 45));
                e.Graphics.DrawString("Date : " + distTran_DGV.SelectedRows[0].Cells[0].Value.ToString(), regular, Brushes.Black, new Point(5, 60));

                e.Graphics.DrawString("Barang(pcs)", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(5, 75));
                e.Graphics.DrawString("Total Harga", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(120, 75));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, 85f), new PointF(600f, 87f));

                int totalHarga = 0;
                int x = 5;
                int y = 90;
                dt.Rows[0].ItemArray[0].ToString();

                int dtRIndex = dt.Rows.Count;
                for (int i = 0; i < dtRIndex; i++)
                {
                    e.Graphics.DrawString($"{dt.Rows[i].ItemArray[2].ToString()}", regular, Brushes.Black, new Point(x, y + 10));
                    e.Graphics.DrawString($"{dt.Rows[i].ItemArray[4].ToString()}", regular, Brushes.Black, new Point(x + 120, y + 10));
                    y += 20;
                    totalHarga += Int32.Parse(dt.Rows[i].ItemArray[4].ToString());
                }
                e.Graphics.DrawString("TOTAL HARGA : ", regular, Brushes.Black, new Point(x + 20, y + (5 * (dtRIndex - 1) + 30)));
                e.Graphics.DrawString($"{totalHarga.ToString()}", regular, Brushes.Black, new Point(x + 120, y + (5 * (dtRIndex - 1) + 30)));
                y = y + (5 * (dtRIndex - 1) + 35);
                e.Graphics.DrawString("========== TERIMA KASIH ==========", regular, Brushes.Black, new Point(5, y + 20));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, y + 30f), new PointF(600f, y + 32f));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Distributor Error - PrinDocumnet");
            }
            finally
            {
                con.Close();
            }

        }

        private void cariTransTB_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show("Masukan Nomor Struk saja", (TextBox)sender, 0, -30, 5000);
        }

        private void cariTB_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show("Masukan Nomor Distributor saja", (TextBox)sender, 0, -30, 5000);
        }

        private void alamatTB_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show("Gunakan / untuk memasukan area.\n xxxxx /Jakarta", (TextBox)sender, 0, -60, 2000);
        }
    }
}
