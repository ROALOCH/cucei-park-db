using System;
using System.Data.Common;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace parkDB
{
    public partial class IS_VNT_RecuperarContraseña : Form
    {
        ConexionBD conexionBD = null;
        SendGrid servicioSMPT = null;
        public IS_VNT_RecuperarContraseña()
        {
            conexionBD = new ConexionBD();
            servicioSMPT = new SendGrid();
            InitializeComponent();
        }
        private void IS_VNT_RecuperarContraseña_Load(object sender, EventArgs e)
        {
            if (!validarConexionInternet())
            {
                MessageBox.Show("PARA USAR ESTA FUNCION ES NECESARIO EL ACCESO A INTERNET", "NO HAY CONEXIÓN A INTERNET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void establecerTexto(Control control, string texto) => control.Text = texto;


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



        // ===========================================================
        // ============ FORMULARIO - RECUPERAR CONTRASEÑA ============
        // ===========================================================

        private bool validarInputs()
        {
            if (IS_TXB_Email.Text == "Correo electrónico" || IS_TXB_Email.Text == "")
            {
                return false;
            }

            return true;
        }
        private void IS_BTN_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IS_TXB_Email_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (IS_TXB_Email.Text == "Correo electrónico")
            {
                establecerTexto(IS_TXB_Email, "");
            }
        }
        private void IS_TXB_Email_Leave(object sender, EventArgs e)
        {
            if (IS_TXB_Email.Text == "")
            {
                establecerTexto(IS_TXB_Email, "Correo electrónico");
            }
        }
        private void IS_BTN_Enviar_Click(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (!validarInputs())
            {
                mostrarBarraMensaje("Error: Ingresa la información requerida", Color.FromArgb(245, 0, 87));
                return;
            }

            string email = IS_TXB_Email.Text.ToUpper();
            if (!validarCorreo(email))
            {
                mostrarBarraMensaje("Error: No se encontró ningun usuario registrado con ese email", Color.FromArgb(245, 0, 87));
                return;
            }

            if (!enviarCorreoRecuperacion(email))
            {
                mostrarBarraMensaje("Error: No se ha podido enviar el correo de recuperación", Color.FromArgb(245, 0, 87));
                return;
            }

            mostrarBarraMensaje("Exito: Correo de recuperación enviado", Color.FromArgb(89, 243, 113));

        }



        // ==========================================================
        // ============ VALIDACIÓN DE CORREO ELECTRÓNICO ============
        // ==========================================================

        private bool validarCorreo(string email) // VERIFICA QUE EL CORREO EXISTA EN LA BASE DE DATOS
        {
            conexionBD.Open();
            DbDataReader lectorSQL = conexionBD.Query($"SELECT email FROM usuarios WHERE email = '{email}';");

            if (!lectorSQL.HasRows)
            {
                mostrarBarraMensaje("Error: No se encontraron usuarios registrados con ese correo electrónico", Color.FromArgb(245, 0, 87));
                conexionBD.Close();
                return false;
            }
            conexionBD.Close();
            return true;
        }



        // =====================================================================================
        // ============ ENVIAR CORREO DE RECUPERACIÓN Y ACTUALIZAR CONTRASEÑA EN BD ============
        // =====================================================================================

        private bool enviarCorreoRecuperacion(string email) // ENVIA EL CORREO DE RECUPERACION USANDO SENDGRID API
        {
            try
            {
                string codigoAcceso = generarCodigoAcceso(email);
                servicioSMPT.EnviarRecuperacionAsync(email, codigoAcceso);
                actualizarCodigoAcceso(email, codigoAcceso);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void actualizarCodigoAcceso(string email, string codigo) // ACTUALIZA LA CONTRASEÑA A UN NUEVO CÓDIGO EN LA BASE DE DATOS
        {
            conexionBD.Open();
            conexionBD.Query($"UPDATE usuarios SET contraseña = '{codigo}' WHERE email = '{email}';");
            conexionBD.Close();
        }



        // ===============================================================
        // ============ GENERACIÓN DE NUEVAS LLAVES DE ACCESO ============
        // ===============================================================

        private string generarCodigoAcceso(string email) // GENERA UN CÓDIGO ALEATORIO DE 8 LETRAS
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < 8; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }



        // =====================================================
        // ============ VALIDAR CONEXIÓN A INTERNET ============
        // =====================================================

        private bool validarConexionInternet() // VERIFICA QUE EXISTA UNA CONEXION A INTERNET
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
