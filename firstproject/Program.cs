namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arr1 = {1,2,3,5};
            int[] arr2 = { 2, 4, 6 };
            MergeSortedArray mr = new MergeSortedArray(arr1, arr2,4,3);
            int[] arr = mr.MergeArray();
            foreach (int x in arr)
            {
                Console.Write(x);
            }
        }
    }
}