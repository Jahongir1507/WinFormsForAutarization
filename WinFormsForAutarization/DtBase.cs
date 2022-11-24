using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsForAutarization
{
    internal class DtBase
    {
        MySqlConnection sqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;databae=winform");
        public void openConnection()
        { 
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }
        public MySqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
