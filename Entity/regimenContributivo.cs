using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class RegimenContributivo : LiquidacionRegimen
    {
        

        public double cuotaModeradora { get; set; }

        //public double calcularCuotaModeradora()
        //{
        //    cuotaModeradora = valorServicio * tarifa;
            
        //    if (cuotaModeradora > topeMax)
        //    {
        //        cuotaModeradora = topeMax;
        //    }

        //    return cuotaModeradora;
        //}
    }
}
