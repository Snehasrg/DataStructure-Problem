using DataStructureProblem;

namespace DatastructureProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day6 Datastructure PracticeProblem");
            Console.WriteLine("Select any one option from \n 1.Generic Custom Linkedlist\n 2.Generic Class Custom Stack" +
                              "\n 3.Generic Class Custom Queue\n 4.Builtin Linkedlist CRUD operation" +
                              "\n 5.Built in Stack CRUD operation");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    GenericClassCustomLinkedlist<int> integerLinkList = new GenericClassCustomLinkedlist<int>();
                    integerLinkList.AddLast(10);
                    integerLinkList.AddLast(20);
                    integerLinkList.Addfirst(30);

                    GenericClassCustomLinkedlist<string> stringLinkList = new GenericClassCustomLinkedlist<string>();
                    Console.WriteLine("Before Removing Elements");
                    stringLinkList.AddLast("Shruti");
                    stringLinkList.Addfirst("Srushti");
                    Console.WriteLine();
                    Console.WriteLine("After Removing Elements");
                    stringLinkList.Remove("Srushti");
                    stringLinkList.DisplayList();
                    break;

                case 2:
                    GenericClassStack<int> stack = new GenericClassStack<int>();
                    stack.Add(10);
                    stack.Add(20);
                    stack.Add(30);
                    stack.Display();
                    stack.Pop();
                    stack.isEmpty();
                    stack.Display();
                    break;

                case 3:
                    GenericClassQueue<int> queue = new GenericClassQueue<int>();
                    queue.Enqueue(10);
                    queue.Enqueue(20);
                    queue.Enqueue(30);
                    queue.Display();
                    queue.Dequeue();
                    queue.Display();
                    break;

                case 4:
                    BuiltinLinkedListCRUD.LinkedList();
                    break;

                case 5:
                    BuiltinStackCRUD.StackOperation();
                    break;

                default:
                    Console.WriteLine("Please Enter Valid Option");
                    break;
            }
        }
    }

}
