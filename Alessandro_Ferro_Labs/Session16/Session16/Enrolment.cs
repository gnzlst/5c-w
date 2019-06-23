using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    public class Enrolment : IComparable<Enrolment>
    {
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }

        public Course Course { get; set; }


        public Enrolment(DateTime dateEnrolled, string grade, string semester, Course course)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Course = course;
        }

        public static bool operator ==(Enrolment x, Enrolment y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Enrolment x, Enrolment y)
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
            Enrolment rhs = obj as Enrolment;
            return this.DateEnrolled == rhs.DateEnrolled && this.Grade == rhs.Grade && this.Semester == rhs.Semester && this.Course == rhs.Course;
        }

        public override int GetHashCode()
        {
            return this.DateEnrolled.GetHashCode() ^ this.Grade.GetHashCode() ^ this.Semester.GetHashCode() ^ this.Course.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", DateEnrolled, Grade, Semester, Course);
        }

        // Implement CompareTo method
        public int CompareTo(Enrolment enrolment)
        {
            if (enrolment == null)
                return 1;
            if (ReferenceEquals(enrolment, this))
                return 0;
            if (enrolment.GetType() != this.GetType())
                throw new ArgumentException();

            return this.DateEnrolled.CompareTo(enrolment.DateEnrolled);
        }
    }
}
