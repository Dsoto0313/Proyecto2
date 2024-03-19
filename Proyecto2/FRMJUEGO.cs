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
        int[,] tablero = new int[6, 7];
        int turnoActual = 1;
        private Queue<string> turnos; // Cola para almacenar el orden de los turnos
        private Stack<string> ordenJugadas; // Pila para almacenar el orden de las jugadas
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
                    break;
                case 2:
                    F40.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 3:
                    F30.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 4:
                    F20.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 5:
                    F10.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 6:
                    F00.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
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
                    break;
                    case 2:
                    F41.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                    case 3:
                    F31.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                    case 4:
                    F21.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                    case 5:
                    F11.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                    case 6:
                    F01.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
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
                    break;
                case 2:
                    F42.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 3:
                    F32.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 4:
                    F22.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 5:
                    F12.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 6:
                    F02.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
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
                    break;
                case 2:
                    F43.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 3:
                    F33.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 4:
                    F23.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 5:
                    F13.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 6:
                    F03.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
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
                    break;
                case 2:
                    F44.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 3:
                    F34.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 4:
                    F24.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 5:
                    F14.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 6:
                    F04.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
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
                    break;
                case 2:
                    F45.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 3:
                    F35.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 4:
                    F25.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 5:
                    F15.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 6:
                    F05.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
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
                    break;
                case 2:
                    F46.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 3:
                    F36.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 4:
                    F26.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 5:
                    F16.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                case 6:
                    F06.Image = (turnoActual == 1) ? Jugador1.Imagen : Jugador2.Imagen;
                    break;
                default:
                    MessageBox.Show("La columna seleccionada está llena");
                        CambiarTurno();
                        break;
            }
        }
        #endregion 



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


                    //Logica para validar si un jugador ganó
                    //if (ControlVictoria.Gano(tablero))
                    //{
                    // Si alguien gana aqui se puede imprimir el mensaje
                    //MessageBox.Show("El jugador " + turnoActual + " ganó");
                    //}

                    existePosicionVacia = true; // Marcamos que encontramos una posición vacía


                }
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
            return "Posición vacía encontrada";
                          
            // Si todas las posiciones están llenas, retornamos nulo
            return null;

        }
    #endregion  


    }

}



