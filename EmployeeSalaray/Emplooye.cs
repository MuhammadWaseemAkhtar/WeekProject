using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaray
{
    abstract class Emplooye
    { 
        protected double baseSalary;
        protected double fuelAllowance;
        protected double medicalAllowance;
        protected double grossPay;
        abstract public void SetMedicalAllowance();
        abstract public void SetFuelAllowance();

        public void SetBaseSalary()
        {
            this.baseSalary = 1500;
        }
        public double GetBaseSalary()
        {
            return this.baseSalary;
        }
        
        public double GetFuelAllowance()
        {
            return this.fuelAllowance;
        }
        
        public double GetMedicalAllowance()
        {
            return this.medicalAllowance;
        }
        public double GrossPay()
        {
            this.grossPay = this.GetBaseSalary() + this.GetFuelAllowance() + this.GetMedicalAllowance();
            return this.grossPay;
        }
    }
}
