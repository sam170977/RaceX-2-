using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX__2_
{
    public class AutoTodoterreno : Auto
    {
        public AutoTodoterreno() { Tipo = "Todoterreno"; }

        public override int CalcularBonificacion(string clima)
        {
            return clima == "Lluvia" ? 2 : 0;
        }
    }
}
