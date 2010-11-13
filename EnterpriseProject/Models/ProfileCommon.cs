using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseProject.Models
{
    public class ProfileCommon : ProfileBase
    {
        public virtual string FirstName
        {
            get
            {
                return ((string)(this.GetPropertyValue("FirstName")));
            }
            set
            {
                this.SetPropertyValue("FirstName", value);
            }
        }

        public virtual string LastName
        {
            get
            {
                return ((string)(this.GetPropertyValue("LastName")));
            }
            set
            {
                this.SetPropertyValue("LastName", value);
            }
        }

        public virtual string Bio
        {
            get
            {
                return ((string)(this.GetPropertyValue("Bio")));
            }
            set
            {
                this.SetPropertyValue("Bio", value);
            }
        }

        public virtual string Phone
        {
            get
            {
                return ((string)(this.GetPropertyValue("Phone")));
            }
            set
            {
                this.SetPropertyValue("Phone", value);
            }
        }

        public virtual string Street
        {
            get
            {
                return ((string)(this.GetPropertyValue("Street")));
            }
            set
            {
                this.SetPropertyValue("Street", value);
            }
        }

        public virtual string City
        {
            get
            {
                return ((string)(this.GetPropertyValue("City")));
            }
            set
            {
                this.SetPropertyValue("City", value);
            }
        }



        public virtual string County
        {
            get
            {
                return ((string)(this.GetPropertyValue("County")));
            }
            set
            {
                this.SetPropertyValue("County", value);
            }
        }

        public ProfileCommon GetProfile(string username)
        {
            return Create(username) as ProfileCommon;
        }
    }
}