using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business
{
    public class RegistryProfile
    {
        private ProfileData profileData = new ProfileData();

        public RegistryProfile()
        {

        }

        public bool createProfile(Profile p)
        {
            if(validateProfile(p))
            {
                return profileData.create(p);
            }
            return false;
        }

        public Profile readProfile(Profile p)
        {
            return profileData.read(p);
        }

        public bool updateProfile(Profile p)
        {
            if(validateProfile(p))
            {
                return profileData.update(p);
            }
            return false;
        }

        public bool deleteProfile(Profile p)
        {
            return profileData.delete(p);
        }

        public bool validateProfile(Profile p)
        {
            if(p.getName() != null && p.getLastName() != null && p.getBirth() != null && p.getObservations() != null && p.getURL() != null) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
