using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX__2_
{
    public class Carrera
    {
        public List<Auto> Autos { get; set; } = new List<Auto>();
        public string Clima { get; set; }
        public bool CarreraTerminada { get; private set; } = false;
        public Auto Ganador { get; private set; } 

        private Random rnd = new Random();

        public string SiguienteTurno()
        {
            string mensaje = "";

            foreach (var auto in Autos)
            {
                if (CarreraTerminada)
                    break;

                int avance = auto.Avanzar(Clima);

                // 30% de probabilidad de obstáculo
                bool obstaculo = rnd.Next(1, 101) <= 30;

                if (obstaculo)
                {
                    avance -= 5;
                    mensaje += $"{auto.Nombre} fue afectado por un obstáculo: avance reducido en 5 metros.\n";
                }

                auto.DistanciaRecorrida += Math.Max(0, avance);

                if (auto.DistanciaRecorrida >= 150)
                {
                    CarreraTerminada = true;
                    Ganador = auto; 
                    mensaje += $"\n🏆 ¡{auto.Nombre} ha ganado la carrera!";
                }
            }

            return mensaje;
        }

        public void Reiniciar()
        {
            foreach (var auto in Autos)
                auto.DistanciaRecorrida = 0;

            CarreraTerminada = false;
            Ganador = null; 
        }
    }
}
