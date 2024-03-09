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
            Jugador2.nombre = Txb_J2.Text;
            if (Abrir_Imagen.ShowDialog() == DialogResult.OK)
            {
                Jugador2.Imagen = Image.FromFile(Abrir_Imagen.FileName);
                Img_J2.Image = Jugador2.Imagen;
            }
        }

        private void Btn_AsignarJ2_Click(object sender, EventArgs e)
        {
            P_J1.Visible = false ;
            P_J2.Visible = true ;
            Btn_AsignarJ1.Visible = true;
            Btn_AsignarJ2.Visible = false;
            Btn_Jugar.Visible = true;
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
            FRMJUEGO Juego = new FRMJUEGO();
            Juego.Show();
            this.Hide();
        }
    }
}
