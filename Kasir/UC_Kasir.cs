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

namespace Natural_1.Kasir
{
    public partial class UC_Kasir : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public UC_Kasir()
        {
            InitializeComponent();
            barang_CB = kasirHelper.loadCBX(barang_CB,"Barang", "Nama", con);
            ongkir_TB.Text = "0";
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
                        System.Windows.MessageBox.Show(ex.Message+"\nError at UC_Kasir.cs noPelangganTB_KeyUp","UC_KASIR.cs - noPelangganTB_Keyup");
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                
                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }

            }
        }

        private void noPelanggan_TB_Leave(object sender, EventArgs e)
        {
           
        }

        private void baru_BTN_Click(object sender, EventArgs e)
        {
            kasir_DGV.Rows.Clear();
            kasirHelper.totalHarga = 0;
            if (nonMember_CB.Checked == false && pelangganBaru_CB.Checked == false)
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Pelanggan SET Bonus = {bonusPelanggan_TB.Text}", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nbaru_BTN_Click", "UC_Kasir.cs - baru_BTN_Click");
                }
            }
        }

        private void pelangganBaru_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (pelangganBaru_CB.Checked == true)
            {
                beliLangsung_BTN.Enabled = true;
                namaPelanggan_TB.Enabled = true;
                alamatPelanggan_TB.Enabled = true;
                areaPelanggan_TB.Enabled = true;
                bonusPelanggan_TB.Enabled = true;

                if (nonMember_CB.Checked == true)
                {
                    noTelepon_TB.Enabled = false;
                    noPelanggan_TB.Enabled = false;
                }
                else
                {
                    noTelepon_TB.Enabled = true;
                    noPelanggan_TB.Enabled = true;
                }
                
            }
            else
            {
                beliLangsung_BTN.Enabled = false;
                namaPelanggan_TB.Enabled = false;
                alamatPelanggan_TB.Enabled = false;
                areaPelanggan_TB.Enabled = false;
                bonusPelanggan_TB.Enabled = false;

                beliLangsung_BTN.Enabled = false;
            }
        }

        private void beliLangsung_BTN_Click(object sender, EventArgs e)
        {
            if (pelangganBaru_CB.Checked == true)
            {
                kasir_DGV.Rows.Add();
                try
                {

                    //add to Data grid
                    int rowIndex = kasir_DGV.Rows.Count-1;
                    kasir_DGV.Rows[rowIndex].Cells[0].Value = barang_CB.SelectedItem.ToString();
                    kasir_DGV.Rows[rowIndex].Cells[1].Value = "-";
                    kasir_DGV.Rows[rowIndex].Cells[2].Value = jumlah_TB.Text.ToString();
                    kasir_DGV.Rows[rowIndex].Cells[3].Value = "Galon";
                    kasir_DGV.Rows[rowIndex].Cells[4].Value = hargaSatuan_TB.Text.ToString();
                    kasir_DGV.Rows[rowIndex].Cells[5].Value = Int32.Parse(hargaSatuan_TB.Text.ToString()) * Int32.Parse(jumlah_TB.Text.ToString());

                    //disabling buttonand tb cb
                    pelangganBaru_CB.Enabled = false;
                    nonMember_CB.Enabled = false;
                    beliLangsung_BTN.Enabled = false;
                    namaPelanggan_TB.Enabled = false;
                    alamatPelanggan_TB.Enabled = false;
                    areaPelanggan_TB.Enabled = false;
                    bonusPelanggan_TB.Enabled = false;
                    namaPelanggan2_TB.Enabled = false;
                    alamatPelanggan2_TB.Enabled = false;
                    areaPelanggan2_TB.Enabled = false;
                    bonusPelanggan2_TB.Enabled = false;
                    ambilBonus_BTN.Enabled = false;
                    tambah_BTN.Enabled = false;
                    beli_BTN.Enabled = false;
                    hapusbarang_BTN.Enabled = false;
                    cetakStruk_BTN.Enabled = true;

                    //Adding transaksi into database Log.
                    try
                    {
                        noStruk_TB.Text = kasirHelper.getNoStruk(con, Karyawan.Nama);
                        SqlCommand cmd = new SqlCommand($"INSERT INTO TransactionLog(TanggalJam,Operator,Kegiatan,Modul,Pemasukan,Struk) " +
                        $"VALUES('{DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}', '{Karyawan.Nama.ToString()}', '{barang_CB.SelectedItem.ToString()}', 'Kasir', {kasir_DGV.Rows[rowIndex].Cells[5].Value.ToString()},'{noStruk_TB.Text.ToString()}')", con);
                        con.Open();
                        int status = cmd.ExecuteNonQuery();
                        if (status > 0)
                        {
                            MessageBox.Show("Ditambahkan ke Data Transaksi.","Transaksi berhasil");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nAT BeliLangsungBTN_Click when try to input data from datagrid into Database Transaction Log", "UC_Kasir.cs-beliLangsungBTN_Click");
                    }
                    finally
                    {
                        con.Close();
                    }


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nError at beliLangsung_BTN_Click when pelangganBaru_Cb.Checked==true and\ntrying to add value into datagrid", "UC_Kasir.cs - beliLangsung_BTN_Click Eror");
                }
            }
        }

        private void nonMember_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (nonMember_CB.Checked == true)
            {
                noPelanggan_TB.Enabled = false;
                noTelepon_TB.Enabled = false;
            }
            else
            {
                noPelanggan_TB.Enabled = true;
                noTelepon_TB.Enabled = true;
            }
        }

        private void barang_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            kasirHelper.getBarangDetail(con, barang_CB.SelectedItem.ToString());
            hargaSatuan_TB.Text = Barang.Harga_PCS.ToString();
        }

        private void tambah_BTN_Click(object sender, EventArgs e)
        {
            if (jumlah_TB.Text != "")
            {
                beliLangsung_BTN.Enabled = false;
                beli_BTN.Enabled = true;
                ongkir_TB.Enabled = true;
                hapusbarang_BTN.Enabled = true;
                if (bonusPelanggan_TB.Text != null)
                {
                    ambilBonus_BTN.Enabled = true;
                }

                kasir_DGV.Rows.Add();
                try
                {

                    //kasir_DGV.Rows[indexRow].Cells
                    int indexRow = kasir_DGV.Rows.Count - 1;
                    kasir_DGV.Rows[indexRow].Cells[0].Value = barang_CB.SelectedItem.ToString();
                    kasir_DGV.Rows[indexRow].Cells[1].Value = "-";
                    kasir_DGV.Rows[indexRow].Cells[2].Value = jumlah_TB.Text.ToString();
                    kasir_DGV.Rows[indexRow].Cells[3].Value = Barang.Satuan;
                    kasir_DGV.Rows[indexRow].Cells[4].Value = hargaSatuan_TB.Text.ToString();
                    kasir_DGV.Rows[indexRow].Cells[5].Value = Int32.Parse(hargaSatuan_TB.Text.ToString()) * Int32.Parse(jumlah_TB.Text.ToString());


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "tambah_BTN_Click when input data to datagrid", "UC_Kasir.cs - tambah_BTN_Click ERROR");
                }
            }
            else
            {
                MessageBox.Show("Jumlah Textbox Kosong!");
            }

        }

        private void namaPelanggan_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }
            }
        }

        private void noTelepon_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }
            }
        }

        private void alamatPelanggan_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }
            }
        }

        private void areaPelanggan_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (kasirHelper.checkTextBox(nonMember_CB, namaPelanggan_TB, alamatPelanggan_TB, areaPelanggan_TB, noTelepon_TB, noPelanggan_TB))
                {
                    tambah_BTN.Enabled = true;
                }
                else
                {
                    tambah_BTN.Enabled = false;
                }
            }
        }

        private void beli_BTN_Click(object sender, EventArgs e)
        {
            noStruk_TB.Text = kasirHelper.getNoStruk(con, Karyawan.Nama);
            int totalRow = kasir_DGV.Rows.Count;
            //input datagrid to database
            for(int a=0; a < totalRow; a++)
            {
                if (kasirHelper.totalHarga < 0)
                {
                    kasirHelper.totalHarga = 0;
                }
                SqlCommand cmd = new SqlCommand($"INSERT INTO TransactionLog(TanggalJam, Operator,Kegiatan,Modul,Pemasukan,Struk)" +
                    $"VALUES( '{DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}'," +
                    $"'{Karyawan.Nama}','{barang_CB.SelectedItem.ToString()}','Kasir', {kasir_DGV.Rows[a].Cells[5].Value.ToString()}, '{noStruk_TB.Text.ToString()}' )", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n beliBTN_Click When upload it to database.", "UC_Kasir.cs - beli_BTN_Click Error");
                }
                finally
                {
                    con.Close();
                }

                kasirHelper.totalHarga += Int32.Parse(kasir_DGV.Rows[a].Cells[5].Value.ToString());
                if (ongkir_TB.Text == "")
                {
                    try
                    {
                        kasirHelper.totalHarga += Int32.Parse(ongkir_TB.Text.ToString());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Pastikan textbox ongkir hanya angka!\nError Message:\n" + ex.Message, "UC_Kasir.cs - beli_Btn_Click ERROR");
                    }
                }
            }
            kasir_DGV.Rows.Add();
            totalRow = kasir_DGV.Rows.Count - 1;
            for(int a =0; a <= 4; a++)
            {
                kasir_DGV.Rows[totalRow].Cells[a].Value = "====";
            }
            // memberikan total harga yang harus dibayar.
            kasir_DGV.Rows[totalRow].Cells[5].Value = kasirHelper.totalHarga.ToString();
            #region Menonaktifkan_Button_Yang_Tidak_Terpakai
            //nonaktif
            pelangganBaru_CB.Enabled = false;
            nonMember_CB.Enabled = false;
            beliLangsung_BTN.Enabled = false;
            namaPelanggan_TB.Enabled = false;
            alamatPelanggan_TB.Enabled = false;
            areaPelanggan_TB.Enabled = false;
            bonusPelanggan_TB.Enabled = false;
            namaPelanggan2_TB.Enabled = false;
            alamatPelanggan2_TB.Enabled = false;
            areaPelanggan2_TB.Enabled = false;
            bonusPelanggan2_TB.Enabled = false;
            ambilBonus_BTN.Enabled = false;
            tambah_BTN.Enabled = false;
            beli_BTN.Enabled = false;
            hapusbarang_BTN.Enabled = false;
            //aktif
            cetakStruk_BTN.Enabled = true;
            baru_BTN.Enabled = true;
            #endregion


        }

        private void hapusbarang_BTN_Click(object sender, EventArgs e)
        {
            kasir_DGV.Rows.Remove(kasir_DGV.SelectedRows[0]);
        }

        private void kasir_DGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hapusbarang_BTN.Enabled = true;
        }

        private void cetakStruk_BTN_Click(object sender, EventArgs e)
        { 
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("paper", 216, 600);
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
            e.Graphics.DrawString("No Struk :\t\t" + noStruk_TB.Text.ToString(), regular, Brushes.Black, new Point(5, 45));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToShortDateString(), regular, Brushes.Black, new Point(5, 60));

            //draw item
            e.Graphics.DrawString("Barang(pcs)", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(5,75));
            e.Graphics.DrawString("Total Harga", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(120, 75));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, 85f), new PointF(600f, 87f));
            int y = 90;
            int x = 5;
            int totalRow = kasir_DGV.Rows.Count;
            for (int i = 0; i < totalRow-1; i++)
            {
                e.Graphics.DrawString($"{kasir_DGV.Rows[i].Cells[0].Value}({kasir_DGV.Rows[i].Cells[2].Value})", regular, Brushes.Black, new Point(x, y + 10));
                e.Graphics.DrawString($"{kasir_DGV.Rows[i].Cells[5].Value}", regular, Brushes.Black, new Point(x + 120, y + 10));
                y += 20;
            }
            e.Graphics.DrawString("Ongkos Kirim : ",regular,Brushes.Black,new Point(x, y + (5 * (totalRow - 1) + 5)));
            e.Graphics.DrawString($"{kasirHelper.totalHarga.ToString()}", regular, Brushes.Black, new Point(x + 120, y + (5 * (totalRow - 1) + 5)));
            e.Graphics.DrawString("TOTAL HARGA : ", regular, Brushes.Black, new Point(x + 20, y + (5 * (totalRow - 1) + 20)));
            e.Graphics.DrawString($"{kasirHelper.totalHarga.ToString()}", regular, Brushes.Black, new Point(x + 120, y + (5 * (totalRow - 1) + 20)));
            y = y + (5 * (totalRow - 1) + 25);
            e.Graphics.DrawString("========== TERIMA KASIH ==========", regular, Brushes.Black, new Point(5, y + 20));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, y+30f), new PointF(600f, y+32f));

        }

        private void ambilBonus_BTN_Click(object sender, EventArgs e)
        {
            int pBon = Int32.Parse(bonusPelanggan_TB.Text);
            int bBon = Barang.Bonus_PER;
            if (pBon>bBon)
            {
                int totalBonus = pBon - bBon;
                Pelanggan.Bonus = totalBonus.ToString();
                bonusPelanggan_TB.Text = totalBonus.ToString();
                kasirHelper.totalHarga -= Barang.Harga_PCS;
                kasir_DGV.Rows.Add();
                int iRow = kasir_DGV.Rows.Count-1;
                kasir_DGV.Rows[iRow].Cells[0].Value = Barang.NamaBarang+" BONUS";
                kasir_DGV.Rows[iRow].Cells[1].Value = "-";
                kasir_DGV.Rows[iRow].Cells[2].Value = "1";
                kasir_DGV.Rows[iRow].Cells[3].Value = Barang.Satuan;
                kasir_DGV.Rows[iRow].Cells[4].Value = "0";
                kasir_DGV.Rows[iRow].Cells[5].Value = "0";
            }
        }

        
    }
}
