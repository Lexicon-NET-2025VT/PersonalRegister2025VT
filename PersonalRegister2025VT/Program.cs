namespace PersonalRegister2025VT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Droid d1 = new Droid("C-3PO",27000);
            //Droid d2 = new Droid();
            //Droid d3 = new Droid("Dalek");
            //d2.Salary = 2000;
            //d2.SetFirstName("Potatis"); 

            //Console.WriteLine(d1.GetFirstName());
            ////d1.firstname = "R2-D2";
            //d1.SetFirstName("R2-D2");
            //Console.WriteLine(d1.GetFirstName());
            //d1.Salary = 25000;
            //Console.WriteLine(d1.Salary);
            //Console.ReadLine();
            //
            Droid d1 = new Droid();
            //d1.Count;
            Console.WriteLine(Droid.Count);
            Droid d2 = new Droid();
            Droid.GetCount(); 
            Droid d3 = new Droid();
            Console.WriteLine(Droid.Count);
            Droid d4 = new Droid();
            Droid.GetCount();
            Droid d5 = new Droid();
            Console.WriteLine(Droid.Count);
        }
    }
}
