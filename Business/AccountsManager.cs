using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace Business
{
    public class AccountsManager
    {
        AccountData accountData = new AccountData();
        public AccountsManager()
        {

        }

        public bool createAccount(Account a)
        {
            return true;
        }

        public Account readAccount(Account a)
        {
            return a;
        }

        public bool editAccount(Account a)
        {
            return true;
        }

        public bool deleteAccount(Account a)
        {
            return true;
        }


    }
}
