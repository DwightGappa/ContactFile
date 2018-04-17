using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactFile
{


    
    public class PhysicalAddress
    {

        private string city;

        private string country;

        private string line1;

        private string line2;

        private string line3;

        private string postalCode;

        private string stateProvince;

        public  string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public  string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public  string Line1
        {
            get
            {
                return line1;
            }

            set
            {
                line1 = value;
            }
        }

        public  string Line2
        {
            get
            {
                return line2;
            }

            set
            {
                line2 = value;
            }
        }

        public  string Line3
        {
            get
            {
                return line3;
            }

            set
            {
                line3 = value;
            }
        }

        public  string PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value;
            }
        }

        public  string StateProvince
        {
            get
            {
                return stateProvince;
            }

            set
            {
                stateProvince = value;
            }
        }

        public PhysicalAddress()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}