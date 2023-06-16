using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class GenericClassStack<T>
    {
        public Node<T> top;
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} is inserted into Stack", top.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} is inserted into Stack", top.data);
            }
        }
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("{0} is at the top", top.data);
            }
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("{0} is Removed from the Stack", top.data);
                top = top.next;
            }
        }
        public void isEmpty()
        {
            while (top != null)
            {
                Peek();
                Pop();
            }
        }
        public void Display()
        {
            if (top == null)
                Console.WriteLine("Stack is Empty");
            else
            {
                Console.WriteLine("Stack Contains-");
                Node<T> temp = top;
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
