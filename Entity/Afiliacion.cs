using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public interface Afiliacion
    {
        public double numeroLiquidacion { get; set; }
        public DateTime fechaLiquidacion { get; set; }
        public double tarifa { get; set; }
        public double cuotaModeradora { get; set; }
        public double valorServicio { get; set; }

    }
}
