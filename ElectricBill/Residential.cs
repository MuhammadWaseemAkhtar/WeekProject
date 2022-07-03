using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricBill
{
    class Residential : ElectricBill
    {
        public override void CalculateBill()
        {
            if(this.totalUnits > 500 )
            {
                this.bill += (totalUnits - 500) * 69;
                this.totalUnits = 500;
            }
            if(this.totalUnits > 200)
            {
                this.bill += (totalUnits - 200) * 23;
                this.totalUnits = 200;
            }
            if(this.totalUnits > 100)
            {
                this.bill += (totalUnits - 100) * 17;
                this.totalUnits = 100;
            }
            if (this.totalUnits > 0)
            {
                this.bill += totalUnits * 5;
            }

        }

        public override void CalculateTax()
        {
            this.taxAmount = (this.bill * this.taxPercent) / 100;
        }
    }
}
