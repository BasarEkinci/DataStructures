namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dlinkedList = new DoublyLinkedList();

            dlinkedList.Append(1);
            dlinkedList.PrintList();
            dlinkedList.DeleteLast();
            dlinkedList.PrintList();
        }
    }
}
