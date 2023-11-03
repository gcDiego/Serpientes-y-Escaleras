using System;
namespace juegoSerpientesyEscaleras
{
    public class Tablero
    {
        public Tablero()
        {
        }
        
        //Método para crear mi tablero, empieza en la posicion 0,0 (esquina superior izquierda)
        public string[,] tablero()
        {
            string[,] tablero = new string[10, 10];
            int a = 00;
            Console.WriteLine("--- TABLERO ---");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (a < 10)
                    {
                        tablero[i, j] = $"[0{a++}]";
                    }
                    else
                    {
                        tablero[i, j] = $"[{a++}]";
                    }
                    Console.Write(string.Format("{0}", tablero[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            return tablero;
        }

        //Metodo para saber si estoy en una escalera o serpinte
        public int[] escaleraSerpiente(int nJ, int[] p)
        {
            int[] posicion = p;
            //aqui me quede, aplicar un switch case
            for(int i = 0; i < nJ; i++)
            {
                switch (posicion[i])
                {
                    /*Casillas para serpientes*/
                    case 24:
                        Console.WriteLine("Has caído en una SERPIENTE");
                        posicion[i] = 4;
                        break;
                    case 33:
                        Console.WriteLine("Has caído en una SERPIENTE");
                        posicion[i] = 0;
                        break;
                    case 46:
                        Console.WriteLine("Has caído en una SERPIENTE");
                        posicion[i] = 18;
                        break;
                    case 64:
                        Console.WriteLine("Has caído en una SERPIENTE");
                        posicion[i] = 51;
                        break;
                    case 86:
                        Console.WriteLine("Has caído en una SERPIENTE");
                        posicion[i] = 56;
                        break;
                    case 90:
                        Console.WriteLine("Has caído en una SERPIENTE");
                        posicion[i] = 60;
                        break;
                    case 98:
                        Console.WriteLine("Has caído en una SERPIENTE");
                        posicion[i] = 68;
                        break;
                    /*Casillas para escaleras*/
                    case 2:
                        Console.WriteLine("Has caído en una ESCALERA");
                        posicion[i] = 50;
                        break;
                    case 5:
                        Console.WriteLine("Has caído en una ESCALERA");
                        posicion[i] = 26;
                        break;
                    case 19:
                        Console.WriteLine("Has caído en una ESCALERA");
                        posicion[i] = 59;
                        break;
                    case 35:
                        Console.WriteLine("Has caído en una ESCALERA");
                        posicion[i] = 54;
                        break;
                    case 62:
                        Console.WriteLine("Has caído en una ESCALERA");
                        posicion[i] = 94;
                        break;
                    case 68:
                        Console.WriteLine("Has caído en una ESCALERA");
                        posicion[i] = 97;
                        break;
                }
            }
            return posicion;
        }
    }
}