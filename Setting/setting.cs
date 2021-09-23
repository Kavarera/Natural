using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace Natural_1.Setting
{
    public partial class setting : Form
    {

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        string connectionSave;
        public setting()
        {
            InitializeComponent();
            string[] sprator = { ";", "=" };
            connectionSave = config.ConnectionStrings.ConnectionStrings["cn"].ConnectionString;
            string[] splitconnectionSave = connectionSave.Split(sprator, StringSplitOptions.RemoveEmptyEntries);

            server_TB.Text = splitconnectionSave[1];
            database_TB.Text = splitconnectionSave[3];
            usernameSetting_TB.Text = splitconnectionSave[5];
            passwordSetting_TB.Text = splitconnectionSave[7];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_BTN_Click(object sender, EventArgs e)
        {
            string format = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", server_TB.Text, database_TB.Text, usernameSetting_TB.Text, passwordSetting_TB.Text);
            Helper helper = new Helper();
            helper.SaveConnection("cn", format);
            MessageBox.Show("Berhasil Disimpan!");

            Application.Restart();

            this.Close();
        }
    }
}
