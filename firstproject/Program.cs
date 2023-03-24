namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddFAndB afb = new AddFAndB("hello");
            Console.WriteLine(afb.addFandB());
        }
    }
}