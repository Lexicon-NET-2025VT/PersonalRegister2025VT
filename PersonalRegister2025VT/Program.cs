﻿


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
                Console.WriteLine("1: Add employee" +
                    "\n2: Show employees" +
                    "\nQ: Quit");

                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "1":
                        AddEmployee(); 
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
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
