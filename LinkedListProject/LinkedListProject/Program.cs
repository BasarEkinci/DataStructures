namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(12);
            list.Append(7);
            list.PrintList();
        }
    }
}
