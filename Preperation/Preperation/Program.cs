namespace Preperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile auto1 = new Automobile("BMW");
            Console.WriteLine(auto1.Brand);
            Automobile auto2;
            auto2 = auto1;
            Console.WriteLine(auto2.Brand);
        }
    }
}
