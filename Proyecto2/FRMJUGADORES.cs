using Proyecto2.Mensajes;
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
    public partial class FRMJUGADORES : Form
    {
        private bool mouseDown;
        private Point lastPos;
        public FRMJUGADORES()
        {
            InitializeComponent();
        }

        private void Btn_Jugador1_Click(object sender, EventArgs e)
        {
            Jugador1.nombre = Txb_J1.Text;
            if(Abrir_Imagen.ShowDialog() == DialogResult.OK)
            {
                Jugador1.Imagen = Image.FromFile(Abrir_Imagen.FileName);
                Img_J1.Image = Jugador1.Imagen;
            }
            
          

        }

        private void Btn_J2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Abrir_Imagen.ShowDialog() == DialogResult.OK)
                {
                    Jugador2.Imagen = Image.FromFile(Abrir_Imagen.FileName);
                    Img_J2.Image = Jugador2.Imagen;
                }
            }
            catch (Exception ex)
            {
                Mensaje.MostrarMensaje(false, ex.Message);
            }
        }

        private void Btn_AsignarJ2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txb_J1.Text))
            {
                Mensaje.MostrarMensaje(false , "Debe escribir un nombre para el jugador 1");
            }
            else if(Jugador1.Imagen == null)
            {
                Mensaje.MostrarMensaje(false, "Seleccionar una ficha para el jugador 1");
            }
            else
            {
                P_J1.Visible = false;
                P_J2.Visible = true;
                Btn_AsignarJ1.Visible = true;
                Btn_AsignarJ2.Visible = false;
                Btn_Jugar.Visible = true;
                Mensaje.MostrarMensaje(true, "Jugador 1 agregado con éxito");
            }
            
        }

        private void Btn_AsignarJ1_Click(object sender, EventArgs e)
        {
            P_J1.Visible = true;
            P_J2.Visible = false ;
            Btn_AsignarJ1.Visible = false ;
            Btn_AsignarJ2.Visible = true;
            Btn_Jugar.Visible = false ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            P_J1.Visible = true;
            P_J2.Visible = false;
        }

        private void Btn_Jugar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txb_J2.Text))
            {
                Mensaje.MostrarMensaje(false, "Debe escribir un nombre para el jugador 2");
            }
            else if (Jugador2.Imagen == null)
            {
                Mensaje.MostrarMensaje(false, "Seleccionar una ficha para el jugador 2");
            }
            else
            {
                Jugador2.nombre = Txb_J2.Text;
                FRMJUEGO Juego = new FRMJUEGO();
                Juego.Show();
                this.Hide();
            }
        }

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

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txb_J2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
