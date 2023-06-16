using DataStructureProblem;

namespace DatastructureProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day6 Datastructure PracticeProblem");
            Console.WriteLine("Select any one option from \n 1.Generic Custom Linkedlist\n 2.Generic Class Custom Stack");
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

                default:
                    Console.WriteLine("Please Enter Valid Option");
                    break;
            }
        }
    }

}
