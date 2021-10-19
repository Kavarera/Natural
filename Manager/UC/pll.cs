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
namespace Natural_1.Manager.UC
{
    public partial class pll : UserControl
    {
        DataTable sdt = new DataTable();
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public pll()
        {
            InitializeComponent();


            SqlCommand cmd = new SqlCommand($"select NamaTransaksi as 'Transaksi', TargetTransaksi as 'Target',Jumlah,Satuan, HargaSatuan as 'Harga Satuan', HargaTotal as 'Total Harga'," +
                        $"Discount, Discount*HargaTotal/100 as 'Harga Discount' from pll order by ID Desc", con);
            pllDGV.Columns.Clear();
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                sda.Fill(sdt);
                pllDGV.DataSource = null;
                pllDGV.DataSource = sdt.DefaultView;
                sda.Dispose();
                simpanBTN.Enabled = false;
                button5.Enabled = false;
                beliBTN.Enabled = false;
                hapusbarangBTN.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "pll-strukEnter");
            }
            finally
            {
                con.Close();
            }


            Kasir.kasirHelper.loadCBX(comboBox1, "SatuanBarang", "Nama", con);

        }

        private void discountCB_CheckedChanged(object sender, EventArgs e)
        {
            if (discountCB.Checked)
            {
                TB_discount.Visible = true;
                TB_discount.Text = "0";
            }
            else
            {
                TB_discount.Visible = false;
            }
        }

        private void baruBTN_Click(object sender, EventArgs e)
        {
            simpanBTN.Enabled = true;
            inputBTN.Enabled = false;
            cetakstrukBTN.Enabled = false;
            hapusbarangBTN.Enabled = false;
            pllDGV.Enabled = true;
            sdt.Rows.Clear();
            sdt.AcceptChanges();
        }

        private void button5_Click(object sender, EventArgs e)  //Button Ubah
        {
            if (pllDGV.SelectedRows.Count > 0)
            {
                namatransaksiTB.Text = pllDGV.SelectedRows[0].Cells[0].Value.ToString();
                targettransaksi_TB.Text = pllDGV.SelectedRows[0].Cells[1].Value.ToString();
                jumlahTB.Text = pllDGV.SelectedRows[0].Cells[2].Value.ToString();
                hargasatuanTB.Text = pllDGV.SelectedRows[0].Cells[4].Value.ToString();
                hargatotalTB.Text = pllDGV.SelectedRows[0].Cells[5].Value.ToString();
                if (pllDGV.SelectedRows[0].Cells[6].Value.ToString() != "0")
                {
                    discountCB.Checked = true;
                    TB_discount.Text = pllDGV.SelectedRows[0].Cells[6].Value.ToString();
                }

                baruBTN.Enabled = false;
                pllDGV.Enabled = false;
                beliBTN.Enabled = false;
                simpanBTN.Enabled = true;
                sdt.Rows.Remove(sdt.Rows[pllDGV.CurrentCell.RowIndex]);
                sdt.AcceptChanges();
                pllDGV.Refresh();
            }
        }

        private void simpanBTN_Click(object sender, EventArgs e)
        {
            if (namatransaksiTB.Text != "" && jumlahTB.Text != "" && targettransaksi_TB.Text != "" && hargasatuanTB.Text != "")
            {
                sdt.Rows.Add();
                sdt.Rows[sdt.Rows.Count - 1]["Transaksi"] = namatransaksiTB.Text;
                sdt.Rows[sdt.Rows.Count - 1]["Target"] = targettransaksi_TB.Text;
                sdt.Rows[sdt.Rows.Count - 1]["Jumlah"] = jumlahTB.Text;
                sdt.Rows[sdt.Rows.Count - 1]["Satuan"] = comboBox1.SelectedItem.ToString();
                sdt.Rows[sdt.Rows.Count - 1]["Harga Satuan"] = hargasatuanTB.Text;
                sdt.Rows[sdt.Rows.Count - 1]["Total Harga"] = hargatotalTB.Text;
                sdt.Rows[sdt.Rows.Count - 1]["Discount"] = TB_discount.Text;
                sdt.Rows[sdt.Rows.Count - 1]["Harga Discount"] = (Int32.Parse(hargatotalTB.Text) * Int32.Parse(TB_discount.Text) / 100).ToString();
                sdt.AcceptChanges();
            }
            hapusbarangBTN.Enabled = true;
            if (pllDGV.Rows.Count > 0)
            {
                beliBTN.Enabled = true;
            }
        }

        private void beliBTN_Click(object sender, EventArgs e)
        {
            //clearing tb
            namatransaksiTB.Clear();
            targettransaksi_TB.Clear();
            hargasatuanTB.Clear();
            jumlahTB.Clear();
            hargatotalTB.Clear();
            biayaProsesTB.Text="0";
            strukTB.Clear();



            pllDGV.Enabled = true;
            inputBTN.Enabled = false;
            beliBTN.Enabled = false;
            cetakstrukBTN.Enabled = false;
            if (pllDGV.Rows.Count > 0)
            {
                strukTB.Text = managerHelper.generateStruk(con);
                try
                {
                    SqlCommand cmd = new SqlCommand("",con);
                    con.Open();
                    for (int i = 0; i < pllDGV.Rows.Count; i++)
                    {
                        cmd = new SqlCommand($"insert into pll( Tanggal, Jam, NamaTransaksi, TargetTransaksi, Jumlah, Satuan, HargaSatuan" +
                            $", HargaTotal, Discount, Struk, Keterangan ) " +
                            $"values ( '{dateTimePicker2.Text.ToString()}' , '{dateTimePicker1.Text.ToString()}' , '{pllDGV.Rows[i].Cells[0].Value.ToString()}', " +
                            $" '{pllDGV.Rows[i].Cells[1].Value.ToString()}', '{pllDGV.Rows[i].Cells[2].Value.ToString()}' , '{pllDGV.Rows[i].Cells[3].Value.ToString()}', " +
                            $"'{pllDGV.Rows[i].Cells[4].Value.ToString()}', '{pllDGV.Rows[i].Cells[5].Value.ToString()}', '{pllDGV.Rows[i].Cells[6].Value.ToString()}', " +
                            $"'{strukTB.Text}','{biayaProsesTB.Text}' )", con);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "pll.cs-beli eror");
                }
                finally
                {
                    con.Close();
                    pllDGV.DataSource = null;
                    cetakstrukBTN.Enabled = true;
                    simpanBTN.Enabled = false;
                    baruBTN.Enabled = true;
                    MessageBox.Show("Memperbarui data berhasil!");
                }
            }
        }

        private void hapusbarangBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (pllDGV.SelectedRows.Count > 0 )
                {
                    sdt.Rows.Remove(sdt.Rows[pllDGV.CurrentCell.RowIndex]);
                    sdt.AcceptChanges();
                    pllDGV.Refresh();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "hapusbarangBTN_click");
            }
        }
        #region numberonlyrules!
        private void jumlahTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void hargasatuanTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void hargatotalTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        private void strukTB_KeyUp(object sender, KeyEventArgs e)
        {
            cetakstrukBTN.Enabled = true;
            if (e.KeyCode == Keys.Enter)
            {
                inputBTN.Enabled = true;
                sdt.Clear();
                sdt.AcceptChanges();
                if (strukTB.Text != "")
                {
                    SqlCommand cmd = new SqlCommand($"select NamaTransaksi as 'Transaksi', TargetTransaksi as 'Target',Jumlah,Satuan, HargaSatuan as 'Harga Satuan', HargaTotal as 'Total Harga'," +
                        $"Discount, Discount*HargaTotal/100 as 'Harga Discount' from pll where Struk='{strukTB.Text}'", con);
                    pllDGV.Columns.Clear();
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                        sda.Fill(sdt);
                        pllDGV.DataSource = null;
                        pllDGV.DataSource = sdt.DefaultView;
                        sda.Dispose();
                        simpanBTN.Enabled = false;
                        button5.Enabled = false;
                        beliBTN.Enabled = false;
                        hapusbarangBTN.Enabled = false;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "pll-strukEnter");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Struk Kosong! masukan struk terlebih dahulu!");
                }
            }
        }

        private void inputBTN_Click(object sender, EventArgs e)
        {
            simpanBTN.Enabled = true;
            baruBTN.Enabled = false;
            button5.Enabled = true;
            hapusbarangBTN.Enabled = true;
            beliBTN.Enabled = true;
            inputBTN.Enabled = false;
            cetakstrukBTN.Enabled = true;
            

            SqlCommand cmd = new SqlCommand($"delete from pll where Struk='{strukTB.Text}'", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Removing db-inputbtn");
            }
            finally
            {
                con.Close();
            }

        }

        private void cetakstrukBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for(int i = 1; i < pllDGV.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = pllDGV.Columns[i - 1].HeaderText;
                }

                for(int i = 0; i < pllDGV.Rows.Count; i++)
                {
                    for(int j = 0; j < pllDGV.Columns.Count; j++)
                    {
                        excel.Cells[i + 3, j + 1] = pllDGV.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Cells[pllDGV.Rows.Count + 5, pllDGV.Columns.Count + 1] = "Biaya Proses = " + biayaProsesTB.Text;
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "pll-Cetak Error");
            }
        }

        private void hargasatuanTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (hargasatuanTB.Text != "" && jumlahTB.Text!="")
            {
                hargatotalTB.Text = (Int32.Parse(hargasatuanTB.Text) * Int32.Parse(jumlahTB.Text)).ToString();
            }
        }
    }
}
