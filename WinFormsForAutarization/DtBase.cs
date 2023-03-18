using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsForAutarization
{
    class DtBase : DbContext
    {
       /* public DbSet<User> Users => Set<User>();

        public DtBase()
        { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) 
        {
            dbContextOptionsBuilder.UseSqlServer("Server=USER-PC\\SQLEXPRESS;Database=itproger;Trusted_Connection=True;");
        }*/


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
