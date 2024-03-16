using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Mensajes
{
    public static class Mensaje
    {
        public static void MostrarMensaje(bool Tipo,string Mensaje)
        {
            if (Tipo)
            {
                FRMEXITO exito = new FRMEXITO();
                exito.guna2HtmlLabel1.Text = Mensaje;
                exito.Show();
            }
            else
            {
                FRMERROR error = new FRMERROR();
                error.guna2HtmlLabel1.Text = Mensaje;
                error.Show();
            }
        }
    }
}
