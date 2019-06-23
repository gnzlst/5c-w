using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session14
{
    class PersonTelNumComparer : Comparer<Person>
    {
        private static PersonTelNumComparer _instance = new PersonTelNumComparer();

        public static PersonTelNumComparer Instance { get { return _instance; } }

        private PersonTelNumComparer() { }

        public override int Compare(Person x, Person y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;

            return string.Compare(x.TelNum, y.TelNum, StringComparison.CurrentCulture);
        }
    }
}
