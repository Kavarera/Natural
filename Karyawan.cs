using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_1
{
    public static class Karyawan
    {
        private static string nama;
        public static string Id { get; set; }
        public static string Username { get; set; }
        public static string Sandi { get; set; }
        public static string Nama { get { return nama; } set { nama = value; } }
        public static string Jobname { get; set; }
        public static string Status { get; set; }

    }
}
