using MySql.Data.MySqlClient;

namespace D05K14BlazorServerApp.Data
{
    public class DBMySQL
    {
        private static string HostName = "localhost";
        private static string UserName = "root";
        private static string Password = "";
        private static string Database = "mobile_shop_php";
        private static int Port = 3306;
        
        public static MySqlConnection GetMySqlConnection()
        {
            string connStr = String.Format("Server={0};Database={1};User={2};Password={3};Port={4}",HostName, Database,UserName,Password,Port);
            return new MySqlConnection(connStr);
        }
    }
}
