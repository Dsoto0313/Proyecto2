
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
            this.Btn_Cerrar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_Jugador1 = new Guna.UI2.WinForms.Guna2Button();
            this.Img_J1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Txb_J1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_AsignarJ2 = new Guna.UI2.WinForms.Guna2Button();
            this.P_J2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_J2 = new Guna.UI2.WinForms.Guna2Button();
            this.Img_J2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Txb_J2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_AsignarJ1 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Jugar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.P_J1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_J1)).BeginInit();
            this.P_J2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_J2)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Abrir_Imagen
            // 
            this.Abrir_Imagen.FileName = "openFileDialog1";
            // 
            // P_J1
            // 
            this.P_J1.BackColor = System.Drawing.Color.Transparent;
            this.P_J1.BorderColor = System.Drawing.Color.White;
            this.P_J1.BorderRadius = 10;
            this.P_J1.BorderThickness = 2;
            this.P_J1.Controls.Add(this.Btn_Cerrar);
            this.P_J1.Controls.Add(this.guna2HtmlLabel1);
            this.P_J1.Controls.Add(this.Btn_Jugador1);
            this.P_J1.Controls.Add(this.Img_J1);
            this.P_J1.Controls.Add(this.Txb_J1);
            this.P_J1.FillColor = System.Drawing.Color.SteelBlue;
            this.P_J1.Location = new System.Drawing.Point(17, 9);
            this.P_J1.Name = "P_J1";
            this.P_J1.Size = new System.Drawing.Size(434, 262);
            this.P_J1.TabIndex = 0;
            this.P_J1.UseTransparentBackground = true;
            this.P_J1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_J1_MouseDown);
            this.P_J1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_J1_MouseMove);
            this.P_J1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_J1_MouseUp);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackgroundImage = global::Proyecto2.Properties.Resources.ch5;
            this.Btn_Cerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Cerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Cerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Cerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Cerrar.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cerrar.Location = new System.Drawing.Point(399, 3);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Cerrar.TabIndex = 4;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(168, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(97, 24);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Jugador 1";
            // 
            // Btn_Jugador1
            // 
            this.Btn_Jugador1.AutoRoundedCorners = true;
            this.Btn_Jugador1.BorderColor = System.Drawing.Color.White;
            this.Btn_Jugador1.BorderRadius = 21;
            this.Btn_Jugador1.BorderThickness = 1;
            this.Btn_Jugador1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Jugador1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Jugador1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Jugador1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Jugador1.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Jugador1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Jugador1.ForeColor = System.Drawing.Color.White;
            this.Btn_Jugador1.Location = new System.Drawing.Point(134, 203);
            this.Btn_Jugador1.Name = "Btn_Jugador1";
            this.Btn_Jugador1.Size = new System.Drawing.Size(180, 45);
            this.Btn_Jugador1.TabIndex = 2;
            this.Btn_Jugador1.Text = "Cargar Ficha";
            this.Btn_Jugador1.UseTransparentBackground = true;
            this.Btn_Jugador1.Click += new System.EventHandler(this.Btn_Jugador1_Click);
            // 
            // Img_J1
            // 
            this.Img_J1.Image = global::Proyecto2.Properties.Resources.USER;
            this.Img_J1.ImageRotate = 0F;
            this.Img_J1.Location = new System.Drawing.Point(174, 96);
            this.Img_J1.Name = "Img_J1";
            this.Img_J1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Img_J1.Size = new System.Drawing.Size(100, 100);
            this.Img_J1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_J1.TabIndex = 1;
            this.Img_J1.TabStop = false;
            this.Img_J1.UseTransparentBackground = true;
            // 
            // Txb_J1
            // 
            this.Txb_J1.AutoRoundedCorners = true;
            this.Txb_J1.BorderRadius = 16;
            this.Txb_J1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_J1.DefaultText = "";
            this.Txb_J1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_J1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_J1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_J1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_J1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_J1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Txb_J1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_J1.Location = new System.Drawing.Point(39, 54);
            this.Txb_J1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txb_J1.Name = "Txb_J1";
            this.Txb_J1.PasswordChar = '\0';
            this.Txb_J1.PlaceholderText = "Ingrese el nombre del jugador 1";
            this.Txb_J1.SelectedText = "";
            this.Txb_J1.Size = new System.Drawing.Size(371, 35);
            this.Txb_J1.TabIndex = 0;
            this.Txb_J1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_AsignarJ2
            // 
            this.Btn_AsignarJ2.AutoRoundedCorners = true;
            this.Btn_AsignarJ2.BackColor = System.Drawing.Color.Transparent;
            this.Btn_AsignarJ2.BorderColor = System.Drawing.Color.White;
            this.Btn_AsignarJ2.BorderRadius = 21;
            this.Btn_AsignarJ2.BorderThickness = 1;
            this.Btn_AsignarJ2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AsignarJ2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AsignarJ2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_AsignarJ2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_AsignarJ2.FillColor = System.Drawing.Color.SteelBlue;
            this.Btn_AsignarJ2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_AsignarJ2.ForeColor = System.Drawing.Color.White;
            this.Btn_AsignarJ2.Location = new System.Drawing.Point(99, 30);
            this.Btn_AsignarJ2.Name = "Btn_AsignarJ2";
            this.Btn_AsignarJ2.Size = new System.Drawing.Size(245, 45);
            this.Btn_AsignarJ2.TabIndex = 3;
            this.Btn_AsignarJ2.Text = "Asignar Jugador 2";
            this.Btn_AsignarJ2.UseTransparentBackground = true;
            this.Btn_AsignarJ2.Click += new System.EventHandler(this.Btn_AsignarJ2_Click);
            // 
            // P_J2
            // 
            this.P_J2.BackColor = System.Drawing.Color.Teal;
            this.P_J2.BorderColor = System.Drawing.Color.White;
            this.P_J2.BorderRadius = 10;
            this.P_J2.BorderThickness = 2;
            this.P_J2.Controls.Add(this.guna2CircleButton1);
            this.P_J2.Controls.Add(this.guna2HtmlLabel2);
            this.P_J2.Controls.Add(this.Btn_J2);
            this.P_J2.Controls.Add(this.Img_J2);
            this.P_J2.Controls.Add(this.Txb_J2);
            this.P_J2.Location = new System.Drawing.Point(17, 6);
            this.P_J2.Name = "P_J2";
            this.P_J2.Size = new System.Drawing.Size(434, 262);
            this.P_J2.TabIndex = 3;
            this.P_J2.Visible = false;
            this.P_J2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_J1_MouseDown);
            this.P_J2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_J1_MouseMove);
            this.P_J2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_J1_MouseUp);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackgroundImage = global::Proyecto2.Properties.Resources.ch5;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(399, 3);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.TabIndex = 5;
            this.guna2CircleButton1.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(171, 20);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(97, 24);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Jugador 2";
            // 
            // Btn_J2
            // 
            this.Btn_J2.AutoRoundedCorners = true;
            this.Btn_J2.BackColor = System.Drawing.Color.Transparent;
            this.Btn_J2.BorderColor = System.Drawing.Color.White;
            this.Btn_J2.BorderRadius = 21;
            this.Btn_J2.BorderThickness = 1;
            this.Btn_J2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_J2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_J2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_J2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_J2.FillColor = System.Drawing.Color.SteelBlue;
            this.Btn_J2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_J2.ForeColor = System.Drawing.Color.White;
            this.Btn_J2.Location = new System.Drawing.Point(129, 203);
            this.Btn_J2.Name = "Btn_J2";
            this.Btn_J2.Size = new System.Drawing.Size(180, 45);
            this.Btn_J2.TabIndex = 2;
            this.Btn_J2.Text = "Cargar Ficha J2";
            this.Btn_J2.UseTransparentBackground = true;
            this.Btn_J2.Click += new System.EventHandler(this.Btn_J2_Click);
            // 
            // Img_J2
            // 
            this.Img_J2.Image = global::Proyecto2.Properties.Resources.USER;
            this.Img_J2.ImageRotate = 0F;
            this.Img_J2.Location = new System.Drawing.Point(169, 96);
            this.Img_J2.Name = "Img_J2";
            this.Img_J2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Img_J2.Size = new System.Drawing.Size(100, 100);
            this.Img_J2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_J2.TabIndex = 1;
            this.Img_J2.TabStop = false;
            // 
            // Txb_J2
            // 
            this.Txb_J2.AutoRoundedCorners = true;
            this.Txb_J2.BorderRadius = 17;
            this.Txb_J2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_J2.DefaultText = "";
            this.Txb_J2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_J2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_J2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_J2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_J2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_J2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Txb_J2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_J2.Location = new System.Drawing.Point(77, 53);
            this.Txb_J2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txb_J2.Name = "Txb_J2";
            this.Txb_J2.PasswordChar = '\0';
            this.Txb_J2.PlaceholderText = "Ingrese el nombre del jugador 2";
            this.Txb_J2.SelectedText = "";
            this.Txb_J2.Size = new System.Drawing.Size(284, 36);
            this.Txb_J2.TabIndex = 0;
            this.Txb_J2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_AsignarJ1
            // 
            this.Btn_AsignarJ1.AutoRoundedCorners = true;
            this.Btn_AsignarJ1.BackColor = System.Drawing.Color.Transparent;
            this.Btn_AsignarJ1.BorderColor = System.Drawing.Color.White;
            this.Btn_AsignarJ1.BorderRadius = 21;
            this.Btn_AsignarJ1.BorderThickness = 1;
            this.Btn_AsignarJ1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AsignarJ1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AsignarJ1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_AsignarJ1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_AsignarJ1.FillColor = System.Drawing.Color.SteelBlue;
            this.Btn_AsignarJ1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AsignarJ1.ForeColor = System.Drawing.Color.White;
            this.Btn_AsignarJ1.Location = new System.Drawing.Point(56, 3);
            this.Btn_AsignarJ1.Name = "Btn_AsignarJ1";
            this.Btn_AsignarJ1.Size = new System.Drawing.Size(319, 45);
            this.Btn_AsignarJ1.TabIndex = 4;
            this.Btn_AsignarJ1.Text = "Configuarar Jugador 1";
            this.Btn_AsignarJ1.UseTransparentBackground = true;
            this.Btn_AsignarJ1.Visible = false;
            this.Btn_AsignarJ1.Click += new System.EventHandler(this.Btn_AsignarJ1_Click);
            // 
            // Btn_Jugar
            // 
            this.Btn_Jugar.AutoRoundedCorners = true;
            this.Btn_Jugar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Jugar.BorderColor = System.Drawing.Color.White;
            this.Btn_Jugar.BorderRadius = 21;
            this.Btn_Jugar.BorderThickness = 1;
            this.Btn_Jugar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Jugar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Jugar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Jugar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Jugar.FillColor = System.Drawing.Color.MediumPurple;
            this.Btn_Jugar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Jugar.ForeColor = System.Drawing.Color.White;
            this.Btn_Jugar.Location = new System.Drawing.Point(134, 59);
            this.Btn_Jugar.Name = "Btn_Jugar";
            this.Btn_Jugar.Size = new System.Drawing.Size(180, 45);
            this.Btn_Jugar.TabIndex = 5;
            this.Btn_Jugar.Text = "Jugar";
            this.Btn_Jugar.UseTransparentBackground = true;
            this.Btn_Jugar.Visible = false;
            this.Btn_Jugar.Click += new System.EventHandler(this.Btn_Jugar_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.Controls.Add(this.Btn_AsignarJ2);
            this.guna2GradientPanel1.Controls.Add(this.Btn_Jugar);
            this.guna2GradientPanel1.Controls.Add(this.Btn_AsignarJ1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SeaGreen;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(17, 292);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(434, 107);
            this.guna2GradientPanel1.TabIndex = 6;
            this.guna2GradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_J1_MouseDown);
            this.guna2GradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_J1_MouseMove);
            this.guna2GradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_J1_MouseUp);
            // 
            // FRMJUGADORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 417);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.P_J2);
            this.Controls.Add(this.P_J1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMJUGADORES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.P_J1.ResumeLayout(false);
            this.P_J1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_J1)).EndInit();
            this.P_J2.ResumeLayout(false);
            this.P_J2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_J2)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Cerrar;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}

