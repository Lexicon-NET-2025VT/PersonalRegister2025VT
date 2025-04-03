


using PersonalRegister2025VT.Helpers;

namespace PersonalRegister2025VT
{
    internal class Program
    {
        private static Payroll payroll = new Payroll();         
        static void Main(string[] args)
        {
            bool isAlive = true;
            SeedData(); 
            do
            {
                MenuHelper.ShowMainMenu();

                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case MenuHelper.Add:
                        AddEmployee(); 
                        break;
                    case MenuHelper.Print:
                        PrintEmployees();
                        break;
                    case MenuHelper.Quit:
                        //case "q":
                        //Environment.Exit(0); 
                        isAlive = false; 
                        break; 
                    default:
                        break;
                }

            } while (isAlive);

        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 20000);
            payroll.AddEmployee("Anna", 25000);
            payroll.AddEmployee("Stefan", 28000);
        }

        private static void AddEmployee()
        {
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");
            payroll.AddEmployee(name, salary);
        }
        private static void PrintEmployees()
        {
            foreach (Employee employee in payroll.GetEmployees())
            {
                //Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
                Console.WriteLine(employee);
            }
        }
    }
}
