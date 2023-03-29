namespace firstproject {
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task<int> task = AsyncEx.Method1();    
            Task<int> task2 = AsyncEx.Method2();
            await task;
            await task2;
        }
    }
}