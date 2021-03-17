using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class RegimenSubsidiado : Regimen 
    {
        double SMMLV = 908.526;

        public RegimenSubsidiado(double numeroLiquidacion, double valorServicio, DateTime fechaLiquidacion,
            double cuotaModeradora, double tarifa, double topeMax) : base
            (numeroLiquidacion, valorServicio, fechaLiquidacion, cuotaModeradora, tarifa, topeMax)
        {

        }

        public void calcularCuotaModeladora()
        {
            Tarifa = 0.05;
            TopeMax = 200000;
            CuotaModeradora = Tarifa * ValorServicio;

            if (TopeMax < CuotaModeradora)
            {
                CuotaModeradora = TopeMax; 
            }

        }

    }
}
