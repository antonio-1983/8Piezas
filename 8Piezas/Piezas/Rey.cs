using _8Piezas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Piezas.Piezas
{
    public class Rey : IPieza
    {

        public bool SePuedeInsertar(int[][] tablero, int fila, int columna)
        {
            // Verificar si hay un rey en la misma fila o columna
            for (int i = 0; i < 8; i++)
            {
                if (tablero[fila][i] != 0 || tablero[i][columna] != 0)
                    return false;
            }

            // Verificar las diagonales
            for (int i = fila, j = columna; i >= 0 && j >= 0; i--, j--)
            {
                if (tablero[i][j] != 0)
                    return false;
            }

            for (int i = fila, j = columna; i < 8 && j < 8; i++, j++)
            {
                if (tablero[i][j] != 0)
                    return false;
            }

            for (int i = fila, j = columna; i >= 0 && j < 8; i--, j++)
            {
                if (tablero[i][j] != 0)
                    return false;
            }

            for (int i = fila, j = columna; i < 8 && j >= 0; i++, j--)
            {
                if (tablero[i][j] != 0)
                    return false;
            }

            return true;
        }
        public override string ToString()
        {
            return "Reyes";
        }
    }
}
