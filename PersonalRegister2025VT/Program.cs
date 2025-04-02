namespace PersonalRegister2025VT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Anders", 20000);
            //emp.Name = "Anders";
            //emp.Salary = 20000;

            Console.WriteLine($"Name: {emp.Name} Salary: {emp.Salary}");
            //Console.WriteLine("Name: " + emp.Name + " Salary: " + emp.Salary);
            //Console.WriteLine("Name: {0} Salary: {1}", emp.Name, emp.Salary);
            emp.Name = "Nisse";
            Console.WriteLine($"Name: {emp.Name} Salary: {emp.Salary}");

        }
    }
}
