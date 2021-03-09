using System;
using System.Windows.Forms;

namespace parkDB
{
    public partial class UA_VNT_Principal : Form
    {
        Usuario usuario = null;
        ConexionBD conexionBD = null;
        Estacionamiento estacionamiento = null;
        public UA_VNT_Principal(Usuario usuario, ConexionBD conexionBD, Estacionamiento estacionamiento)
        {
            this.usuario = usuario;
            this.conexionBD = conexionBD;
            this.estacionamiento = estacionamiento;
            InitializeComponent();
        }



        // ===================================================
        // ============ SINCRONIZACIÓN DE CONTROL ============
        // ===================================================

        private void Sincronizar()
        {
            UA_CUS_Inicio.ConexionBD = conexionBD;
            UA_CUS_Inicio.Estacionamiento = estacionamiento;
            UA_CUS_Inicio.SincronizarControl();

            UA_CUS_Detalles.ConexionBD = conexionBD;
            UA_CUS_Detalles.Estacionamiento = estacionamiento;
            UA_CUS_Detalles.SincronizarControl();

            UA_CUS_Usuarios.Usuario = usuario;
            UA_CUS_Usuarios.ConexionBD = conexionBD;
            UA_CUS_Usuarios.Estacionamiento = estacionamiento;
            UA_CUS_Usuarios.SincronizarControl();

            UA_CUS_Configuracion.Usuario = usuario;
            UA_CUS_Configuracion.ConexionBD = conexionBD;
            UA_CUS_Configuracion.Estacionamiento = estacionamiento;
            UA_CUS_Configuracion.SincronizarControl();
        }
        private void UA_VNT_Principal_Load(object sender, EventArgs e)
        {
            Sincronizar();
        }



        // ========================================
        // ============ MENÚ PRINCIPAL ============
        // ========================================

        private void UA_BTN_Inicio_MouseEnter(object sender, EventArgs e)
        {
            UA_PAN_Secundario.Visible = false;
        }
        private void UA_BTN_Inicio_Click(object sender, EventArgs e)
        {
            UA_PAN_IndicadorPrimario.Top = UA_BTN_Inicio.Top;
            UA_PAN_IndicadorSecundario.Visible = false;
            UA_CUS_Inicio.BringToFront();
        }
        private void UA_BTN_Detalles_MouseEnter(object sender, EventArgs e)
        {
            UA_PAN_Secundario.Visible = false;
        }
        private void UA_BTN_Detalles_Click(object sender, EventArgs e)
        {
            UA_PAN_IndicadorPrimario.Top = UA_BTN_Detalles.Top;
            UA_PAN_IndicadorSecundario.Visible = false;
            UA_CUS_Detalles.BringToFront();
        }
        private void UA_BTN_Administracion_MouseEnter(object sender, EventArgs e)
        {
            UA_PAN_Secundario.BringToFront();
            UA_PAN_Secundario.Visible = true;
        }
        private void UA_BTN_Configuracion_MouseEnter(object sender, EventArgs e)
        {
            UA_PAN_Secundario.Visible = false;
        }
        private void UA_BTN_Configuracion_Click(object sender, EventArgs e)
        {
            UA_PAN_IndicadorPrimario.Top = UA_BTN_Configuracion.Top;
            UA_PAN_IndicadorSecundario.Visible = false;
            UA_CUS_Configuracion.SincronizarPerfil();
            UA_CUS_Configuracion.BringToFront();
        }
        private void UA_BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // =========================================
        // ============ MENÚ SECUNDARIO ============
        // =========================================

        private void UA_BTN_Usuarios_Click(object sender, EventArgs e)
        {
            UA_PAN_IndicadorSecundario.Top = UA_BTN_Usuarios.Top;
            UA_PAN_IndicadorPrimario.Top = UA_BTN_Administracion.Top;
            UA_PAN_IndicadorSecundario.Visible = true;
            UA_PAN_Secundario.Visible = false;
            UA_CUS_Usuarios.BringToFront();
        }
        private void UA_BTN_Vehiculos_Click(object sender, EventArgs e)
        {
            UA_PAN_IndicadorSecundario.Top = UA_BTN_Vehiculos.Top;
            UA_PAN_IndicadorPrimario.Top = UA_BTN_Administracion.Top;
            UA_PAN_IndicadorSecundario.Visible = true;
            UA_PAN_Secundario.Visible = false;
        }
        private void UA_BTN_Estacionamientos_Click(object sender, EventArgs e)
        {
            UA_PAN_IndicadorSecundario.Top = UA_BTN_Estacionamientos.Top;
            UA_PAN_IndicadorPrimario.Top = UA_BTN_Administracion.Top;
            UA_PAN_IndicadorSecundario.Visible = true;
            UA_PAN_Secundario.Visible = false;
        }



        // ========================================
        // ============ EVENT HANDLERS ============
        // ========================================

        private void UA_CUS_Inicio_ActualizacionBD(object sender, EventArgs e)
        {
            Sincronizar();
        }
        private void UA_CUS_Usuarios_ActualizacionBD(object sender, EventArgs e)
        {
            Sincronizar();
        }
        private void UA_CUS_Configuracion_EstacionamientoCambiado(object sender, EventArgs e)
        {
            estacionamiento = UA_CUS_Configuracion.Estacionamiento;
            Sincronizar();
        }

        private void UA_CUS_Usuarios_UsuarioActivoEliminado(object sender, EventArgs e)
        {
            // TODO: MESSAGEBOX PERSONALIZADO
            MessageBox.Show("CUENTA ACTIVA ELIMINADA");
            Sincronizar();
            this.Close();
        }
    }
}
