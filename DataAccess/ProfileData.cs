using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Net;
using System.Drawing;

namespace DataAccess
{
    public class ProfileData
    {
        private SqlConnection con;
        private string dataSource = "Data Source=DESKTOP-0J8ESI8\\SQLEXPRESS;Initial Catalog=xregister;Integrated Security=true;";
        private SqlDataReader reader;

        public ProfileData()
        {
            this.con = new SqlConnection();
            this.con.ConnectionString = dataSource;
        }

        public bool create(Profile p)
        {
            this.con.Open();
            string query =
                "insert into Profiles(name, lastname, birth, city, education, work, url, active, observations, rank, photo) values('" + p.getName() + "', '" + p.getLastName() +"', '" +p.getBirth() +"', '"+p.getCity()+"', '"+p.getEducation()+"', '"+p.getEducation()+"','"+p.getURL()+"', '"+p.getActive()+"', '"+p.getObservations()+"', '"+p.getRank()+"', '"+p.getPhoto()+"')";
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

        public Profile read(Profile p)
        {
            return p;
        }

        public bool update(Profile p)
        {
            return true;
        }

        public bool delete(Profile p)
        {
            return true;
        }

        public Profile readForID()
        {
            this.con.Open();
            string query = "select idProfile from Profiles where idProfile = 1";
            SqlCommand cmd = new SqlCommand(query, this.con);
            try
            {
                this.reader = cmd.ExecuteReader();
                Profile p = new Profile(reader["name"].ToString(), reader["lastname"].ToString(), (DateTime) reader["birth"], reader["city"].ToString(), reader["education"].ToString(), reader["work"].ToString(),reader["url"].ToString(), (bool) reader["active"], reader["observations"].ToString(), (float) reader["rank"], (Image) reader["photo"]);
                return p;
            }

            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
