using System;
using System.Collections.Generic;

namespace Proyecto2
{
    internal class GuardadoDePartida
    {
        private int[,] tableroJugador1 = new int[6,7];
        private int[,] tableroJugador2 = new int[6, 7];
        private int contadorVictoriasJugador1;
        private int contadorVictoriasJugador2;
        private Stack<string> Orden;
       


        public GuardadoDePartida(int[,] tableroJugador1, int[,] tableroJugador2, int contadorVictoriasJugador1, int contadorVictoriasJugador2, Stack<string> OrdenJugadas)
        {
            this.tableroJugador1 = tableroJugador1;
            this.tableroJugador2 = tableroJugador2;
            this.contadorVictoriasJugador1 = contadorVictoriasJugador1;
            this.contadorVictoriasJugador2 = contadorVictoriasJugador2;
            this.Orden  = OrdenJugadas ;

        }

        internal Queue<object> Guardar()
        {
            Queue<object> Memoria = new Queue<object>();
            Memoria.Enqueue(this.tableroJugador1);
            Memoria.Enqueue(this.tableroJugador2);
            Memoria.Enqueue(this.contadorVictoriasJugador1);
            Memoria.Enqueue(this.contadorVictoriasJugador2);
            Memoria.Enqueue(this.Orden);
            return Memoria;
        }


    }


}