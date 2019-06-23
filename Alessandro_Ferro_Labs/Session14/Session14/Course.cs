using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session14
{
    public class Course : IComparable<Course>
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public double Cost { get; set; }

        public Course(string courseCode, string courseName, double cost)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Cost = cost;
        }

        public static bool operator ==(Course x, Course y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Course x, Course y)
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
            Course rhs = obj as Course;
            return this.CourseCode == rhs.CourseCode && this.CourseName == rhs.CourseName && this.Cost == rhs.Cost;
        }

        public override int GetHashCode()
        {
            return this.CourseCode.GetHashCode() ^ this.CourseName.GetHashCode() ^ this.Cost.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", CourseCode, CourseName, Cost);
        }


        // Implement CompareTo method
        public int CompareTo(Course course)
        {
            if (course == null)
                return 1;
            if (ReferenceEquals(course, this))
                return 0;
            if (course.GetType() != this.GetType())
                throw new ArgumentException(" Not a course");

            return this.CourseCode.CompareTo(course.CourseCode);
        }
    }
}
