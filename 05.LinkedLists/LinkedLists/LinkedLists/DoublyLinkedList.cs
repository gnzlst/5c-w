﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class DoublyLinkedList<T>:System.Collections.Generic.ICollection<T>
    {
        public LinkedListNode<T> Head
        {
            get; private set;
        }
        public LinkedListNode<T> Tail
        {
            get; private set;
        }
        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }
        public void AddFirst(LinkedListNode<T> node)
        {
            //save the head node so we don't lose it
            LinkedListNode<T> temp = Head;

            //point head to the new node
            Head = node;

            //Insert the rest of the list behind the head
            Head.Next = temp;
            if (Count==0)
            {
                //if the list was empty then Head and Tail should 
                //both point to the new node
                Tail = Head;
            }
            else
            {
                // Before: Head-------> 5 <-> 7 ->null
                // After:  Head-> 3 <-> 5 <-> 7 ->null

                //temp.Previous was null, now Head
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

                //Before: Head -> 3 <-> 5  -> null
                //After:  Head -> 3 <-> 5 <-> 7 ->null
                //7.Previous=5
                node.Previous = Tail;
            }
            Tail = node;
            Count++;
        }
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                //Before: Head-> 3 <-> 5
                //After:  Head----->5

                //Head->3->null
                //Head---->null

                Head = Head.Next;
                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }
                else
                {
                    //5.Prevoius was 3, now is null
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
                    //Before: Head-->3-->5-->7
                    //        Tail=7
                    //After:  Head-->3-->5-->null
                    //        Tail=5
                    //Null out 5's Next pointer
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;                    

                }
                Count--;
            }
        }
        public int Count
        {
            get; private set;
        }
        public void Add(T item)
        {
            AddFirst(item);
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
        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;
            // 1. Empty List -do nothing
            // 2. Single Node:(previous is null)
            // 3. Many nodes
            //    a: node to remove is the fisrt node
            //    b: node to remove is the middle or last

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    //it's a node in the middle or end
                    if (previous != null)
                    {
                        //case 3b

                        //Before: Head->3->5->null
                        //After:  Head->3---->null
                        previous.Next = current.Next;

                        //it was the end - so update Tail
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            //Before: Head-> 3 <-> 5 <-> 7 -> null
                            //After:  Head-> 3 <-------> 7 -> null
                            //previous=3
                            //current=5
                            //current.Next=7
                            //7.Previous=3
                            current.Next.Previous = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        //case 2 or 3a
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;

            }
            return false;
        }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable <T>) this).GetEnumerator();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }
}
