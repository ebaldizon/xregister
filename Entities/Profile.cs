using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;

namespace Entities
{
    public class Profile
    {
        private string name;
        private string lastname;
        private DateTime birth;
        private string city;
        private string education;
        private string work;
        private string url;
        private bool active;
        private string observations;
        private float rank;
        private Image photo;

        public Profile()
        {

        }

        public Profile(string name, string lastname, DateTime birth, string city, string education, string work, string url, bool active, string observations, float rank, Image photo)
        {
            this.name = name;
            this.lastname = lastname;
            this.birth = birth;
            this.city = city;
            this.education = education;
            this.work = work;
            this.url = url;
            this.active = active;
            this.observations = observations;
            this.rank = rank;
            this.photo = photo;
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

        public string getCity()
        {
            return this.city;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public string getEducation()
        {
            return this.education;
        }

        public void setEducation(string education)
        {
            this.education = education;
        }

        public string getWork()
        {
            return this.work;
        }

        public void setWork(string work)
        {
            this.work = work;
        }

        public string getURL()
        {
            return this.url;
        }

        public void setURL(string url)
        {
            this.url = url;
        }

        public bool getActive()
        {
            return this.active;
        }

        public void setActive(bool active)
        {
            this.active = active;
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

        public Image getPhoto()
        {
            return this.photo;
        }

        public void setPhoto(Image photo)
        {
            this.photo = photo;
        }
    }
}
