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

            // Recorre todos los autos y avanza cada uno
            foreach (var auto in Autos)
            {
                // Verifica si la carrera ha terminado
                if (CarreraTerminada)
                    break;

                // Avanza el auto
                int avance = auto.Avanzar(Clima);

                // 30% de probabilidad de obstáculo
                bool obstaculo = rnd.Next(1, 101) <= 30;

                if (obstaculo)
                {
                    avance -= 5;
                    mensaje += $"{auto.Nombre} fue afectado por un obstáculo:\n avance reducido en 5 metros.\n";
                }

                auto.DistanciaRecorrida += Math.Max(0, avance);

                // Verifica si el auto ha alcanzado la meta
                if (auto.DistanciaRecorrida >= 150)
                {
                    CarreraTerminada = true;
                    Ganador = auto; 

                    mensaje += $"🏆 ¡{auto.Nombre} ha ganado la carrera!";
                }
            }

            return mensaje;
        }
    }
}
