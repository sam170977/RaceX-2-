using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX__2_
{
    public static class AutoFactory
    {
        public static Auto CrearAuto(string tipo, string nombre)
        {
            Auto auto;

            switch (tipo)
            {
                case "Deportivo":
                    auto = new AutoDeportivo()
                    {
                        Tipo = tipo
                    };
                    break;
                case "Todoterreno":
                    auto = new AutoTodoterreno()
                    {
                        Tipo = tipo
                    };
                    break;
                case "Híbrido":
                    auto = new AutoHibrido()
                    {
                        Tipo = tipo
                    };
                    break;
                default:
                    throw new ArgumentException("Tipo de auto no válido");
            }

            auto.Nombre = nombre;

            return auto;
        }
    }
}