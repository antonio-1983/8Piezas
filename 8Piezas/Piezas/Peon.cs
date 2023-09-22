using _8Piezas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Piezas.Piezas
{
    public class Peon : IPieza
    {
        public bool SePuedeInsertar(int[][] tablero, int fila, int columna)
        {

            // Verificar la fila superior para evitar colisiones
            if (fila > 0 && tablero[fila - 1][columna] != 0)
                return false;

            // Verificar las diagonales superiores para evitar colisiones
            if (fila > 0)
            {
                if (columna > 0 && tablero[fila - 1][columna - 1] != 0)
                    return false;

                if (columna < 8 - 1 && tablero[fila - 1][columna + 1] != 0)
                    return false;
            }

            return true;
        }
        public override string ToString()
        {
            return "Peones";
        }

    }
}
