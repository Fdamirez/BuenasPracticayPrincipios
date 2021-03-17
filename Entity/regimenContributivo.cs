using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class RegimenContributivo : Regimen 
    {

        double SMMLV = 908.526;

        public RegimenContributivo(double numeroLiquidacion, double valorServicio, DateTime fechaLiquidacion,
            double cuotaModeradora, double tarifa, double topeMax) : base 
            (numeroLiquidacion,valorServicio,fechaLiquidacion,cuotaModeradora,tarifa,topeMax)
        {
        
        }

        public void CalcularTarifa(double Salario)
        {


            if (Salario < (SMMLV * 2))
            {
                Tarifa = 0.15;
            }
            else if (Salario < (SMMLV * 5))
            {
                Tarifa = 0.20;
            }
            else if (Salario >= (SMMLV * 5))
            {
                Tarifa = 0.25;
            }

        }

        public void calculartopeMaximo(double Salario)
        {
            if (Salario < (SMMLV * 2))
            {
                TopeMax = 250000;
            }
            else if (Salario < (SMMLV * 5))
            {
                TopeMax = 0.20;
            }
            else if (Salario >= (SMMLV * 5))
            {
                TopeMax = 0.25;
            }
        }

        public void calcularCuotaModeladora()
        {
            CuotaModeradora = Tarifa * ValorServicio;
        }


    }
}
