using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session14
{
    class Program
    {
        static void Main(string[] args)
        {// Create dates
            DateTime enrolDate1 = new DateTime(2011, 01, 01);
            DateTime enrolDate2 = new DateTime(2011, 01, 01);
            DateTime enrolDate3 = new DateTime(2013, 03, 03);

            DateTime regDate1 = new DateTime(2011, 05, 05);
            DateTime regDate2 = new DateTime(2010, 07, 07);
            

            // Create instances
            Address address1 = new Address("3", "Three st.", "Adelaide", "5000", "SA");
            Address address2 = new Address("5", "ZOne st.", "Mile End", "5031", "SA");
            Address address3 = new Address("1", "One st.", "Nile End", "5032", "SA");

            Person person1 = new Person("002", "Giorgio", "giorgio@gmail.com", "7110005200", address3);
            Person person2 = new Person("008", "ALEX", "ALEX@GMAIL.COM", "5000111410", address1);
            Person person3 = new Person("0022", "Beppe", "beppe@gmail.com", "6110005200", "3", "Three st.", "Adelaide", "5000", "SA");
            Person person4 = new Person("001", "Zura", "zural@gmail.com", "9000111410", address1);
            Person person5 = new Person("0012", "Alex", "alex@gmail.com", "8000211410", address1);

            Course course1 = new Course("001", "5C#W", 1000.00);
            Course course2 = new Course("002", "4C#M", 1000.00);
            Course course3 = new Course("003", "5JAW", 1500.00);

            Enrolment enrol1 = new Enrolment(enrolDate1, "Pass", "1", course1);
            Enrolment enrol2 = new Enrolment(enrolDate2, "Pass", "1", course1);
            Enrolment enrol3 = new Enrolment(enrolDate3, "Pass", "2", course3);

            Student student1 = new Student("Diploma Software Dev", regDate1, "003", "Melchiorre", "melchiorre@gmail.com", "0000111410", address1, enrol1);
            Student student2 = new Student("Diploma Software Dev", regDate1, "001", "Alex", "alex@gmail.com", "0000111410", address1, enrol1);
            Student student3 = new Student("Diploma Web Dev", regDate2, "005", "Tiziano", "tiziano@gmail.com", "0000111410", address1, enrol2);
            Student student4 = new Student("Diploma Web Dev", regDate2, "002", "Giorgio", "giorgio@gmail.com", "1110005200", address3, enrol3);


            // Create Address List
            List<Address> addressList = new List<Address>();
            addressList.Add(address1);
            addressList.Add(address2);
            addressList.Add(address3);

            // Create Person Array (To use comparer)
            Person[] personArray = { person1, person2, person3, person4, person5 };

            // Create Course List
            List<Course> courseList = new List<Course>();
            courseList.Add(course1);
            courseList.Add(course2);
            courseList.Add(course3);

            // Create Enrol List
            List<Enrolment> enrolList = new List<Enrolment>();
            enrolList.Add(enrol1);
            enrolList.Add(enrol2);
            enrolList.Add(enrol3);

            // Create Student List
            List<Student> studentList = new List<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);

            /////////START COMPARISONS///////////////////

            // Using CompareTo method
            Console.WriteLine("\n--------------------------- CompareTo Method -----------------------------------------\n");

            // Address
            Console.WriteLine("\n**Address**");
            displayOrder(address1, address1);
            displayOrder(address1, address2);
            displayOrder(address1, address3);

            Console.ReadKey();

            // Course
            Console.WriteLine("\n**Course**");
            displayOrder(course1, course1);
            displayOrder(course1, course2);
            displayOrder(course1, course3);

            Console.ReadKey();

            // Enrolment
            Console.WriteLine("\n**Enrolment**");
            displayOrder(enrol1, enrol1);
            displayOrder(enrol1, enrol2);
            displayOrder(enrol1, enrol3);

            Console.ReadKey();

            // Person
            Console.WriteLine("\n**Person (Id)**");
            displayOrder(person1, person1);
            displayOrder(person1, person2);
            displayOrder(person1, person3);
            displayOrder(person1, person4);
            displayOrder(person1, person5);

            Console.ReadKey();

            // Student
            Console.WriteLine("\n**Student**");
            displayOrder(student1, student1);
            displayOrder(student1, student2);
            displayOrder(student1, student3);
            displayOrder(student1, student4);

            Console.ReadKey();

            // COMPARERS
            Console.WriteLine("\n\n--------------------------- Comparers -----------------------------------------\n");

            // PersonNameComparer
            Console.WriteLine("\n**PersonNameComparer**");
            sortAndShowName(personArray);

            Console.ReadKey();

            // PersonEmailComparer
            Console.WriteLine("\n**PersonEmailComparer**");
            sortAndShowEmail(personArray);

            Console.ReadKey();

            // PersonTelNumComparer
            Console.WriteLine("\nPersonTelNumComparer**");
            sortAndShowTelNum(personArray);

            Console.ReadKey();

            //HashSet
            Console.WriteLine("\n\n--------------------------- HashSet + Equality Comparer -----------------------------------------\n");
            HashSet<Person> personHashSet = new HashSet<Person>(PersonEqualityComparer.Instance);
            personHashSet.Add(person1);
            personHashSet.Add(person2);
            personHashSet.Add(person3);
            personHashSet.Add(person4);
            personHashSet.Add(person5);
            personHashSet.Add(person5);

            foreach (var person in personHashSet)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }

        // Use CompareTo method.
        static void displayOrder<T>(T x, T y) where T : IComparable<T>
        {
            int result = x.CompareTo(y);
            if (result == 0)
                Console.WriteLine("{0}  =  {1}", x, y);
            else if (result > 0)
                Console.WriteLine("{0}  >  {1}", x, y);
            else
                Console.WriteLine("{0}  <  {1}", x, y);
        }

        // Use Name Comparer
        static void sortAndShowName(Person[] personArray)
        {
            Array.Sort(personArray, PersonNameComparer.Instance);

            foreach (var person in personArray)
                Console.WriteLine(person);
        }

        // Use Email Comparer
        static void sortAndShowEmail(Person[] personArray)
        {
            Array.Sort(personArray, PersonEmailComparer.Instance);

            foreach (var person in personArray)
                Console.WriteLine(person);
        }

        // Use TelNum Comparer
        static void sortAndShowTelNum(Person[] personArray)
        {
            Array.Sort(personArray, PersonTelNumComparer.Instance);

            foreach (var person in personArray)
                Console.WriteLine(person);
        }
    }
}
