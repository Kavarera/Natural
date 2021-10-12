using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Natural_1.Manager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle = 0x2000000;
                return handleParams;
            }
        }

        private void addUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            panelContainer.Visible = false;
            panelContainer.Controls.Add(uc);
            uc.Visible = false;
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            uc.Visible = true;
            panelContainer.Visible = true;
        }

        //164, 89
        private void transaksiBTN_Click(object sender, EventArgs e)
        {
            transaksiBTN.Width = 195;
            transaksiBTN.Font = new Font("Microsoft Sans Serif", 14);
            transaksiBTN.BackColor = ColorTranslator.FromHtml("#4A6FF6");
            transaksiBTN.ForeColor = Color.White;

            //chane another button to default
            pllBTN.Width = 164;
            pllBTN.Font = new Font("Microsoft Sans Serif", 11);
            pllBTN.BackColor = Color.White;
            pllBTN.ForeColor = Color.Black;

            satuanBTN.Width = 164;
            satuanBTN.Font = new Font("Microsoft Sans Serif", 11);
            satuanBTN.BackColor = Color.White;
            satuanBTN.ForeColor = Color.Black;

            addUserControl(new UC.transaksi());


        }

        private void pllBTN_Click(object sender, EventArgs e)
        {
            pllBTN.Width = 195;
            pllBTN.Font = new Font("Microsoft Sans Serif", 14);
            pllBTN.BackColor = ColorTranslator.FromHtml("#4A6FF6");
            pllBTN.ForeColor = Color.White;

            //chane another button to default
            transaksiBTN.Width = 164;
            transaksiBTN.Font = new Font("Microsoft Sans Serif", 11);
            transaksiBTN.BackColor = Color.White;
            transaksiBTN.ForeColor = Color.Black;

            satuanBTN.Width = 164;
            satuanBTN.Font = new Font("Microsoft Sans Serif", 11);
            satuanBTN.BackColor = Color.White;
            satuanBTN.ForeColor = Color.Black;
        }

        private void satuanBTN_Click(object sender, EventArgs e)
        {
            satuanBTN.Width = 195;
            satuanBTN.Font = new Font("Microsoft Sans Serif", 14);
            satuanBTN.BackColor = ColorTranslator.FromHtml("#4A6FF6");
            satuanBTN.ForeColor = Color.White;

            //chane another button to default
            pllBTN.Width = 164;
            pllBTN.Font = new Font("Microsoft Sans Serif", 11);
            pllBTN.BackColor = Color.White;
            pllBTN.ForeColor = Color.Black;

            transaksiBTN.Width = 164;
            transaksiBTN.Font = new Font("Microsoft Sans Serif", 11);
            transaksiBTN.BackColor = Color.White;
            transaksiBTN.ForeColor = Color.Black;
        }

        private void clsBTN_Click(object sender, EventArgs e)
        {
            var loginPage = new MainWindow();
            loginPage.Show();
            this.Close();
        }
    }
}
