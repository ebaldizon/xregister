using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class ProfileData
    {
        public bool create(Profile p)
        {

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
    }
}
