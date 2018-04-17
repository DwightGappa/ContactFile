using System;

namespace ContactFile
{
    /// <summary>
    /// Summary description for PhoneNumber
    /// </summary>
    public class PhoneNumber
    {
        private string description;

        private string extension;

        private string number;

        public PhoneNumber()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public const string InternationalPrefixSymbol = @"+";

        //public const int NumberMaxLength = 15;

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }

        public string Extension
        {
            get
            {
                return this.extension;
            }

            set
            {
                this.extension = value;
            }
        }

        public string Number
        {
            get { return this.number; }
            set
            {
                this.number = value;
                // value = value.Replace(InternationalPrefixSymbol, "");
                // if (value.Length <= (NumberMaxLength - 1) ){
                //     
                // }
                // else
                // {
                //     throw new ArgumentOutOfRangeException("number",String.Format("Phone numbers are limited to {0} characters by ITU-T standards",NumberMaxLength));
                // }
            }
        }


    }
}
