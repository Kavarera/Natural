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

namespace Natural_1.Admin.UC
{
    public partial class items : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public items()
        {
            InitializeComponent();
            adminHelper.loadData(con, "Items", itemsDGV);
            idTB.Text = itemsDGV.Rows.Count.ToString();
        }

        private void ubahBTN_Click(object sender, EventArgs e)
        {
            if (itemsDGV.SelectedRows.Count > 0)
            {
                //disabling button 
                baruBTN.Enabled = false;
                nonaktifBTN.Enabled = false;
                aktifBTN.Enabled = false;

                //enabling button
                simpanBTN.Enabled = true;

                //transfer selected value to tb
                idTB.Text = itemsDGV.SelectedRows[0].Cells[0].Value.ToString();
                namabarangTB.Text = itemsDGV.SelectedRows[0].Cells[1].Value.ToString();
                jumlahTB.Text= itemsDGV.SelectedRows[0].Cells[2].Value.ToString();
                hargaTB.Text= itemsDGV.SelectedRows[0].Cells[3].Value.ToString();
                bonusTB.Text= itemsDGV.SelectedRows[0].Cells[4].Value.ToString();
                statusTB.Text= itemsDGV.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void itemsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //enabling button
            simpanBTN.Enabled = true;
            ubahBTN.Enabled = true;
            nonaktifBTN.Enabled = true;
            aktifBTN.Enabled = true;
        }

        private void itemsDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //enabling button
            ubahBTN.Enabled = true;
            simpanBTN.Enabled = true;
            nonaktifBTN.Enabled = true;
            aktifBTN.Enabled = true;
        }

        private void simpanBTN_Click(object sender, EventArgs e)
        {
            if (namabarangTB.Text != "" || jumlahTB.Text != "" || hargaTB.Text!="" || bonusTB.Text != "")
            {
                SqlCommand cmd = new SqlCommand($"update Barang set " +
                    $"Nama = '{namabarangTB.Text}' , Jumlah='{jumlahTB.Text}', Harga_pcs='{hargaTB.Text}'," +
                    $" Bonus_per= '{bonusTB.Text}' where ID = {idTB.Text}", con);

                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                  $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Ubah', 'Items', 'Barang','{namabarangTB.Text}'," +
                  $" '{idTB.Text}') ", con);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "items-simpanBTN error");
                }
                finally
                {
                    con.Close();
                    simpanBTN.Enabled = false;
                    baruBTN.Enabled = true;
                    namabarangTB.Clear();
                    jumlahTB.Clear();
                    hargaTB.Clear();
                    bonusTB.Clear();
                    MessageBox.Show("Data berhasil diubah!");
                    adminHelper.loadData(con, "Items", itemsDGV);

                }
            }

            else
            {
                MessageBox.Show("Ada bagian yang belum terisi!");
            }

        }

        private void nonaktifBTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"update Barang set Status = 'Inactive' " +
                $"where ID = {itemsDGV.SelectedRows[0].Cells[0].Value.ToString()}",con);

            SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                  $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Non-Aktif', 'Items', 'Barang','{itemsDGV.SelectedRows[0].Cells[1].Value.ToString()}'," +
                  $" '{itemsDGV.SelectedRows[0].Cells[0].Value.ToString()}') ", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "items-nonaktifBTN error");
            }
            finally
            {
                con.Close();
                adminHelper.loadData(con, "Items", itemsDGV);
                nonaktifBTN.Enabled = false;
                aktifBTN.Enabled = false;
                ubahBTN.Enabled = false;
            }
        }

        private void aktifBTN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"update Barang set Status = 'Active' " +
                $"where ID = {itemsDGV.SelectedRows[0].Cells[0].Value.ToString()}", con);

            SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                  $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Aktif', 'Items', 'Barang','{itemsDGV.SelectedRows[0].Cells[1].Value.ToString()}'," +
                  $" '{itemsDGV.SelectedRows[0].Cells[0].Value.ToString()}') ", con);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "items-aktifBTN error");
            }
            finally
            {
                con.Close();
                adminHelper.loadData(con, "Items", itemsDGV);
                nonaktifBTN.Enabled = false;
                aktifBTN.Enabled = false;
                ubahBTN.Enabled = false;
            }
        }

        private void baruBTN_Click(object sender, EventArgs e)
        {
            if(namabarangTB.Text != "" || jumlahTB.Text != "" || hargaTB.Text != "" || bonusTB.Text != "")
            {
                SqlCommand cmd = new SqlCommand($"insert into Barang (Nama, Jumlah, Satuan, Harga_pcs, Bonus_per) " +
                    $"values('{namabarangTB.Text}', {jumlahTB.Text}, 'Pcs' , '{hargaTB.Text}', '{bonusTB.Text}') ", con);

                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                  $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Simpan', 'Items', 'Barang','{namabarangTB.Text}'," +
                  $" '{idTB.Text}' ) ", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Items-baruBTN");
                }
                finally
                {
                    con.Close();
                    MessageBox.Show("Item baru berhasil ditambahkan!");
                    adminHelper.loadData(con, "Items", itemsDGV);
                }
            }
        }

        private void cariTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cariTB.Text != "")
                {
                    SqlCommand cmd = new SqlCommand($"select * from barang where Nama = '{cariTB.Text}'", con);
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        itemsDGV.DataSource = dt.DefaultView;
                        sda.Dispose();
                        dt.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Items-cariTB Erro");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    adminHelper.loadData(con, "Items", itemsDGV);
                }
            }
        }

        private void cariTB_Enter(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.Show("Masukan Nama Barang saja", (TextBox)sender, 0, -30, 3000);
        }
    }
}
