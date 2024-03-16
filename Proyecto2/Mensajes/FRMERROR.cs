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
    public partial class FRMERROR : Form
    {
        public FRMERROR()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value -= 1;

        if( guna2ProgressBar1.Value == 0){
                timer.Stop();
             Close();
            }
            

        else if( guna2ProgressBar1.Value < 20)
            {
                Opacity -= 0.1;
            }
            
        else
            {
                Show();
            }
            
        
        }

        private void FRMERROR_Load(object sender, EventArgs e)
        {
            guna2GradientPanel1.Height = guna2GradientPanel1.Height + guna2HtmlLabel1.Height;
            timer.Start();
        }
    }
}
