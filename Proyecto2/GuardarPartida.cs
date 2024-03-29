using System;
using System.Collections.Generic;

namespace Proyecto2
{
    internal class GuardarPartida
    {
        private int[,] tableroJugador1;
        private int[,] tableroJugador2;
        private int contadorVictoriasJugador1;
        private int contadorVictoriasJugador2;
        private Queue<string> queue;

        public GuardarPartida(int[,] tableroJugador1, int[,] tableroJugador2, int contadorVictoriasJugador1, int contadorVictoriasJugador2, Queue<string> queue)
        {
            this.tableroJugador1 = tableroJugador1;
            this.tableroJugador2 = tableroJugador2;
            this.contadorVictoriasJugador1 = contadorVictoriasJugador1;
            this.contadorVictoriasJugador2 = contadorVictoriasJugador2;
            this.queue = queue;
        }

        internal void GuardarEnCola(Queue<string> guardar)
        {
            throw new NotImplementedException();
        }
    }
}