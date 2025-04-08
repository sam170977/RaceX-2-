using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX__2_
{
    public class AutoTodoterreno : Auto
    {
        public override int Avanzar(string clima)
        {
            Random rnd = new Random();
            int avanceBase = rnd.Next(8, 19); // 8 a 18
            int bonificacion = CalcularBonificacion(clima);
            return avanceBase + bonificacion;
        }

        protected override int CalcularBonificacion(string clima)
        {
            return clima == "Lluvioso" ? 2 : 0;
        }
    }
}
