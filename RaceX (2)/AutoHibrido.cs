using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX__2_
{
    public class AutoHibrido : Auto
    {
        public AutoHibrido() { Tipo = "Híbrido"; }

        public override int CalcularBonificacion(string clima)
        {
            return clima == "Ventoso" ? -1 : 0;
        }
    }
}
