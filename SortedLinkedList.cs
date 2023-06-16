using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{

    public class Node
    {
        public int Value;
        public Node Next;

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class SortedLinkedList
    {
        private Node Head;

        public SortedLinkedList()
        {
            Head = null;
        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (Head == null || value > Head.Value)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            Node current = Head;

            while (current.Next != null && value < current.Next.Value)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void Display()
        {
            Node current = Head;

            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }

}
