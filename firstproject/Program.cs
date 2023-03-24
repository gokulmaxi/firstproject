namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exFirstAndLast stringEx = new exFirstAndLast("hello"); 
            Console.WriteLine(stringEx.exchange());
        }
    }
}