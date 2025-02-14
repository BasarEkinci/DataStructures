using System.Net.WebSockets;

namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dlinkedList = new DoublyLinkedList();

            dlinkedList.Append(1);
            dlinkedList.Append(2);
            dlinkedList.Append(3);
            dlinkedList.Append(4);
            dlinkedList.PrintList();
            Console.WriteLine("\nLenght: " + dlinkedList.GetLength() + "\n---------------------");
            Node deletedNode = dlinkedList.DeleteNodeAt(2);
            dlinkedList.PrintList();
            Console.Write("\nDeleted Node: " + deletedNode?.Data);
            Console.WriteLine("\nLenght: " + dlinkedList.GetLength() + "\n---------------------");
        }
    }
}
