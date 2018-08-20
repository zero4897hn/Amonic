using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlDataExecution
    {
        SqlConnection connection = null;
        public void OpenConnection(string database)
        {
            if (connection == null) connection = new SqlConnection(@"Server = ZERO-PC\SQLEXPRESS; Database = " + database + "; User ID = sa; Password = nobita12");
            if (connection.State == ConnectionState.Closed) connection.Open();
        }
        public void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open) connection.Close();
        }
        public SqlDataReader Reader(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            return command.ExecuteReader();
        }
        public SqlDataReader Reader(string sql, params object[] Object)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            for (int i = 0; i < Object.Length; i++) command.Parameters.AddWithValue("@pa" + i, Object[i]);
            return command.ExecuteReader();
        }
        public int NonQuery(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            return command.ExecuteNonQuery();
        }
        public int NonQuery(string sql, params object[] Object)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            for (int i = 0; i < Object.Length; i++) command.Parameters.AddWithValue("@pa" + i, Object[i]);
            return command.ExecuteNonQuery();
        }
        public object Scalar(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            return command.ExecuteScalar();
        }
        public object Scalar(string sql, params object[] Object)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            for (int i = 0; i < Object.Length; i++) command.Parameters.AddWithValue("@pa" + i, Object[i]);
            return command.ExecuteScalar();
        }
    }
}
