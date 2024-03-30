using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2.Mensajes
{
    public partial class FRMNuevaRonda : Form
    {
        public FRMNuevaRonda()
        {
            InitializeComponent();
        }
        public bool esVisible { get; private set; }
        private void FRMEXITO_Load(object sender, EventArgs e)
        {
            esVisible = true;
            guna2GradientPanel1.Height = guna2GradientPanel1.Height + guna2HtmlLabel1.Height ;
           
        }     

   

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FRMJUEGO"] is FRMJUEGO activeForm)
            {
                // Llamar al método LimpiarTabla() en el formulario activo
                activeForm.LimpiarTabla();
                this.Close();
                esVisible = false;
            }
        }
    }
}
