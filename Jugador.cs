using System;
namespace juegoSerpientesyEscaleras
{
    public class Jugador
    {
        private int numJugadores;

        //Método que almacena cantidad y nombres de los usuarios
        public string[] jugadores()
        {
            string[] listaJugadores = new string[0];
            int a = 1;
            Console.WriteLine("¿Cuántos jugadores van a participar?");
            numJugadores = int.Parse(Console.ReadLine());
            //Guardar el nombre de cada jugador
            listaJugadores = new string[numJugadores];

            for (int i = 0; i < numJugadores; i++)
            {
                Console.WriteLine($"Ingresa el nombre del jugador número {a++}");
                listaJugadores[i] = Console.ReadLine();
            }
            Console.Clear();
            return listaJugadores;
        }

        //Método para lanzar DOS dados
        public int lanzarDados()
        {
            int sumaDados = 0;
            int dado_1 = 0;
            int dado_2 = 0;

            //Generar numeros al lanzar un dado
            var rd = new Random();
            dado_1 = rd.Next(1, 7);
            dado_2 = rd.Next(1, 7);
            sumaDados = dado_1 + dado_2;
            Console.WriteLine("LANZAMIENTO DE DADOS...");
            Console.Write($"el primer dado lanzado arroja: {dado_1},");
            Console.WriteLine($" el segundo dado lanzado arroja: {dado_2}");
            Console.WriteLine($"La suma de los dos dados lanzados es de {sumaDados}");

            return sumaDados;
        }

        //Método para jugar
        public int[] jugar(string[] listaJugadores)
        {
            int tirarDados = 0;
            int[] posiciones = new int[numJugadores];

            Tablero t = new Tablero();
            while (posiciones[0] < 100 || posiciones[1] < 100)
            {
                for (int i = 0; i < numJugadores; i++)
                {
                    Console.WriteLine($"¿{listaJugadores[i]}, estas en la posición {posiciones[i]} deseas tirar tus dados? (presiona 'y' para continuar, presionar cualquier letra para omitir)");
                    char entrada = char.Parse(Console.ReadLine());
                    if (entrada == 'y')
                    {
                        posiciones[i] += tirarDados = lanzarDados();
                        //Llamar al metodo para saber si caigo en escalera o serpiente
                        t.escaleraSerpiente(numJugadores, posiciones);
                        Console.WriteLine($"{listaJugadores[i]} Por lo tanto tu posicion será: {posiciones[i]}");
                        Console.WriteLine();
                        Console.WriteLine("-------------- SIGUIENTE TURNO --------------");
                        Console.WriteLine();
                        //Aqui deberia imprimirse el tablero mostrando las posiciones del jugador

                    }
                }
                if (posiciones[0] > 100)
                {
                    Console.WriteLine($"{listaJugadores[0]}, felicidades has ganado :)");
                    break;
                }
                else
                {
                    if (posiciones[1] > 100)
                    {
                        Console.WriteLine($"{listaJugadores[1]}, felicidades has ganado :)");
                        break;
                    }
                }
            }
            return posiciones;
        }
    }
}

