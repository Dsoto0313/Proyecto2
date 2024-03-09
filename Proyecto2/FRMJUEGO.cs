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
        public FRMJUEGO()
        {
            InitializeComponent();
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
