using System;

namespace Entity
{
    public class Regimen
    {

        double numeroLiquidacion, valorServicio;
        DateTime fechaLiquidacion;
        double cuotaModeradora, tarifa, topeMax;

        public Regimen(double numeroLiquidacion, double valorServicio, DateTime fechaLiquidacion, double cuotaModeradora, double tarifa, double topeMax)
        {
            NumeroLiquidacion = numeroLiquidacion;
            ValorServicio = valorServicio;
            FechaLiquidacion = fechaLiquidacion;
            CuotaModeradora = cuotaModeradora;
            Tarifa = tarifa;
            TopeMax = topeMax;
        }

        public double NumeroLiquidacion { get; set ; }
        public double ValorServicio { get; set; }
        public DateTime FechaLiquidacion { get; set; }
        public double CuotaModeradora { get; set; }
        public double Tarifa { get; set; }
        public double TopeMax { get; set; }

    }
}
