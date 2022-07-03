using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaray
{
    class Manager : Emplooye
    {
        public override void SetFuelAllowance()
        {
            this.fuelAllowance = 250;
        }

        public override void SetMedicalAllowance()
        {
            this.medicalAllowance = 1000;
        }
    }
}
