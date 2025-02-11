using System.Net.WebSockets;

namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Append(10);
            list.Append(20);
            list.Append(30);
            list.PrintList();
            list.DeleteFirstNode();
            Console.WriteLine("After Delete First Node:");
            list.PrintList();
            list.DeleteFirstNode();
            Console.WriteLine("After delete firts node of the new list: ");
            list.PrintList();
            list.DeleteFirstNode();
            list.PrintList();
            list.DeleteFirstNode();
            list.PrintList();
        }
    }
}
