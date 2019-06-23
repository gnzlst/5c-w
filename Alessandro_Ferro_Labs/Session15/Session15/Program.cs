using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create dates
            DateTime enrolDate1 = new DateTime(2011, 01, 01);
            DateTime enrolDate2 = new DateTime(2011, 01, 01);
            DateTime enrolDate3 = new DateTime(2013, 03, 03);

            DateTime regDate1 = new DateTime(2011, 05, 05);
            DateTime regDate2 = new DateTime(2010, 07, 07);

            // Create some address, courses and enrolments to add variety.
            // One of each would have been enough.
            Address address1 = new Address("1", "One st.", "Nile End", "5032", "SA");
            Address address2 = new Address("5", "ZOne st.", "Mile End", "5031", "SA");
            Address address3 = new Address("3", "Three st.", "Adelaide", "5000", "SA");
            Address address4 = new Address("88", "Quack av.", "Warra Warra", "8200", "NSW");
            Address address5 = new Address("11", "Four ln.", "BAdelaide", "5001", "TA");

            Course course1 = new Course("001", "5C#W", 1000.00);
            Course course2 = new Course("002", "4C#M", 1000.00);
            Course course3 = new Course("003", "5JAW", 1500.00);
            Course course4 = new Course("021", "8CCC", 800.00);
            Course course5 = new Course("008", "4BBB", 200.00);

            Enrolment enrol1 = new Enrolment(enrolDate2, "Pass", "1", course1);
            Enrolment enrol2 = new Enrolment(enrolDate1, "Pass", "1", course3);
            Enrolment enrol3 = new Enrolment(enrolDate3, "Pass", "2", course2);
            Enrolment enrol4 = new Enrolment(enrolDate3, "Pass", "1", course5);
            Enrolment enrol5 = new Enrolment(enrolDate2, "Pass", "2", course4);

                   
            // Create ten students

            Student student1 = new Student("Diploma I", regDate1, "001", "Ivan", "ivan@gmail.com", "101005200", address3, enrol3);
            Student student2 = new Student("Diploma A", regDate2, "001", "Alex", "alex@gmail.com", "0000111410", address1, enrol1);
            Student student3 = new Student("Diploma G", regDate1, "001", "Giorgio", "giorgio@gmail.com", "8880005200", address3, enrol3);
            Student student4 = new Student("Diploma B", regDate2, "001", "Bobby", "Bobby@gmail.com", "0000222410", address1, enrol1);
            Student student5 = new Student("Diploma J", regDate1, "001", "Jayjay", "jayjay@gmail.com", "0110005200", address3, enrol3);
            Student student6 = new Student("Diploma E", regDate2, "001", "Ector", "ector@gmail.com", "5550005200", address3, enrol3);
            Student student7 = new Student("Diploma D", regDate1, "001", "Donald", "Donald@gmail.com", "4440005200", address2, enrol2);
            Student student8 = new Student("Diploma F", regDate2, "001", "Frederick", "frederick@gmail.com", "7770005200", address3, enrol3);
            Student student9 = new Student("Diploma C", regDate1, "001", "Carl", "Carl@gmail.com", "0000333410", address2, enrol2);
            Student student10 = new Student("Diploma H", regDate1, "001", "Holly", "holly@gmail.com", "9990005200", address3, enrol3);

            // Create the array
            Student[] studentArray = { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };
            Console.WriteLine("\n------------------------ Unsorted Array ---------------------------------\n");
            output(studentArray);

            // LinearSearch
            Console.WriteLine("\n------------------------ LinearSearch ---------------------------------\n");
            Console.WriteLine("Search for student3 - Giorgio ----> Expected at index 2");
            Console.ReadKey();
            LinearSearch(studentArray, student3);
            Console.ReadKey();

            // Bubble Sort
            Console.WriteLine("\n------------------------ BubbleSort ---------------------------------\n");
            BubbleSort(studentArray);

            //// BinarySearch
            Console.WriteLine("\n------------------------ BinarySearch ---------------------------------\n");
            Console.WriteLine("Search for student3 - Giorgio ----> Expected at index 6");
            Console.ReadKey();
            BinarySearch(studentArray, student3);

            // END
            Console.ReadKey();
        }

        // LinearSearch
        static void LinearSearch(Student[] studentArray, Student student)
        {
            for (int i = 0; i < studentArray.Length; i++)
            {
                if (studentArray[i] == student)
                {
                    Console.WriteLine("Student {0} found at index {1}", studentArray[i], i);
                    return;
                }
            }
            Console.WriteLine("Student not found!");
        }

        // BinarySearch
        static void BinarySearch(Student[] studentArray, Student student)
        {
            int min = 0;
            int max = studentArray.Length - 1;
            do
            {
                int mid = (min + max) / 2;
                int result = student.CompareTo(studentArray[mid]);
                if (result > 0)
                { min = mid + 1; }
                else
                { max = mid - 1; }
                if (student == studentArray[mid])
                {
                    Console.WriteLine("Student {0} is found at index {1}", studentArray[mid], mid);
                    return;
                }
                if (min > max) { break; }

            } while (min <= max);
            Console.WriteLine("Student not found");
        }

        // BubbleSort
        static void BubbleSort(Student[] studentArray)
        {
            Student student;
            for (int i = 0; i <= studentArray.Length - 2; i++)
            {
                for (int j = 0; j <= studentArray.Length - 2; j++)
                {
                    if (studentArray[j].Name.CompareTo(studentArray[j + 1].Name) > 0)
                    {
                        student = studentArray[j + 1];
                        studentArray[j + 1] = studentArray[j];
                        studentArray[j] = student;
                    }
                }
            }
            output(studentArray);
        }


        // Simple method to output the array
        static void output(Student[] studentArray)
        {
            foreach (var student in studentArray)
                Console.WriteLine(student);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
