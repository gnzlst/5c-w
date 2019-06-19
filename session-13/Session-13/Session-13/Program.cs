using Session_13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_13
{
    class Program
    {

        /* START ATTRIBUTES FOR OBJECTS 1 AND 1_1 */

        // Address 1 and 1_1
        public static string number = "Number 1";
        public static string street = "Street 1";
        public static string suburb = "Suburb 1";
        public static string postCode = "PostCode 1";
        public static string state = "State 1";

        // Course 1 and 1_1
        public static string courseCode = "Course Code 1";
        public static string courseName = "Course Name 1";
        public static Double cost = 100.00;

        // Enrollment 1 and 1_1
        public static string dateEnrolled = "Date enrolled 1";
        public static string grade = "Grade 1";
        public static string semester = "Semester 1";

        // Person 1 and 1_1
        public static string name = "Name 1";
        public static string email = "Email 1";
        public static string telNum = "TelNum 1";

        // Student 1 and 1_1
        public static string program = "Program 1";
        public static string dateRegistered = "Date Registered 1";

        /* END ATTRIBUTES FOR OBJECTS 1 AND 1_1 */


        /* START ATTRIBUTES FOR OBJECTS 2 */

        // Address 1 and 1_1
        public static string number_2 = "Number 2";
        public static string street_2 = "Street 2";
        public static string suburb_2 = "Suburb 2";
        public static string postCode_2 = "PostCode 2";
        public static string state_2 = "State 2";

        // Course 1 and 1_1
        public static string courseCode_2 = "Course Code 2";
        public static string courseName_2 = "Course Name 2";
        public static Double cost_2 = 200.00;

        // Enrollment 1 and 1_1
        public static string dateEnrolled_2 = "Date enrolled 2";
        public static string grade_2 = "Grade 2";
        public static string semester_2 = "Semester 2";

        // Person 1 and 1_1
        public static string name_2 = "Name 2";
        public static string email_2 = "Email 2";
        public static string telNum_2 = "TelNum 2";

        // Student 1 and 1_1
        public static string program_2 = "Program 2";
        public static string dateRegistered_2 = "Date Registered 2";

        /* END ATTRIBUTES FOR OBJECTS 2 */

        public static int i = 0;
        public static string actualOutput;
        static void Main(string[] args)
        {
            Address myAddress_1 = new Address(number, street, suburb, postCode, state);
            Course myCourse_1 = new Course(courseCode, courseName, cost);
            Enrollment myEnrollment_1 = new Enrollment(dateEnrolled, grade, semester, myCourse_1);
            Person myPerson_1 = new Person(name, email, telNum, myAddress_1);
            Student myStudent_1 = new Student(program, dateRegistered, myEnrollment_1);

            Address myAddress_1_1 = new Address(number, street, suburb, postCode, state);
            Course myCourse_1_1 = new Course(courseCode, courseName, cost);
            Enrollment myEnrollment_1_1 = new Enrollment(dateEnrolled, grade, semester, myCourse_1_1);
            Person myPerson_1_1 = new Person(name, email, telNum, myAddress_1_1);
            Student myStudent_1_1 = new Student(program, dateRegistered, myEnrollment_1_1);

            Address myAddress_2 = new Address(number_2, street_2, suburb_2, postCode_2, state_2);
            Course myCourse_2 = new Course(courseCode_2, courseName_2, cost_2);
            Enrollment myEnrollment_2 = new Enrollment(dateEnrolled_2, grade_2, semester_2, myCourse_2);
            Person myPerson_2 = new Person(name_2, email_2, telNum_2, myAddress_2);
            Student myStudent_2 = new Student(program_2, dateRegistered_2, myEnrollment_2);

            DisplayWhetherEqual(myPerson_1, myPerson_1, "Testing Same Objects with Same Attributes", "==");
            DisplayWhetherEqual(myPerson_1, myPerson_1_1, "Testing Different Objects with Same Attributes", "==");
            DisplayWhetherEqual(myPerson_1, myPerson_2, "Testing Different Objects with Different Attributes", "!=");

            DisplayWhetherEqual(myStudent_1, myStudent_1, "Testing Same Objects with Same Attributes", "==");
            DisplayWhetherEqual(myStudent_1, myStudent_1_1, "Testing Different Objects with Same Attributes", "==");
            DisplayWhetherEqual(myStudent_1, myStudent_2, "Testing Same object", "!=");
        }

        static void DisplayWhetherEqual(Person p1, Person p2, string reason, string expectedOutput)
        {
            i++;
            Console.WriteLine("********* START COMPARING " + i + " *********");
            Console.WriteLine("Reason:\t" + reason + ".\n");
            if (p1 == p2)
            {
                Console.WriteLine(string.Format("{0, 8}\t==\n\n{1}", p1, p2));
                actualOutput = "==";
                if (expectedOutput.Equals(actualOutput)) // This validation is meant to replace the test cases since it will always print the message.
                {
                    Console.WriteLine("Conclusion:\tThey are ==\n");
                }

            }
            else
            {
                Console.WriteLine(string.Format("{0, 8}\t!=\n\n{1}", p1, p2));
                actualOutput = "!=";
                if (expectedOutput.Equals(actualOutput))
                {
                    Console.WriteLine("Conclusion:\tThey are !=\n");
                }
            }
            Console.WriteLine("********* END COMPARING " + i + " *********");

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }
    }

    class Address
    {

        public Address() : base()
        {

        }

        public Address(string number, string street, string suburb, string postCode, string state)
        {
            Number = number;
            Street = street;
            Suburb = suburb;
            PostCode = postCode;
            State = state;
        }

        public string Number { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }

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
            Address myObject = obj as Address;
            return this.Number == myObject.Number &&
                this.Street == myObject.Street &&
                this.Suburb == myObject.Suburb &&
                this.PostCode == myObject.PostCode &&
                this.State == myObject.State;
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode() ^
               this.Street.GetHashCode() ^
               this.Suburb.GetHashCode() ^
               this.PostCode.GetHashCode() ^
               this.State.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0},\n{1},\n{2},\n{3},\n{4}\n", Number, Street, Suburb, PostCode, State);
        }

    }

    class Course
    {
        public Course() : base()
        {

        }
        public Course(string courseCode, string courseName, double cost)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Cost = cost;
        }

        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public double Cost { get; set; }

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
            Course myObject = obj as Course;
            return this.CourseCode == myObject.CourseCode &&
                this.CourseName == myObject.CourseName &&
                this.Cost == myObject.Cost;
        }

        public override int GetHashCode()
        {
            return this.CourseCode.GetHashCode() ^
               this.CourseName.GetHashCode() ^
               this.Cost.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0},\n{1},\n{2}\n", CourseCode, CourseName, Cost);
        }

    }

    class Enrollment
    {
        public Enrollment() : base()
        {

        }

        public Enrollment(string dateEnrolled, string grade, string semester, Course course)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Course = course;
        }

        public string DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Course Course { get; set; }

        public static bool operator ==(Enrollment x, Enrollment y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Enrollment x, Enrollment y)
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
            Enrollment myObject = obj as Enrollment;
            return this.DateEnrolled == myObject.DateEnrolled &&
                this.Grade == myObject.Grade &&
                this.Semester == myObject.Semester &&
                this.Course == myObject.Course;

        }

        public override int GetHashCode()
        {
            return this.DateEnrolled.GetHashCode() ^
               this.Grade.GetHashCode() ^
               this.Semester.GetHashCode() ^
               this.Course.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0},\n{1},\n{2},\n{3}\n", DateEnrolled, Grade, Semester, Course);
        }


    }

    class Person
    {

        public Person() : base()
        {

        }
        public Person(string name, string email, string telNum, Address address)
        {
            Name = name;
            Email = email;
            TelNum = telNum;
            Address = address;
        }

        public Person(string name, string email, string telnum, string number, string street, string suburb, string postcode, string state)
        {
            Name = name;
            Email = email;
            TelNum = telnum;
            Address = new Address(number, street, suburb, postcode, state);
        }


        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }
        public Address Address { get; set; }

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
            Person myObject = obj as Person;
            return this.Name == myObject.Name &&
                this.Email == myObject.Email &&
                this.TelNum == myObject.TelNum &&
                this.Address == myObject.Address;

        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^
               this.Email.GetHashCode() ^
               this.TelNum.GetHashCode() ^
               this.Address.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0},\n{1},\n{2},\n{3}\n", Name, Email, TelNum, Address);
        }
    }

    sealed class Student : Person
    {

        public Student() : base()
        {

        }
        public Student(string program, string dateRegistered, Enrollment enrollment)
        {
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;
        }

        public Student(string program, string dateRegistered, string dateEnrolled, string grade, string semester, Course course, string name, string email, string telnum, string number, string street, string suburb, string postcode, string state)
        : base(name, email, telnum, number, street, suburb, postcode, state)
        {
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = new Enrollment(dateEnrolled, grade, semester, course);
        }


        public string Program { get; set; }
        public string DateRegistered { get; set; }
        public Enrollment Enrollment { get; set; }

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
            Student myObject = obj as Student;
            return this.Program == myObject.Program &&
                this.DateRegistered == myObject.DateRegistered &&
                this.Enrollment == myObject.Enrollment;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.Program.GetHashCode() ^
            this.DateRegistered.GetHashCode() ^
            this.Enrollment.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0},\n{1},\n{2}\n", Program, DateRegistered, Enrollment);
        }
    }

}

