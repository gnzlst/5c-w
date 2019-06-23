using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    public class Person : IComparable<Person>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }

        public Address Address { get; set; }

        public Person(string id, string name, string email, string telnum, Address address)
        {
            Id = id;
            Name = name;
            Email = email;
            TelNum = telnum;
            Address = address;
        }

        public Person(string id, string name, string email, string telnum, string number, string street, string suburb, string postcode, string state)
        {
            Id = id;
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
            return this.Id == rhs.Id && this.Name.ToUpperInvariant() == rhs.Name.ToUpperInvariant() && this.Email.ToUpperInvariant() == rhs.Email.ToUpperInvariant() && this.TelNum == rhs.TelNum && this.Address == rhs.Address;
        }

        public override int GetHashCode()
        {
            return this.Id.ToUpperInvariant().GetHashCode() ^ this.Name.ToUpperInvariant().GetHashCode() ^ this.Email.ToUpperInvariant().GetHashCode() ^ this.TelNum.GetHashCode() ^ this.Address.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}",Id, Name, Email, TelNum, Address.ToString());
        }

        // Implement CompareTo method
        public int CompareTo(Person obj)
        {
            if (obj == null)
                return 1;
            if (ReferenceEquals(obj, this))
                return 0;
            if (obj.GetType() != this.GetType())
                throw new ArgumentException(" Not a course");

            return this.Id.CompareTo(obj.Id);
        }
    }
}
