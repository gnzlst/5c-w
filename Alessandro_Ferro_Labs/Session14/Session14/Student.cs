using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session14;

namespace Session14
{
    public sealed class Student : Person, IComparable<Student>
    {
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }

        public Enrolment Enrolment { get; set; }

        public Student(string program, DateTime dateRegistered, string id, string name, string email, string telNum, Address address, Enrolment enrolment)
            : base(id, name, email, telNum, address)
        {
            this.Program = program;
            this.DateRegistered = dateRegistered;
            this.Enrolment = enrolment;
        }

        public Student(string program, DateTime dateRegistered, DateTime dateEnrolled, string grade, string semester, Course course, string id, string name, string email, string telnum, string number, string street, string suburb, string postcode, string state)
        : base(id, name, email, telnum, number, street, suburb, postcode, state)
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
            return base.Equals(obj) && this.Enrolment == rhs.Enrolment && this.DateRegistered == rhs.DateRegistered;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.DateRegistered.GetHashCode() ^ this.Enrolment.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}",Id, Name, Program);
        }
        // Make student a sealed class and compare every attribute.
        public int CompareTo(Student obj)
        {
            if (obj == null)
                return 1;
            if (ReferenceEquals(obj, this))
                return 0;
            if (obj.GetType() != this.GetType())
                throw new ArgumentException(" Not a Student");

            if (base.CompareTo(obj) != 0)
                return base.CompareTo(obj);
            else if (this.Program.CompareTo(obj.Program) != 0)
                return this.Program.CompareTo(obj.Program);
            else if (this.DateRegistered.CompareTo(obj.DateRegistered) != 0)
                return this.DateRegistered.CompareTo(obj.DateRegistered);
            else
                return this.Enrolment.CompareTo(obj.Enrolment);
        }
    }
}
