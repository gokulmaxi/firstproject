namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4,1,2};
            char[] charArr = { 'a', 'b','b'};
            FindDuplicateCount<int> findDupCount = new FindDuplicateCount<int>(arr);
            Console.WriteLine( findDupCount.GetCount());
            FindDuplicateCount<char> findDupCountChar = new FindDuplicateCount<char>(charArr);
            Console.WriteLine( findDupCountChar.GetCount());
        }
    }
}