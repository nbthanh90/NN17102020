using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnectDB
{
    class ConnectDB
    {
        string ConnectionString = "Data Source=pc21;Initial Catalog=Test;Integrated Security=True";
        public void InsertQuery(string Query)
        {
            SqlConnection Cnn = new SqlConnection(ConnectionString);
            Cnn.Open();
            SqlCommand cmd = new SqlCommand(Query, Cnn);
            cmd.ExecuteNonQuery();
            Cnn.Close();
        }
        /// <summary>
        /// lấy tất cả các dòng từ câu lệnh truy vấn
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public SqlDataReader SelectQuery(string Query)
        {
            SqlConnection Cnn = new SqlConnection(ConnectionString);
            Cnn.Open();
            SqlCommand cmd = new SqlCommand(Query, Cnn);
            SqlDataReader res = cmd.ExecuteReader();
            return res;
        }
    }
}
