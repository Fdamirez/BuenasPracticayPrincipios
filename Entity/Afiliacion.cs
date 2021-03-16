using System;

namespace Entity
{
    public interface Afiliacion
    {
        public Paciente paciente { get; set; }
        public double numeroLiquidacion { get; set; }
        public DateTime fechaLiquidacion { get; set; }
        public double tarifa { get; set; }
        public double topeMax { get; set; }
        public double valorServicio { get; set; }

        public double calculaTarifa()
        {
            double SSMLV = 908.526;

            if (paciente.salario < (2 * SSMLV))
            {
                tarifa = 0.15;
            }else if(paciente.salario >= (2 * SSMLV) && paciente.salario < (5 * SSMLV))
            {
                tarifa = 0.25;
            }else if (paciente.salario > (5 * SSMLV))
            {
                tarifa = 0.30;
            }

            return tarifa;
        }

    }
}
