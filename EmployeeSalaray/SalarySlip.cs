using System;

namespace EmployeeSalaray
{
    class SalarySlip
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter number From Menu ");
            Console.WriteLine("1 For Manager \n2 For Engineer \nany Other For Analysts");
            int choice = Convert.ToInt32(Console.ReadLine());
            Emplooye obj;
            if (choice == 1)
                obj = new Manager();
            else if (choice == 2)
                obj = new Engineer();
            else
                obj = new Analysts();

            obj.SetBaseSalary();
            obj.SetFuelAllowance();
            obj.SetMedicalAllowance();
            Console.WriteLine("Employee Gross salaray is "+ obj.GrossPay());

        }
    }
}
