
using _8Piezas.Interfaces;

namespace _8Piezas
{
    public class Resolver
    {
        
        public void Resolver8Piezas(IPieza pieza)
        {
            int[][] tablero = new int[8][];
            for (int i = 0; i < 8; i++)
            {
                tablero[i] = new int[8];
            }
             

            bool InsertarPieza(int[][] tablero, int columna)
            {
                if (columna >= 8)
                    return true;//aca estan todas las reinas puestas y listas para imprimir el tablero

                for (int i = 0; i < 8; i++)
                {
                    if (pieza.SePuedeInsertar(tablero, i, columna))
                    {
                        tablero[i][columna] = 1;

                        if (InsertarPieza(tablero, columna + 1))
                        {
                            return true;
                        }

                        tablero[i][columna] = 0; // deshace el movimiento
                                                 
                    }
                }

                return false; // Si no se pueden colocar todas las reinas
            }

            if (InsertarPieza(tablero, 0))
            {
                Console.WriteLine("Solución 8 "+pieza);
                Console.WriteLine("0 - Casillero vacio ");
                Console.WriteLine("1 - Pieza insertada");
                Console.WriteLine("--------------------");
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(tablero[i][j] + "");
                    }
                    Console.WriteLine();
                }
            }

        }
        
        
    }
}


