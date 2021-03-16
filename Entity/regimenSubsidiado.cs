using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class RegimenSubsidiado : LiquidacionRegimen
    {
       
        public double CuotaModeradora { get; set; }

        public double CalcularcuotaModeradora()
        {
            return 0.0; 
        }
    }
}
