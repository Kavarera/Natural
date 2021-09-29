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
    public partial class UC_Belanja : UserControl
    {
        int totalTransaksi = 0;
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public UC_Belanja()
        {
            InitializeComponent();
            CBX_namaToko= kasirHelper.loadCBX(CBX_namaToko, "Distributor", "Nama_Toko",con);
            CBX_Barang = kasirHelper.loadCBX(CBX_Barang, "Barang", "Nama", con);
            CBX_namaToko.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TB_Jam.Text = DateTime.Now.ToString("t");
            TB_TglBeli.Text = DateTime.Now.ToString("d");
            timer1.Start();
            
        }

        private void CBX_namaToko_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucbHelper.getDistributorDetail(con, CBX_namaToko.SelectedItem.ToString());
            TB_NoDistr.Text = Distributor.NoDistributor;
            TB_alamat.Text = Distributor.Alamat;
            TB_NoTel.Text = Distributor.NoTelp;
            TB_Area.Text = Distributor.Area;
            if (Distributor.Status == "Inactive")
            {
                CBX_namaToko.ForeColor = Color.Red;
            }
        }

        private void BTN_tambah_Click(object sender, EventArgs e)
        {
            ongkir_TB.Enabled = true;
            if((TB_alamat.Text!=""&&TB_Area.Text != ""&&TB_NoDistr.Text != ""&&TB_NoTel.Text != ""&&TB_Area.Text != "" && TB_Kurir.Text!="") && TB_Jumlah.Text != "")
            {
                belanja_DVG.Rows.Add();
                belanja_DVG.Rows[belanja_DVG.Rows.Count - 1].Cells[0].Value = Barang.NamaBarang;
                belanja_DVG.Rows[belanja_DVG.Rows.Count - 1].Cells[1].Value = TB_Jumlah.Text;
                belanja_DVG.Rows[belanja_DVG.Rows.Count - 1].Cells[2].Value = Barang.Satuan;
                belanja_DVG.Rows[belanja_DVG.Rows.Count - 1].Cells[3].Value = Barang.Harga_PCS;
                belanja_DVG.Rows[belanja_DVG.Rows.Count - 1].Cells[4].Value = Int32.Parse(Barang.Harga_PCS.ToString()) * Int32.Parse(TB_Jumlah.Text.ToString());
                hapusBTN.Enabled = true;
                beliBTN.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ada data yang belum terisi!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TB_Jam.Text = DateTime.Now.ToString("t");
            TB_TglBeli.Text = DateTime.Now.ToString("d");
        }

        private void CBX_Barang_SelectedIndexChanged(object sender, EventArgs e)
        {
            kasirHelper.getBarangDetail(con, CBX_Barang.SelectedItem.ToString());
            hargaSatuan_TB.Text = Barang.Harga_PCS.ToString();
        }

        private void hapusBTN_Click(object sender, EventArgs e)
        {
            try
            {
                belanja_DVG.Rows.Remove(belanja_DVG.SelectedRows[0]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nPilih bagian yang ingin di hapus!", "UC_Belanja - hapusBTN-clik ERROR");
            }
        }

        private void beliBTN_Click(object sender, EventArgs e)
        {
            int indexRow = belanja_DVG.Rows.Count;
            int ongkir = 0;
            if (ongkir_TB.Text != "")
            {
                ongkir = Int32.Parse(ongkir_TB.Text.ToString());
            }
            struk_TB.Text = kasirHelper.getNoStruk("Distributor", Karyawan.Nama, totalTransaksi);
            for(int i = 0; i < indexRow; i++)
            {
                D_ItemDibeli.pemasukan += Int32.Parse(belanja_DVG.Rows[i].Cells[4].Value.ToString());
            }
            SqlCommand cmd = new SqlCommand($"INSERT INTO TransactionLog(TanggalJam, Operator, Kegiatan, Modul, Pemasukan, Pengeluaran, Struk, Keterangan , NamaPelanggan)" +
                $"VALUES( '{TB_TglBeli.Text.ToString() + TB_Jam.Text.ToString()}' , '{Karyawan.Nama}' , 'Distributor' , 'Belanja' , '{D_ItemDibeli.pemasukan.ToString()}' , '{D_ItemDibeli.pengeluaran}'," +
                $"'{struk_TB.Text.ToString()}' , 'Distributor' , '{CBX_namaToko.SelectedItem.ToString()}' )", con);
            try
            {
                con.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nbeliBTNClick", "UC_Belanja.cs - beli_BtnClick ERROR");
            }
            finally
            {
                con.Close();
            }

            //Adding new row for total harda
            belanja_DVG.Rows.Add();
            for(int i = belanja_DVG.Rows.Count - 1; i < belanja_DVG.Rows.Count; i++)
            {
                belanja_DVG.Rows[i].Cells[4].Value = D_ItemDibeli.pemasukan + ongkir;
            }
            totalTransaksi += 1;
            //Disabling the button for continue the process example baru btn and cetak struk btn
            beliBTN.Enabled = false;
            BTN_tambah.Enabled = false;
            hapusBTN.Enabled = false;


            //Enabling the button
            baruBTN.Enabled = true;
            cetakStrukBTN.Enabled = true;

        }

        private void baruBTN_Click(object sender, EventArgs e)
        {
            baruBTN.Enabled = false;
            belanja_DVG.Rows.Clear();
            D_ItemDibeli.Clear();
            cetakStrukBTN.Enabled = false;

            //enabling button
            BTN_tambah.Enabled = true;
        }

        private void cetakStrukBTN_Click(object sender, EventArgs e)
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
            e.Graphics.DrawString("No Struk :\t" + struk_TB.Text.ToString(), regular, Brushes.Black, new Point(5, 45));
            e.Graphics.DrawString("Date : " + TB_TglBeli.Text.ToString(), regular, Brushes.Black, new Point(5, 60));

            //draw item
            e.Graphics.DrawString("Barang(pcs)", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(5, 75));
            e.Graphics.DrawString("Total Harga", new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Regular), Brushes.Black, new Point(120, 75));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, 85f), new PointF(600f, 87f));
            int y = 90;
            int x = 5;
            int totalRow = belanja_DVG.Rows.Count;
            for (int i = 0; i <= totalRow - 2; i++)
            {
                e.Graphics.DrawString($"{belanja_DVG.Rows[i].Cells[0].Value}", regular, Brushes.Black, new Point(x, y + 10));
                e.Graphics.DrawString($"{belanja_DVG.Rows[i].Cells[4].Value}", regular, Brushes.Black, new Point(x + 120, y + 10));
                y += 20;
            }
            e.Graphics.DrawString("Ongkos Kirim : ", regular, Brushes.Black, new Point(x, y + (5 * (totalRow - 1) + 5)));
            e.Graphics.DrawString($"{ongkir_TB.Text.ToString()}", regular, Brushes.Black, new Point(x + 120, y + (5 * (totalRow - 1) + 5)));
            e.Graphics.DrawString("TOTAL HARGA : ", regular, Brushes.Black, new Point(x + 20, y + (5 * (totalRow - 1) + 30)));
            e.Graphics.DrawString($"{D_ItemDibeli.pemasukan.ToString()}", regular, Brushes.Black, new Point(x + 120, y + (5 * (totalRow - 1) + 30)));
            y = y + (5 * (totalRow - 1) + 35);
            e.Graphics.DrawString("========== TERIMA KASIH ==========", regular, Brushes.Black, new Point(5, y + 20));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(0f, y + 30f), new PointF(600f, y + 32f));
        }
    }
}
