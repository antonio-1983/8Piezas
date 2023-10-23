using _8Piezas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Piezas.Piezas
{
    public class PiezaSinSolucion :  IPieza
    {
        public bool SePuedeInsertar(int[][] tablero, int fila, int columna)
        {
            // Verificar la fila y columna 
            for (int i = 0; i < 8; i++)
            {
                if (tablero[fila][i] != 0 || tablero[i][columna] != 0)
                    return false;
            }

            return false;//cambie por false
        }
    }
}
