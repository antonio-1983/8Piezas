using _8Piezas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Piezas.Piezas
{
    public class Caballo : IPieza
    {
     
        //verificar si un caballo puede ser colocado en la posición (x, y)
        public bool SePuedeInsertar(int[][] tablero, int fila, int columna)
        {
            int[] dx = { -2, -1, 1, 2, 2, 1, -1, -2 };
            int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

            for (int i = 0; i < 8; i++)
            {
                int nuevaFila = fila + dx[i];
                int nuevaColumna = columna + dy[i];

                if (nuevaFila >= 0 && nuevaFila < 8 && nuevaColumna >= 0 && nuevaColumna < 8 && tablero[nuevaFila][nuevaColumna] == 1)
                    return false;
            }

            return true;
        }

        public override string ToString()
        {
            return "Caballos";
        }
    }
}
