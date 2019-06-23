using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    sealed class Student : Person
    {
        public string Program { get; set; }
        public string DateRegistered { get; set; }

        public Enrolment Enrolment { get; set; }

        public Student(string program, string dateRegistered, string name, string email, string telNum, Address address, Enrolment enrolment)
            : base(name, email, telNum, address)
        {
            this.Program = program;
            this.DateRegistered = dateRegistered;
            this.Enrolment = enrolment;
        }

        public Student(string program, string dateRegistered, string dateEnrolled, string grade, string semester, Course course, string name, string email, string telnum, string number, string street, string suburb, string postcode, string state)
        : base(name, email, telnum, number, street, suburb, postcode, state)
        {
            Program = program;
            DateRegistered = dateRegistered;
            Enrolment = new Enrolment(dateEnrolled, grade, semester, course);
        }

        public static bool operator ==(Student x, Student y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Student x, Student y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            Student rhs = (Student)obj;

            return this.Program == rhs.Program && this.DateRegistered == rhs.DateRegistered;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.Program.GetHashCode() ^ this.DateRegistered.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", Name, Program, DateRegistered, Enrolment.ToString());
        }
    }
}
