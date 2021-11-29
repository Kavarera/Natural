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
        public static string username = "";
        public uc_user()
        {
            InitializeComponent();
            adminHelper.loadData(con, "User", User_DGV);
            Kasir.kasirHelper.loadCBX(role_TB, "Job", "Pekerjaan", con);
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
                User_DGV.Enabled = false;
                id_TB.Text = "UPDATING";
                nama_TB.Text = User_DGV.SelectedRows[0].Cells[1].Value.ToString();
                telepon_TB.Text= User_DGV.SelectedRows[0].Cells[2].Value.ToString();
                alamat_TB.Text= User_DGV.SelectedRows[0].Cells[3].Value.ToString();
                role_TB.Text= User_DGV.SelectedRows[0].Cells[4].Value.ToString();
                status_TB.Text= User_DGV.SelectedRows[0].Cells[5].Value.ToString();
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
                User_DGV.Enabled = true;
                SqlCommand cmd = new SqlCommand($"UPDATE Karyawan SET Nama = '{nama_TB.Text.ToString()}' , No_Telepon = '{telepon_TB.Text.ToString()}', " +
                    $"Alamat = '{alamat_TB.Text.ToString()}', Role = '{role_TB.Text}' WHERE Username = '{User_DGV.SelectedRows[0].Cells[0].Value.ToString()}' ", con);
                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                    $"values('{DateTime.Now.ToString("dd/MM/yyyy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Ubah', 'User', 'Karyawan','{nama_TB.Text}'," +
                    $" '{id_TB.Text}') ", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
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
                    role_TB.SelectedIndex=0;
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
                SqlCommand cmd = new SqlCommand($"UPDATE Karyawan SET Status = 'Inactive' WHERE Username = '{User_DGV.SelectedRows[0].Cells[0].Value.ToString()}'", con);
                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                    $"values('{DateTime.Now.ToString("dd/MM/yyyy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Non-Aktif', 'User', 'Karyawan','{User_DGV.SelectedRows[0].Cells[2].Value.ToString()}'," +
                    $" '{User_DGV.SelectedRows[0].Cells[0].Value.ToString()}') ", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
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
                SqlCommand cmd = new SqlCommand($"UPDATE Karyawan SET Status = 'Active' WHERE Username = '{User_DGV.SelectedRows[0].Cells[0].Value}'", con);
                SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                    $"values('{DateTime.Now.ToString("dd/MM/yyyy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Aktif', 'User', 'Karyawan','{User_DGV.SelectedRows[0].Cells[2].Value.ToString()}'," +
                    $" '{User_DGV.SelectedRows[0].Cells[0].Value.ToString()}') ", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
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
            if (nama_TB.Text!="" && alamat_TB.Text!= "" && telepon_TB.Text!="" && role_TB.Text!="")
            {
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(Id_Karyawan) FROM Karyawan WHERE Role ='{role_TB.Text}'", con);
                
                int idkar = 0;
                try
                {
                    con.Open();
                    idkar = Int32.Parse(cmd.ExecuteScalar().ToString());
                    idkar += 1;

                    Form setpas = new SetPassword();
                    setpas.ShowDialog();

                    // belum set password
                    if (encPwd != "" && username!="")
                    {
                        cmd = new SqlCommand($"INSERT INTO Karyawan(Id_Karyawan, Username, Password, Nama, No_Telepon, Alamat, Role) " +
                         $"VALUES ( '{role_TB.Text.Substring(0,1).ToUpper() + idkar.ToString()}', '{username}', '{encPwd}', " +
                         $" '{nama_TB.Text}', '{telepon_TB.Text}', '{alamat_TB.Text}', '{role_TB.Text.Substring(0,1).ToUpper() + role_TB.Text.Substring(1,role_TB.Text.Length-1).ToLower()}' )", con);
                        cmd.ExecuteNonQuery();
                        id_TB.Text = role_TB.Text.Substring(0, 1).ToUpper() + idkar.ToString();
                        SqlCommand cmd2 = new SqlCommand($"insert into Log(Tanggal, Jam, Operator,Kegiatan, Modul, Target, Nama_Target,Id_Target) " +
                        $"values('{DateTime.Now.ToString("dd/MM/yyyy")}','{DateTime.Now.ToString("HH:mm tt")}', '{Karyawan.Nama}', 'Simpan', 'User', 'Karyawan','{nama_TB.Text}'," +
                        $" '{id_TB.Text}') ", con);
                        cmd2.ExecuteNonQuery();
                        setpas.Dispose();
                        MessageBox.Show("User baru telah ditambahkan ke database!");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nbaruBtnClick, eror when update to database", "uc_user.cs - baru_btn_click");
                }
                finally
                {
                    con.Close();

                    //updating
                    id_TB.Clear();
                    nama_TB.Clear();
                    telepon_TB.Clear();
                    alamat_TB.Clear();
                    role_TB.SelectedIndex=0;
                    status_TB.Clear();
                    simpan_btn.Enabled = false;
                    baru_btn.Enabled = true;
                    User_DGV.Columns.Clear();
                    adminHelper.loadData(con, "User", User_DGV);

                }
            }
            else
            {
                MessageBox.Show("Ada Data yang belum terisi!");
            }
        }

        private void cari_TB_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show("Masukan Nama User saja", (TextBox)sender, 0, -30, 5000);
        }

        private void cari_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand cmd = new SqlCommand($"SELECT Username, Nama,No_Telepon,Alamat, Role,Status FROM Karyawan WHERE Nama LIKE  '%{cari_TB.Text}%' ", con);
                if (cari_TB.Text != "")
                {
                    try
                    {
                        con.Open();
                        User_DGV.Columns.Clear();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        User_DGV.DataSource = dt.DefaultView;
                        dt.Dispose();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\ncariSearchFailed" + "uc_users.cs - carisearch error");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    adminHelper.loadData(con, "User", User_DGV);
                }
            }
        }

        private void nama_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                telepon_TB.Focus();
            }
        }

        private void telepon_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                alamat_TB.Focus();
            }
        }

        private void alamat_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                role_TB.Focus();
            }
        }

        private void role_TB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (simpan_btn.Enabled == true)
                {
                    simpan_btn.Focus();
                }
                else
                {
                    baru_btn.Focus();
                }
            }
        }

        private void status_TB_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void baru_btn_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
