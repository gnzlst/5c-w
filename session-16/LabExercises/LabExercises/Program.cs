using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node { Value = 3 };
            Node middle = new Node { Value = 5 };
            first.Next = middle;
            Node last = new Node { Value = 7 };
            middle.Next = last;

            Node myNode = new Node();

            Console.WriteLine("******** START - Lab 01 - Node Chains *********");
            PrintList(first);
            Console.WriteLine("******** END - Lab 01 - Node Chains *********");
            Console.ReadLine();


        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

    }

    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

    }


}
