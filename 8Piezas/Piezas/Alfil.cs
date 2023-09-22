using _8Piezas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Piezas.Piezas
{
    public class Alfil : IPieza
    {
        public bool SePuedeInsertar(int[][] tablero, int fila, int columna)
        {
            // Verificar la diagonal superior izquierda
            for (int i = fila, j = columna; i >= 0 && j >= 0; i--, j--)
            {
                if (tablero[i][j] != 0)
                    return false;
            }

            // Verificar la diagonal superior derecha
            for (int i = fila, j = columna; i >= 0 && j < 8; i--, j++)
            {
                if (tablero[i][j] != 0)
                    return false;
            }

            // Verificar la diagonal inferior izquierda
            for (int i = fila, j = columna; i < 8 && j >= 0; i++, j--)
            {
                if (tablero[i][j] != 0)
                    return false;
            }

            // Verificar la diagonal inferior derecha
            for (int i = fila, j = columna; i < 8 && j < 8; i++, j++)
            {
                if (tablero[i][j] != 0)
                    return false;
            }

            return true;
        }

        public override string ToString()
        {
            return "Alfiles";
        }
    }
}
