using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UTS_KRS
{
    class Koneksi
    {

        private static string conn;
        static Koneksi()
        {
            string connStr = "Server=192.168.56.1;" +
                "Database=dbAppKrs;" +
                "User Id=sa;" +
                "Password=07032015rIsA";

            conn = connStr;
        }

        public static SqlConnection Conn
        {
            get
            {
                return new SqlConnection(conn);
            }
        }
    }
}

