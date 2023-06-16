using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class GenericClassQueue<T>
    {
        public Node<T> head;
        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted into the Queue ", head.data);
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is inserted into the Queue ", newNode.data);
            }
        }
        public void Dequeue()
        {
            if (head == null)
                Console.WriteLine("Queue is Empty");
            else
            {
                Console.WriteLine("{0} is removed from the Queue", head.data);
                head = head.next;
            }
        }
        public void Display()
        {
            Console.WriteLine("Queue Contains-");
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
