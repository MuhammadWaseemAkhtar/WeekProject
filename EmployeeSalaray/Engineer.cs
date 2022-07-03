using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaray
{
    class Engineer : Emplooye
    {
        public override void SetFuelAllowance()
        {
            this.fuelAllowance = 100;
        }

        public override void SetMedicalAllowance()
        {
            this.medicalAllowance = 500;
        }
    }
}
