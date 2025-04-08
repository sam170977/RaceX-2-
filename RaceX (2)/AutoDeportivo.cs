using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX__2_
{
    public class AutoDeportivo : Auto
    {
        public override int Avanzar(string clima)
        {
            Random rnd = new Random();
            int avanceBase = rnd.Next(10, 21); // 10 a 20
            int bonificacion = CalcularBonificacion(clima);
            return avanceBase + bonificacion;
        }

        protected override int CalcularBonificacion(string clima)
        {
            return clima == "Soleado" ? 3 : 0;
        }
    }
}