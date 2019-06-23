using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    class Program
    {
        static void Main(string[] args)
        {
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

            // a. Create an instance of the Doubly Linked List and Add several Student instances to the List.
            Console.WriteLine("\n----------------------------------------- CREATE LIST AND ADD STUDENTS ------------------------------------\n");
            DoublyLinkedList<Student> studentList = new DoublyLinkedList<Student>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            studentList.Add(student5);
            studentList.Add(student6);
            studentList.Add(student7);
            studentList.Add(student8);
            studentList.Add(student9);
            studentList.Add(student10);

            Console.WriteLine("10 students added to the list");
            Console.ReadKey();

            // b. Enumerate through the list and display each of the Student node values
            Console.WriteLine("\n----------------------------------------- ENUMERATE THROUGH LIST ------------------------------------\n");
            output(studentList);

            // c. Add a Student instance to the end of the list and enumerate through list to ensure it was added at the end
            Console.WriteLine("\n----------------------------------------- ADD STUDENT AT THE END ------------------------------------\n");
            Student student11 = new Student("Diploma X", regDate2, "555", "GianGiorgio", "gian@giorgio.com", "5555555555", address5, enrol5);
            studentList.AddLast(student11);
            output(studentList);

            // d. Using the appropriate method in the list find if a particular student instance is found in the list.
            // Check existing student using student5
            Console.WriteLine("\n----------------------------------------- CHECK IF STUDENT IS IN LIST ------------------------------------\n");
            Console.WriteLine("Check for student 5 ----> " + studentList.Contains(student5));
            Console.WriteLine(student5);
            Console.ReadKey();

            // e. Remove a Student instance from the beginning of the list and test if it worked.
            Console.WriteLine("\n----------------------------------------- REMOVE FIRST STUDENT ------------------------------------\n");
            studentList.RemoveFirst();
            output(studentList);

            // f.Remove a Student from the end of the list and test if it worked.
            Console.WriteLine("\n----------------------------------------- REMOVE LAST STUDENT ------------------------------------\n");
            studentList.RemoveLast();
            output(studentList);

            // END   
        }

        // Simple method to output the list
        static void output(DoublyLinkedList<Student> studentList)
        {
            foreach (var student in studentList)
                Console.WriteLine(student);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
