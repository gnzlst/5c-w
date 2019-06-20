using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_16_lab_2
{
    class Program
    {

        static void Main(string[] args)
        {
            DoublyLinkedList<Student> myLinkedList = new DoublyLinkedList<Student>();
            Course myCourse;
                                  
            Console.WriteLine("******** START - A) Create an instance of the Doubly LinkedList and Add several Student instances to the List  *********");

            for (int i = 0; i < 10; i++)
            {
                string program = "program# " + i;
                string dateRegistered = "dateRegistered# " + i;
                string dateEnrolled = "dateEnrolled# " + i;
                string grade = "grade# " + i;
                string semester = "semester# " + i;

                string courseCode = "courseCode# " + i;
                string courseName = "courseName# " + i;
                double cost = 212.21 * i; // Any number, it doesn't matter
                myCourse = new Course(courseCode, courseName, cost);

                string name = "name# " + i;
                string email = "email# " + i;
                string telnum = "telnum# " + i;
                string number = "number# " + i;
                string street = "street# " + i;
                string suburb = "suburb# " + i;
                string postcode = "postcode# " + i;
                string state = "state# " + i;

                myLinkedList.Add(new Student(program, dateRegistered, dateEnrolled, grade,
                    semester, myCourse, name, email, telnum, number, street, suburb, postcode, state));
            }
            Console.WriteLine("******** END - A) Create an instance of the Doubly LinkedList and Add several Student instances to the List  *********");
            Console.ReadLine();


            Console.WriteLine("******** START - B) Enumerate through the list and display each of the Student node values  *********");
            foreach (Student myStudent in myLinkedList)
            {
                Console.WriteLine(myStudent);
            }
            Console.WriteLine("******** END - B) Enumerate through the list and display each of the Student node values  *********");
            Console.ReadLine();

            Console.WriteLine("******** START - C) Create three other LinkedListNode instances and add them to your list using the appropriate Add ( )  *********");
            myCourse = new Course("courseCode_AddLast", "courseName_AddLast", 999.99);
            myLinkedList.AddLast(new Student("program_AddLast", "dateRegistered_AddLast", "dateEnrolled_AddLast", "grade_AddLast",
                    "semester_AddLast", myCourse, "name_AddLast", "email_AddLast", "telnum_AddLast", "number_AddLast", "street_AddLast", "suburb_AddLast", "postcode_AddLast", "state_AddLast"));
            foreach (Student myStudent in myLinkedList)
            {
                Console.WriteLine(myStudent);
            }
            Console.WriteLine("******** END - C) Create three other LinkedListNode instances and add them to your list using the appropriate Add ( )  *********");
            Console.ReadLine();

            Console.WriteLine("******** START - D) Using the appropriate method in the list find if a particular student instance is found in the list *********");
            myCourse = new Course("courseCode_AddLast", "courseName_AddLast", 999.99);
            Student studentContainedIn = new Student("program_AddLast", "dateRegistered_AddLast", "dateEnrolled_AddLast", "grade_AddLast",
                    "semester_AddLast", myCourse, "name_AddLast", "email_AddLast", "telnum_AddLast", "number_AddLast", "street_AddLast", "suburb_AddLast", "postcode_AddLast", "state_AddLast");

            Console.WriteLine("Result: " + myLinkedList.Contains(studentContainedIn));
            Console.WriteLine("******** END - D) Using the appropriate method in the list find if a particular student instance is found in the list *********");
            Console.ReadLine();

            Console.WriteLine("******** START - E) Remove a Student instance from the beginning of the list and test if it worked.  *********");
            myLinkedList.RemoveFirst();
            foreach (Student myStudent in myLinkedList)
            {
                Console.WriteLine(myStudent);
            }
            Console.WriteLine("******** END - E) Remove a Student instance from the beginning of the list and test if it worked.  *********");
            Console.ReadLine();

            Console.WriteLine("******** START - F) Remove a Student from the end of the list and test if it worked.  *********");
            myLinkedList.RemoveLast();
            foreach (Student myStudent in myLinkedList)
            {
                Console.WriteLine(myStudent);
            }
            Console.WriteLine("******** END - F) Remove a Student from the end of the list and test if it worked.  *********");
            Console.ReadLine();

        }

    }




    // START STUDENT
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

    // END STUDENT









    // START LINKEDLISTNODE

    class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Previous { get; set; }
    }
    class DoublyLinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        public LinkedListNode<T> Tail
        {
            get;
            private set;
        }

        public int Count
        {
            get;
            private set;
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;

            if (Count == 0)
            {
                Tail = Head;

            }
            else
            {
                temp.Previous = Head;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }
                Count--;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    // END LINKEDLISTNODE

}
