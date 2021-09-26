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
namespace Natural_1.Kasir
{
    public partial class UC_Belanja : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public UC_Belanja()
        {
            InitializeComponent();
            CBX_namaToko= kasirHelper.loadCBX(CBX_namaToko, "Distributor", "Nama_Toko",con);
        }

        private void CBX_namaToko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
