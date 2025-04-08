using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX__2_
{
    public abstract class Auto
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int DistanciaRecorrida { get; set; } = 0;

        public abstract int CalcularBonificacion(string clima);
        public abstract int Avanzar(string clima);

        //public virtual int Avanzar(string clima)
        //{
        //    Random rnd = new Random();

        //    int avanceBase = rnd.Next(5, 16); // 5 a 15
        //    int bonificacion = CalcularBonificacion(clima);

        //    return avanceBase + bonificacion;
        //}
    }
}
