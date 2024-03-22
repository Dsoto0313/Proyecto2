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
            int Consecutivo = 0; // Variable para rastrear la cantidad de elementos consecutivos iguales

            // Revision Vertical de arriba a abajo
            for (int v = 0; v < 7; v++) // Recorre verticalmente la matriz de arriba a abajo
            {
                for (int h = 0; h < 6; h++) // Recorre horizontalmente la matriz de izquierda a derecha
                {
                    if (Matriz[h, v] == 1) // Si el elemento es igual a 1
                    {
                        Consecutivo += 1; // Incrementa el contador de consecutivos
                    }
                    else
                    {
                        Consecutivo = 0; // Reinicia el contador si el elemento no es 1
                    }

                    if (Consecutivo == 4) // Si se encuentran 4 elementos consecutivos iguales
                    {
                        return true; // Hay un ganador, retorna verdadero
                    }
                }
            }
            Consecutivo = 0;
            // Revision Horizontal de izquierda a derecha
            for (int h = 0; h < 6; h++) // Recorre horizontalmente la matriz de izquierda a derecha
            {
                for (int v = 0; v < 7; v++) // Recorre verticalmente la matriz de arriba a abajo
                {
                    if (Matriz[h, v] == 1) // Si el elemento es igual a 1
                    {
                        Consecutivo += 1; // Incrementa el contador de consecutivos
                    }
                    else
                    {
                        Consecutivo = 0; // Reinicia el contador si el elemento no es 1
                    }

                    if (Consecutivo == 4) // Si se encuentran 4 elementos consecutivos iguales
                    {
                        return true; // Hay un ganador, retorna verdadero
                    }
                }
            }
            Consecutivo = 0;
            // Revision diagonal de izquierda a derecha
            for (int h = 0; h < 6; h++) // Recorre horizontalmente la matriz de izquierda a derecha
            {
                for (int v = 5; v >= 0; v--) // Recorre verticalmente la matriz de abajo a arriba
                {
                    if (v == 5 - h) // Verifica si está en la diagonal de izquierda a derecha
                    {
                        if (Matriz[h, v] == 1) // Si el elemento es igual a 1
                        {
                            Consecutivo += 1; // Incrementa el contador de consecutivos
                        }
                        else
                        {
                            Consecutivo = 0; // Reinicia el contador si el elemento no es 1
                        }

                        if (Consecutivo == 4) // Si se encuentran 4 elementos consecutivos iguales
                        {
                            return true; // Hay un ganador, retorna verdadero
                        }
                    }
                }
            }
            Consecutivo = 0;
            // Revision diagonal de derecha a izquierda
            for (int h = 0; h < 6; h++) // Recorre horizontalmente la matriz de izquierda a derecha
            {
                for (int v = 6; v >= 3; v--) // Recorre verticalmente la matriz de abajo a arriba
                {
                    if (v == 5 - h) // Verifica si está en la diagonal de derecha a izquierda
                    {
                        if (Matriz[h, v] == 1) // Si el elemento es igual a 1
                        {
                            Consecutivo += 1; // Incrementa el contador de consecutivos
                        }
                        else
                        {
                            Consecutivo = 0; // Reinicia el contador si el elemento no es 1
                        }

                        if (Consecutivo == 4) // Si se encuentran 4 elementos consecutivos iguales
                        {
                            return true; // Hay un ganador, retorna verdadero
                        }
                    }
                }
            }

            return false; // Si no se encuentra un ganador en ninguna dirección, retorna falso
        }
    }
}
