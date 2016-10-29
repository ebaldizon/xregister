using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DataAccess
{
    public class AccountData
    {
        private SqlConnection con;
        private string dataSource = "Data Source=localhost;" + "Initial Catalog=facturacion;Integrated Security=true;";

        public AccountData()
        {
            this.con = new SqlConnection();
            this.con.ConnectionString = dataSource;
            
        }
        public bool create(Account a)
        {
            this.con.Open();
            string query = 
                "insert into Profiles(name, lastname, birth, url, state, observations, rank) values('Emanuel', 'Baldizon', '01-01-2000', 'asdasd', 1, 'ninguna', 4.5)";
            SqlCommand cmd = new SqlCommand(query, this.con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        public Account read(Account a)
        {
            return a;
        }

        public bool update(Account a)
        {
            return true;
        }

        public bool delete(Account a)
        {
            return true;
        }
    }
}
