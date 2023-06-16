using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class BuiltinQueueCRUD
    {
        public static void QueueOperation()
        {
            Queue<int> intQueue = new Queue<int>();
            // Create Operation
            intQueue.Enqueue(10);
            intQueue.Enqueue(20);
            intQueue.Enqueue(30);

            // Read Operation
            Console.WriteLine("Elements in Queue are ");
            foreach (var data in intQueue)
            {
                Console.WriteLine(data);
            }

            //Delete operation

            Console.WriteLine("Dequeue Element is " + intQueue.Dequeue());

            Console.WriteLine("Peak Element is " + intQueue.Peek());

            Console.WriteLine("After Dequeue Elements in Queue are ");
            foreach (var data in intQueue)
            {
                Console.WriteLine(data);
            }
            //intQueue.Clear();
        }
    }
}
