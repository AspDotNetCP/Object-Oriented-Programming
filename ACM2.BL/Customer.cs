using System;

namespace ACM2
{
    public class Customer
    {
        //In case need any code in get/set block
        //Full property syntax
        private string _lastName { get; set; }

        public string LastName 
        { 
            get=> _lastName;
            set=> _lastName = value;
        }

        //In case dont need any logic within getter/setter block
        public string FirstName { get; set; } //auto implemented property
        public string EmailAddress { get; set; }

        //Database is going to set the id
        public int CustomerId { get; private set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public string FullName 
        { 
            get=> LastName +","+ FirstName;
        }
    }
}
