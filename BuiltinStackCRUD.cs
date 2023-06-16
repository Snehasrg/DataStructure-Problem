using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class BuiltinStackCRUD
    {
        public static void StackOperation()
        {
            Stack<string> intStack = new Stack<string>();
            // Create operation
            intStack.Push("Shital");
            intStack.Push("Shreya");
            intStack.Push("Pallavi");

            //Read Operation
            Console.WriteLine("\nElement Present in Stack are");
            foreach (var item in intStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPeak Element is " + intStack.Peek());
            //Delete Operation
            Console.WriteLine("\nPopped Element is " + intStack.Pop());
            Console.WriteLine("\nAfter Pop Operation elements in Stack");
            foreach (var item in intStack)
            {
                Console.WriteLine(item);
            }

            //intStack.Clear();

        }
    }
}
