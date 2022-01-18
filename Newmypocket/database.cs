using MySql.Data.MySqlClient;
namespace Newmypocket
{
    class database
    {

        public MySqlConnection ConString()
        {
            string connStr = "server=127.0.0.1;user=root;database=mypocket;port=3306;password=green2Apple#";
            MySqlConnection conn = new MySqlConnection(connStr);
            return ConString();
        }
    }
}
