using System;
using System.Threading.Tasks;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net.Http;

namespace parkDB
{
    public partial class UA_VNT_FormularioUsuario : Form
    {
        string urlAvatar = "";
        string pathArchivo = "";
        string usuarioInicial = "";

        bool nuevoRegistro = true;

        ImgBB imagenAPI = new ImgBB();
        Usuario usuarioTemp = new Usuario();
        public UA_VNT_FormularioUsuario()
        {
            InitializeComponent();
        }



        // ===========================================
        // ============ GETTERS / SETTERS ============
        // ===========================================

        public Usuario Usuario { get; set; }
        public ConexionBD ConexionBD { get; set; }
        public Estacionamiento Estacionamiento { get; set; }

        public void Sincronizar()
        {
            UA_CBX_Estacionamientos.Items.Clear();

            try
            {
                ConexionBD.Open();
                DbDataReader lectorSQL = ConexionBD.Query("SELECT id_estacionamiento, nombre_estacionamiento FROM estacionamientos;");

                if (!lectorSQL.HasRows)
                {
                    UA_CBX_Estacionamientos.Enabled = false;
                    ConexionBD.Close();
                    return;
                }

                while (lectorSQL.Read())
                {
                    Estacionamiento item = new Estacionamiento();
                    item.ID = $"{lectorSQL["id_estacionamiento"]}";
                    item.Nombre = $"{lectorSQL["nombre_estacionamiento"]}";
                    UA_CBX_Estacionamientos.Items.Add(item);
                }

                ConexionBD.Close();
            }
            catch (Exception)
            {
                ConexionBD.Close();
            }
        }
        public void CargarDatos(string usuario)
        {
            nuevoRegistro = false;

            if (!descargarUsuario(usuario))
                return;

            cargarInfoControles();
        }
        private bool descargarUsuario(string usuario)
        {
            try
            {
                ConexionBD.Open();
                DbDataReader lectorSQL = ConexionBD.Query($"SELECT * FROM usuarios WHERE usuario = '{usuario}';");

                if (!lectorSQL.HasRows)
                {
                    ConexionBD.Close();
                    return false;
                }

                lectorSQL.Read();

                usuarioTemp.UsuarioID = lectorSQL.GetString(0);
                usuarioInicial = usuarioTemp.UsuarioID;
                usuarioTemp.Contraseña = lectorSQL.GetString(1);
                usuarioTemp.Nombres = lectorSQL.GetString(2);
                usuarioTemp.Apellidos = lectorSQL.GetString(3);
                usuarioTemp.Email = lectorSQL.GetString(4);
                usuarioTemp.Puesto = lectorSQL.GetString(5);
                usuarioTemp.Salario = lectorSQL.GetDouble(6);
                usuarioTemp.Administrador = lectorSQL.GetBoolean(7);
                usuarioTemp.Avatar = lectorSQL.GetString(8);

                ConexionBD.Close();
                return true;
            }
            catch (Exception)
            {
                ConexionBD.Close();
                return false;
            }
        }
        private void cargarInfoControles()
        {
            cargarFotoPerfil();

            UA_TXB_Usuario.Text = usuarioTemp.UsuarioID;
            UA_TXB_Contraseña.Text = usuarioTemp.Contraseña;
            UA_TXB_Nombres.Text = usuarioTemp.Nombres;
            UA_TXB_Apellidos.Text = usuarioTemp.Apellidos;
            UA_TXB_Email.Text = usuarioTemp.Email;

            bool usuarioAdministrador = false;
            if (usuarioTemp.Administrador)
                usuarioAdministrador = true;

            UA_CHB_TipoUsuario.Checked = usuarioAdministrador;

            UA_CBX_Puesto.Text = usuarioTemp.Puesto;
            UA_CBX_Estacionamientos.Text = obtenerEstacionamientoAsignado();
            UA_NUD_Salario.Value = (decimal)usuarioTemp.Salario;
        }
        private void cargarFotoPerfil()
        {
            try // INTENTA RECUPERAR LA IMAGEN ALMACENADA EN CLOUD
            {
                UA_PBX_Avatar.Load(usuarioTemp.Avatar);
                UA_PBX_Avatar.BackgroundImage = UA_PBX_Avatar.Image;
                UA_PBX_Avatar.Image = Properties.Resources.CU_IMG_AvatarMask;
            }
            catch (Exception) // ESTABLECE UN AVATAR POR DEFECTO
            {
                UA_PBX_Avatar.Image = Properties.Resources.CU_IMG_AvatarMask;
                UA_PBX_Avatar.BackgroundImage = Properties.Resources.CU_IMG_Avatar;
            }
        }
        private string obtenerEstacionamientoAsignado()
        {
            try
            {
                ConexionBD.Open();
                DbDataReader lectorSQL = ConexionBD.Query($"SELECT nombre_estacionamiento FROM estacionamientos INNER JOIN trabajan_en ON estacionamientos.id_estacionamiento = trabajan_en.id_estacionamiento AND trabajan_en.usuario = '{usuarioTemp.UsuarioID}';");

                if (!lectorSQL.HasRows)
                {
                    ConexionBD.Close();
                    return "";
                }

                lectorSQL.Read();
                string nombreEstacionamiento = $"{lectorSQL["nombre_estacionamiento"]}";
                ConexionBD.Close();

                return nombreEstacionamiento;
            }
            catch (Exception)
            {
                ConexionBD.Close();
                return "";
            }
        }



        // ===========================================================
        // ============ FORMULARIO DE USUARIO (CONTROLES) ============
        // ===========================================================


        private void UA_TXB_Usuario_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (UA_TXB_Usuario.Text == "Usuario")
                UA_TXB_Usuario.Text = "";
        }

        private void UA_TXB_Usuario_Leave(object sender, EventArgs e)
        {
            if (UA_TXB_Usuario.Text == "")
                UA_TXB_Usuario.Text = "Usuario";
        }

        private void UA_TXB_Contraseña_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (UA_TXB_Contraseña.Text == "Contraseña")
                UA_TXB_Contraseña.Text = "";
        }

        private void UA_TXB_Contraseña_Leave(object sender, EventArgs e)
        {
            if (UA_TXB_Contraseña.Text == "")
                UA_TXB_Contraseña.Text = "Contraseña";
        }

        private void UA_CHB_TipoUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (UA_CHB_TipoUsuario.Checked)
            {
                UA_CHB_TipoUsuario.Text = "Usuario Administrador";
                UA_CHB_TipoUsuario.ForeColor = Color.White;
            }
            else
            {
                UA_CHB_TipoUsuario.Text = "Usuario Normal";
                UA_CHB_TipoUsuario.ForeColor = Color.FromArgb(166, 188, 208);
            }
        }

        private void UA_TXB_Nombres_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (UA_TXB_Nombres.Text == "Nombres")
                UA_TXB_Nombres.Text = "";
        }

        private void UA_TXB_Nombres_Leave(object sender, EventArgs e)
        {
            if (UA_TXB_Nombres.Text == "")
                UA_TXB_Nombres.Text = "Nombres";
        }

        private void UA_TXB_Apellidos_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (UA_TXB_Apellidos.Text == "Apellidos")
                UA_TXB_Apellidos.Text = "";
        }

        private void UA_TXB_Apellidos_Leave(object sender, EventArgs e)
        {
            if (UA_TXB_Apellidos.Text == "")
                UA_TXB_Apellidos.Text = "Apellidos";
        }

        private void UA_TXB_Email_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (UA_TXB_Email.Text == "Email")
                UA_TXB_Email.Text = "";
        }

        private void UA_TXB_Email_Leave(object sender, EventArgs e)
        {
            if (UA_TXB_Email.Text == "")
                UA_TXB_Email.Text = "Email";
        }



        // ========================================
        // ============ ENVIAR USUARIO ============
        // ========================================
        private bool validarInput()
        {
            if(UA_TXB_Usuario.Text == "Usuario" ||
               UA_TXB_Contraseña.Text == "Contraseña" ||
               UA_TXB_Nombres.Text == "Nombres" ||
               UA_TXB_Apellidos.Text == "Apellidos" ||
               UA_TXB_Email.Text == "Email" ||
               UA_CBX_Puesto.Text == "" ||
               UA_CBX_Estacionamientos.SelectedItem == null
               )
            {
                return false;
            }

            return true;
        }
        private bool usuarioDisponible(string usuario)
        {
            try
            {
                if (usuarioTemp.UsuarioID == usuario)
                    return true;

                ConexionBD.Open();
                DbDataReader lectorSQL = ConexionBD.Query($"SELECT usuario FROM usuarios WHERE usuario = '{usuario}';");

                if (!lectorSQL.HasRows)
                {
                    ConexionBD.Close();
                    return true;
                }

                ConexionBD.Close();
                return false;
            }
            catch (Exception)
            {
                ConexionBD.Close();
                return false;
            }
        }
        private bool enviarUsuario()
        {
            try
            {
                string usuario = UA_TXB_Usuario.Text;
                string contraseña = UA_TXB_Contraseña.Text;
                string nombres = UA_TXB_Nombres.Text.ToUpper();
                string apellidos = UA_TXB_Apellidos.Text.ToUpper();
                string email = UA_TXB_Email.Text.ToUpper();
                string puesto = UA_CBX_Puesto.Text;
                string salario = UA_NUD_Salario.Value.ToString();
                string administrador = UA_CHB_TipoUsuario.Checked.ToString().ToUpper();
                string idEstacionamiento = ((Estacionamiento)UA_CBX_Estacionamientos.SelectedItem).ID;

                if (nuevoRegistro)
                {
                    // AÑADIR USUARIO A TABLA [USUARIOS]
                    ConexionBD.Open();
                    ConexionBD.Query($"INSERT INTO usuarios VALUES ('{usuario}', '{contraseña}', '{nombres}', '{apellidos}', '{email}', '{puesto}', '{salario}', '{administrador}', '{urlAvatar}');");
                    ConexionBD.Close();

                    // AÑADIR USUARIO A TABLA [TRABAJAN_EN]
                    ConexionBD.Open();
                    ConexionBD.Query($"INSERT INTO trabajan_en VALUES ('{idEstacionamiento}', '{usuario}');");
                    ConexionBD.Close();

                    return true;
                }
                else
                {
                    // ACTUALIZAR USUARIO EN TABLA [USUARIOS]
                    ConexionBD.Open();
                    ConexionBD.Query($"UPDATE usuarios SET usuario = '{usuario}', contraseña = '{contraseña}', nombres = '{nombres}', apellidos = '{apellidos}', email = '{email}', puesto = '{puesto}', salario = '{salario}', administrador = '{administrador}', avatar = '{urlAvatar}' WHERE usuario = '{usuarioInicial}';");
                    ConexionBD.Close();

                    // ACTUALIZAR ESTACIONAMIENTO EN TABLA [TRABAJAN_EN]
                    ConexionBD.Open();
                    ConexionBD.Query($"UPDATE trabajan_en SET id_estacionamiento = '{idEstacionamiento}' WHERE usuario = '{usuario}';");
                    ConexionBD.Close();

                    return true;
                }
            }
            catch (Exception)
            {
                ConexionBD.Close();
                return false;
            }
        }


        // ===========================================
        // ============ BARRA DE MENSAJES ============
        // ===========================================

        public void cerrarBarraMensaje() => UA_PAN_Mensaje.Visible = false;
        private void mostrarBarraMensaje(string mensaje, Color color)
        {
            UA_LBL_Mensaje.Text = mensaje;
            UA_PAN_Mensaje.BackColor = color;
            UA_PAN_Mensaje.Visible = true;
        }
        private void UA_BTN_CerrarMensaje_Click(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
        }

        private void UA_BTN_Enviar_Click(object sender, EventArgs e)
        {
            if (!validarInput())
            {
                mostrarBarraMensaje("Error: Ingresa la información requerida", Color.FromArgb(245, 0, 87));
                return;
            }

            string usuario = UA_TXB_Usuario.Text;

            if (!usuarioDisponible(usuario))
            {
                mostrarBarraMensaje("Error: El usuario ya se encuentra ocupado", Color.FromArgb(245, 0, 87));
                return;
            }

            if (!enviarUsuario())
            {
                mostrarBarraMensaje("Error: No se pudo enviar el usuario", Color.FromArgb(245, 0, 87));
                return;
            }

            mostrarBarraMensaje("Exito: Usuario enviado", Color.FromArgb(89, 243, 113));
            UA_CMS_Opciones.Enabled = false;
            UA_GRB_Cuenta.Enabled = false;
            UA_GRB_DatosPersonales.Enabled = false;
            UA_GRB_Trabajo.Enabled = false;
            UA_BTN_Enviar.Visible = false;
            UA_BTN_Salir.Visible = true;
        }



        // ==========================================
        // ============ IMAGEN DE PERFIL ============
        // ==========================================

        private void UA_CMS_EliminarFoto_Click(object sender, EventArgs e)
        {
            
            UA_PBX_Avatar.Image = Properties.Resources.CU_IMG_AvatarMask;
            UA_PBX_Avatar.BackgroundImage = Properties.Resources.CU_IMG_Avatar;
            urlAvatar = "";

            mostrarBarraMensaje("Exito: Imagen eliminada", Color.FromArgb(89, 243, 113));
        }

        private void UA_PBX_Avatar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                UA_CMS_Opciones.Show(Cursor.Position);
        }
        private bool seleccionarArchivo()
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Imagen (*.JPG) | *.JPG";
            if (DialogResult.OK == archivo.ShowDialog())
            {
                var size = new FileInfo(archivo.FileName).Length;

                if (size > 50000)
                    return false;

                pathArchivo = archivo.FileName;
                return true;
            }
            return false;
        }

        private void UA_CMS_CambiarFoto_Click(object sender, EventArgs e)
        {
            if (!seleccionarArchivo())
            {
                mostrarBarraMensaje("Error: No se pudo abrir el archivo", Color.FromArgb(245, 0, 87));
                return;
            }

            urlAvatar = Task.Run(async () => await imagenAPI.SubirImagenAsync(pathArchivo)).Result;

            UA_PBX_Avatar.BackgroundImage = Image.FromFile(pathArchivo);
            UA_PBX_Avatar.Image = Properties.Resources.CU_IMG_AvatarMask;

            mostrarBarraMensaje("Exito: Imagen cargada", Color.FromArgb(89, 243, 113));
            return;
        }

        private void UA_BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
