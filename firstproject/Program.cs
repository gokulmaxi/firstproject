namespace firstproject {
    internal class Program
    {
        static void Main(string[] args)
        {
            StringOk so = new StringOk("hellokasokdf");
            Console.Write( so.findAndRemoveOK());
        }
    }
}