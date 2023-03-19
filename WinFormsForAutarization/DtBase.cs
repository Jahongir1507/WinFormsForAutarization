using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace WinFormsForAutarization {
    class DtBase : DbContext
    {
      MySqlConnection sqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=itproger");
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
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
