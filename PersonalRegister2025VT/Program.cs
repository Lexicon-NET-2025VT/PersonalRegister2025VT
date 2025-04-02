namespace PersonalRegister2025VT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Droid d1 = new Droid("C-3PO");
            Console.WriteLine(d1.GetFirstName());
            //d1.firstname = "R2-D2";
            d1.SetFirstName("R2-D2");
            Console.WriteLine(d1.GetFirstName());
            d1.Salary = 25000;
            Console.WriteLine(d1.Salary);
            Console.ReadLine(); 
        }
    }
}
