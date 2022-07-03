using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricBill
{
    abstract class ElectricBill
    {
        protected double totalUnits;
        protected double bill;
        protected double taxPercent;
        protected double taxAmount;
        public ElectricBill()
        {
            this.taxAmount = 1;
        }
        public abstract void CalculateBill();
        public abstract void CalculateTax();
        public void SetUnits(double units)
        {
            this.totalUnits = units;
        }
        public void SetTax(double tax)
        {
            this.taxPercent = tax; 
        }
        public void DisplayBill()
        {
            Console.WriteLine($"Your bill without tax = {this.bill}\nYour tax = {this.taxAmount}\nTotal Payable Bill = {this.taxAmount+this.bill}");
        }
    }
}
