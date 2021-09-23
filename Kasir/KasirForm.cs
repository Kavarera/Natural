using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Threading;

namespace Natural_1.Kasir
{
    public partial class KasirForm : Form
    {
        public KasirForm()
        {
            InitializeComponent();
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            var loginPage = new MainWindow();
            //Dipakai jika error 
            //ElementHost.EnableModelessKeyboardInterop(loginPage);  
            Pelanggan.Clear();
            loginPage.Show();
            this.Close();
            //Application.Restart();
        }

        private void kasir_BTN_Click(object sender, EventArgs e)
        {
            kasir_BTN.BackColor = Color.Green;
            kasir_BTN.ForeColor = Color.White;
            belanja_BTN.BackColor = Color.White;
            belanja_BTN.ForeColor = Color.Black;

            UC_Kasir kasir = new UC_Kasir();
            addUserControl(kasir);

        }

        private void addUserControl(UserControl usercontrol)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(usercontrol);
            usercontrol.Dock = DockStyle.Fill;
            usercontrol.BringToFront();
        }

        private void belanja_BTN_Click(object sender, EventArgs e)
        {
            kasir_BTN.BackColor = Color.White;
            kasir_BTN.ForeColor = Color.Black;
            belanja_BTN.BackColor = Color.Green;
            belanja_BTN.ForeColor = Color.White;
            UC_Belanja belanja = new UC_Belanja();
            addUserControl(belanja);
        }
    }
}
