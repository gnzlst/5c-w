﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session14.Classes
{
    public class Enrollment : IComparable<Enrollment>
    {
        public int ID { get; set; }
        public DateTime DateEnrolled { get; set; }
        public String Grade { get; set; }
        public String Semester { get; set; }
        public Course Course { get; set; }

        //Overload The == operator
        public static bool operator ==(Enrollment x, Enrollment y)
        {
            return object.Equals(x, y);
        }
        public static bool operator !=(Enrollment x, Enrollment y)
        {
            return !object.Equals(x, y);
        }

        //Override the Equals() operator
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Enrollment rhs = obj as Enrollment;
            return this.ID == rhs.ID;
        }
        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }

        //Constructor
        public Enrollment(int id, DateTime dateEnrolled, string grade, string semester, Course course)
        {
            this.ID = id;
            this.DateEnrolled = dateEnrolled;
            this.Semester = semester;
            this.Course = course;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", ID, DateEnrolled.ToString("dd/MM/yyyy"), Grade, Semester, Course);
        }

        public int CompareTo(Enrollment obj)
        {
            if (obj == null)
                return 1;
            if (obj != null)
                return this.ID.CompareTo(obj.ID);
            else
                throw new ArgumentException("Object is not an enrollment");
        }
    }
}
