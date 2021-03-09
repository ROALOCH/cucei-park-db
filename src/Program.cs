using System;
using System.Windows.Forms;

namespace parkDB
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ================================================================
            // ============ INICIALIZAR CONEXION CON BASE DE DATOS ============
            // ================================================================

            try
            {
                ConexionBD conexionBD = new ConexionBD();
                conexionBD.Test();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUDO CONECTAR CON LA BASE DE DATOS\nIMPOSIBLE EJECUTAR EL PROGRAMA", "ERROR DE CONEXIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new IS_VNT_InicioSesion());
        }
    }
}
