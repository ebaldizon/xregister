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
        private string dataSource = "Data Source=DESKTOP-0J8ESI8\\SQLEXPRESS;Initial Catalog=xregister;Integrated Security=true;";

        public AccountData()
        {
            this.con = new SqlConnection();
            this.con.ConnectionString = dataSource;
            
        }
        public bool create(Account a)
        {
            this.con.Open();
            string query = "";
            SqlCommand cmd = new SqlCommand(query, this.con);

            try
            {
                cmd.ExecuteNonQuery();
                this.con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        public bool login(Account a)
        {
            this.con.Open();
            string query =
            "select * from Accounts where username like '"+a.getUsername()+"' and password like '"+a.getPassword()+"' and pin = "+a.getPIN()+";";
            SqlCommand cmd = new SqlCommand(query, this.con);
            try
            {
                int result = cmd.ExecuteNonQuery();
                this.con.Close();
                Console.WriteLine("CONEXION:"+ result);
                return Convert.ToBoolean(result);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
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
