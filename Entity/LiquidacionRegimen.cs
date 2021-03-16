using System;

namespace Entity
{
    public abstract class LiquidacionRegimen
    {

        private double numeroLiquidacion,valorServicio;
        private DateTime fechaLiquidacion;
        private double cuotaModeradora, tarifa, topeMax;
        private Paciente paciente; 

        public LiquidacionRegimen(Paciente paciente, double numeroLiquidacion, 
            double valorServicio, DateTime fechaLiquidacion, double cuotaModeradora, 
            double tarifa, double topeMax)
        {
            this.paciente = paciente;
            this.numeroLiquidacion = numeroLiquidacion;
            this.valorServicio = valorServicio;
            this.fechaLiquidacion = fechaLiquidacion;
            this.cuotaModeradora = cuotaModeradora;
            this.tarifa = tarifa;
            this.topeMax = topeMax;
        }
        
        //public LiquidacionRegimen(double numeroLiquidacion, double valorServicio,
        //    DateTime fechaLiquidacion, double cuotaModeradora, double tarifa, double topeMax)
        //{
        //    NumeroLiquidacion = numeroLiquidacion;
        //    ValorServicio = valorServicio;
        //    FechaLiquidacion = fechaLiquidacion;
        //    CuotaModeradora = cuotaModeradora;
        //    Tarifa = tarifa;
        //    TopeMax = topeMax;
        //}

    }
}
