using System;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace parkDB
{
    public partial class IS_VNT_InicioSesion : Form
    {
        Usuario Usuario = null;
        ConexionBD conexionBD = null;
        Estacionamiento estacionamiento = null;
        public IS_VNT_InicioSesion()
        {
            Usuario = new Usuario();
            conexionBD = new ConexionBD();
            estacionamiento = new Estacionamiento();

            InitializeComponent();
        }



        // ===========================================
        // ============ BARRA DE MENSAJES ============
        // ===========================================

        private void cerrarBarraMensaje() => IS_PAN_Mensaje.Visible = false;
        private void mostrarBarraMensaje(string mensaje, Color color)
        {
            IS_LBL_Mensaje.Text = mensaje;
            IS_PAN_Mensaje.BackColor = color;
            IS_PAN_Mensaje.Visible = true;
        }
        private void IS_BTN_CerrarMensaje_Click(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
        }



        // =====================================================
        // ============ FORMULARIO - INICIAR SESIÓN ============
        // =====================================================

        private bool validarInputs()
        {
            if (IS_TXB_Usuario.Text == "Usuario" || IS_TXB_Contraseña.Text == "Contraseña")
            {
                return false;
            }

            return true;
        }
        private void establecerTexto(Control control, string texto) => control.Text = texto;
        private void IS_TXB_Usuario_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (IS_TXB_Usuario.Text == "Usuario")
            {
                establecerTexto(IS_TXB_Usuario, "");
            }
        }
        private void IS_TXB_Usuario_Leave(object sender, EventArgs e)
        {
            if (IS_TXB_Usuario.Text == "")
            {
                establecerTexto(IS_TXB_Usuario, "Usuario");
            }
        }
        private void IS_TXB_Contraseña_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            IS_TXB_Contraseña.isPassword = true;
            if (IS_TXB_Contraseña.Text == "Contraseña")
            {
                establecerTexto(IS_TXB_Contraseña, "");
            }
        }
        private void IS_TXB_Contraseña_Leave(object sender, EventArgs e)
        {
            if (IS_TXB_Contraseña.Text == "")
            {
                IS_TXB_Contraseña.isPassword = false;
                establecerTexto(IS_TXB_Contraseña, "Contraseña");
            }
        }
        private void IS_BTN_IniciarSesion_Click(object sender, EventArgs e)
        {
            if (!validarInputs())
            {
                mostrarBarraMensaje("Error: Ingresa la información requerida", Color.FromArgb(245, 0, 87));
                return;
            }

            string usuario = IS_TXB_Usuario.Text;
            string contraseña = IS_TXB_Contraseña.Text;

            if (!validarCredenciales(usuario, contraseña))
            {
                mostrarBarraMensaje("Error: Credenciales de Acceso Inválidas", Color.FromArgb(245, 0, 87));
                return;
            }

            if (Usuario.Administrador)
            {
                establecerEstacionamientoDefecto(Usuario.UsuarioID);
                UA_VNT_Principal nuevaVentana = new UA_VNT_Principal(Usuario, conexionBD, estacionamiento);
                this.Hide();
                nuevaVentana.ShowDialog();
                this.Show();
            }
            else
            {
                //TODO: Mostrar Vista de Usuario Normal
            }

        }
        private void IS_BTN_RecuperarContraseña_Click(object sender, EventArgs e)
        {
            IS_VNT_RecuperarContraseña nuevaVentana = new IS_VNT_RecuperarContraseña();
            this.Hide();
            nuevaVentana.ShowDialog();
            this.Show();
            nuevaVentana.Dispose();
        }



        // =====================================================================
        // ============ VALIDACIÓN DE CREDENCIALES EN BASE DE DATOS ============
        // =====================================================================

        private bool validarCredenciales(string usuario, string contraseña)
        {
            conexionBD.Open();
            DbDataReader lectorSQL = conexionBD.Query($"SELECT * FROM usuarios WHERE usuario = '{usuario}' AND contraseña = '{contraseña}';");

            if (!lectorSQL.HasRows)
            {
                conexionBD.Close();
                return false;
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

            conexionBD.Close();
            return true;
        }



        // =============================================================
        // ============ OBTENER ESTACIONAMIENTO POR DEFECTO ============
        // =============================================================

        private void establecerEstacionamientoDefecto(string idUsuario)
        {
            conexionBD.Open();
            DbDataReader lectorSQL = conexionBD.Query($"SELECT * FROM estacionamientos INNER JOIN trabajan_en ON estacionamientos.id_estacionamiento = trabajan_en.id_estacionamiento AND trabajan_en.usuario = '{idUsuario}';");

            
            if (!lectorSQL.HasRows)
            {
                conexionBD.Close();
                return;
            }
          

            lectorSQL.Read();
            estacionamiento.ID = lectorSQL.GetInt16(0).ToString();
            estacionamiento.Nombre = lectorSQL.GetString(1);
            estacionamiento.Direccion = lectorSQL.GetString(2);
            estacionamiento.Telefono = lectorSQL.GetString(3);
            estacionamiento.LugaresTotales = lectorSQL.GetInt32(4);
            estacionamiento.LugaresOcupados = lectorSQL.GetInt32(5);
            estacionamiento.PrecioNormal = lectorSQL.GetDouble(6);
            estacionamiento.PrecioPension = lectorSQL.GetDouble(7);
            conexionBD.Close();
        }

    }
}
