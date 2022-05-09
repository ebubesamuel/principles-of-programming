using System;
namespace POP_Assignment1
{
    public class Address
    {
        //public Address()
        //{
        //}

        public string FullAddress { get { return addressNumber + ", " + Street + ", " + City + ", " + Country + "."; } }

        public string addressNumber { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}

