﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto2.Jugadores;

namespace Proyecto2
{
    public partial class FRMJUEGO : Form
    {
        private Queue<string> turnos; // Cola para almacenar el orden de los turnos
        private Stack<string> ordenJugadas; // Pila para almacenar el orden de las jugadas
        private string jugadorActual; // Nombre del jugador actual

        public FRMJUEGO()
        {
            InitializeComponent();
            turnos = new Queue<string>(); // Inicialización de la cola
             ordenJugadas = new Stack<string>(); // Inicialización de la pila
            AgregarJugadoresACola(); // Llenar la cola con los nombres de los jugadores
            MezclarTurnos(); // Mezclar la cola para el primer turno aleatorio
            jugadorActual = ObtenerProximoTurno(); // Establecer el primer jugador como el jugador actual
            LlenarPilaJugadas(jugadorActual); // Llenar la pila con el primer jugador
        }
        public void AgregarJugadoresACola()
        {
            // Agregar los nombres de los jugadores a la cola
            turnos.Enqueue(Jugador1.nombre);
            turnos.Enqueue(Jugador2.nombre);
        }

        public string ObtenerProximoTurno()
        {
            // Verificar si hay elementos en la cola
            if (turnos.Count > 0)
            {
                // Obtener y remover el primer elemento de la cola
                return turnos.Dequeue();
            }
            else
            {
                // Si la cola está vacía, retornar null
                return null;
            }
        }
        private void MezclarTurnos()
        {
            // Generar números aleatorios para cada jugador
            Random rnd = new Random();
            int jugador1Numero = rnd.Next();
            int jugador2Numero = rnd.Next();

            // El jugador con el número aleatorio más bajo es el que inicia
            if (jugador1Numero < jugador2Numero)
            {
                // Si el número aleatorio de Jugador1 es menor, establecerlo como el jugador actual
                jugadorActual = Jugador1.nombre;
            }
            else
            {
                // Si el número aleatorio de Jugador2 es menor (o igual), establecerlo como el jugador actual
                jugadorActual = Jugador2.nombre;
            }
        }
        private void LlenarPilaJugadas(string jugador)
        {
            // Agregar el nombre del jugador actual a la pila de jugadas
            ordenJugadas.Push(jugador);
        }

        private void Img_ficha1_MouseEnter(object sender, EventArgs e)
        {
            Img_ficha1.Image = Jugador1.Imagen;
        }

        private void Img_ficha1_MouseLeave(object sender, EventArgs e)
        {
            Img_ficha1.Image = null;
        }

        private void FRMJUEGO_Load(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = Jugador1.nombre;
            guna2HtmlLabel2.Text = Jugador2.nombre;
            guna2CirclePictureBox1.Image = Jugador1.Imagen;
            guna2CirclePictureBox2.Image = Jugador2.Imagen;

        }
    }
}
