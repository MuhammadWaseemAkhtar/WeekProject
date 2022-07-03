using System;

namespace ElectricBill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter number From Menu ");
            Console.WriteLine("1 For Rasidential \nany Other For Commercial");
            int choice = Convert.ToInt32(Console.ReadLine());
            ElectricBill obj;
            if (choice == 1)
            {
                obj = new Residential();
                obj.SetTax(13);
            }
            else
            {
                obj = new Commercial();
                obj.SetTax(17);
            }
            Console.WriteLine("Please Enter How Many Units were consumed");
            double units = Convert.ToDouble(Console.ReadLine());
            obj.SetUnits(units);
            obj.CalculateBill();
            obj.CalculateTax();
            obj.DisplayBill();

        }
    }
}
