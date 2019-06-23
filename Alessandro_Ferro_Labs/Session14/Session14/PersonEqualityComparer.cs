using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session14
{
    class PersonEqualityComparer : EqualityComparer<Person>
    {
        private static readonly PersonEqualityComparer _instance = new PersonEqualityComparer();

        public static PersonEqualityComparer Instance { get { return _instance; } }

        private PersonEqualityComparer() { }

        public override bool Equals(Person x, Person y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;

            return x.Id == y.Id && x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant();

        }

        public override int GetHashCode(Person obj)
        {
            return obj.Id.GetHashCode() ^ obj.Name.ToUpperInvariant().GetHashCode();
        }
    }
}
