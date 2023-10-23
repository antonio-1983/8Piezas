using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Piezas.Interfaces
{
    public interface IPieza
    {
        bool SePuedeInsertar(int[][] tablero, int fila, int columna);

    }
}
