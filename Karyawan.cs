using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_1
{
    public static class Karyawan
    {
        private static string nama = "";
        private static string jobname = "";
        public static string Id { get; set; }
        public static string Username { get; set; }
        public static string Sandi { get; set; }
        public static string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public static string Jobname
        {
            get { return jobname; }
            set
            {
                switch (value)
                {
                    case "1":
                        jobname = "Kasir";
                        break;
                    case "2":
                        jobname = "Admin";
                        break;
                    case "3":
                        jobname = "Manager";
                        break;
                    default:
                        jobname = "ERROR-UNDEFINED JOB";
                        break;
                }
            }
        }

    }
}
