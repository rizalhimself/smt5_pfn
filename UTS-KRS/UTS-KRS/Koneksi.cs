using System.Data.SqlClient;

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

