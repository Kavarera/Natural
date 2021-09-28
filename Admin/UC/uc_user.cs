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
namespace Natural_1.Admin.Uc
{
    public partial class uc_user : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public static string encPwd = "";
        public uc_user()
        {
            InitializeComponent();
            adminHelper.loadData(con, "User", User_DGV);
        }

        private void User_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (User_DGV.SelectedRows[0].Cells[0].Value.ToString() != Karyawan.Id.ToString() && User_DGV.SelectedRows[0].Cells[5].Value.ToString() != "Admin")
            {
                ubah_btn.Enabled = true;
                nonaktif_btn.Enabled = true;
                aktivasi_btn.Enabled = true;
            }
            else if (User_DGV.SelectedRows[0].Cells[0].Value.ToString() != Karyawan.Id.ToString() && User_DGV.SelectedRows[0].Cells[5].Value.ToString() == "Admin")
            {
                ubah_btn.Enabled = false;
                nonaktif_btn.Enabled = false;
                aktivasi_btn.Enabled = false;
            }
            if (User_DGV.SelectedRows[0].Cells[0].Value.ToString() == Karyawan.Id.ToString() && User_DGV.SelectedRows[0].Cells[5].Value.ToString() == "Admin")
            {
                ubah_btn.Enabled = true;
                nonaktif_btn.Enabled = true;
                aktivasi_btn.Enabled = true;
            }
        }

        private void User_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (User_DGV.SelectedRows[0].Cells[0].Value.ToString() != Karyawan.Id.ToString() && User_DGV.SelectedRows[0].Cells[5].Value.ToString() != "Admin")
            {
                ubah_btn.Enabled = true;
                nonaktif_btn.Enabled = true;
                aktivasi_btn.Enabled = true;
            }
            else if (User_DGV.SelectedRows[0].Cells[0].Value.ToString() != Karyawan.Id.ToString() && User_DGV.SelectedRows[0].Cells[5].Value.ToString() == "Admin")
            {
                ubah_btn.Enabled = false;
                nonaktif_btn.Enabled = false;
                aktivasi_btn.Enabled = false;
            }
            if (User_DGV.SelectedRows[0].Cells[0].Value.ToString() == Karyawan.Id.ToString() && User_DGV.SelectedRows[0].Cells[5].Value.ToString() == "Admin")
            {
                ubah_btn.Enabled = true;
                nonaktif_btn.Enabled = true;
                aktivasi_btn.Enabled = true;
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (User_DGV.SelectedRows.Count > 0)
            {
                id_TB.Text = User_DGV.Rows[0].Cells[0].Value.ToString();
                nama_TB.Text = User_DGV.Rows[0].Cells[2].Value.ToString();
                telepon_TB.Text= User_DGV.Rows[0].Cells[3].Value.ToString();
                alamat_TB.Text= User_DGV.Rows[0].Cells[4].Value.ToString();
                role_TB.Text= User_DGV.Rows[0].Cells[5].Value.ToString();
                status_TB.Text= User_DGV.Rows[0].Cells[6].Value.ToString();
                simpan_btn.Enabled = true;
                baru_btn.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Mohon untuk memilih user di data terlebih dahulu1");
            }
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (nama_TB.Text != "" && alamat_TB.Text != "" && telepon_TB.Text != "" && role_TB.Text != "")
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Karyawan SET Nama = '{nama_TB.Text.ToString()}' , No_Telepon = '{telepon_TB.Text.ToString()}', " +
                    $"Alamat = '{alamat_TB.Text.ToString()}', Role = '{role_TB.Text}' WHERE Id_Karyawan = '{id_TB.Text}' ", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\nbaruBTNClick", "uc_user.cs - baru btn click error");
                }
                finally
                {
                    con.Close();
                    MessageBox.Show("Data telah disimpan di database");
                    id_TB.Clear();
                    nama_TB.Clear();
                    telepon_TB.Clear();
                    alamat_TB.Clear();
                    role_TB.Clear();
                    status_TB.Clear();
                    simpan_btn.Enabled = false;
                    baru_btn.Enabled = true;
                    User_DGV.Columns.Clear();
                    adminHelper.loadData(con, "User", User_DGV);

                }
            }
            else
            {
                MessageBox.Show("Ada data yg kosong!");
            }
        }

        private void nonaktif_btn_Click(object sender, EventArgs e)
        {
            if (User_DGV.SelectedRows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Karyawan SET Status = 'Inactive' WHERE Id_Karyawan = '{User_DGV.SelectedRows[0].Cells[0].Value}'", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nNonaktif btn", "uc_user.cs -nonaktif btn click error");
                }
                finally
                {
                    con.Close();
                    nonaktif_btn.Enabled = false;
                    aktivasi_btn.Enabled = false;
                    User_DGV.Columns.Clear();
                    adminHelper.loadData(con, "User", User_DGV);
                }
            }
            else
            {
                MessageBox.Show("Pilih user terlebih dahulu!");
                nonaktif_btn.Enabled = false;
                aktivasi_btn.Enabled = false;
            }
        }

        private void aktivasi_btn_Click(object sender, EventArgs e)
        {
            if (User_DGV.SelectedRows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand($"UPDATE Karyawan SET Status = 'Active' WHERE Id_Karyawan = '{User_DGV.SelectedRows[0].Cells[0].Value}'", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n aktivasi btn click error", "uc_user.cs -aktivasi btn click error");
                }
                finally
                {
                    con.Close();
                    nonaktif_btn.Enabled = false;
                    aktivasi_btn.Enabled = false;
                    User_DGV.Columns.Clear();
                    adminHelper.loadData(con, "User", User_DGV);
                }
            }
            else
            {
                MessageBox.Show("Pilih user terlebih dahulu!");
                nonaktif_btn.Enabled = false;
                aktivasi_btn.Enabled = false;
            }
        }

        private void baru_btn_Click(object sender, EventArgs e)
        {
            if (id_TB.Text == "")
            {
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(Id_Karyawan) FROM Karyawan WHERE Role ='{role_TB.Text}'", con);
                int idkar = 0;
                try
                {
                    con.Open();
                    idkar = Int32.Parse(cmd.ExecuteScalar().ToString()) +1;

                    Form setpas = new SetPassword();
                    setpas.ShowDialog();

                    // belum set password
                    if (encPwd != "")
                    {
                        cmd = new SqlCommand($"INSERT INTO Karyawan(Id_Karyawan, Username, Password, Nama, No_Telepon, Alamat, Role) " +
                         $"VALUES ( '{role_TB.Text.Substring(0,1).ToUpper() + idkar.ToString()}', '{role_TB.Text.Substring(0, 2).ToUpper() + idkar.ToString()}', '{encPwd}', " +
                         $" '{nama_TB.Text}', '{telepon_TB.Text}', '{alamat_TB.Text}', '{role_TB.Text.Substring(0,1).ToUpper() + role_TB.Text.Substring(1,role_TB.Text.Length-1).ToLower()}' )", con);
                        cmd.ExecuteNonQuery();
                        setpas.Dispose();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nbaruBtnClick, eror when update to database", "uc_user.cs - baru_btn_click");
                }
                finally
                {
                    con.Close();
                    MessageBox.Show("User baru telah ditambahkan ke database!");

                    //updating
                    id_TB.Clear();
                    nama_TB.Clear();
                    telepon_TB.Clear();
                    alamat_TB.Clear();
                    role_TB.Clear();
                    status_TB.Clear();
                    simpan_btn.Enabled = false;
                    baru_btn.Enabled = true;
                    User_DGV.Columns.Clear();
                    adminHelper.loadData(con, "User", User_DGV);

                }
            }
        }
    }
}
