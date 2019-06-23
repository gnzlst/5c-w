using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }

        public Address Address { get; set; }

        public Person(string name, string email, string telnum, Address address)
        {
            Name = name;
            Email = email;
            TelNum = telnum;
            Address = address;
        }

        public Person(string name, string email, string telnum, string number, string street, string suburb, string postcode, string state)
        {
            Name = name;
            Email = email;
            TelNum = telnum;
            Address = new Address(number, street, suburb, postcode, state);
        }

        public static bool operator ==(Person x, Person y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Person x, Person y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Person rhs = obj as Person;
            return this.Name == rhs.Name && this.Email == rhs.Email && this.TelNum == rhs.TelNum && this.Address == rhs.Address;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Email.GetHashCode() ^ this.TelNum.GetHashCode() ^ this.Address.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}, {3}", Name, Email, TelNum, Address.ToString());
        }
    }
}
