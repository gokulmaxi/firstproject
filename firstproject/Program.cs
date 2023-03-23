namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
        GenericMethodEx gme = new GenericMethodEx();
            gme.TestFunction("Hello");
            gme.TestFunction(1);
        }
    }
}