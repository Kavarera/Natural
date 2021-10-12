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
    public partial class transaksi : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public transaksi()
        {
            InitializeComponent();
        }

        private void penjualanBTN_Click(object sender, EventArgs e)
        {
            if (operatorTB.Text != "")
            {
                SqlCommand cmd = new SqlCommand($"select Struk as 'No Struk' , TanggalJam as 'Tanggal & Jam' , NamaPelanggan as 'Customer/Distributor', " +
                $"Modul, Pemasukan as 'Jumlah' , Keterangan, TglUbah as 'Tanggal Ubah', Bonus, Operator from TransactionLog where Modul = 'Kasir' and Operator = " +
                $"'{operatorTB.Text}'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    transaksiDGV.DataSource = dt.DefaultView;
                    dt.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "managerHelper-loadData-Pembelian Error");
                }
                finally
                {
                    con.Close();
                }


                exportBTN.Enabled = true;
                int totalHarga = 0;
                int iROw = transaksiDGV.Rows.Count;
                totalrpTB.Text = "-" + totalHarga.ToString();

                for (int i = 0; i < iROw; i++)
                {
                    totalHarga = totalHarga + Int32.Parse(transaksiDGV.Rows[i].Cells[4].Value.ToString());
                    totalrpTB.Text = totalHarga.ToString();
                    totalrpTB.ForeColor = Color.Red;
                }
            }

            else
            {
                SqlCommand cmd = new SqlCommand($"select Struk as 'No Struk' , TanggalJam as 'Tanggal & Jam' , NamaPelanggan as 'Customer/Distributor', " +
                $"Modul, Pemasukan as 'Jumlah' , Keterangan, TglUbah as 'Tanggal Ubah',Bonus, Operator from TransactionLog where Modul = 'Kasir' ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    transaksiDGV.DataSource = dt.DefaultView;
                    dt.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "managerHelper-loadData-Pembelian Error");
                }
                finally
                {
                    con.Close();
                }


                exportBTN.Enabled = true;
                int totalHarga = 0;
                int totalBonus = 0;
                int iROw = transaksiDGV.Rows.Count;
                totalrpTB.Text = "-" + totalHarga.ToString();

                for (int i = 0; i < iROw; i++)
                {
                    totalHarga = totalHarga + Int32.Parse(transaksiDGV.Rows[i].Cells[4].Value.ToString());
                    totalBonus = totalBonus + Int32.Parse(transaksiDGV.Rows[i].Cells[7].Value.ToString());
                    totalrpTB.Text = totalHarga.ToString();
                    totalbonusTB.Text = totalBonus.ToString();
                }
            }
        }

        private void pembelianBTN_Click(object sender, EventArgs e)
        {

            if (operatorTB.Text != "")
            {
                SqlCommand cmd = new SqlCommand($"select Struk as 'No Struk' , TanggalJam as 'Tanggal & Jam' , NamaPelanggan as 'Customer/Distributor', " +
                $"Modul, Pengeluaran as 'Jumlah' , Keterangan, TglUbah as 'Tanggal Ubah', Operator from TransactionLog where Modul = 'Belanja' and Operator = " +
                $"'{operatorTB.Text}'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    transaksiDGV.DataSource = dt.DefaultView;
                    dt.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "managerHelper-loadData-Pembelian Error");
                }
                finally
                {
                    con.Close();
                }


                exportBTN.Enabled = true;
                int totalHarga = 0;
                int iROw = transaksiDGV.Rows.Count;
                totalrpTB.Text = "-" + totalHarga.ToString();

                for (int i = 0; i < iROw; i++)
                {
                    totalHarga = totalHarga + Int32.Parse(transaksiDGV.Rows[i].Cells[4].Value.ToString());
                    totalrpTB.Text = totalHarga.ToString();
                    totalrpTB.ForeColor = Color.Red;
                }
            }

            else
            {
                SqlCommand cmd = new SqlCommand($"select Struk as 'No Struk' , TanggalJam as 'Tanggal & Jam' , NamaPelanggan as 'Customer/Distributor', " +
                $"Modul, Pengeluaran as 'Jumlah' , Keterangan, TglUbah as 'Tanggal Ubah', Operator from TransactionLog where Modul = 'Belanja'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    transaksiDGV.DataSource = dt.DefaultView;
                    dt.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "managerHelper-loadData-Pembelian Error");
                }
                finally
                {
                    con.Close();
                }


                exportBTN.Enabled = true;
                int totalHarga = 0;
                int iROw = transaksiDGV.Rows.Count;
                totalrpTB.Text = "-" + totalHarga.ToString();

                for (int i = 0; i < iROw; i++)
                {
                    totalHarga = totalHarga + Int32.Parse(transaksiDGV.Rows[i].Cells[4].Value.ToString());
                    totalrpTB.Text = totalHarga.ToString();
                    totalrpTB.ForeColor = Color.Red;
                }
            }

        }

        private void exportBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (transaksiDGV.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < transaksiDGV.Columns.Count + 1; i++)
                    {
                        excel.Cells[1, i] = transaksiDGV.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < transaksiDGV.Rows.Count; i++)
                    {
                        for (int j = 0; j < transaksiDGV.Columns.Count; j++)
                        {
                            excel.Cells[i + 3, j + 1] = transaksiDGV.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    excel.Columns.AutoFit();
                    excel.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "cetak Log error");
            }
        }
    }
}
