using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class BuiltinLinkedListCRUD
    {
        public static void LinkedList()
        {
            LinkedList<int> linkListData = new LinkedList<int>();
            // Create operation
            linkListData.AddFirst(40);
            linkListData.AddFirst(50);
            linkListData.AddLast(60);
            Console.WriteLine("Current elements in Linkedlist are");

            // Read operation
            foreach (int data in linkListData)
            {
                Console.WriteLine(data);
            }

            // Update operation
            LinkedListNode<int> node = linkListData.Find(50);
            if (node != null)
            {
                node.Value = 70;
            }
            Console.WriteLine("After Update Elements are");
            foreach (int data in linkListData)
            {
                Console.WriteLine(data);
            }

            // Delete operation
            linkListData.RemoveFirst();
            Console.WriteLine("After Removing Elements");
            foreach (int data in linkListData)
            {
                Console.WriteLine(data);
            }

        }
    }
}
