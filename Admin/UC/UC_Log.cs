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
    public partial class UC_Log : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public UC_Log()
        {
            InitializeComponent();
            adminHelper.loadData(con, "Log", logDGV);
            Kasir.kasirHelper.loadCBX(operatorTB, "Karyawan", "Nama", con);
        }

        private void cariBTN_Click(object sender, EventArgs e)
        {
            if (operatorTB.Text != "" || modulTB.Text != "")
            {
                //MessageBox.Show(tglMulaiDTP.Value.ToString("MM/dd/yy"));
                SqlCommand cmd = new SqlCommand($"select Tanggal, Jam, Operator, Kegiatan, Modul, Target, Nama_Target as 'Nama Target', " +
                    $"Id_Target as 'ID Target', Keterangan from Log where Operator = '{operatorTB.SelectedItem.ToString()}' and Tanggal between '{tglMulaiDTP.Value.ToString("dd/MM/yyyy")}' and " +
                    $"'{tglSelesaiDTP.Value.ToString("dd/MM/yyyy")}' and Modul = '{modulTB.Text}' " +
                    $" order by ID Desc", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    sda.Fill(dt);
                    logDGV.DataSource = dt.DefaultView;
                    sda.Dispose();
                    dt.Dispose();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Log-CariBTN");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operatorTB.SelectedIndex = 0;
            modulTB.Clear();
            adminHelper.loadData(con, "Log", logDGV);
        }

        private void cetakBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (logDGV.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < logDGV.Columns.Count + 1; i++)
                    {
                        excel.Cells[1, i] = logDGV.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < logDGV.Rows.Count; i++)
                    {
                        for (int j = 0; j < logDGV.Columns.Count; j++)
                        {
                            excel.Cells[i + 3, j + 1] = logDGV.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    excel.Columns.AutoFit();
                    excel.Visible = true;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "cetak Log error");
            }
        }

        private void katakunciTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (katakunciTB.Text != "")
                {
                    SqlCommand cmd = new SqlCommand($"select Tanggal, Jam, Operator, Kegiatan, Modul, Target, Nama_Target as 'Nama Target' , ID_Target as 'ID Target'," +
                        $" Keterangan from Log where Tanggal LIKE '%{katakunciTB.Text}%'", con);

                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        cmd.ExecuteNonQuery();
                        sda.Fill(dt);
                        logDGV.DataSource = dt.DefaultView;
                        dt.Dispose();
                        sda.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Log-search error");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                if (katakunciTB.Text == "")
                {
                    adminHelper.loadData(con, "Log", logDGV);
                }
            }

            if (e.KeyCode == Keys.Tab)
            {
                button2.Focus();
            }
        }

        private void katakunciTB_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show("Masukan Tanggal", (TextBox)sender, 0, -30, 3000);
        }

        private void tglMulaiDTP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                tglSelesaiDTP.Focus();
            }
        }

        private void tglSelesaiDTP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                modulTB.Focus();
            }
        }

        private void operatorTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                cariBTN.Focus();
            }
        }

        private void cariBTN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                katakunciTB.Focus() ;
            }
        }

        private void modulTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                operatorTB.Focus();
            }
        }
    }
}
