namespace PersonalRegister2025VT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee("Anders", 20000);
            ////emp.Name = "Anders";
            ////emp.Salary = 20000;

            //Console.WriteLine($"Name: {emp.Name} Salary: {emp.Salary}");
            ////Console.WriteLine("Name: " + emp.Name + " Salary: " + emp.Salary);
            ////Console.WriteLine("Name: {0} Salary: {1}", emp.Name, emp.Salary);
            //emp.Name = "Nisse";
            //Console.WriteLine($"Name: {emp.Name} Salary: {emp.Salary}");

            Payroll payroll = new Payroll();

            //Lägg till ny anställd
            payroll.AddEmployee("Kalle", 20000);
            payroll.AddEmployee("Anna", 25000);
            //payroll.AddEmployee("Anna2", 25000);
            //payroll.AddEmployee("Anna3", 25000);
            //payroll.AddEmployee("Anna4", 25000);
            //payroll.AddEmployee("Anna5", 25000);
            //payroll.AddEmployee("Anna6", 25000);
            //payroll.AddEmployee("Anna7", 25000);
            //payroll.AddEmployee("Anna8", 25000);

            //Hämtar en samling av alla anställda
            IEnumerable<Employee> employees = payroll.GetEmployees();

            //Skriver ut alla anställda
           foreach(Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            }

        }
    }
}
