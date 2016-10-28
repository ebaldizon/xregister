using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Profile
    {
        private string name;
        private string lastname;
        private DateTime birth;
        private string url;
        private bool state;
        private string observations;
        private float rank;

        public Profile()
        {

        }

        public Profile(string name, string lastname, DateTime birth, string url, bool state, string observations, float rank)
        {
            this.name = name;
            this.lastname = lastname;
            this.birth = birth;
            this.url = url;
            this.state = state;
            this.observations = observations;
            this.rank = rank;
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

        public float getRank()
        {
            return this.rank;
        }

        public void setRank(float rank)
        {
            this.rank = rank;
        }
    }
}
