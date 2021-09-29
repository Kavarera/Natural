using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Natural_1.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
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

        //136, 71 -> Normal
        // 195 -> Selected

        private void user_BTN_Click(object sender, EventArgs e)
        {
            user_BTN.Width = 195;
            user_BTN.Font = new Font("Microsoft Sans Serif", 14);
            user_BTN.BackColor = ColorTranslator.FromHtml("#4A6FF6");
            user_BTN.ForeColor = Color.White;
            //make another button to be normal.
            pelanggan_BTN.Width = 136;
            pelanggan_BTN.Font = new Font("Microsoft Sans Serif", 10);
            pelanggan_BTN.BackColor = Color.White;
            pelanggan_BTN.ForeColor = Color.Black;

            distributor_BTN.Width = 136;
            distributor_BTN.Font = new Font("Microsoft Sans Serif", 10);
            distributor_BTN.BackColor = Color.White;
            distributor_BTN.ForeColor = Color.Black;

            item_BTN.Width = 136;
            item_BTN.Font = new Font("Microsoft Sans Serif", 10);
            item_BTN.BackColor = Color.White;
            item_BTN.ForeColor = Color.Black;

            log_BTN.Width = 136;
            log_BTN.Font = new Font("Microsoft Sans Serif", 10);
            log_BTN.BackColor = Color.White;
            log_BTN.ForeColor = Color.Black;

            addUserControl(new Uc.uc_user());

        }

        private void pelanggan_BTN_Click(object sender, EventArgs e)
        {
            pelanggan_BTN.Width = 195;
            pelanggan_BTN.Font = new Font("Microsoft Sans Serif", 14);
            pelanggan_BTN.BackColor = ColorTranslator.FromHtml("#4A6FF6");
            pelanggan_BTN.ForeColor = Color.White;
            //make another button to be normal.
            user_BTN.Width = 136;
            user_BTN.Font = new Font("Microsoft Sans Serif", 10);
            user_BTN.BackColor = Color.White;
            user_BTN.ForeColor = Color.Black;

            distributor_BTN.Width = 136;
            distributor_BTN.Font = new Font("Microsoft Sans Serif", 10);
            distributor_BTN.BackColor = Color.White;
            distributor_BTN.ForeColor = Color.Black;

            item_BTN.Width = 136;
            item_BTN.Font = new Font("Microsoft Sans Serif", 10);
            item_BTN.BackColor = Color.White;
            item_BTN.ForeColor = Color.Black;

            log_BTN.Width = 136;
            log_BTN.Font = new Font("Microsoft Sans Serif", 10);
            log_BTN.BackColor = Color.White;
            log_BTN.ForeColor = Color.Black;

            addUserControl(new UC.uc_pelanggan());
        }

        private void distributor_BTN_Click(object sender, EventArgs e)
        {
            distributor_BTN.Width = 195;
            distributor_BTN.Font = new Font("Microsoft Sans Serif", 14);
            distributor_BTN.BackColor = ColorTranslator.FromHtml("#4A6FF6");
            distributor_BTN.ForeColor = Color.White;
            //make another button to be normal.
            pelanggan_BTN.Width = 136;
            pelanggan_BTN.Font = new Font("Microsoft Sans Serif", 10);
            pelanggan_BTN.BackColor = Color.White;
            pelanggan_BTN.ForeColor = Color.Black;

            user_BTN.Width = 136;
            user_BTN.Font = new Font("Microsoft Sans Serif", 10);
            user_BTN.BackColor = Color.White;
            user_BTN.ForeColor = Color.Black;

            item_BTN.Width = 136;
            item_BTN.Font = new Font("Microsoft Sans Serif", 10);
            item_BTN.BackColor = Color.White;
            item_BTN.ForeColor = Color.Black;

            log_BTN.Width = 136;
            log_BTN.Font = new Font("Microsoft Sans Serif", 10);
            log_BTN.BackColor = Color.White;
            log_BTN.ForeColor = Color.Black;
        }

        private void item_BTN_Click(object sender, EventArgs e)
        {
            item_BTN.Width = 195;
            item_BTN.Font = new Font("Microsoft Sans Serif", 14);
            item_BTN.BackColor = ColorTranslator.FromHtml("#4A6FF6");
            item_BTN.ForeColor = Color.White;
            //make another button to be normal.
            pelanggan_BTN.Width = 136;
            pelanggan_BTN.Font = new Font("Microsoft Sans Serif", 10);
            pelanggan_BTN.BackColor = Color.White;
            pelanggan_BTN.ForeColor = Color.Black;

            distributor_BTN.Width = 136;
            distributor_BTN.Font = new Font("Microsoft Sans Serif", 10);
            distributor_BTN.BackColor = Color.White;
            distributor_BTN.ForeColor = Color.Black;

            user_BTN.Width = 136;
            user_BTN.Font = new Font("Microsoft Sans Serif", 10);
            user_BTN.BackColor = Color.White;
            user_BTN.ForeColor = Color.Black;

            log_BTN.Width = 136;
            log_BTN.Font = new Font("Microsoft Sans Serif", 10);
            log_BTN.BackColor = Color.White;
            log_BTN.ForeColor = Color.Black;
        }

        private void log_BTN_Click(object sender, EventArgs e)
        {
            log_BTN.Width = 195;
            log_BTN.Font = new Font("Microsoft Sans Serif", 14);
            log_BTN.BackColor = ColorTranslator.FromHtml("#4A6FF6");
            log_BTN.ForeColor = Color.White;
            //make another button to be normal.
            pelanggan_BTN.Width = 136;
            pelanggan_BTN.Font = new Font("Microsoft Sans Serif", 10);
            pelanggan_BTN.BackColor = Color.White;
            pelanggan_BTN.ForeColor = Color.Black;

            distributor_BTN.Width = 136;
            distributor_BTN.Font = new Font("Microsoft Sans Serif", 10);
            distributor_BTN.BackColor = Color.White;
            distributor_BTN.ForeColor = Color.Black;

            item_BTN.Width = 136;
            item_BTN.Font = new Font("Microsoft Sans Serif", 10);
            item_BTN.BackColor = Color.White;
            item_BTN.ForeColor = Color.Black;

            user_BTN.Width = 136;
            user_BTN.Font = new Font("Microsoft Sans Serif", 10);
            user_BTN.BackColor = Color.White;
            user_BTN.ForeColor = Color.Black;
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            var loginPage = new MainWindow();
            loginPage.Show();
            this.Close();
        }
    }
}
