using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _8Piezas.Interfaces;

namespace _8Piezas.Piezas
{
    public class Reina : IPieza
    {
        public bool SePuedeInsertar(int[][] tablero, int fila, int columna)
        {
        // Verificar la fila en la izquierda
        for (int i = 0; i < columna; i++)
        {
            if (tablero[fila][i] == 1)
            {
               return false;
            }

        }

        // Verificar la columna
        for (int i = 0; i < fila; i++)
        {
            if (tablero[i][columna] == 1)
            {
                return false;
            }

        }


        // Verificar la diagonal superior izquierda
        for (int i = fila, j = columna; i >= 0 && j >= 0; i--, j--)
        {
            if (tablero[i][j] == 1)
            {
                return false;
            }


        }

        // Verificar la diagonal inferior izquierda
        for (int i = fila, j = columna; i < 8 && j >= 0; i++, j--)
        {
            if (tablero[i][j] == 1)
            {
                return false;
            }

        }

        //agrego mas condiciones **************************************

        // Verificar la diagonal superior derecha
        for (int i = fila, j = columna; i >= 0 && j <= 0; i--, j++)
        {
            if (tablero[i][j] == 1)
            {
                return false;
            }

        }
        // Verificar la diagonal inferior derecha
        for (int i = fila, j = columna; i < 8 && j <= 0; i++, j++)
        {
            if (tablero[i][j] == 1)
            {
                return false;
            }

        }

            return true;
        }
        public override string ToString()
        {
            return "Reinas";
        }
    }
}
