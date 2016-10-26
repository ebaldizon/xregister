using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Profile
    {
        private string name;
        private string lastname;
        private DateTime birth;
        private string url;
        private bool state;
        private string observations;

        public Profile(string name, string lastname, DateTime birth, string url, bool state, string observations)
        {
            this.name = name;
            this.lastname = lastname;
            this.birth = birth;
            this.url = url;
            this.state = state;
            this.observations = observations;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getLastName()
        {
            return this.lastname;
        }

        public void setLastName(string lastname)
        {
            this.lastname = lastname;
        }

        public DateTime getBirth()
        {
            return this.birth;
        }

        public void setBirth(DateTime birth)
        {
            this.birth = birth;
        }

        public string getURL()
        {
            return this.url;
        }

        public void setURL(string url)
        {
            this.url = url;
        }

        public bool getState()
        {
            return this.state;
        }

        public void setBool(bool state)
        {
            this.state = state;
        }

        public string getObservations()
        {
            return this.observations;
        }

        public void setObservations(string observations)
        {
            this.observations = observations;
        }
    }
}
