using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAFICA2.CLASSES
{
    class CONEXAO
    {
        private static string server = "localhost";
        private static string port = "3306";
        private static string dataBase = "grafica";
        private static string user = "root";
        private static string password = "1234";

        public static string StrConexao
        {
            get
            {
                return $"Data Source = {server}; Integrated security=false; Port = {port}; Initial Catalog = {dataBase};User ID = {user}; password = {password}";
            
            }
        }
    }
}
