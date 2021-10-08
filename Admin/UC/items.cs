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

namespace Natural_1.Admin.UC
{
    public partial class items : UserControl
    {
        SqlConnection con = new SqlConnection(Helper.getConnection("cn"));
        public items()
        {
            InitializeComponent();
            adminHelper.loadData(con, "Items", itemsDGV);
        }
    }
}
