using System;

namespace juegoSerpientesyEscaleras
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero t = new Tablero();
            Jugador j = new Jugador();
            t.tablero();
            string[] listaJugadores = j.jugadores();
            j.jugar(listaJugadores);
            
        }
    }
}

