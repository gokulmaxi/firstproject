namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arr1 = {1,2,3,5};
            SplitEvenOdd seo = new SplitEvenOdd(arr1);
            seo.SplitArray();
            foreach (var item in seo.evenList)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
            foreach (var item in seo.oddList)
            {
                Console.Write(item+",");
            }
        }
    }
}