using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX__2_
{
    public class AutoDeportivo : Auto
    {
        public override int CalcularBonificacion(string clima)
        {
            return clima == "Soleado" ? 3 : 0;
        }
    }
}