namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericTypeEx<int>  geInt = new GenericTypeEx<int>(1);
            GenericTypeEx<string>  geString = new GenericTypeEx<string>("hello");
        }
    }
}