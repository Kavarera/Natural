using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_1.Kasir
{
    class D_ItemDibeli
    {
        public static int pengeluaran { get; set; }
        public static int pemasukan { get; set; }
        public static void Clear()
        {
            pengeluaran = 0;
            pemasukan = 0;
        }

    }
}
