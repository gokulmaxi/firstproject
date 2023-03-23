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
            Console.WriteLine("details of student \nName: " + this.Name);
            Console.WriteLine("Id: "+this.Id);
            Console.WriteLine("Department: "+this.Department);
        }
        ~Program()
        {
            Console.WriteLine("Destructor was called");
        }
        static void Main(string[] args)
        {
            Destructor ds = new Destructor();
        }
    }
}