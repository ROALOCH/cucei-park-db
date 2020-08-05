namespace parkDB
{
    partial class UA_VNT_FormularioUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UA_VNT_FormularioUsuario));
            this.UA_TXB_Usuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UA_TXB_Contraseña = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UA_TXB_Nombres = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UA_TXB_Apellidos = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UA_TXB_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UA_CBX_Estacionamientos = new System.Windows.Forms.ComboBox();
            this.UA_CHB_TipoUsuario = new System.Windows.Forms.CheckBox();
            this.UA_NUD_Salario = new System.Windows.Forms.NumericUpDown();
            this.UA_PAN_Mensaje = new System.Windows.Forms.Panel();
            this.UA_BTN_CerrarMensaje = new System.Windows.Forms.Button();
            this.UA_LBL_Mensaje = new System.Windows.Forms.Label();
            this.UA_GRB_Cuenta = new System.Windows.Forms.GroupBox();
            this.UA_GRB_DatosPersonales = new System.Windows.Forms.GroupBox();
            this.UA_GRB_Trabajo = new System.Windows.Forms.GroupBox();
            this.UA_LBL_Puesto = new System.Windows.Forms.Label();
            this.UA_CBX_Puesto = new System.Windows.Forms.ComboBox();
            this.UA_LBL_SalarioMensual = new System.Windows.Forms.Label();
            this.UA_LBL_Estacionamiento = new System.Windows.Forms.Label();
            this.UA_PBX_Avatar = new System.Windows.Forms.PictureBox();
            this.UA_BTN_Enviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UA_CMS_Opciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UA_CMS_CambiarFoto = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UA_CMS_EliminarFoto = new System.Windows.Forms.ToolStripMenuItem();
            this.UA_BTN_Salir = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.UA_NUD_Salario)).BeginInit();
            this.UA_PAN_Mensaje.SuspendLayout();
            this.UA_GRB_Cuenta.SuspendLayout();
            this.UA_GRB_DatosPersonales.SuspendLayout();
            this.UA_GRB_Trabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UA_PBX_Avatar)).BeginInit();
            this.UA_CMS_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // UA_TXB_Usuario
            // 
            this.UA_TXB_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_TXB_Usuario.BorderColorFocused = System.Drawing.Color.SkyBlue;
            this.UA_TXB_Usuario.BorderColorIdle = System.Drawing.Color.Transparent;
            this.UA_TXB_Usuario.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue;
            this.UA_TXB_Usuario.BorderThickness = 1;
            this.UA_TXB_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UA_TXB_Usuario.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_TXB_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_TXB_Usuario.isPassword = false;
            this.UA_TXB_Usuario.Location = new System.Drawing.Point(8, 31);
            this.UA_TXB_Usuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UA_TXB_Usuario.Name = "UA_TXB_Usuario";
            this.UA_TXB_Usuario.Size = new System.Drawing.Size(291, 50);
            this.UA_TXB_Usuario.TabIndex = 2;
            this.UA_TXB_Usuario.Text = "Usuario";
            this.UA_TXB_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UA_TXB_Usuario.Enter += new System.EventHandler(this.UA_TXB_Usuario_Enter);
            this.UA_TXB_Usuario.Leave += new System.EventHandler(this.UA_TXB_Usuario_Leave);
            // 
            // UA_TXB_Contraseña
            // 
            this.UA_TXB_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_TXB_Contraseña.BorderColorFocused = System.Drawing.Color.SkyBlue;
            this.UA_TXB_Contraseña.BorderColorIdle = System.Drawing.Color.Transparent;
            this.UA_TXB_Contraseña.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue;
            this.UA_TXB_Contraseña.BorderThickness = 1;
            this.UA_TXB_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UA_TXB_Contraseña.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_TXB_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_TXB_Contraseña.isPassword = false;
            this.UA_TXB_Contraseña.Location = new System.Drawing.Point(8, 91);
            this.UA_TXB_Contraseña.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UA_TXB_Contraseña.Name = "UA_TXB_Contraseña";
            this.UA_TXB_Contraseña.Size = new System.Drawing.Size(291, 50);
            this.UA_TXB_Contraseña.TabIndex = 3;
            this.UA_TXB_Contraseña.Text = "Contraseña";
            this.UA_TXB_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UA_TXB_Contraseña.Enter += new System.EventHandler(this.UA_TXB_Contraseña_Enter);
            this.UA_TXB_Contraseña.Leave += new System.EventHandler(this.UA_TXB_Contraseña_Leave);
            // 
            // UA_TXB_Nombres
            // 
            this.UA_TXB_Nombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_TXB_Nombres.BorderColorFocused = System.Drawing.Color.SkyBlue;
            this.UA_TXB_Nombres.BorderColorIdle = System.Drawing.Color.Transparent;
            this.UA_TXB_Nombres.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue;
            this.UA_TXB_Nombres.BorderThickness = 1;
            this.UA_TXB_Nombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UA_TXB_Nombres.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_TXB_Nombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_TXB_Nombres.isPassword = false;
            this.UA_TXB_Nombres.Location = new System.Drawing.Point(8, 31);
            this.UA_TXB_Nombres.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UA_TXB_Nombres.Name = "UA_TXB_Nombres";
            this.UA_TXB_Nombres.Size = new System.Drawing.Size(291, 50);
            this.UA_TXB_Nombres.TabIndex = 6;
            this.UA_TXB_Nombres.Text = "Nombres";
            this.UA_TXB_Nombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UA_TXB_Nombres.Enter += new System.EventHandler(this.UA_TXB_Nombres_Enter);
            this.UA_TXB_Nombres.Leave += new System.EventHandler(this.UA_TXB_Nombres_Leave);
            // 
            // UA_TXB_Apellidos
            // 
            this.UA_TXB_Apellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_TXB_Apellidos.BorderColorFocused = System.Drawing.Color.SkyBlue;
            this.UA_TXB_Apellidos.BorderColorIdle = System.Drawing.Color.Transparent;
            this.UA_TXB_Apellidos.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue;
            this.UA_TXB_Apellidos.BorderThickness = 1;
            this.UA_TXB_Apellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UA_TXB_Apellidos.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_TXB_Apellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_TXB_Apellidos.isPassword = false;
            this.UA_TXB_Apellidos.Location = new System.Drawing.Point(8, 91);
            this.UA_TXB_Apellidos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UA_TXB_Apellidos.Name = "UA_TXB_Apellidos";
            this.UA_TXB_Apellidos.Size = new System.Drawing.Size(291, 50);
            this.UA_TXB_Apellidos.TabIndex = 7;
            this.UA_TXB_Apellidos.Text = "Apellidos";
            this.UA_TXB_Apellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UA_TXB_Apellidos.Enter += new System.EventHandler(this.UA_TXB_Apellidos_Enter);
            this.UA_TXB_Apellidos.Leave += new System.EventHandler(this.UA_TXB_Apellidos_Leave);
            // 
            // UA_TXB_Email
            // 
            this.UA_TXB_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_TXB_Email.BorderColorFocused = System.Drawing.Color.SkyBlue;
            this.UA_TXB_Email.BorderColorIdle = System.Drawing.Color.Transparent;
            this.UA_TXB_Email.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue;
            this.UA_TXB_Email.BorderThickness = 1;
            this.UA_TXB_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UA_TXB_Email.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_TXB_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_TXB_Email.isPassword = false;
            this.UA_TXB_Email.Location = new System.Drawing.Point(8, 149);
            this.UA_TXB_Email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UA_TXB_Email.Name = "UA_TXB_Email";
            this.UA_TXB_Email.Size = new System.Drawing.Size(291, 50);
            this.UA_TXB_Email.TabIndex = 8;
            this.UA_TXB_Email.Text = "Email";
            this.UA_TXB_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UA_TXB_Email.Enter += new System.EventHandler(this.UA_TXB_Email_Enter);
            this.UA_TXB_Email.Leave += new System.EventHandler(this.UA_TXB_Email_Leave);
            // 
            // UA_CBX_Estacionamientos
            // 
            this.UA_CBX_Estacionamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_CBX_Estacionamientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UA_CBX_Estacionamientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UA_CBX_Estacionamientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_CBX_Estacionamientos.FormattingEnabled = true;
            this.UA_CBX_Estacionamientos.Location = new System.Drawing.Point(6, 110);
            this.UA_CBX_Estacionamientos.Name = "UA_CBX_Estacionamientos";
            this.UA_CBX_Estacionamientos.Size = new System.Drawing.Size(291, 31);
            this.UA_CBX_Estacionamientos.TabIndex = 10;
            // 
            // UA_CHB_TipoUsuario
            // 
            this.UA_CHB_TipoUsuario.Appearance = System.Windows.Forms.Appearance.Button;
            this.UA_CHB_TipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_CHB_TipoUsuario.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UA_CHB_TipoUsuario.FlatAppearance.BorderSize = 0;
            this.UA_CHB_TipoUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(141)))));
            this.UA_CHB_TipoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_CHB_TipoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_CHB_TipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UA_CHB_TipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_CHB_TipoUsuario.Location = new System.Drawing.Point(8, 149);
            this.UA_CHB_TipoUsuario.Name = "UA_CHB_TipoUsuario";
            this.UA_CHB_TipoUsuario.Size = new System.Drawing.Size(291, 50);
            this.UA_CHB_TipoUsuario.TabIndex = 4;
            this.UA_CHB_TipoUsuario.Text = "Usuario Normal";
            this.UA_CHB_TipoUsuario.UseVisualStyleBackColor = false;
            this.UA_CHB_TipoUsuario.CheckedChanged += new System.EventHandler(this.UA_CHB_TipoUsuario_CheckedChanged);
            // 
            // UA_NUD_Salario
            // 
            this.UA_NUD_Salario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_NUD_Salario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UA_NUD_Salario.DecimalPlaces = 2;
            this.UA_NUD_Salario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_NUD_Salario.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.UA_NUD_Salario.Location = new System.Drawing.Point(6, 169);
            this.UA_NUD_Salario.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.UA_NUD_Salario.Name = "UA_NUD_Salario";
            this.UA_NUD_Salario.Size = new System.Drawing.Size(291, 30);
            this.UA_NUD_Salario.TabIndex = 11;
            this.UA_NUD_Salario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UA_NUD_Salario.ThousandsSeparator = true;
            // 
            // UA_PAN_Mensaje
            // 
            this.UA_PAN_Mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.UA_PAN_Mensaje.Controls.Add(this.UA_BTN_CerrarMensaje);
            this.UA_PAN_Mensaje.Controls.Add(this.UA_LBL_Mensaje);
            this.UA_PAN_Mensaje.ForeColor = System.Drawing.Color.White;
            this.UA_PAN_Mensaje.Location = new System.Drawing.Point(315, 688);
            this.UA_PAN_Mensaje.Name = "UA_PAN_Mensaje";
            this.UA_PAN_Mensaje.Size = new System.Drawing.Size(720, 40);
            this.UA_PAN_Mensaje.TabIndex = 13;
            this.UA_PAN_Mensaje.Visible = false;
            // 
            // UA_BTN_CerrarMensaje
            // 
            this.UA_BTN_CerrarMensaje.BackColor = System.Drawing.Color.Transparent;
            this.UA_BTN_CerrarMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UA_BTN_CerrarMensaje.FlatAppearance.BorderSize = 0;
            this.UA_BTN_CerrarMensaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UA_BTN_CerrarMensaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UA_BTN_CerrarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UA_BTN_CerrarMensaje.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_BTN_CerrarMensaje.Location = new System.Drawing.Point(687, 3);
            this.UA_BTN_CerrarMensaje.Name = "UA_BTN_CerrarMensaje";
            this.UA_BTN_CerrarMensaje.Size = new System.Drawing.Size(30, 34);
            this.UA_BTN_CerrarMensaje.TabIndex = 14;
            this.UA_BTN_CerrarMensaje.Text = "X";
            this.UA_BTN_CerrarMensaje.UseVisualStyleBackColor = false;
            this.UA_BTN_CerrarMensaje.Click += new System.EventHandler(this.UA_BTN_CerrarMensaje_Click);
            // 
            // UA_LBL_Mensaje
            // 
            this.UA_LBL_Mensaje.BackColor = System.Drawing.Color.Transparent;
            this.UA_LBL_Mensaje.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_LBL_Mensaje.Location = new System.Drawing.Point(3, 8);
            this.UA_LBL_Mensaje.Name = "UA_LBL_Mensaje";
            this.UA_LBL_Mensaje.Size = new System.Drawing.Size(678, 23);
            this.UA_LBL_Mensaje.TabIndex = 15;
            this.UA_LBL_Mensaje.Text = "_Respuesta: _Mensaje";
            // 
            // UA_GRB_Cuenta
            // 
            this.UA_GRB_Cuenta.Controls.Add(this.UA_TXB_Usuario);
            this.UA_GRB_Cuenta.Controls.Add(this.UA_TXB_Contraseña);
            this.UA_GRB_Cuenta.Controls.Add(this.UA_CHB_TipoUsuario);
            this.UA_GRB_Cuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.UA_GRB_Cuenta.Location = new System.Drawing.Point(178, 310);
            this.UA_GRB_Cuenta.Name = "UA_GRB_Cuenta";
            this.UA_GRB_Cuenta.Size = new System.Drawing.Size(307, 218);
            this.UA_GRB_Cuenta.TabIndex = 1;
            this.UA_GRB_Cuenta.TabStop = false;
            this.UA_GRB_Cuenta.Text = "Cuenta";
            // 
            // UA_GRB_DatosPersonales
            // 
            this.UA_GRB_DatosPersonales.Controls.Add(this.UA_TXB_Nombres);
            this.UA_GRB_DatosPersonales.Controls.Add(this.UA_TXB_Apellidos);
            this.UA_GRB_DatosPersonales.Controls.Add(this.UA_TXB_Email);
            this.UA_GRB_DatosPersonales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.UA_GRB_DatosPersonales.Location = new System.Drawing.Point(522, 310);
            this.UA_GRB_DatosPersonales.Name = "UA_GRB_DatosPersonales";
            this.UA_GRB_DatosPersonales.Size = new System.Drawing.Size(307, 218);
            this.UA_GRB_DatosPersonales.TabIndex = 5;
            this.UA_GRB_DatosPersonales.TabStop = false;
            this.UA_GRB_DatosPersonales.Text = "Datos Personales";
            // 
            // UA_GRB_Trabajo
            // 
            this.UA_GRB_Trabajo.Controls.Add(this.UA_LBL_Puesto);
            this.UA_GRB_Trabajo.Controls.Add(this.UA_CBX_Puesto);
            this.UA_GRB_Trabajo.Controls.Add(this.UA_LBL_SalarioMensual);
            this.UA_GRB_Trabajo.Controls.Add(this.UA_LBL_Estacionamiento);
            this.UA_GRB_Trabajo.Controls.Add(this.UA_CBX_Estacionamientos);
            this.UA_GRB_Trabajo.Controls.Add(this.UA_NUD_Salario);
            this.UA_GRB_Trabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.UA_GRB_Trabajo.Location = new System.Drawing.Point(866, 310);
            this.UA_GRB_Trabajo.Name = "UA_GRB_Trabajo";
            this.UA_GRB_Trabajo.Size = new System.Drawing.Size(307, 218);
            this.UA_GRB_Trabajo.TabIndex = 9;
            this.UA_GRB_Trabajo.TabStop = false;
            this.UA_GRB_Trabajo.Text = "Trabajo";
            // 
            // UA_LBL_Puesto
            // 
            this.UA_LBL_Puesto.BackColor = System.Drawing.Color.Transparent;
            this.UA_LBL_Puesto.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_LBL_Puesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_LBL_Puesto.Location = new System.Drawing.Point(6, 23);
            this.UA_LBL_Puesto.Name = "UA_LBL_Puesto";
            this.UA_LBL_Puesto.Size = new System.Drawing.Size(291, 24);
            this.UA_LBL_Puesto.TabIndex = 35;
            this.UA_LBL_Puesto.Text = "Puesto";
            this.UA_LBL_Puesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UA_CBX_Puesto
            // 
            this.UA_CBX_Puesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.UA_CBX_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UA_CBX_Puesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UA_CBX_Puesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_CBX_Puesto.FormattingEnabled = true;
            this.UA_CBX_Puesto.Items.AddRange(new object[] {
            "GERENTE GENERAL",
            "OPERADOR"});
            this.UA_CBX_Puesto.Location = new System.Drawing.Point(6, 50);
            this.UA_CBX_Puesto.Name = "UA_CBX_Puesto";
            this.UA_CBX_Puesto.Size = new System.Drawing.Size(291, 31);
            this.UA_CBX_Puesto.TabIndex = 34;
            // 
            // UA_LBL_SalarioMensual
            // 
            this.UA_LBL_SalarioMensual.BackColor = System.Drawing.Color.Transparent;
            this.UA_LBL_SalarioMensual.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_LBL_SalarioMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_LBL_SalarioMensual.Location = new System.Drawing.Point(6, 144);
            this.UA_LBL_SalarioMensual.Name = "UA_LBL_SalarioMensual";
            this.UA_LBL_SalarioMensual.Size = new System.Drawing.Size(291, 24);
            this.UA_LBL_SalarioMensual.TabIndex = 33;
            this.UA_LBL_SalarioMensual.Text = "Salario Mensual";
            this.UA_LBL_SalarioMensual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UA_LBL_Estacionamiento
            // 
            this.UA_LBL_Estacionamiento.BackColor = System.Drawing.Color.Transparent;
            this.UA_LBL_Estacionamiento.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_LBL_Estacionamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.UA_LBL_Estacionamiento.Location = new System.Drawing.Point(6, 87);
            this.UA_LBL_Estacionamiento.Name = "UA_LBL_Estacionamiento";
            this.UA_LBL_Estacionamiento.Size = new System.Drawing.Size(291, 24);
            this.UA_LBL_Estacionamiento.TabIndex = 32;
            this.UA_LBL_Estacionamiento.Text = "Estacionamiento Asignado";
            this.UA_LBL_Estacionamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UA_PBX_Avatar
            // 
            this.UA_PBX_Avatar.BackgroundImage = global::parkDB.Properties.Resources.CU_IMG_Avatar;
            this.UA_PBX_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UA_PBX_Avatar.Image = global::parkDB.Properties.Resources.CU_IMG_AvatarMask;
            this.UA_PBX_Avatar.Location = new System.Drawing.Point(575, 74);
            this.UA_PBX_Avatar.Name = "UA_PBX_Avatar";
            this.UA_PBX_Avatar.Size = new System.Drawing.Size(200, 200);
            this.UA_PBX_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UA_PBX_Avatar.TabIndex = 10;
            this.UA_PBX_Avatar.TabStop = false;
            this.UA_PBX_Avatar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UA_PBX_Avatar_MouseClick);
            // 
            // UA_BTN_Enviar
            // 
            this.UA_BTN_Enviar.ActiveBorderThickness = 1;
            this.UA_BTN_Enviar.ActiveCornerRadius = 25;
            this.UA_BTN_Enviar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(243)))), ((int)(((byte)(113)))));
            this.UA_BTN_Enviar.ActiveForecolor = System.Drawing.Color.White;
            this.UA_BTN_Enviar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(243)))), ((int)(((byte)(113)))));
            this.UA_BTN_Enviar.BackColor = System.Drawing.Color.White;
            this.UA_BTN_Enviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UA_BTN_Enviar.BackgroundImage")));
            this.UA_BTN_Enviar.ButtonText = "Enviar";
            this.UA_BTN_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UA_BTN_Enviar.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_BTN_Enviar.ForeColor = System.Drawing.Color.Transparent;
            this.UA_BTN_Enviar.IdleBorderThickness = 1;
            this.UA_BTN_Enviar.IdleCornerRadius = 25;
            this.UA_BTN_Enviar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(141)))));
            this.UA_BTN_Enviar.IdleForecolor = System.Drawing.Color.White;
            this.UA_BTN_Enviar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(141)))));
            this.UA_BTN_Enviar.Location = new System.Drawing.Point(522, 558);
            this.UA_BTN_Enviar.Margin = new System.Windows.Forms.Padding(5);
            this.UA_BTN_Enviar.Name = "UA_BTN_Enviar";
            this.UA_BTN_Enviar.Size = new System.Drawing.Size(307, 60);
            this.UA_BTN_Enviar.TabIndex = 12;
            this.UA_BTN_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UA_BTN_Enviar.Click += new System.EventHandler(this.UA_BTN_Enviar_Click);
            // 
            // UA_CMS_Opciones
            // 
            this.UA_CMS_Opciones.BackColor = System.Drawing.Color.White;
            this.UA_CMS_Opciones.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_CMS_Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UA_CMS_CambiarFoto,
            this.eliminarFotoToolStripMenuItem});
            this.UA_CMS_Opciones.Name = "UA_CMS_Opciones";
            this.UA_CMS_Opciones.ShowImageMargin = false;
            this.UA_CMS_Opciones.Size = new System.Drawing.Size(158, 60);
            // 
            // UA_CMS_CambiarFoto
            // 
            this.UA_CMS_CambiarFoto.ForeColor = System.Drawing.Color.Black;
            this.UA_CMS_CambiarFoto.Name = "UA_CMS_CambiarFoto";
            this.UA_CMS_CambiarFoto.Size = new System.Drawing.Size(157, 28);
            this.UA_CMS_CambiarFoto.Text = "Cambiar";
            this.UA_CMS_CambiarFoto.Click += new System.EventHandler(this.UA_CMS_CambiarFoto_Click);
            // 
            // eliminarFotoToolStripMenuItem
            // 
            this.eliminarFotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UA_CMS_EliminarFoto});
            this.eliminarFotoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.eliminarFotoToolStripMenuItem.Name = "eliminarFotoToolStripMenuItem";
            this.eliminarFotoToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.eliminarFotoToolStripMenuItem.Text = "Eliminar Foto";
            // 
            // UA_CMS_EliminarFoto
            // 
            this.UA_CMS_EliminarFoto.BackColor = System.Drawing.Color.White;
            this.UA_CMS_EliminarFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.UA_CMS_EliminarFoto.Name = "UA_CMS_EliminarFoto";
            this.UA_CMS_EliminarFoto.Size = new System.Drawing.Size(161, 28);
            this.UA_CMS_EliminarFoto.Text = "Confirmar";
            this.UA_CMS_EliminarFoto.Click += new System.EventHandler(this.UA_CMS_EliminarFoto_Click);
            // 
            // UA_BTN_Salir
            // 
            this.UA_BTN_Salir.ActiveBorderThickness = 1;
            this.UA_BTN_Salir.ActiveCornerRadius = 25;
            this.UA_BTN_Salir.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(243)))), ((int)(((byte)(113)))));
            this.UA_BTN_Salir.ActiveForecolor = System.Drawing.Color.White;
            this.UA_BTN_Salir.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(243)))), ((int)(((byte)(113)))));
            this.UA_BTN_Salir.BackColor = System.Drawing.Color.White;
            this.UA_BTN_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UA_BTN_Salir.BackgroundImage")));
            this.UA_BTN_Salir.ButtonText = "Regresar";
            this.UA_BTN_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UA_BTN_Salir.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_BTN_Salir.ForeColor = System.Drawing.Color.Transparent;
            this.UA_BTN_Salir.IdleBorderThickness = 1;
            this.UA_BTN_Salir.IdleCornerRadius = 25;
            this.UA_BTN_Salir.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(141)))));
            this.UA_BTN_Salir.IdleForecolor = System.Drawing.Color.White;
            this.UA_BTN_Salir.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(141)))));
            this.UA_BTN_Salir.Location = new System.Drawing.Point(522, 558);
            this.UA_BTN_Salir.Margin = new System.Windows.Forms.Padding(5);
            this.UA_BTN_Salir.Name = "UA_BTN_Salir";
            this.UA_BTN_Salir.Size = new System.Drawing.Size(307, 60);
            this.UA_BTN_Salir.TabIndex = 14;
            this.UA_BTN_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UA_BTN_Salir.Visible = false;
            this.UA_BTN_Salir.Click += new System.EventHandler(this.UA_BTN_Salir_Click);
            // 
            // UA_VNT_FormularioUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.UA_BTN_Salir);
            this.Controls.Add(this.UA_BTN_Enviar);
            this.Controls.Add(this.UA_PBX_Avatar);
            this.Controls.Add(this.UA_GRB_Trabajo);
            this.Controls.Add(this.UA_GRB_DatosPersonales);
            this.Controls.Add(this.UA_GRB_Cuenta);
            this.Controls.Add(this.UA_PAN_Mensaje);
            this.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "UA_VNT_FormularioUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parkDB | Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.UA_NUD_Salario)).EndInit();
            this.UA_PAN_Mensaje.ResumeLayout(false);
            this.UA_GRB_Cuenta.ResumeLayout(false);
            this.UA_GRB_DatosPersonales.ResumeLayout(false);
            this.UA_GRB_Trabajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UA_PBX_Avatar)).EndInit();
            this.UA_CMS_Opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox UA_TXB_Usuario;
        private Bunifu.Framework.UI.BunifuMetroTextbox UA_TXB_Contraseña;
        private Bunifu.Framework.UI.BunifuMetroTextbox UA_TXB_Nombres;
        private Bunifu.Framework.UI.BunifuMetroTextbox UA_TXB_Apellidos;
        private Bunifu.Framework.UI.BunifuMetroTextbox UA_TXB_Email;
        private System.Windows.Forms.ComboBox UA_CBX_Estacionamientos;
        private System.Windows.Forms.CheckBox UA_CHB_TipoUsuario;
        private System.Windows.Forms.NumericUpDown UA_NUD_Salario;
        private System.Windows.Forms.Panel UA_PAN_Mensaje;
        private System.Windows.Forms.Button UA_BTN_CerrarMensaje;
        private System.Windows.Forms.Label UA_LBL_Mensaje;
        private System.Windows.Forms.GroupBox UA_GRB_Cuenta;
        private System.Windows.Forms.GroupBox UA_GRB_DatosPersonales;
        private System.Windows.Forms.GroupBox UA_GRB_Trabajo;
        private System.Windows.Forms.Label UA_LBL_Estacionamiento;
        private System.Windows.Forms.Label UA_LBL_SalarioMensual;
        private System.Windows.Forms.PictureBox UA_PBX_Avatar;
        private Bunifu.Framework.UI.BunifuThinButton2 UA_BTN_Enviar;
        private System.Windows.Forms.Label UA_LBL_Puesto;
        private System.Windows.Forms.ComboBox UA_CBX_Puesto;
        private System.Windows.Forms.ContextMenuStrip UA_CMS_Opciones;
        private System.Windows.Forms.ToolStripMenuItem UA_CMS_CambiarFoto;
        private System.Windows.Forms.ToolStripMenuItem eliminarFotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UA_CMS_EliminarFoto;
        private Bunifu.Framework.UI.BunifuThinButton2 UA_BTN_Salir;
    }
}