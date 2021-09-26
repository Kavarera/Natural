using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace Natural_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_BTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void login_BTN_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"SELECT Password, Id_Karyawan,Status , Role ,Username, Nama FROM Karyawan WHERE Username ='{username_TB.Text}'", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                    Karyawan.Id = sdr["Id_Karyawan"].ToString();
                    Karyawan.Username = sdr["Username"].ToString();
                    Karyawan.Sandi = sdr["Password"].ToString();
                    Karyawan.Jobname = sdr["Role"].ToString();
                    Karyawan.Status = sdr["Status"].ToString();
                    Karyawan.Nama = sdr["Nama"].ToString();
                }
                con.Close();
                if (MySHA256ENC.SHA256Enc.Get_Enc(password_PB.Password) == Karyawan.Sandi && Karyawan.Username == username_TB.Text)
                {
                    this.Dispatcher.Invoke(() => loginPage.BeginAnimation(OpacityProperty, new DoubleAnimation(1, 0, TimeSpan.FromSeconds(1.5))));
                    login_BTN.IsEnabled = false;
                    await Task.Delay(1500);
                    login_BTN.IsEnabled = true;
                    Helper.setLogin(Karyawan.Jobname, Karyawan.Status);
                    this.Hide();
                }
                else
                {
                    System.Windows.MessageBox.Show("Username atau Password Salah");
                }

            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message,"Database Settings error");
                con.Close();
            }
        }

        private void setting_BTN_Click(object sender, RoutedEventArgs e)
        {
            Form setting = new Setting.setting();
            setting.ShowDialog();
        }

        private void username_TB_GotFocus(object sender, RoutedEventArgs e)
        {
            username_TB.Text = "";
        }

        private void password_PB_GotFocus(object sender, RoutedEventArgs e)
        {
            password_PB.Password = "";
        }
    }
}
