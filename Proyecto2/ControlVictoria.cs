using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class ControlVictoria
    {
        public static bool Gano(int[,] Matriz)
        {
           

            // Revision Vertical de arriba a abajo
            for (int v = 0; v < Matriz.GetLength(1) ; v++) // Recorre verticalmente la matriz de arriba a abajo
            {
                for (int h = 0; h <= Matriz.GetLength(0)-4; h++) // Recorre horizontalmente la matriz de izquierda a derecha
                {
                    if (Matriz[h, v] == 1 && // Si el elemento es igual a 1
                        Matriz[h + 1, v] == 1 && // Si el siguiente elemento en la columna es igual a 1
                        Matriz[h + 2, v] == 1 && // Si el siguiente elemento en la columna es igual a 1
                        Matriz[h + 3, v] == 1) // Si el siguiente elemento en la columna es igual a 1
                    {
                        // Si se encuentra una secuencia de cuatro unos consecutivos en vertical, retornar true
                        return true;
                    }

                }
            }

            // Revision Horizontal de izquierda a derecha
            for (int h = 0; h < Matriz.GetLength(0); h++) // Recorre horizontalmente la matriz de izquierda a derecha
            {
                for (int v = 0; v < Matriz.GetLength(1)-4; v++) // Recorre verticalmente la matriz de arriba a abajo
                {
                    if (Matriz[h, v] == 1 && // Si el elemento es igual a 1
                        Matriz[h, v + 1] == 1 && // Si el siguiente elemento en la fila es igual a 1
                        Matriz[h, v + 2] == 1 && // Si el siguiente elemento en la fila es igual a 1
                        Matriz[h, v + 3] == 1) // Si el siguiente elemento en la fila es igual a 1
                    {
                        // Si se encuentra una secuencia de cuatro unos consecutivos horizontalmente, retornar true
                        return true;
                    }
                }
            }

            // Revisión diagonal de izquierda a derecha
            for (int h = 0; h < 3; h++) // Recorre verticalmente la matriz hasta la fila 3
            {
                for (int v = 0; v < 4; v++) // Recorre horizontalmente la matriz hasta la columna 4
                {
                    if (Matriz[h, v] == 1 && // Verifica si el elemento actual es 1
                        Matriz[h + 1, v + 1] == 1 && // Verifica el siguiente elemento en la diagonal
                        Matriz[h + 2, v + 2] == 1 && // Verifica el siguiente elemento en la diagonal
                        Matriz[h + 3, v + 3] == 1) // Verifica el siguiente elemento en la diagonal
                    {
                        return true; // Si se encuentra una secuencia de cuatro elementos iguales en la diagonal, retorna verdadero
                    }
                }
            }

           
            // Revision diagonal de derecha a izquierda
            for (int h = 0; h < 3; h++) // Recorre verticalmente la matriz hasta la fila 3
            {
                for (int v = 3; v < 7; v++) // Recorre horizontalmente la matriz desde la columna 3 hasta la columna 6
                {
                    if (Matriz[h, v] == 1 && // Verifica si el elemento actual es 1
                        Matriz[h + 1, v - 1] == 1 && // Verifica el siguiente elemento en la diagonal
                        Matriz[h + 2, v - 2] == 1 && // Verifica el siguiente elemento en la diagonal
                        Matriz[h + 3, v - 3] == 1) // Verifica el siguiente elemento en la diagonal
                    {
                        return true; // Si se encuentra una secuencia de cuatro elementos iguales en la diagonal, retorna verdadero
                    }
                }
            }

            return false; // Si no se encuentra un ganador en ninguna dirección, retorna falso
        }
    }
}
