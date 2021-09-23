using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_1
{
    public static class Pelanggan
    {

        public static string ID { get; set; }
        public static string ID_Pelanggan { get; set; }
        public static string Nama { get; set; }
        public static string Telepon { get; set; }
        public static string Alamat { get; set; }
        public static string Bonus { get; set; }
        public static string Area { get; set; }

        public static void Clear()
        {
            ID = null;
            ID_Pelanggan = null;
            Nama = null;
            Telepon = null;
            Alamat = null;
            Bonus = null;
            Area = null;
        }
    }
}
