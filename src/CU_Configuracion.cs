using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace parkDB
{
    public partial class CU_Configuracion : UserControl
    {
        public event EventHandler EstacionamientoCambiado;
        List<Estacionamiento> lista = new List<Estacionamiento>();
        public CU_Configuracion()
        {
            InitializeComponent();
        }



        // ===========================================
        // ============ GETTERS / SETTERS ============
        // ===========================================

        public Usuario Usuario { get; set; }
        public ConexionBD ConexionBD { get; set; }
        public Estacionamiento Estacionamiento { get; set; }



        // ===================================================
        // ============ SINCRONIZACIÓN DE CONTROL ============
        // ===================================================

        public void SincronizarControl()
        {
            cargarDatosPerfil();
            cargarDatosEstacionamiento();
            cargarListaEstacionamientos();
        }
        public void SincronizarPerfil()
        {
            try
            {
                ConexionBD.Open();
                DbDataReader lectorSQL = ConexionBD.Query($"SELECT * FROM usuarios WHERE usuario = '{Usuario.UsuarioID}';");

                if (!lectorSQL.HasRows)
                {
                    ConexionBD.Close();
                    return;
                }

                lectorSQL.Read();

                Usuario.UsuarioID = lectorSQL.GetString(0);
                Usuario.Contraseña = lectorSQL.GetString(1);
                Usuario.Nombres = lectorSQL.GetString(2);
                Usuario.Apellidos = lectorSQL.GetString(3);
                Usuario.Email = lectorSQL.GetString(4);
                Usuario.Puesto = lectorSQL.GetString(5);
                Usuario.Salario = lectorSQL.GetDouble(6);
                Usuario.Administrador = lectorSQL.GetBoolean(7);
                Usuario.Avatar = lectorSQL.GetString(8);

                ConexionBD.Close();
                SincronizarControl();
            }
            catch (Exception)
            {
                ConexionBD.Close();
                return;
            }
        }
        private void cargarDatosPerfil()
        {
            // CARGAR IMAGEN DE PERFIL //

            try // INTENTA RECUPERAR LA IMAGEN ALMACENADA EN CLOUD
            {
                CU_PBX_Avatar.Load(Usuario.Avatar);
                CU_PBX_Avatar.BackgroundImage = CU_PBX_Avatar.Image;
                CU_PBX_Avatar.Image = Properties.Resources.CU_IMG_AvatarMask;
            }
            catch (Exception) // ESTABLECE UN AVATAR POR DEFECTO
            {
                CU_PBX_Avatar.Image = Properties.Resources.CU_IMG_AvatarMask;
                CU_PBX_Avatar.BackgroundImage = Properties.Resources.CU_IMG_Avatar;
            }

            // CARGAR INFORMACIÓN //

            CU_LBL_Usuario.Text = $"{Usuario.Nombres} {Usuario.Apellidos}";
            CU_LBL_Puesto.Text = Usuario.Puesto;
            CU_LBL_Email.Text = Usuario.Email;
            CU_LBL_Salario.Text = $"${Usuario.Salario} MENSUALES";

            string tipoUsuario = "NORMAL";

            if (Usuario.Administrador)
            {
                tipoUsuario = "ADMINISTRADOR";
            }

            CU_LBL_Administrador.Text = tipoUsuario;
        }
        private void cargarDatosEstacionamiento()
        {
            CU_LBL_NombreEst.Text = Estacionamiento.Nombre;
            CU_LBL_Direccion.Text = Estacionamiento.Direccion;
            CU_LBL_Telefono.Text = Estacionamiento.Telefono;
            CU_LBL_Precios.Text = $"NORMAL: ${Estacionamiento.PrecioNormal} MXN / PENSIÓN: ${Estacionamiento.PrecioPension} MXN";
            CU_LBL_Capacidad.Text = $"CAPACIDAD: {Estacionamiento.LugaresTotales} | OCUPADOS: {Estacionamiento.LugaresOcupados}";
        }
        private void cargarListaEstacionamientos()
        {
            lista.Clear();
            ConexionBD.Open();
            DbDataReader lectorSQL = ConexionBD.Query("SELECT * FROM estacionamientos;");

            if (!lectorSQL.HasRows)
            {
                return;
            }

            while (lectorSQL.Read())
            {
                Estacionamiento item = new Estacionamiento();

                item.ID = lectorSQL.GetInt32(0).ToString();
                item.Nombre = lectorSQL.GetString(1);
                item.Direccion = lectorSQL.GetString(2);
                item.Telefono = lectorSQL.GetString(3);
                item.LugaresTotales = lectorSQL.GetInt32(4);
                item.LugaresOcupados = lectorSQL.GetInt32(5);
                item.PrecioNormal = lectorSQL.GetDouble(6);
                item.PrecioPension = lectorSQL.GetDouble(7);

                lista.Add(item);
            }

            CU_CBX_Estacionamientos.DataSource = lista;
            ConexionBD.Close();
        }
        protected virtual void OnEstacionamientoCambiado(EventArgs e)
        {
            EstacionamientoCambiado?.Invoke(this, e);
        }



        // =================================================
        // ============ CAMBIAR ESTACIONAMIENTO ============
        // =================================================

        private void CU_CBX_Estacionamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            Estacionamiento = (Estacionamiento)CU_CBX_Estacionamientos.SelectedItem;
            cargarDatosEstacionamiento();
        }
        private void CU_BTN_Cambiar_Click(object sender, EventArgs e)
        {
            Estacionamiento = (Estacionamiento)CU_CBX_Estacionamientos.SelectedItem;
            OnEstacionamientoCambiado(EventArgs.Empty);
            mostrarBarraMensaje("Exito: Estacionamiento cambiado", Color.FromArgb(89, 243, 113));
        }
        private void CU_BTN_Cambiar_MouseEnter(object sender, EventArgs e)
        {
            CU_BTN_Cambiar.ForeColor = Color.FromKnownColor(KnownColor.LightSkyBlue);
        }
        private void CU_BTN_Cambiar_MouseLeave(object sender, EventArgs e)
        {
            CU_BTN_Cambiar.ForeColor = Color.FromArgb(166, 188, 208);
        }



        // ===========================================
        // ============ BARRA DE MENSAJES ============
        // ===========================================

        public void cerrarBarraMensaje() => CU_PAN_Mensaje.Visible = false;
        private void mostrarBarraMensaje(string mensaje, Color color)
        {
            CU_LBL_Mensaje.Text = mensaje;
            CU_PAN_Mensaje.BackColor = color;
            CU_PAN_Mensaje.Visible = true;
        }
        private void CU_BTN_CerrarMensaje_Click(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
        }
    }
}
