using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    public class Address
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
            return string.Format("{0}, {1}, {2}, {3}, {4}", Number, Street, Suburb, Postcode, State);
        }
    }
}
