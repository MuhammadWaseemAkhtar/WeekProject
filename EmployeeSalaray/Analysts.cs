using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaray
{
    class Analysts : Emplooye
    {
        public override void SetFuelAllowance()
        {
            this.fuelAllowance = 150;
        }

        public override void SetMedicalAllowance()
        {
            this.medicalAllowance = 800;
        }
    }
}
