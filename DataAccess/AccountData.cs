using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    class AccountData
    {
        public AccountData()
        {


        }
        public bool create(Account a)
        {
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
