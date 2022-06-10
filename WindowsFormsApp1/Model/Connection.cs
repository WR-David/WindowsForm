using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Model
{
    internal class Connection
    {
        public MySqlConnection con;
        public MySqlConnection conectar()
        {
            string host = "localhost";
            string db = "prograavanzada";
            string user = "root";
            string clave = "12345678";
            string conecta = "server = " + host + "; user id = " + user + "; database = " + db
           + "; password = " + clave;
            con = new MySqlConnection(conecta);
            return con;
        }
    }
}
