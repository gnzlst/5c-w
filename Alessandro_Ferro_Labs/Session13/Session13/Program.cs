using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session13;

namespace Session13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;

            Address address1 = new Address("1", "One st.", "Mile End", "5031", "SA");
            Address address2 = new Address("1", "One st.", "Mile End", "5031", "SA");
            Address address3 = new Address("3", "Three st.", "Adelaide", "5000", "SA");

            Person person1 = new Person("Alex", "alex@gmail.com", "0000111410", address1);
            Person person2 = new Person("Alex", "alex@gmail.com", "0000111410", address1);
            Person person3 = new Person("Giorgio", "giorgio@gmail.com", "1110005200", address3);
            Person person4 = new Person("Giorgio", "giorgio@gmail.com", "1110005200", "3", "Three st.", "Adelaide", "5000", "SA");

            Course course1 = new Course("001", "5C#W", 1000.00);
            Course course2 = new Course("001", "5C#W", 1000.00);
            Course course3 = new Course("003", "5JAW", 1500.00);

            Enrolment enrol1 = new Enrolment("01/01/2011", "Pass", "1", course1);
            Enrolment enrol2 = new Enrolment("01/01/2011", "Pass", "1", course1);
            Enrolment enrol3 = new Enrolment("03/03/2013", "Pass", "2", course3);

            Student student1 = new Student("Diploma Software Dev", "05/05/2011", "Alex", "alex@gmail.com", "0000111410", address1, enrol1);
            Student student2 = new Student("Diploma Software Dev", "05/05/2011", "Alex", "alex@gmail.com", "0000111410", address1, enrol1);
            Student student3 = new Student("Diploma Web Dev", "07/07/2010", "Alex", "alex@gmail.com", "0000111410", address1, enrol2);
            Student student4 = new Student("Diploma Web Dev", "07/07/2010", "Giorgio", "giorgio@gmail.com", "1110005200", address3, enrol3);

            Console.WriteLine("SESSION 13 - TEST FOR EQUALITY");

            Console.WriteLine("\n---------------------------------- address -------------------------------\n");
            // CASE 1
            result = address1 == address1;
            Console.WriteLine("Case 1 --> address1 == address1 (Same object - same attributes): " + result);

            // CASE 2
            result = address1 == address2;
            Console.WriteLine("Case 2 --> address1 == address2 (Different objects - same attributes): " + result);

            // CASE 3
            result = address1 == address3;
            Console.WriteLine("Case 3 --> address1 == address3 (Different objects - different attributes): " + result);

            Console.WriteLine("\n---------------------------------- person -------------------------------\n");
            // CASE 4
            result = person1 == person1;
            Console.WriteLine("Case 4 --> person1 == person1 (Same object - same attributes): " + result);

            // CASE 5
            result = person1 == person2;
            Console.WriteLine("Case 5 --> person1 == person2 (Different objects - same attributes): " + result);

            // CASE 6
            result = person1 == person3;
            Console.WriteLine("Case 6 --> person1 == person3 (Different objects - different attributes): " + result);

            // CASE 7
            result = person3 == person4;
            Console.WriteLine("Case 7 --> person3 == person4 (Different objects - Same attributes - Address created with different constructors): " + result);

            Console.WriteLine("\n---------------------------------- course -------------------------------\n");
            // CASE 8
            result = course1 == course1;
            Console.WriteLine("Case 8 --> course1 == course1 (Same object - same attributes): " + result);

            // CASE 9
            result = course1 == course2;
            Console.WriteLine("Case 9 --> course1 == course2 (Different objects - same attributes): " + result);

            // CASE 10
            result = course1 == course3;
            Console.WriteLine("Case 10 --> course1 == course3 (Different objects - different attributes): " + result);

            Console.WriteLine("\n---------------------------------- enrolment -------------------------------\n");
            // CASE 11
            result = enrol1 == enrol1;
            Console.WriteLine("Case 11 --> enrol1 == enrol1 (Same object - same attributes): " + result);

            // CASE 12
            result = enrol1 == enrol2;
            Console.WriteLine("Case 12 --> enrol1 == enrol2 (Different objects - same attributes): " + result);

            // CASE 13
            result = enrol1 == enrol3;
            Console.WriteLine("Case 13 --> enrol1 == enrol3 (Different objects - different attributes): " + result);

            Console.WriteLine("\n---------------------------------- student - Implements DisplayWetherEqual -------------------------------\n");
            // CASE 14
            result = student1 == student1;
            Console.WriteLine("Case 14 --> student1 == student1 (Same object - same attributes): " + result);
            DisplayWetherEqual(student1, student1);

            // CASE 15
            result = student1 == student2;
            Console.WriteLine("Case 15 --> student1 == studet2 (Different objects - same attributes): " + result);
            DisplayWetherEqual(student1, student2);

            // CASE 16
            result = student1 == student3;
            Console.WriteLine("Case 15 --> student1 == student3 (Different objects - different attributes): " + result);
            DisplayWetherEqual(student1, student3);

            // CASE 17
            result = student3 == student4;
            Console.WriteLine("Case 17 --> student3 == student4 (Bonus - Extra student object I created and i forgot why): " + result);
            DisplayWetherEqual(student3, student4);

            Console.WriteLine("\n---------------------------------- Compare Person and Student -------------------------------\n");
            // CASE 18
            result = person1 == student1;
            Console.WriteLine("Case 18 --> Test Person1 == Student1 (Student has same attributes of parent + extra fiedls): " + result);
            DisplayWetherEqual(person1, student1);

            Console.ReadKey();
        }

        static void DisplayWetherEqual(Person x, Person y)
        {
            if (x == y)
                Console.WriteLine(string.Format("{0}  ==  {1}", x, y));
            else
                Console.WriteLine(string.Format("{0}  !=  {1}", x, y));

            Console.WriteLine();
        }
    }
}
