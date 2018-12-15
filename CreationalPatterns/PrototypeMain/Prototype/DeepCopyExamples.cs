using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Address
    {
        public string StreetName { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }

        public Address(string streetName, int zipCode, string city)
        {
            StreetName = streetName;
            ZipCode = zipCode;
            City = city;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address HomeAddress;

        public Person() { }
       
        public Person ShallowCopy()
        {
            return MemberwiseClone() as Person;
        }
        
        public Person DeepCopy()
        {
            Person newPerson = (Person)MemberwiseClone();
            newPerson.HomeAddress = new Address(HomeAddress.StreetName,HomeAddress.ZipCode, HomeAddress.City) ;
            return newPerson;
        }
    }
}
