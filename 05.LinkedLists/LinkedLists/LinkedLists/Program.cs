using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<Student> sList = new DoublyLinkedList<Student>();
            Student s1 = new Student("John", "John@gmail.com", "04111111","pro1", "01/01/2019");
            Student s2 = new Student("Mary", "Mary@gmail.com", "04222222","pro2", "02/01/2019");
            Student s3 = new Student("Harry", "Harry@gmail.com", "0433333","pro1", "03/01/2019");
            Student s4 = new Student("Eric", "Eric@outlook.com", "04444444","pro3", "01/04/2019");
            Student s5 = new Student("Patty", "Patty@gmail.com", "0455555","pro4", "02/02/2019");
            sList.Add(s1);
            sList.Add(s2);
            sList.Add(s3);
            sList.Add(s4);
            //Enumerate through the list and display each of the Student node values
            Console.WriteLine("---Enumerate through the list and display each of the Student node values");
            foreach (var s in sList)
                Console.WriteLine(s);
            Console.WriteLine();
            
            //Add Patty to the end of the list
            Console.WriteLine("---Add Patty to the end of the list");
            sList.AddLast(s5);
            foreach (var s in sList)
                Console.WriteLine(s);
            Console.WriteLine();

            //see if Eric is in the List
            Console.WriteLine("---see if Eric is in the List");
            Console.WriteLine("Is Eric in the list? "+ sList.Contains(s4));
            Console.WriteLine();

            //Remove a Student instance from the beginning of the list
            Console.WriteLine("---Remove a Student instance from the beginning of the list");
            sList.RemoveFirst();
            foreach (var s in sList)
                Console.WriteLine(s);
            Console.WriteLine();

            //Remove a Student from the end of the list
            Console.WriteLine("---Remove a Student from the end of the list");
            sList.RemoveLast();
            foreach (var s in sList)
                Console.WriteLine(s);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
