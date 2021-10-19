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
    public partial class UC_Satuan : UserControl
    {

        void updateDGV()
        {
            SqlCommand cmd = new SqlCommand($"select Nama from SatuanBarang order by ID desc", con);
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.ExecuteNonQuery();
                sda.Fill(dt);
                sda.Dispose();
                satuanDGV.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UC-Satuan_loadDGV Failed");
            }
            finally
            {
                con.Close();
            }
        }

        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public UC_Satuan()
        {
            InitializeComponent();
            updateDGV();
        }

        private void baruBTN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand($"insert into SatuanBarang(Nama) values('{textBox1.Text}')", con);

                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                  $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Menambahkan', 'Satuan', '{textBox1.Text}','{textBox1.Text}'," +
                  $" '{textBox1.Text}') ", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Adding satuan Failed");
                }
                finally
                {
                    con.Close();
                    updateDGV();
                }
            }
        }

        private void tambahBTN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && satuanDGV.SelectedRows.Count>0)
            {
                SqlCommand cmd = new SqlCommand($"update SatuanBarang Set Nama = '{textBox1.Text}' where ID =(select ID " +
                    $"from SatuanBarang where Nama = '{satuanDGV.SelectedRows[0].Cells[0].Value.ToString()}') ", con);

                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                  $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Memperbarui', 'Satuan', '{textBox1.Text}','{satuanDGV.SelectedRows[0].Cells[0].Value.ToString()}'," +
                  $" '{textBox1.Text}') ", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "update failed");
                }
                finally
                {
                    con.Close();
                    updateDGV();
                    ubahBTN.Enabled = false;
                    hapusBTN.Enabled = false;
                    baruBTN.Enabled = true;
                    satuanDGV.Enabled = true;
                }
            }
        }

        private void ubahBTN_Click(object sender, EventArgs e)
        {
            if (satuanDGV.SelectedRows.Count > 0)
            {
                satuanDGV.Enabled = false;
                baruBTN.Enabled = false;
                tambahBTN.Enabled = true;
                hapusBTN.Enabled = false;
                textBox1.Text = satuanDGV.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void hapusBTN_Click(object sender, EventArgs e)
        {
            if (satuanDGV.SelectedRows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand($"delete SatuanBarang where Nama = '{satuanDGV.SelectedRows[0].Cells[0].Value.ToString()}'", con);
                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                  $"values('{DateTime.Now.ToString("MM/dd/yy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Menghapus', 'Satuan', '{textBox1.Text}','{satuanDGV.SelectedRows[0].Cells[0].Value.ToString()}'," +
                  $" '{textBox1.Text}') ", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "deleting failed.");
                }

                finally
                {
                    con.Close();
                    updateDGV();
                }
            }
        }

        private void satuanDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ubahBTN.Enabled = true;
            hapusBTN.Enabled = true;
        }

        private void satuanDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ubahBTN.Enabled = true;
            hapusBTN.Enabled = true;
        }
    }
}
