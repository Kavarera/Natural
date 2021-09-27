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
            belanja_DVG.Rows.Remove(belanja_DVG.SelectedRows[0]);
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
            SqlCommand cmd = new SqlCommand($"INSERT INTO TransactionLog(TanggalJam, Operator, Kegiatan, Modul, Pemasukan, Pengeluaran, Struk, Keterangan)" +
                $"VALUES( '{TB_TglBeli.Text.ToString() + TB_Jam.Text.ToString()}' , '{Karyawan.Nama}' , 'Distributor' , 'Belanja' , '{D_ItemDibeli.pemasukan.ToString()}' , '{D_ItemDibeli.pengeluaran}'," +
                $"'{struk_TB.Text.ToString()}' , 'Distributor' )", con);
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
    }
}
