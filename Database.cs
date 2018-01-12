using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Veri tabanı ile bağlantı kısmıdır.

namespace QuizGame
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=Quiz;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}