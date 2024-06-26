﻿using Proyecto2.Mensajes;
using System;
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
        int[,] tablero = new int[6, 7]; //Tablero para visualizacion
        int[,] tableroJugador1 = new int[6, 7];// este tablero lleva se usa para calcular la victoria
        int[,] tableroJugador2 = new int[6, 7];// este tablero lleva se usa para calcular la victoria

        int turnoActual = 1;
        private Queue<string> turnos; // Cola para almacenar el orden de los turnos        
        private Stack<string> ordenJugadas; // Pila para almacenar el orden de las jugadas
        private Stack<int> victoriasJugador1 = new Stack<int>();
        private Stack<int> victoriasJugador2 = new Stack<int>();
        private string jugadorActual; // Nombre del jugador actual
        private bool mouseDown;
        private Point lastPos;
        int columnaSeleccionada = 0;
        int contColumna1 = 0;
        int contColumna2 = 0;
        int contColumna3 = 0;
        int contColumna4 = 0;
        int contColumna5 = 0;
        int contColumna6 = 0;
        int contColumna7 = 0;
        bool existePosicionVacia = false;
        private Queue<Object> Memoria = new Queue<Object>() ;


        public FRMJUEGO()
        {
            InitializeComponent();
            // Inicializar todos los elementos de la matriz en 0
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tablero[i, j] = 0;
                }
            }
        
             turnos = new Queue<string>(); // Inicialización de la cola
             ordenJugadas = new Stack<string>(); // Inicialización de la pila
            AgregarJugadoresACola(); // Llenar la cola con los nombres de los jugadores
            MezclarTurnos(); // Mezclar la cola para el primer turno aleatorio
            jugadorActual = ObtenerProximoTurno(); // Establecer el primer jugador como el jugador actual
            LlenarPilaJugadas(jugadorActual); // Llenar la pila con el primer jugador
            

        }
        private void CambiarTurno()
        {
            // Cambiar el turno al siguiente jugador
            turnoActual = (turnoActual == 1) ? 2 : 1;
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

        private void FRMJUEGO_Load(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = Jugador1.nombre;
            guna2HtmlLabel2.Text = Jugador2.nombre;
            guna2CirclePictureBox1.Image = Jugador1.Imagen;
            guna2CirclePictureBox2.Image = Jugador2.Imagen;

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //En esta región se controla las imagenes insertadas en el tablero
        #region Botones superiores
        private void Img_ficha1_Click_1(object sender, EventArgs e)
        {
            columnaSeleccionada = 0;
            ObtenerPosicionVacia(columnaSeleccionada);
            if (existePosicionVacia) 
            switch (contColumna1)
            {

                    //Se busca mediante un contador en que
                    //posición va la ficha correspondiente

                case 1:
                    F50.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha1.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 2:
                    F40.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha1.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                        }
                        else
                        {
                            tableroJugador2[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 3:
                    F30.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha1.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                        }
                        else
                        {
                            tableroJugador2[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 4:
                    F20.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha1.Image = ObtenerImagenSiguienteJugador();
                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                        }
                        else
                        {
                            tableroJugador2[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 5:
                    F10.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha1.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                        }
                        else
                        {
                            tableroJugador2[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 6:
                    F00.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha1.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                        }
                        else
                        {
                            tableroJugador2[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                default:
                        MessageBox.Show("La columna seleccionada está llena");
                        CambiarTurno();
                        break;
                        //En caso de ya haber recorrido las 6 filas muestra un
                        //mensaje de que la columna esta llena
                }
            }       
        private void Img_ficha2_Click_1(object sender, EventArgs e)
        {
            columnaSeleccionada = 1;
            ObtenerPosicionVacia(columnaSeleccionada);
            if (existePosicionVacia) 
                switch (contColumna2)
                {
                    case 1:
                    F51.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha2.Image = ObtenerImagenSiguienteJugador();
                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                    case 2:
                    F41.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha2.Image = ObtenerImagenSiguienteJugador();
                       
                        if (turnoActual == 1)
                        {
                            tableroJugador1[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                    case 3:
                    F31.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha2.Image = ObtenerImagenSiguienteJugador();
                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                    case 4:
                    F21.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha2.Image = ObtenerImagenSiguienteJugador();
                       
                        if (turnoActual == 1)
                        {
                            tableroJugador1[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                    case 5:
                    F11.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha2.Image = ObtenerImagenSiguienteJugador();                       
                        if (turnoActual == 1)
                        {
                            tableroJugador1[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                    case 6:
                    F01.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha2.Image = ObtenerImagenSiguienteJugador();                      
                        if (turnoActual == 1)
                        {
                            tableroJugador1[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                default:
                        MessageBox.Show("La columna seleccionada está llena");
                        CambiarTurno();
                        break;

                }
        }
        private void Img_ficha3_Click(object sender, EventArgs e)
        {
            columnaSeleccionada = 2;
            ObtenerPosicionVacia(columnaSeleccionada);
            if (existePosicionVacia) 
            switch (contColumna3)
            {
                case 1:
                    F52.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha3.Image = ObtenerImagenSiguienteJugador();
                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 2:
                    F42.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha3.Image = ObtenerImagenSiguienteJugador();                       
                        if (turnoActual == 1)
                        {
                            tableroJugador1[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 3:
                    F32.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha3.Image = ObtenerImagenSiguienteJugador();
                                                if (turnoActual == 1)
                        {
                            tableroJugador1[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 4:
                    F22.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha3.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 5:
                    F12.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha3.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 6:
                    F02.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha3.Image = ObtenerImagenSiguienteJugador();                       
                        if (turnoActual == 1)
                        {
                            tableroJugador1[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                default:
                    MessageBox.Show("La columna seleccionada está llena");
                        CambiarTurno();
                        break;
            }

        }
        private void Img_ficha4_Click(object sender, EventArgs e)
        {
            columnaSeleccionada = 3;
            ObtenerPosicionVacia(columnaSeleccionada);
            if (existePosicionVacia) 
            switch (contColumna4)
            {
                case 1:
                    F53.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha4.Image = ObtenerImagenSiguienteJugador();                      
                        if (turnoActual == 1)
                        {
                            tableroJugador1[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }

                        break;
                case 2:
                    F43.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha4.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 3:
                    F33.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha4.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 4:
                    F23.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha4.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 5:
                    F13.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha4.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 6:
                    F03.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha4.Image = ObtenerImagenSiguienteJugador();                       
                        if (turnoActual == 1)
                        {
                            tableroJugador1[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                default:
                        MessageBox.Show("La columna seleccionada está llena");
                        CambiarTurno();
                        break;
            }
        }
        private void Img_ficha5_Click(object sender, EventArgs e)
        {
            columnaSeleccionada = 4;
            ObtenerPosicionVacia(columnaSeleccionada);
            if (existePosicionVacia) 
            switch (contColumna5)
            {
                case 1:
                    F54.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha5.Image = ObtenerImagenSiguienteJugador();                        
                        if (turnoActual == 1)
                        {
                            tableroJugador1[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 2:
                    F44.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha5.Image = ObtenerImagenSiguienteJugador();                       
                        if (turnoActual == 1)
                        {
                            tableroJugador1[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 3:
                    F34.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha5.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 4:
                    F24.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha5.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 5:
                    F14.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha5.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 6:
                    F04.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha5.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                default:
                    MessageBox.Show("La columna seleccionada está llena");
                        CambiarTurno();
                        break;
            }
        }
        private void Img_ficha6_Click(object sender, EventArgs e)
        {
            columnaSeleccionada = 5;
            ObtenerPosicionVacia(columnaSeleccionada);
            if (existePosicionVacia) 
            switch (contColumna6)
            {
                case 1:
                    F55.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha6.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 2:
                    F45.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha6.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 3:
                    F35.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha6.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 4:
                    F25.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha6.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 5:
                    F15.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha6.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 6:
                    F05.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha6.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                default:
                    MessageBox.Show("La columna seleccionada está llena");
                        CambiarTurno();
                        break;
            }
        }
        private void Img_ficha7_Click(object sender, EventArgs e)
        {
            columnaSeleccionada = 6;
            ObtenerPosicionVacia(columnaSeleccionada);
            if (existePosicionVacia) 
            switch (contColumna7)
            {
                case 1:
                    F56.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha7.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[5, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 2:
                    F46.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha7.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[4, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 3:
                    F36.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha7.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[3, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 4:
                        F26.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha7.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[2, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 5:
                        F16.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha7.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                             
                        }
                        else
                        {
                            tableroJugador2[1, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                case 6:
                    F06.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                        Img_ficha7.Image = ObtenerImagenSiguienteJugador();
                        if (turnoActual == 1)
                        {
                            tableroJugador1[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador1, Jugador1.nombre);
                            
                        }
                        else
                        {
                            tableroJugador2[0, columnaSeleccionada] = 1;
                            DeterminarGanadorYGuardarEnPila(tableroJugador2, Jugador2.nombre);
                        }
                        break;
                default:
                    MessageBox.Show("La columna seleccionada está llena");
                        CambiarTurno();
                        break;
            }
            
        }
        #endregion


        #region Mover interfaz
        private void P_J1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastPos = MousePosition;
        }

        private void P_J1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int xoffset = MousePosition.X - lastPos.X;
                int yoffset = MousePosition.Y - lastPos.Y;
                Left += xoffset;
                Top += yoffset;
                lastPos = MousePosition;
            }
        }

        private void P_J1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion 


        #region Imagen de siguiente turno
        // funcion para obtener la imagen del jugador actual
        private Image ObtenerImagenSiguienteJugador()
        {
            // verificar el nombre del jugador actual y devolver la imagen correspondiente
            return (turnoActual == 1) ? Jugador2.Imagen : Jugador1.Imagen;
        }
        #endregion


        // En esta region se configura la funcion de morstrar la imagen del
        // jugador en el turno actual en las fichas superiores
        #region MostrarFichaMouse

        private void Img_ficha1_MouseEnter(object sender, EventArgs e)
        {
            Img_ficha1.Image = ObtenerImagenSiguienteJugador();
        }

        private void Img_ficha1_MouseLeave(object sender, EventArgs e)
        {
            Img_ficha1.Image = null;
        }
        private void Img_ficha2_MouseEnter(object sender, EventArgs e)
        {
            Img_ficha2.Image = ObtenerImagenSiguienteJugador();
        }

        private void Img_ficha2_MouseLeave(object sender, EventArgs e)
        {
            Img_ficha2.Image = null;
        }

        private void Img_ficha3_MouseEnter(object sender, EventArgs e)
        {
            Img_ficha3.Image = ObtenerImagenSiguienteJugador();
        }

        private void Img_ficha3_MouseLeave(object sender, EventArgs e)
        {
            Img_ficha3.Image = null;
        }

        private void Img_ficha4_MouseEnter(object sender, EventArgs e)
        {
            Img_ficha4.Image = ObtenerImagenSiguienteJugador();
        }

        private void Img_ficha4_MouseLeave(object sender, EventArgs e)
        {
            Img_ficha4.Image = null;
        }

        private void Img_ficha5_MouseEnter(object sender, EventArgs e)
        {
            Img_ficha5.Image = ObtenerImagenSiguienteJugador();
        }

        private void Img_ficha5_MouseLeave(object sender, EventArgs e)
        {
            Img_ficha5.Image = null;
        }

        private void Img_ficha6_MouseEnter(object sender, EventArgs e)
        {
            Img_ficha6.Image = ObtenerImagenSiguienteJugador();
        }

        private void Img_ficha6_MouseLeave(object sender, EventArgs e)
        {
            Img_ficha6.Image = null;
        }

        private void Img_ficha7_MouseEnter(object sender, EventArgs e)
        {
            Img_ficha7.Image = ObtenerImagenSiguienteJugador();
        }

        private void Img_ficha7_MouseLeave(object sender, EventArgs e)
        {
            Img_ficha7.Image = null;
        }


        #endregion



        #region Validacion de matriz

        public string ObtenerPosicionVacia(int columna)
        {
            // Recorre la columna desde abajo hasta arriba
            for (int fila = 5; fila >= 0; fila--)
            {
                // Si la posición esta vacia osea 0
                // Se busca la pocición en base a la fila definida
                // por el for y la columna seleccionada
                if (tablero[fila, columnaSeleccionada] == 0)
                {
                    // Coloca el ( 1 ) en esa posición
                    tablero[fila, columnaSeleccionada] = 1;





                    existePosicionVacia = true; // Marcamos que encontramos una posición vacía


                }
                //Logica para validar si un jugador ganó


            }
         
            switch (columnaSeleccionada)
                    {
                        case 0: contColumna1++; break;
                        case 1: contColumna2++; break;
                        case 2: contColumna3++; break;
                        case 3: contColumna4++; break;
                        case 4: contColumna5++; break;
                        case 5: contColumna6++; break;
                        case 6: contColumna7++; break;
                    }
            CambiarTurno(); // Cambia el turno al siguiente jugador
            if(existePosicionVacia)
            {
                return "Posición vacía encontrada";
            }
            else
            {
                return null;
            }
            
                          
            // Si todas las posiciones están llenas, retornamos nulo
            

        }

        #endregion
          
        private void btnNuevaRonda_Click(object sender, EventArgs e)
        {
            ReiniciarPartidas();
        }

        private void ReiniciarPartidas() 
        {
            // Recorrer todos los controles en la forma
            foreach (Control control in Controls)
            {
                // Verificar si el control es un PictureBox y no es guna2PictureBox1
                if (control is PictureBox pictureBox && pictureBox != guna2PictureBox1)
                {
                    // Establecer la imagen del PictureBox en null
                    pictureBox.Image = null;
                }
            }

            // Reiniciar los contadores de victorias a cero
            // Asegúrate de reemplazar estos nombres con los contadores de tu implementación
            contColumna1 = 0;
            contColumna2 = 0;
            contColumna3 = 0;
            contColumna4 = 0;
            contColumna5 = 0;
            contColumna6 = 0;
            contColumna7 = 0;

            LabelVictoriasJ1.Text = "0";
            LabelVictoriasJ2.Text = "0";

            // Limpiar la pila de orden de jugadas
            ordenJugadas.Clear();
        }
      

        public void LimpiarTabla()
        {
            // Recorrer todos los controles en la forma
            foreach (Control control in Controls)
            {
                // Verificar si el control es un PictureBox y no es guna2PictureBox1
                if (control is PictureBox pictureBox && pictureBox != guna2PictureBox1)
                {
                    // Establecer la imagen del PictureBox en null
                    pictureBox.Image = null;
                }
             
            }

            // Limpiar la matriz
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    tableroJugador1[i, j] = 0; // Asignar el valor predeterminado (0 en este caso)
                    tableroJugador2[i, j] = 0; // Asignar el valor predeterminado (0 en este caso)
                    tablero[i, j] = 0; // Asignar el valor predeterminado (0 en este caso)
                }
            }
            
            
            // Reiniciar los contadores de victorias a cero            
            contColumna1 = 0;
            contColumna2 = 0;
            contColumna3 = 0;
            contColumna4 = 0;
            contColumna5 = 0;
            contColumna6 = 0;
            contColumna7 = 0;

            ordenJugadas.Clear();
        }

        

        private void DeterminarGanadorYGuardarEnPila(int[,] TablaDeJugador,string Nombre)
        {
            // Utiliza la clase ControlVictoria para determinar si hay un ganador
            bool hayGanador = ControlVictoria.Gano(TablaDeJugador);

            // Obtiene el número de columna donde se realizó la jugada
            int columna = columnaSeleccionada + 1;

            // Construye el mensaje de la jugada
            string mensajeJugada = string.Format("Jugador {0}, movió en columna {1}, turno {2}", Nombre, columna, turnoActual);

            // Agrega el mensaje de la jugada al historial de jugadas
            ordenJugadas.Push(mensajeJugada);

            if (ordenJugadas.Count == 42)
            {
                // Si se alcanza el límite de movimientos, muestra un mensaje de empate
                MessageBox.Show("¡Empate! Se han realizado todos los movimientos posibles sin un ganador.", "Empate");

                // Limpia la tabla
                LimpiarTabla();
            }

            // Si hay un ganador, determina qué jugador ganó y guarda el resultado en la pila correspondiente
            if (hayGanador)
            {
                Mensajes.FRMNuevaRonda Victoria = new FRMNuevaRonda();
                if (turnoActual == 1)
                {
                    victoriasJugador1.Push(1); // Guarda un 1 en la pila del jugador 1
                   
                    LabelVictoriasJ1.Text = victoriasJugador1.Count.ToString(); // Actualiza la etiqueta con el número de victorias del jugador 1
                    Victoria.guna2HtmlLabel1.Text = "Ganador " + Nombre;
                    if(Victoria.esVisible != true)
                    {
                        Victoria.Show();
                    }
                   
                }
                else
                {
                    victoriasJugador2.Push(2); // Guarda un 2 en la pila del jugador 2
                    LabelVictoriasJ2.Text = victoriasJugador2.Count.ToString();
                    Victoria.guna2HtmlLabel1.Text = "Ganador " + Nombre;
                    if (Victoria.esVisible != true)
                    {
                        Victoria.Show();
                    }

                }
                // Aquí podrías mostrar un mensaje o realizar otras acciones cuando un jugador gana
            }

        }

        private void GuardarPartida(int[,] tableroJugador1, int[,] tableroJugador2, int contadorVictoriasJugador1, int contadorVictoriasJugador2, Stack<string> historialJugadas) 
        {

            try
            {
                // Crear una instancia de GuardarPartida con los datos actuales del juego
                GuardadoDePartida partidaGuardada = new GuardadoDePartida(tableroJugador1, tableroJugador2,
                                                                    contadorVictoriasJugador1, contadorVictoriasJugador2,
                                                                    new Stack<string>(historialJugadas));

                // Guardar la partida en la cola Guardar
                Memoria = partidaGuardada.Guardar(); 

                // Notificar al usuario que la partida se ha guardado correctamente
                Mensaje.MostrarMensaje(true,"Partida almacenada con éxito");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre algún problema durante el guardado
                Mensaje.MostrarMensaje(false,"Error al guardar la partida: " + ex.Message);
            }
        }

        public void GuardarEnCola(Queue<string> colaGuardar)
        {
            // Construir una cadena que represente los datos de la partida y agregarla a la cola
            string datosPartida = $"{tableroJugador1},{tableroJugador2},{LabelVictoriasJ1.Text},{LabelVictoriasJ2.Text}";
            colaGuardar.Enqueue(datosPartida);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GuardarPartida(tableroJugador1, tableroJugador2, int.Parse(LabelVictoriasJ1.Text), int.Parse(LabelVictoriasJ2.Text), ordenJugadas );
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Memoria.Count != 0)
                {
                    LimpiarTabla();
                    tableroJugador1 = (int[,])Memoria.Dequeue();
                    tableroJugador2 = (int[,])Memoria.Dequeue();
                    int j1 = (int)Memoria.Dequeue();
                    int j2 = (int)Memoria.Dequeue();

                    Stack<string> OrdenAnterior = (Stack<string>)Memoria.Dequeue();
                    turnoActual = 1;
                    foreach (string i in OrdenAnterior)
                    {
                        if (i.Contains(Jugador1.nombre))
                        {
                            jugadorActual = Jugador1.nombre;
                            if (i.Contains("columna 1")) { Img_ficha1_Click_1(this, e); }
                            else if (i.Contains("columna 2")) { Img_ficha2_Click_1(this, e); }
                            else if (i.Contains("columna 3")) { Img_ficha3_Click(this, e); }
                            else if (i.Contains("columna 4")) { Img_ficha4_Click(this, e); }
                            else if (i.Contains("columna 5")) { Img_ficha5_Click(this, e); }
                            else if (i.Contains("columna 6")) { Img_ficha6_Click(this, e); }
                            else if (i.Contains("columna 7")) { Img_ficha7_Click(this, e); }
                        }
                        else
                        {
                            jugadorActual = Jugador2.nombre;
                            if (i.Contains("columna 1")) { Img_ficha1_Click_1(this, e); }
                            else if (i.Contains("columna 2")) { Img_ficha2_Click_1(this, e); }
                            else if (i.Contains("columna 3")) { Img_ficha3_Click(this, e); }
                            else if (i.Contains("columna 4")) { Img_ficha4_Click(this, e); }
                            else if (i.Contains("columna 5")) { Img_ficha5_Click(this, e); }
                            else if (i.Contains("columna 6")) { Img_ficha6_Click(this, e); }
                            else if (i.Contains("columna 7")) { Img_ficha7_Click(this, e); }
                        }
                        Img_ficha1.Image = null;
                        Img_ficha2.Image = null;
                        Img_ficha3.Image = null;
                        Img_ficha4.Image = null;
                        Img_ficha5.Image = null;
                        Img_ficha6.Image = null;
                        Img_ficha7.Image = null;
                        LabelVictoriasJ1.Text = j1.ToString();
                        LabelVictoriasJ2.Text = j2.ToString();
                    }
                }
                else
                {
                    Mensaje.MostrarMensaje(false, "No hay partidas guardadas");
                }
            }
            catch(Exception ex)
            {
                Mensaje.MostrarMensaje(false, ex.Message);
            }

        }
    }

}



