namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.WriteLine("Is my stack empty: " + stack.IsEmpty());
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.PrintTop();
            stack.PrintAll();
            Console.WriteLine("Is my stack empty: " + stack.IsEmpty());
            Console.WriteLine("Count: " +stack.GetCount());
            Console.WriteLine("-----------------------------");
            Node pop = stack.Pop();
            Console.WriteLine("Pop: " + pop.Data);
            stack.PrintTop();
            stack.PrintAll();
            Console.WriteLine("Count: " + stack.GetCount());
        }
    }
}
