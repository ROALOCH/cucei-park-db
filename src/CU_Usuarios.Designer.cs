namespace parkDB
{
    partial class CU_Usuarios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CU_LBL_Usuarios = new System.Windows.Forms.Label();
            this.CU_LSV_Usuarios = new System.Windows.Forms.ListView();
            this.usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CU_BTN_NuevoUsuario = new System.Windows.Forms.Button();
            this.CU_CMS_Opciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CU_CMS_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.CU_CMS_EliminarOpcion = new System.Windows.Forms.ToolStripMenuItem();
            this.CU_CMS_EliminarConfirmar = new System.Windows.Forms.ToolStripMenuItem();
            this.CU_PAN_Mensaje = new System.Windows.Forms.Panel();
            this.CU_BTN_CerrarMensaje = new System.Windows.Forms.Button();
            this.CU_LBL_Mensaje = new System.Windows.Forms.Label();
            this.CU_CMS_Opciones.SuspendLayout();
            this.CU_PAN_Mensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // CU_LBL_Usuarios
            // 
            this.CU_LBL_Usuarios.Font = new System.Drawing.Font("Uber Move", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LBL_Usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(53)))));
            this.CU_LBL_Usuarios.Location = new System.Drawing.Point(110, 31);
            this.CU_LBL_Usuarios.Name = "CU_LBL_Usuarios";
            this.CU_LBL_Usuarios.Size = new System.Drawing.Size(901, 41);
            this.CU_LBL_Usuarios.TabIndex = 18;
            this.CU_LBL_Usuarios.Text = "Usuarios Registrados";
            // 
            // CU_LSV_Usuarios
            // 
            this.CU_LSV_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CU_LSV_Usuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usuario,
            this.nombres,
            this.apellidos,
            this.puesto,
            this.salario});
            this.CU_LSV_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CU_LSV_Usuarios.Font = new System.Drawing.Font("Uber Move", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LSV_Usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CU_LSV_Usuarios.FullRowSelect = true;
            this.CU_LSV_Usuarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CU_LSV_Usuarios.HideSelection = false;
            this.CU_LSV_Usuarios.LabelWrap = false;
            this.CU_LSV_Usuarios.Location = new System.Drawing.Point(110, 127);
            this.CU_LSV_Usuarios.MultiSelect = false;
            this.CU_LSV_Usuarios.Name = "CU_LSV_Usuarios";
            this.CU_LSV_Usuarios.Size = new System.Drawing.Size(901, 472);
            this.CU_LSV_Usuarios.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CU_LSV_Usuarios.TabIndex = 20;
            this.CU_LSV_Usuarios.UseCompatibleStateImageBehavior = false;
            this.CU_LSV_Usuarios.View = System.Windows.Forms.View.Details;
            this.CU_LSV_Usuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CU_LSV_Usuarios_MouseClick);
            // 
            // usuario
            // 
            this.usuario.Text = "Usuario";
            this.usuario.Width = 200;
            // 
            // nombres
            // 
            this.nombres.Text = "Nombres";
            this.nombres.Width = 200;
            // 
            // apellidos
            // 
            this.apellidos.Text = "Apellidos";
            this.apellidos.Width = 200;
            // 
            // puesto
            // 
            this.puesto.Text = "Puesto";
            this.puesto.Width = 180;
            // 
            // salario
            // 
            this.salario.Text = "Salario";
            this.salario.Width = 120;
            // 
            // CU_BTN_NuevoUsuario
            // 
            this.CU_BTN_NuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(141)))));
            this.CU_BTN_NuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CU_BTN_NuevoUsuario.FlatAppearance.BorderSize = 0;
            this.CU_BTN_NuevoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(141)))));
            this.CU_BTN_NuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(242)))), ((int)(((byte)(111)))));
            this.CU_BTN_NuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CU_BTN_NuevoUsuario.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_BTN_NuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.CU_BTN_NuevoUsuario.Location = new System.Drawing.Point(904, 75);
            this.CU_BTN_NuevoUsuario.Name = "CU_BTN_NuevoUsuario";
            this.CU_BTN_NuevoUsuario.Size = new System.Drawing.Size(107, 29);
            this.CU_BTN_NuevoUsuario.TabIndex = 21;
            this.CU_BTN_NuevoUsuario.Text = "Nuevo";
            this.CU_BTN_NuevoUsuario.UseVisualStyleBackColor = false;
            this.CU_BTN_NuevoUsuario.Click += new System.EventHandler(this.CU_BTN_NuevoUsuario_Click);
            // 
            // CU_CMS_Opciones
            // 
            this.CU_CMS_Opciones.BackColor = System.Drawing.Color.White;
            this.CU_CMS_Opciones.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_CMS_Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CU_CMS_Modificar,
            this.CU_CMS_EliminarOpcion});
            this.CU_CMS_Opciones.Name = "CU_CMS_Opciones";
            this.CU_CMS_Opciones.ShowImageMargin = false;
            this.CU_CMS_Opciones.Size = new System.Drawing.Size(132, 60);
            this.CU_CMS_Opciones.Text = "Opciones";
            // 
            // CU_CMS_Modificar
            // 
            this.CU_CMS_Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CU_CMS_Modificar.ForeColor = System.Drawing.Color.Black;
            this.CU_CMS_Modificar.Name = "CU_CMS_Modificar";
            this.CU_CMS_Modificar.Size = new System.Drawing.Size(131, 28);
            this.CU_CMS_Modificar.Text = "Modificar";
            this.CU_CMS_Modificar.Click += new System.EventHandler(this.CU_CMS_Modificar_Click);
            // 
            // CU_CMS_EliminarOpcion
            // 
            this.CU_CMS_EliminarOpcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CU_CMS_EliminarOpcion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CU_CMS_EliminarConfirmar});
            this.CU_CMS_EliminarOpcion.ForeColor = System.Drawing.Color.Black;
            this.CU_CMS_EliminarOpcion.Name = "CU_CMS_EliminarOpcion";
            this.CU_CMS_EliminarOpcion.Size = new System.Drawing.Size(131, 28);
            this.CU_CMS_EliminarOpcion.Text = "Eliminar";
            // 
            // CU_CMS_EliminarConfirmar
            // 
            this.CU_CMS_EliminarConfirmar.BackColor = System.Drawing.Color.White;
            this.CU_CMS_EliminarConfirmar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CU_CMS_EliminarConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.CU_CMS_EliminarConfirmar.Name = "CU_CMS_EliminarConfirmar";
            this.CU_CMS_EliminarConfirmar.Size = new System.Drawing.Size(161, 28);
            this.CU_CMS_EliminarConfirmar.Text = "Confirmar";
            this.CU_CMS_EliminarConfirmar.Click += new System.EventHandler(this.CU_CMS_EliminarConfirmar_Click);
            // 
            // CU_PAN_Mensaje
            // 
            this.CU_PAN_Mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(243)))), ((int)(((byte)(113)))));
            this.CU_PAN_Mensaje.Controls.Add(this.CU_BTN_CerrarMensaje);
            this.CU_PAN_Mensaje.Controls.Add(this.CU_LBL_Mensaje);
            this.CU_PAN_Mensaje.ForeColor = System.Drawing.Color.White;
            this.CU_PAN_Mensaje.Location = new System.Drawing.Point(200, 664);
            this.CU_PAN_Mensaje.Name = "CU_PAN_Mensaje";
            this.CU_PAN_Mensaje.Size = new System.Drawing.Size(720, 40);
            this.CU_PAN_Mensaje.TabIndex = 30;
            this.CU_PAN_Mensaje.Visible = false;
            // 
            // CU_BTN_CerrarMensaje
            // 
            this.CU_BTN_CerrarMensaje.BackColor = System.Drawing.Color.Transparent;
            this.CU_BTN_CerrarMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CU_BTN_CerrarMensaje.FlatAppearance.BorderSize = 0;
            this.CU_BTN_CerrarMensaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CU_BTN_CerrarMensaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CU_BTN_CerrarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CU_BTN_CerrarMensaje.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_BTN_CerrarMensaje.Location = new System.Drawing.Point(687, 3);
            this.CU_BTN_CerrarMensaje.Name = "CU_BTN_CerrarMensaje";
            this.CU_BTN_CerrarMensaje.Size = new System.Drawing.Size(30, 34);
            this.CU_BTN_CerrarMensaje.TabIndex = 1;
            this.CU_BTN_CerrarMensaje.Text = "X";
            this.CU_BTN_CerrarMensaje.UseVisualStyleBackColor = false;
            this.CU_BTN_CerrarMensaje.Click += new System.EventHandler(this.CU_BTN_CerrarMensaje_Click);
            // 
            // CU_LBL_Mensaje
            // 
            this.CU_LBL_Mensaje.BackColor = System.Drawing.Color.Transparent;
            this.CU_LBL_Mensaje.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LBL_Mensaje.Location = new System.Drawing.Point(3, 8);
            this.CU_LBL_Mensaje.Name = "CU_LBL_Mensaje";
            this.CU_LBL_Mensaje.Size = new System.Drawing.Size(678, 23);
            this.CU_LBL_Mensaje.TabIndex = 0;
            this.CU_LBL_Mensaje.Text = "_Respuesta: _Mensaje";
            // 
            // CU_Usuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CU_PAN_Mensaje);
            this.Controls.Add(this.CU_BTN_NuevoUsuario);
            this.Controls.Add(this.CU_LSV_Usuarios);
            this.Controls.Add(this.CU_LBL_Usuarios);
            this.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CU_Usuarios";
            this.Size = new System.Drawing.Size(1126, 705);
            this.CU_CMS_Opciones.ResumeLayout(false);
            this.CU_PAN_Mensaje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CU_LBL_Usuarios;
        private System.Windows.Forms.ListView CU_LSV_Usuarios;
        private System.Windows.Forms.ColumnHeader usuario;
        private System.Windows.Forms.ColumnHeader nombres;
        private System.Windows.Forms.ColumnHeader apellidos;
        private System.Windows.Forms.ColumnHeader puesto;
        private System.Windows.Forms.ColumnHeader salario;
        private System.Windows.Forms.Button CU_BTN_NuevoUsuario;
        private System.Windows.Forms.ContextMenuStrip CU_CMS_Opciones;
        private System.Windows.Forms.ToolStripMenuItem CU_CMS_Modificar;
        private System.Windows.Forms.ToolStripMenuItem CU_CMS_EliminarOpcion;
        private System.Windows.Forms.ToolStripMenuItem CU_CMS_EliminarConfirmar;
        private System.Windows.Forms.Panel CU_PAN_Mensaje;
        private System.Windows.Forms.Button CU_BTN_CerrarMensaje;
        private System.Windows.Forms.Label CU_LBL_Mensaje;
    }
}
