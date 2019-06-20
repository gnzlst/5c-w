using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> myLinkedList = new DoublyLinkedList<int>();
            int[] myArray;

            LinkedList<int> myLinkedList2 = new LinkedList<int>();

            myLinkedList2.AddLast(3);
            myLinkedList2.AddLast(5);
            myLinkedList2.AddLast(7);

            foreach (int value in myLinkedList2)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("******** START - Adding three integers to the lists appropriate Add ( )  *********");
            myLinkedList.Add(2);
            myLinkedList.AddFirst(1);
            myLinkedList.AddLast(3);
            foreach (int myInteger in myLinkedList)
            {
                Console.WriteLine(myInteger);
            }
            Console.WriteLine("******** END - Adding three integers to the lists appropriate Add ( )  *********");
            Console.ReadLine();


            Console.WriteLine("******** START - Create three other LinkedListNode instances and add them to your list using the appropriate Add ( )  *********");
            myLinkedList.AddLast(4);
            myLinkedList.AddLast(5);
            myLinkedList.AddLast(6);
            foreach (int myInteger in myLinkedList)
            {
                Console.WriteLine(myInteger);
            }
            Console.WriteLine("******** END - Create three other LinkedListNode instances and add them to your list using the appropriate Add ( )  *********");
            Console.ReadLine();


            Console.WriteLine("******** START - Now enumerate through the list to display the node values  *********");
            foreach (int myInteger in myLinkedList)
            {
                Console.WriteLine(myInteger);
            }
            Console.WriteLine("******** END - Now enumerate through the list to display the node values  *********");
            Console.ReadLine();

            Console.WriteLine("******** START - RemoveFirst  *********");
            myLinkedList.RemoveFirst();
            foreach (int myInteger in myLinkedList)
            {
                Console.WriteLine(myInteger);
            }
            Console.WriteLine("******** END - RemoveFirst  *********");
            Console.ReadLine();

            Console.WriteLine("******** START - RemoveLast  *********");
            myLinkedList.RemoveLast();
            foreach (int myInteger in myLinkedList)
            {
                Console.WriteLine(myInteger);
            }
            Console.WriteLine("******** END - RemoveLast  *********");
            Console.ReadLine();

            Console.WriteLine("******** START - IsReadOnly  *********");
            Console.WriteLine("Result: " + myLinkedList.IsReadOnly);
            Console.WriteLine("******** END - IsReadOnly  *********");
            Console.ReadLine();

            Console.WriteLine("******** START - Count  *********");
            Console.WriteLine("Result: " + myLinkedList.Count);
            Console.WriteLine("******** END - Count  *********");
            Console.ReadLine();

            Console.WriteLine("******** START - Contains (1), expected false *********");
            Console.WriteLine("Result: " + myLinkedList.Contains(1));
            Console.WriteLine("******** END - Contains (1), expected false *********");
            Console.ReadLine();

            Console.WriteLine("******** START - Contains (2), expected true *********");
            Console.WriteLine("Result: " + myLinkedList.Contains(2));
            Console.WriteLine("******** END - Contains (2), expected true *********");
            Console.ReadLine();

            Console.WriteLine("******** START - CopyTo *********");
            myArray = new int[myLinkedList.Count];
            myLinkedList.CopyTo(myArray, 0);
            foreach (int i in myArray)
            {
                Console.WriteLine("{0} ", i);
            }
            Console.WriteLine("******** END - CopyTo *********");
            Console.ReadLine();

            Console.WriteLine("******** START - Remove (2)  *********");
            myLinkedList.Remove(2);
            foreach (int myInteger in myLinkedList)
            {
                Console.WriteLine(myInteger);
            }
            Console.WriteLine("******** END - Remove (2)  *********");
            Console.ReadLine();

            Console.WriteLine("******** START - GetEnumerator *********");
            Console.WriteLine(myLinkedList.GetEnumerator().ToString());
            Console.WriteLine("******** END - GetEnumerator *********");
            Console.ReadLine();

            Console.WriteLine("******** START - Clear *********");
            myLinkedList.Clear();
            if (myLinkedList.Count == 0)
            {
                Console.WriteLine("Ooops, there is nothing here...");
            }
            else
            {
                foreach (int myInteger in myLinkedList)
                {
                    Console.WriteLine(myInteger);
                }
            }

            Console.WriteLine("******** END - Clear *********");
            Console.ReadLine();




        }
    }

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
}
