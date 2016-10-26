using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Account
    {
        private string username;
        private string password;
        private int PIN;

        public Account(string username, string password, int PIN)
        {
            this.username = username;
            this.password = password;
            this.PIN = PIN;
        }

        public string getUsername()
        {
            return this.username;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public int getPIN()
        {
            return this.PIN;
        }

        public void setPIN(int PIN)
        {
            this.PIN = PIN;
        }
    }
}
