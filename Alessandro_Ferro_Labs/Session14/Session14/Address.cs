using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session14
{
    public class Address : IComparable<Address>
    {
        public string Number { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        public Address(string number, string street, string suburb, string postcode, string state)
        {
            Number = number;
            Street = street;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        public static bool operator ==(Address x, Address y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Address x, Address y)
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
            Address rhs = obj as Address;
            return this.Number == rhs.Number && this.Street == rhs.Street && this.Suburb == rhs.Suburb
                    && this.Postcode == rhs.Postcode && this.State == rhs.State;
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode() ^ this.Street.GetHashCode() ^ this.Suburb.GetHashCode() ^
                this.Postcode.GetHashCode() ^ this.State.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2},  {3}, {4}", Number, Street, Suburb, Postcode, State);
        }

        // Implement CompareTo method
        public int CompareTo(Address obj)
        {
            if (obj == null)
                return 1;
            if (ReferenceEquals(obj, this))
                return 0;
            if (obj.GetType() != this.GetType())
                throw new ArgumentException(" Not an Address!");

            if (this.Number.CompareTo(obj.Number) != 0)
                return this.Number.CompareTo(obj.Number);
            else if (this.Street.CompareTo(obj.Street) != 0)
                return this.Street.CompareTo(obj.Street);
            else if (this.Suburb.CompareTo(obj.Suburb) != 0)
                return this.Suburb.CompareTo(obj.Suburb);
            else if (this.Postcode.CompareTo(obj.Postcode) != 0)
                return this.Postcode.CompareTo(obj.Postcode);
            else
                return this.State.CompareTo(obj.State);
        }
    }
}
