using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorioo_3
{

    public class AmigoSecreto
    {
        public int CantidadJugadores { get; set; }
        public Jugador[] Jugadores { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int NumeroDeJugadores { get; set; }
        public int FrecuenciaEndulzadasEnDias { get; set; }
        public decimal ValorEndulzada { get; set; }
        public decimal ValorRegalo { get; set; }
        public Dictionary<string, string> AmigosSecretos { get; set; }
        public Dictionary<string, string> GustosJugadores { get; set; }



        public AmigoSecreto(int cantidadJugadores)
        {
            if (cantidadJugadores <= 1)
            {
                throw new ArgumentException("Se requieren al menos dos jugadores para el juego de Amigo Secreto.");
            }

            CantidadJugadores = cantidadJugadores;
            Jugadores = new Jugador[cantidadJugadores];
        }

        public void AsignarJugadores(Jugador[] jugadores)
        {
            if (jugadores.Length != CantidadJugadores)
            {
                throw new Exception("La cantidad de jugadores proporcionados no coincide con la cantidad establecida.");
            }

            if (jugadores.Distinct().Count() != jugadores.Length)
            {
                throw new Exception("No deben existir jugadores duplicados.");
            }

            Jugadores = jugadores;

        }


    }
}

