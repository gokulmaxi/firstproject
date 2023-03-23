
namespace firstproject
{
    internal class Program
    {
        string Name;
        int Id;
        string Department;
       public Program(string name,int id,string department) {
            this.Name = name;
            this.Id = id;
            this.Department = department;   
        }
        public void DisplayStudent()
        {
            Console.WriteLine("details of student \nName :" + this.Name);
            Console.WriteLine("Id: "+this.Id);
            Console.WriteLine("Department: "+this.Department);
        }
        static void Main(string[] args)
        {
            Program myProgram = new Program("gokul",2,"Mechatronics");
            myProgram.DisplayStudent();
        }
    }
}