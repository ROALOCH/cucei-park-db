using System;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace parkDB
{
    public partial class CU_Usuarios : UserControl
    {
        public event EventHandler UsuarioActivoEliminado;
        public event EventHandler ActualizacionBD;
        public CU_Usuarios()
        {
            InitializeComponent();
        }



        // ===========================================
        // ============ GETTERS / SETTERS ============
        // ===========================================

        public Usuario Usuario { get; set; }
        public ConexionBD ConexionBD { get; set; }
        public Estacionamiento Estacionamiento { get; set; }
        protected virtual void OnEstacionamientoCambiado(EventArgs e)
        {
            ActualizacionBD?.Invoke(this, e);
        }
        protected virtual void OnUsuarioActivoEliminado(EventArgs e)
        {
            UsuarioActivoEliminado?.Invoke(this, e);
        }

        // ===================================================
        // ============ SINCRONIZACIÓN DE CONTROL ============
        // ===================================================

        public void SincronizarControl()
        {
            sincronizarListaUsuarios();
        }
        private void sincronizarListaUsuarios()
        {
            CU_LSV_Usuarios.Items.Clear();

            ConexionBD.Open();
            DbDataReader lectorSQL = ConexionBD.Query($"SELECT * FROM usuarios ORDER BY apellidos ASC;");

            if (!lectorSQL.HasRows)
            {
                ConexionBD.Close();
                return;
            }

            while (lectorSQL.Read())
            {
                string[] datos =
                {
                    $"{lectorSQL["usuario"]}",
                    $"{lectorSQL["nombres"]}",
                    $"{lectorSQL["apellidos"]}",
                    $"{lectorSQL["puesto"]}",
                    $"{lectorSQL["salario"]}",
                };

                ListViewItem item = new ListViewItem(datos);
                CU_LSV_Usuarios.Items.Add(item);
            }

            ConexionBD.Close();
        }



        // =======================================
        // ============ NUEVO USUARIO ============
        // =======================================
        private void CU_BTN_NuevoUsuario_Click(object sender, System.EventArgs e)
        {
            UA_VNT_FormularioUsuario nuevaVentana = new UA_VNT_FormularioUsuario();
            nuevaVentana.ConexionBD = ConexionBD;
            nuevaVentana.Sincronizar();
            nuevaVentana.ShowDialog();
            sincronizarListaUsuarios();
            nuevaVentana.Dispose();
        }



        // =========================================
        // ============ MENU CONTEXTUAL ============
        // =========================================
        private void CU_LSV_Usuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (CU_LSV_Usuarios.FocusedItem.Bounds.Contains(e.Location))
                {
                    CU_CMS_Opciones.Show(Cursor.Position);
                }
            }
        }
        private void CU_CMS_EliminarConfirmar_Click(object sender, System.EventArgs e)
        {
            string usuario = CU_LSV_Usuarios.FocusedItem.Text;

            if (!eliminarUsuario(usuario))
            {
                mostrarBarraMensaje("Error: No se pudo eliminar el usuario", Color.FromArgb(245, 0, 87));
                return;
            }

            sincronizarListaUsuarios();
            mostrarBarraMensaje("Exito: Usuario eliminado", Color.FromArgb(89, 243, 113));

            // SI EL USUARIO ELIMINADO ES EL USUARIO EN USO, SE CIERRA EL PROGRAMA
            if (Usuario.UsuarioID == usuario)
                OnUsuarioActivoEliminado(EventArgs.Empty);
        }
        private void CU_CMS_Modificar_Click(object sender, System.EventArgs e)
        {
            string usuario = CU_LSV_Usuarios.FocusedItem.Text;

            UA_VNT_FormularioUsuario nuevaVentana = new UA_VNT_FormularioUsuario();
            nuevaVentana.ConexionBD = ConexionBD;
            nuevaVentana.Sincronizar();
            nuevaVentana.CargarDatos(usuario);
            nuevaVentana.ShowDialog();
            sincronizarListaUsuarios();
            nuevaVentana.Dispose();
        }



        // ===========================================================
        // ============ ELIMINAR USUARIO DE BASE DE DATOS ============
        // ===========================================================
        private bool eliminarUsuario(string usuario)
        {
            try
            {
                // ELIMINAR DE TABLA [TRABAJAN_EN] //
                ConexionBD.Open();
                ConexionBD.Query($"DELETE FROM trabajan_en WHERE usuario = '{usuario}';");
                ConexionBD.Close();

                // ELIMINAR DE TABLA [USUARIOS] //
                ConexionBD.Open();
                ConexionBD.Query($"DELETE FROM usuarios WHERE usuario = '{usuario}';");
                ConexionBD.Close();

                return true;
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
