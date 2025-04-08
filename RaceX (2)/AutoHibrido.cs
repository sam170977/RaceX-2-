﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX__2_
{
    public class AutoHibrido : Auto
    {
        public override int Avanzar(string clima)
        {
            Random rnd = new Random();
            int avanceBase = rnd.Next(5, 16); // 5 a 15
            int bonificacion = CalcularBonificacion(clima);
            return avanceBase + bonificacion;
        }

        public override int CalcularBonificacion(string clima)
        {
            return clima == "Ventoso" ? -1 : 0;
        }
    }
}
