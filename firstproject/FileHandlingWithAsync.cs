using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    internal class FileHandlingWithAsync
    {
        public string path = "C:\\Users\\DELL\\source\\repos\\c#basics\\filename1.txt";
        public FileHandlingWithAsync() { 

        }
        public async static Task<FileStream> OpenFile()
        {
            Console.WriteLine("opening file...");
            FileStream file = new FileStream("C:\\Users\\DELL\\source\\repos\\c#basics\\filename1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Counter();
            Console.WriteLine("file opened successfully");
            return file;
        }
        public static void Counter()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static async void ReadWriteFile()
        {
            FileStream file = await OpenFile();
            Console.WriteLine("writing to a file...");
            string str = "heythere another test on a file";
            byte[] byteArr = Encoding.UTF8.GetBytes(str);
            file.Write(byteArr);
            Console.WriteLine("File written successfully");
            file.Close();
        }
    }
}







