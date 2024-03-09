
namespace Proyecto2
{
    partial class FRMJUGADORES
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Abrir_Imagen = new System.Windows.Forms.OpenFileDialog();
            this.P_J1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_Jugador1 = new Guna.UI2.WinForms.Guna2Button();
            this.Img_J1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Txb_J1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_AsignarJ2 = new Guna.UI2.WinForms.Guna2Button();
            this.P_J2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_J2 = new Guna.UI2.WinForms.Guna2Button();
            this.Img_J2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Txb_J2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_AsignarJ1 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Jugar = new Guna.UI2.WinForms.Guna2Button();
            this.P_J1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_J1)).BeginInit();
            this.P_J2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_J2)).BeginInit();
            this.SuspendLayout();
            // 
            // Abrir_Imagen
            // 
            this.Abrir_Imagen.FileName = "openFileDialog1";
            // 
            // P_J1
            // 
            this.P_J1.Controls.Add(this.Btn_Jugador1);
            this.P_J1.Controls.Add(this.Img_J1);
            this.P_J1.Controls.Add(this.Txb_J1);
            this.P_J1.Location = new System.Drawing.Point(46, 9);
            this.P_J1.Name = "P_J1";
            this.P_J1.Size = new System.Drawing.Size(434, 171);
            this.P_J1.TabIndex = 0;
            // 
            // Btn_Jugador1
            // 
            this.Btn_Jugador1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Jugador1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Jugador1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Jugador1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Jugador1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Jugador1.ForeColor = System.Drawing.Color.White;
            this.Btn_Jugador1.Location = new System.Drawing.Point(162, 69);
            this.Btn_Jugador1.Name = "Btn_Jugador1";
            this.Btn_Jugador1.Size = new System.Drawing.Size(180, 45);
            this.Btn_Jugador1.TabIndex = 2;
            this.Btn_Jugador1.Text = "Cargar Ficha J1";
            this.Btn_Jugador1.Click += new System.EventHandler(this.Btn_Jugador1_Click);
            // 
            // Img_J1
            // 
            this.Img_J1.ImageRotate = 0F;
            this.Img_J1.Location = new System.Drawing.Point(56, 42);
            this.Img_J1.Name = "Img_J1";
            this.Img_J1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Img_J1.Size = new System.Drawing.Size(100, 100);
            this.Img_J1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_J1.TabIndex = 1;
            this.Img_J1.TabStop = false;
            // 
            // Txb_J1
            // 
            this.Txb_J1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_J1.DefaultText = "";
            this.Txb_J1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_J1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_J1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_J1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_J1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_J1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_J1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_J1.Location = new System.Drawing.Point(66, 3);
            this.Txb_J1.Name = "Txb_J1";
            this.Txb_J1.PasswordChar = '\0';
            this.Txb_J1.PlaceholderText = "";
            this.Txb_J1.SelectedText = "";
            this.Txb_J1.Size = new System.Drawing.Size(284, 36);
            this.Txb_J1.TabIndex = 0;
            // 
            // Btn_AsignarJ2
            // 
            this.Btn_AsignarJ2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AsignarJ2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AsignarJ2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_AsignarJ2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_AsignarJ2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_AsignarJ2.ForeColor = System.Drawing.Color.White;
            this.Btn_AsignarJ2.Location = new System.Drawing.Point(310, 191);
            this.Btn_AsignarJ2.Name = "Btn_AsignarJ2";
            this.Btn_AsignarJ2.Size = new System.Drawing.Size(180, 45);
            this.Btn_AsignarJ2.TabIndex = 3;
            this.Btn_AsignarJ2.Text = "Asignar Jugador 2";
            this.Btn_AsignarJ2.Click += new System.EventHandler(this.Btn_AsignarJ2_Click);
            // 
            // P_J2
            // 
            this.P_J2.Controls.Add(this.Btn_J2);
            this.P_J2.Controls.Add(this.Img_J2);
            this.P_J2.Controls.Add(this.Txb_J2);
            this.P_J2.Location = new System.Drawing.Point(46, 9);
            this.P_J2.Name = "P_J2";
            this.P_J2.Size = new System.Drawing.Size(434, 171);
            this.P_J2.TabIndex = 3;
            this.P_J2.Visible = false;
            // 
            // Btn_J2
            // 
            this.Btn_J2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_J2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_J2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_J2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_J2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_J2.ForeColor = System.Drawing.Color.White;
            this.Btn_J2.Location = new System.Drawing.Point(162, 89);
            this.Btn_J2.Name = "Btn_J2";
            this.Btn_J2.Size = new System.Drawing.Size(180, 45);
            this.Btn_J2.TabIndex = 2;
            this.Btn_J2.Text = "Cargar Ficha J2";
            this.Btn_J2.Click += new System.EventHandler(this.Btn_J2_Click);
            // 
            // Img_J2
            // 
            this.Img_J2.ImageRotate = 0F;
            this.Img_J2.Location = new System.Drawing.Point(44, 59);
            this.Img_J2.Name = "Img_J2";
            this.Img_J2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Img_J2.Size = new System.Drawing.Size(100, 100);
            this.Img_J2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_J2.TabIndex = 1;
            this.Img_J2.TabStop = false;
            // 
            // Txb_J2
            // 
            this.Txb_J2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_J2.DefaultText = "";
            this.Txb_J2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_J2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_J2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_J2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_J2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_J2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_J2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_J2.Location = new System.Drawing.Point(66, 17);
            this.Txb_J2.Name = "Txb_J2";
            this.Txb_J2.PasswordChar = '\0';
            this.Txb_J2.PlaceholderText = "";
            this.Txb_J2.SelectedText = "";
            this.Txb_J2.Size = new System.Drawing.Size(284, 36);
            this.Txb_J2.TabIndex = 0;
            // 
            // Btn_AsignarJ1
            // 
            this.Btn_AsignarJ1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AsignarJ1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AsignarJ1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_AsignarJ1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_AsignarJ1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_AsignarJ1.ForeColor = System.Drawing.Color.White;
            this.Btn_AsignarJ1.Location = new System.Drawing.Point(34, 191);
            this.Btn_AsignarJ1.Name = "Btn_AsignarJ1";
            this.Btn_AsignarJ1.Size = new System.Drawing.Size(180, 45);
            this.Btn_AsignarJ1.TabIndex = 4;
            this.Btn_AsignarJ1.Text = "Configuarar Jugador 1";
            this.Btn_AsignarJ1.Visible = false;
            this.Btn_AsignarJ1.Click += new System.EventHandler(this.Btn_AsignarJ1_Click);
            // 
            // Btn_Jugar
            // 
            this.Btn_Jugar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Jugar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Jugar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Jugar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Jugar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Jugar.ForeColor = System.Drawing.Color.White;
            this.Btn_Jugar.Location = new System.Drawing.Point(310, 191);
            this.Btn_Jugar.Name = "Btn_Jugar";
            this.Btn_Jugar.Size = new System.Drawing.Size(180, 45);
            this.Btn_Jugar.TabIndex = 5;
            this.Btn_Jugar.Text = "Jugar";
            this.Btn_Jugar.Visible = false;
            this.Btn_Jugar.Click += new System.EventHandler(this.Btn_Jugar_Click);
            // 
            // FRMJUGADORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 248);
            this.Controls.Add(this.Btn_Jugar);
            this.Controls.Add(this.Btn_AsignarJ1);
            this.Controls.Add(this.P_J2);
            this.Controls.Add(this.Btn_AsignarJ2);
            this.Controls.Add(this.P_J1);
            this.Name = "FRMJUGADORES";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.P_J1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_J1)).EndInit();
            this.P_J2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_J2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog Abrir_Imagen;
        private Guna.UI2.WinForms.Guna2Panel P_J1;
        private Guna.UI2.WinForms.Guna2Button Btn_Jugador1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Img_J1;
        private Guna.UI2.WinForms.Guna2TextBox Txb_J1;
        private Guna.UI2.WinForms.Guna2Button Btn_AsignarJ2;
        private Guna.UI2.WinForms.Guna2Panel P_J2;
        private Guna.UI2.WinForms.Guna2Button Btn_J2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Img_J2;
        private Guna.UI2.WinForms.Guna2TextBox Txb_J2;
        private Guna.UI2.WinForms.Guna2Button Btn_AsignarJ1;
        private Guna.UI2.WinForms.Guna2Button Btn_Jugar;
    }
}

