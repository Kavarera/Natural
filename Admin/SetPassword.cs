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

namespace Natural_1.Admin
{
    public partial class SetPassword : Form
    {

        public SetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                Uc.uc_user.encPwd = MySHA256ENC.SHA256Enc.Get_Enc(textBox1.Text);
                this.Close();
                
            }
        }


        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uc.uc_user.encPwd = "";
            this.Close();
        }
    }
}
