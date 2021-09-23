using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            loginPage.Show();
            this.Close();
        }
    }
}
