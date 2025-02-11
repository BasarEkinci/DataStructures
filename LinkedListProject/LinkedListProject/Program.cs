using System.Net.WebSockets;

namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.PrintList();
            list.DeleteNode(1);
            list.PrintList();
        }
    }
}
