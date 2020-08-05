namespace parkDB
{
    partial class IS_VNT_InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IS_VNT_InicioSesion));
            this.IS_TXB_Usuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.IS_TXB_Contraseña = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.IS_LBL_Bienvenido = new System.Windows.Forms.Label();
            this.IS_PAN_IniciarSesion = new System.Windows.Forms.Panel();
            this.IS_BTN_RecuperarContraseña = new Bunifu.Framework.UI.BunifuThinButton2();
            this.IS_BTN_IniciarSesion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.IS_PAN_Izquierdo = new System.Windows.Forms.Panel();
            this.IS_PAN_Mensaje = new System.Windows.Forms.Panel();
            this.IS_BTN_CerrarMensaje = new System.Windows.Forms.Button();
            this.IS_LBL_Mensaje = new System.Windows.Forms.Label();
            this.IS_PAN_IniciarSesion.SuspendLayout();
            this.IS_PAN_Mensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // IS_TXB_Usuario
            // 
            this.IS_TXB_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.IS_TXB_Usuario.BorderColorFocused = System.Drawing.Color.SkyBlue;
            this.IS_TXB_Usuario.BorderColorIdle = System.Drawing.Color.Transparent;
            this.IS_TXB_Usuario.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue;
            this.IS_TXB_Usuario.BorderThickness = 1;
            this.IS_TXB_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IS_TXB_Usuario.Font = new System.Drawing.Font("Uber Move", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_TXB_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.IS_TXB_Usuario.isPassword = false;
            this.IS_TXB_Usuario.Location = new System.Drawing.Point(27, 89);
            this.IS_TXB_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.IS_TXB_Usuario.Name = "IS_TXB_Usuario";
            this.IS_TXB_Usuario.Size = new System.Drawing.Size(370, 60);
            this.IS_TXB_Usuario.TabIndex = 8;
            this.IS_TXB_Usuario.Text = "Usuario";
            this.IS_TXB_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IS_TXB_Usuario.Enter += new System.EventHandler(this.IS_TXB_Usuario_Enter);
            this.IS_TXB_Usuario.Leave += new System.EventHandler(this.IS_TXB_Usuario_Leave);
            // 
            // IS_TXB_Contraseña
            // 
            this.IS_TXB_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.IS_TXB_Contraseña.BorderColorFocused = System.Drawing.Color.SkyBlue;
            this.IS_TXB_Contraseña.BorderColorIdle = System.Drawing.Color.Transparent;
            this.IS_TXB_Contraseña.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue;
            this.IS_TXB_Contraseña.BorderThickness = 1;
            this.IS_TXB_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IS_TXB_Contraseña.Font = new System.Drawing.Font("Uber Move", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_TXB_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.IS_TXB_Contraseña.isPassword = false;
            this.IS_TXB_Contraseña.Location = new System.Drawing.Point(27, 162);
            this.IS_TXB_Contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.IS_TXB_Contraseña.Name = "IS_TXB_Contraseña";
            this.IS_TXB_Contraseña.Size = new System.Drawing.Size(370, 60);
            this.IS_TXB_Contraseña.TabIndex = 9;
            this.IS_TXB_Contraseña.Text = "Contraseña";
            this.IS_TXB_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IS_TXB_Contraseña.Enter += new System.EventHandler(this.IS_TXB_Contraseña_Enter);
            this.IS_TXB_Contraseña.Leave += new System.EventHandler(this.IS_TXB_Contraseña_Leave);
            // 
            // IS_LBL_Bienvenido
            // 
            this.IS_LBL_Bienvenido.AutoSize = true;
            this.IS_LBL_Bienvenido.Font = new System.Drawing.Font("Uber Move", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_LBL_Bienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(53)))));
            this.IS_LBL_Bienvenido.Location = new System.Drawing.Point(119, 16);
            this.IS_LBL_Bienvenido.Name = "IS_LBL_Bienvenido";
            this.IS_LBL_Bienvenido.Size = new System.Drawing.Size(184, 33);
            this.IS_LBL_Bienvenido.TabIndex = 1;
            this.IS_LBL_Bienvenido.Text = "¡BIENVENIDO!";
            // 
            // IS_PAN_IniciarSesion
            // 
            this.IS_PAN_IniciarSesion.BackColor = System.Drawing.Color.White;
            this.IS_PAN_IniciarSesion.Controls.Add(this.IS_LBL_Bienvenido);
            this.IS_PAN_IniciarSesion.Controls.Add(this.IS_TXB_Usuario);
            this.IS_PAN_IniciarSesion.Controls.Add(this.IS_BTN_RecuperarContraseña);
            this.IS_PAN_IniciarSesion.Controls.Add(this.IS_TXB_Contraseña);
            this.IS_PAN_IniciarSesion.Controls.Add(this.IS_BTN_IniciarSesion);
            this.IS_PAN_IniciarSesion.Location = new System.Drawing.Point(678, 158);
            this.IS_PAN_IniciarSesion.Name = "IS_PAN_IniciarSesion";
            this.IS_PAN_IniciarSesion.Size = new System.Drawing.Size(429, 412);
            this.IS_PAN_IniciarSesion.TabIndex = 6;
            // 
            // IS_BTN_RecuperarContraseña
            // 
            this.IS_BTN_RecuperarContraseña.ActiveBorderThickness = 1;
            this.IS_BTN_RecuperarContraseña.ActiveCornerRadius = 25;
            this.IS_BTN_RecuperarContraseña.ActiveFillColor = System.Drawing.Color.Transparent;
            this.IS_BTN_RecuperarContraseña.ActiveForecolor = System.Drawing.Color.LightSkyBlue;
            this.IS_BTN_RecuperarContraseña.ActiveLineColor = System.Drawing.Color.Transparent;
            this.IS_BTN_RecuperarContraseña.BackColor = System.Drawing.Color.White;
            this.IS_BTN_RecuperarContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IS_BTN_RecuperarContraseña.BackgroundImage")));
            this.IS_BTN_RecuperarContraseña.ButtonText = "¿Olvidaste tu Contraseña?";
            this.IS_BTN_RecuperarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IS_BTN_RecuperarContraseña.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_BTN_RecuperarContraseña.ForeColor = System.Drawing.Color.Transparent;
            this.IS_BTN_RecuperarContraseña.IdleBorderThickness = 1;
            this.IS_BTN_RecuperarContraseña.IdleCornerRadius = 25;
            this.IS_BTN_RecuperarContraseña.IdleFillColor = System.Drawing.Color.Transparent;
            this.IS_BTN_RecuperarContraseña.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.IS_BTN_RecuperarContraseña.IdleLineColor = System.Drawing.Color.Transparent;
            this.IS_BTN_RecuperarContraseña.Location = new System.Drawing.Point(62, 336);
            this.IS_BTN_RecuperarContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.IS_BTN_RecuperarContraseña.Name = "IS_BTN_RecuperarContraseña";
            this.IS_BTN_RecuperarContraseña.Size = new System.Drawing.Size(300, 60);
            this.IS_BTN_RecuperarContraseña.TabIndex = 11;
            this.IS_BTN_RecuperarContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IS_BTN_RecuperarContraseña.Click += new System.EventHandler(this.IS_BTN_RecuperarContraseña_Click);
            // 
            // IS_BTN_IniciarSesion
            // 
            this.IS_BTN_IniciarSesion.ActiveBorderThickness = 1;
            this.IS_BTN_IniciarSesion.ActiveCornerRadius = 25;
            this.IS_BTN_IniciarSesion.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(243)))), ((int)(((byte)(113)))));
            this.IS_BTN_IniciarSesion.ActiveForecolor = System.Drawing.Color.White;
            this.IS_BTN_IniciarSesion.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(243)))), ((int)(((byte)(113)))));
            this.IS_BTN_IniciarSesion.BackColor = System.Drawing.Color.White;
            this.IS_BTN_IniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IS_BTN_IniciarSesion.BackgroundImage")));
            this.IS_BTN_IniciarSesion.ButtonText = "Iniciar Sesión";
            this.IS_BTN_IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IS_BTN_IniciarSesion.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_BTN_IniciarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.IS_BTN_IniciarSesion.IdleBorderThickness = 1;
            this.IS_BTN_IniciarSesion.IdleCornerRadius = 25;
            this.IS_BTN_IniciarSesion.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(141)))));
            this.IS_BTN_IniciarSesion.IdleForecolor = System.Drawing.Color.White;
            this.IS_BTN_IniciarSesion.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(141)))));
            this.IS_BTN_IniciarSesion.Location = new System.Drawing.Point(62, 243);
            this.IS_BTN_IniciarSesion.Margin = new System.Windows.Forms.Padding(5);
            this.IS_BTN_IniciarSesion.Name = "IS_BTN_IniciarSesion";
            this.IS_BTN_IniciarSesion.Size = new System.Drawing.Size(300, 60);
            this.IS_BTN_IniciarSesion.TabIndex = 1;
            this.IS_BTN_IniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IS_BTN_IniciarSesion.Click += new System.EventHandler(this.IS_BTN_IniciarSesion_Click);
            // 
            // IS_PAN_Izquierdo
            // 
            this.IS_PAN_Izquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.IS_PAN_Izquierdo.BackgroundImage = global::parkDB.Properties.Resources.IS_IMG_PanelIzquierdo;
            this.IS_PAN_Izquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IS_PAN_Izquierdo.Location = new System.Drawing.Point(-1, -2);
            this.IS_PAN_Izquierdo.Name = "IS_PAN_Izquierdo";
            this.IS_PAN_Izquierdo.Size = new System.Drawing.Size(400, 733);
            this.IS_PAN_Izquierdo.TabIndex = 7;
            // 
            // IS_PAN_Mensaje
            // 
            this.IS_PAN_Mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.IS_PAN_Mensaje.Controls.Add(this.IS_BTN_CerrarMensaje);
            this.IS_PAN_Mensaje.Controls.Add(this.IS_LBL_Mensaje);
            this.IS_PAN_Mensaje.ForeColor = System.Drawing.Color.White;
            this.IS_PAN_Mensaje.Location = new System.Drawing.Point(532, 691);
            this.IS_PAN_Mensaje.Name = "IS_PAN_Mensaje";
            this.IS_PAN_Mensaje.Size = new System.Drawing.Size(720, 40);
            this.IS_PAN_Mensaje.TabIndex = 10;
            this.IS_PAN_Mensaje.Visible = false;
            // 
            // IS_BTN_CerrarMensaje
            // 
            this.IS_BTN_CerrarMensaje.BackColor = System.Drawing.Color.Transparent;
            this.IS_BTN_CerrarMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IS_BTN_CerrarMensaje.FlatAppearance.BorderSize = 0;
            this.IS_BTN_CerrarMensaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IS_BTN_CerrarMensaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IS_BTN_CerrarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IS_BTN_CerrarMensaje.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_BTN_CerrarMensaje.Location = new System.Drawing.Point(687, 3);
            this.IS_BTN_CerrarMensaje.Name = "IS_BTN_CerrarMensaje";
            this.IS_BTN_CerrarMensaje.Size = new System.Drawing.Size(30, 34);
            this.IS_BTN_CerrarMensaje.TabIndex = 1;
            this.IS_BTN_CerrarMensaje.Text = "X";
            this.IS_BTN_CerrarMensaje.UseVisualStyleBackColor = false;
            this.IS_BTN_CerrarMensaje.Click += new System.EventHandler(this.IS_BTN_CerrarMensaje_Click);
            // 
            // IS_LBL_Mensaje
            // 
            this.IS_LBL_Mensaje.BackColor = System.Drawing.Color.Transparent;
            this.IS_LBL_Mensaje.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IS_LBL_Mensaje.Location = new System.Drawing.Point(3, 8);
            this.IS_LBL_Mensaje.Name = "IS_LBL_Mensaje";
            this.IS_LBL_Mensaje.Size = new System.Drawing.Size(678, 23);
            this.IS_LBL_Mensaje.TabIndex = 0;
            this.IS_LBL_Mensaje.Text = "_Respuesta: _Mensaje";
            // 
            // IS_VNT_InicioSesion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.IS_PAN_Mensaje);
            this.Controls.Add(this.IS_PAN_Izquierdo);
            this.Controls.Add(this.IS_PAN_IniciarSesion);
            this.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "IS_VNT_InicioSesion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parkDB | Inicio de Sesión";
            this.IS_PAN_IniciarSesion.ResumeLayout(false);
            this.IS_PAN_IniciarSesion.PerformLayout();
            this.IS_PAN_Mensaje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox IS_TXB_Usuario;
        private Bunifu.Framework.UI.BunifuMetroTextbox IS_TXB_Contraseña;
        private Bunifu.Framework.UI.BunifuThinButton2 IS_BTN_IniciarSesion;
        private Bunifu.Framework.UI.BunifuThinButton2 IS_BTN_RecuperarContraseña;
        private System.Windows.Forms.Label IS_LBL_Bienvenido;
        private System.Windows.Forms.Panel IS_PAN_IniciarSesion;
        private System.Windows.Forms.Panel IS_PAN_Izquierdo;
        private System.Windows.Forms.Panel IS_PAN_Mensaje;
        private System.Windows.Forms.Button IS_BTN_CerrarMensaje;
        private System.Windows.Forms.Label IS_LBL_Mensaje;
    }
}

