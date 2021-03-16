using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class RegimenContributivo : Afiliacion
    {
        public Paciente paciente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double numeroLiquidacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime fechaLiquidacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double tarifa { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double cuotaModeradora { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double valorServicio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
