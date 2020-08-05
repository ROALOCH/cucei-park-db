using System;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace parkDB
{
    public partial class CU_Inicio : UserControl
    {
        public event EventHandler ActualizacionBD;

        bool placaValidada = false;
        public CU_Inicio()
        {
            InitializeComponent();
        }


        // ===========================================
        // ============ GETTERS / SETTERS ============
        // ===========================================

        public ConexionBD ConexionBD { get; set; }
        public Estacionamiento Estacionamiento { get; set; }



        // ===================================================
        // ============ SINCRONIZACIÓN DE CONTROL ============
        // ===================================================

        private void CU_Inicio_Load(object sender, EventArgs e)
        {
            CU_TIM_Reloj.Start();
        }
        private void CU_TIM_Reloj_Tick(object sender, EventArgs e)
        {
            CU_LBL_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            CU_LBL_Fecha.Text = DateTime.Now.ToString("d MMM yyyy");
        }
        private void SincronizarEstacionamiento()
        {
            ConexionBD.Open();
            DbDataReader lectorSQL = ConexionBD.Query($"SELECT * FROM estacionamientos WHERE id_estacionamiento = '{Estacionamiento.ID}';");
            lectorSQL.Read();

            Estacionamiento.ID = lectorSQL.GetInt16(0).ToString();
            Estacionamiento.Nombre = lectorSQL.GetString(1);
            Estacionamiento.Direccion = lectorSQL.GetString(2);
            Estacionamiento.Telefono = lectorSQL.GetString(3);
            Estacionamiento.LugaresTotales = lectorSQL.GetInt32(4);
            Estacionamiento.LugaresOcupados = lectorSQL.GetInt32(5);
            Estacionamiento.PrecioNormal = lectorSQL.GetDouble(6);
            Estacionamiento.PrecioPension = lectorSQL.GetDouble(7);

            ConexionBD.Close();
        }
        public void SincronizarControl()
        {
            SincronizarEstacionamiento();

            CU_LBL_NombreEstacionamiento.Text = Estacionamiento.Nombre;
            CU_LBL_DireccionEstacionamiento.Text = Estacionamiento.Direccion;
            CU_LBL_Disponibles.Text = (Estacionamiento.LugaresTotales - Estacionamiento.LugaresOcupados).ToString();
            CU_LBL_Ocupados.Text = Estacionamiento.LugaresOcupados.ToString();
            CU_LBL_Capacidad.Text = Estacionamiento.LugaresTotales.ToString();

            if (Estacionamiento.LugaresOcupados < Estacionamiento.LugaresTotales)
            {
                CU_LBL_Estado.Text = "D I S P O N I B L E";
                CU_LBL_Estado.ForeColor = Color.FromArgb(89, 243, 113);
            }
            else
            {
                CU_LBL_Estado.Text = "L L E N O";
                CU_LBL_Estado.ForeColor = Color.FromArgb(245, 0, 87);
            }

        }
        protected virtual void OnActualizacionBD(EventArgs e)
        {
            ActualizacionBD?.Invoke(this, e);
        }



        // ===========================================
        // ============ BARRA DE MENSAJES ============
        // ===========================================

        private void cerrarBarraMensaje() => CU_PAN_Mensaje.Visible = false;
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



        // ===========================================================
        // ============ INGRESO DE VEHÍCULOS - FORMULARIO ============
        // ===========================================================

        private void CU_TXB_Placa_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (CU_TXB_Placa.Text == "Placa")
            {
                CU_TXB_Placa.Text = "";
            }
        }
        private void CU_TXB_Placa_Leave(object sender, EventArgs e)
        {
            if (CU_TXB_Placa.Text == "")
            {
                CU_TXB_Placa.Text = "Placa";
            }
        }
        private void CU_TXB_Marca_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (CU_TXB_Marca.Text == "Marca")
            {
                CU_TXB_Marca.Text = "";
            }
        }
        private void CU_TXB_Marca_Leave(object sender, EventArgs e)
        {
            if (CU_TXB_Marca.Text == "")
            {
                CU_TXB_Marca.Text = "Marca";
            }
        }
        private void CU_TXB_Modelo_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (CU_TXB_Modelo.Text == "Modelo")
            {
                CU_TXB_Modelo.Text = "";
            }
        }
        private void CU_TXB_Modelo_Leave(object sender, EventArgs e)
        {
            if (CU_TXB_Modelo.Text == "")
            {
                CU_TXB_Modelo.Text = "Modelo";
            }
        }
        private void CU_TXB_Color_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (CU_TXB_Color.Text == "Color")
            {
                CU_TXB_Color.Text = "";
            }
        }
        private void CU_TXB_Color_Leave(object sender, EventArgs e)
        {
            if (CU_TXB_Color.Text == "")
            {
                CU_TXB_Color.Text = "Color";
            }
        }
        private void CU_CHB_Pension_CheckedChanged(object sender, EventArgs e)
        {
            if (CU_CHB_Pension.Checked)
            {
                CU_CHB_Pension.Text = "Modo Pensión Activado";
                CU_CHB_Pension.ForeColor = Color.White;
            }
            else
            {
                CU_CHB_Pension.Text = "Modo Pensión Desactivado";
                CU_CHB_Pension.ForeColor = Color.FromArgb(166, 188, 208);
            }
        }
        private void UA_BTN_EnviarIngreso_Click(object sender, EventArgs e)
        {
            if (!validarInputsIngreso())
            {
                mostrarBarraMensaje("Error: Ingresa la información requerida", Color.FromArgb(245, 0, 87));
                return;
            }

            string placa = CU_TXB_Placa.Text.ToUpper();
            string marca = CU_TXB_Marca.Text.ToUpper();
            string modelo = CU_TXB_Modelo.Text.ToUpper();
            string color = CU_TXB_Color.Text.ToUpper();
            bool pension = false;

            if (CU_CHB_Pension.Checked) // VALIDA SI EL MODO PENSION ESTA ACTIVADO
            {
                pension = true;
            }

            if (existePlacaBD(placa))
            {
                if (!validarPlacaIngreso(placa))
                {
                    mostrarBarraMensaje("Error: La placa ingresada no ha validado salida", Color.FromArgb(245, 0, 87));
                    return;
                }
            }
            else // SI LA PLACA NO EXISTE EN LA BASE DE DATOS, SE CREA UN NUEVO REGISTRO DE VEHICULO
            {
                if (!registrarVehiculoBD(placa, marca, modelo, color))
                {
                    mostrarBarraMensaje("Error: No se pudo registrar el vehículo", Color.FromArgb(245, 0, 87));
                    return;
                }
            }

            if (!generarTicketIngreso(placa, pension.ToString()))
            {
                mostrarBarraMensaje("Error: No se pudo generar el ticket de ingreso", Color.FromArgb(245, 0, 87));
                return;
            }

            mostrarBarraMensaje("Exito: Ticket de ingreso generado", Color.FromArgb(89, 243, 113));

            OnActualizacionBD(EventArgs.Empty);
            ReestablecerFormularioIngreso();
            SincronizarEstacionamiento();
            SincronizarControl();
        }



        // ==================================================
        // ============ VALIDACIÓN DE DE INGRESO ============
        // ==================================================

        private bool validarInputsIngreso() // VALIDA QUE LOS CAMPOS DE TEXTO NO ESTEN VACIOS
        {
            if (CU_TXB_Placa.Text == "Placa" || CU_TXB_Marca.Text == "Marca" || CU_TXB_Modelo.Text == "Modelo" || CU_TXB_Color.Text == "Color")
            {
                return false;
            }

            if (CU_TXB_Placa.Text == "" || CU_TXB_Marca.Text == "" || CU_TXB_Modelo.Text == "" || CU_TXB_Color.Text == "")
            {
                return false;
            }

            return true;
        }
        private bool existePlacaBD(string placa) // VERIFICA SI LA PLACA YA HA SIDO REGISTRADA ALGUNA VEZ EN LA BASE DE DATOS
        {
            ConexionBD.Open();
            DbDataReader lectorSQL = ConexionBD.Query($"SELECT placa FROM vehiculos WHERE placa = '{placa}';");

            if (lectorSQL.HasRows)
            {
                ConexionBD.Close();
                return true;
            }

            ConexionBD.Close();
            return false;
        }
        private bool validarPlacaIngreso(string placa) // VERIFICA QUE LA PLACA NO ESTE DENTRO DE ALGUN ESTACIONAMIENTO ACTUALMENTE
        {
            ConexionBD.Open();
            DbDataReader lectorSQL = ConexionBD.Query($"SELECT placa FROM tickets WHERE placa = '{placa}' AND validado = false;");

            if (lectorSQL.HasRows)
            {
                ConexionBD.Close();
                return false;
            }

            ConexionBD.Close();
            return true;
        }
        private bool registrarVehiculoBD(string placa, string marca, string modelo, string color) // CREA REGISTRO DE VEHICULO
        {
            try
            {
                ConexionBD.Open();
                ConexionBD.Query($"INSERT INTO vehiculos VALUES ('{placa}', '{marca}', '{modelo}', '{color}');");
                ConexionBD.Close();

                return true;
            }
            catch (Exception)
            {
                ConexionBD.Close();
                return false;
            }
        }
        private bool generarTicketIngreso(string placa, string pension) // GENERA UN TICKET DE INGRESO Y ACTUALIZA DISPONIBILIDAD
        {
            string fechaIngreso = $"{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day} {DateTime.Now.ToString("HH:mm:ss")}";

            try
            {
                // GENERAR TICKET DE INGRESO //
                ConexionBD.Open();
                ConexionBD.Query($"INSERT INTO tickets VALUES (DEFAULT, '{Estacionamiento.ID}', '{placa}', '{fechaIngreso}', '{pension}', 'FALSE');");
                ConexionBD.Close();

                // ACTUALIZAR ESPACIOS EN ESTACIONAMIENTO //
                ConexionBD.Open();
                ConexionBD.Query($"UPDATE estacionamientos SET lugares_ocupados = lugares_ocupados + 1 WHERE id_estacionamiento = '{Estacionamiento.ID}';");
                ConexionBD.Close();

                return true;
            }
            catch (Exception)
            {
                ConexionBD.Close();
                return false;
            }
        }



        // ==========================================================
        // ============ SALIDA DE VEHÍCULOS - FORMULARIO ============
        // ==========================================================

        private void CU_TXB_PlacaSalida_Enter(object sender, EventArgs e)
        {
            cerrarBarraMensaje();
            if (CU_TXB_PlacaSalida.Text == "Placa")
            {
                CU_TXB_PlacaSalida.Text = "";
            }
        }
        private void CU_TXB_PlacaSalida_Leave(object sender, EventArgs e)
        {
            if (CU_TXB_PlacaSalida.Text == "")
            {
                CU_TXB_PlacaSalida.Text = "Placa";
            }
        }
        private void CU_TXB_PlacaSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            cerrarBarraMensaje();
            placaValidada = false;

            if (e.KeyChar == (char)Keys.Enter)
            {
                string placa = CU_TXB_PlacaSalida.Text.ToUpper();

                if (placa == "PLACA" || placa == "")
                {
                    mostrarBarraMensaje("Error: Ingresa la información requerida", Color.FromArgb(245, 0, 87));
                    return;
                }

                if (!existePlacaBD(placa))
                {
                    mostrarBarraMensaje("Error: La placa ingresada no se encuentra registrada", Color.FromArgb(245, 0, 87));
                    return;
                }

                if (!cargarTicketSalida(placa))
                {
                    mostrarBarraMensaje("Error: La placa ingresada no se encuentra dentro del estacionamiento", Color.FromArgb(245, 0, 87));
                    return;
                }

                placaValidada = true;
            }
        }

        private bool cargarTicketSalida(string placa) // OBTIENE EL TICKET DE LA BASE DE DATOS
        {
            ConexionBD.Open();
            DbDataReader lectorSQL = ConexionBD.Query($"SELECT * FROM tickets WHERE placa = '{placa}' AND id_estacionamiento = '{Estacionamiento.ID}' AND validado = false;");

            if (!lectorSQL.HasRows)
            {
                ConexionBD.Close();
                return false;
            }

            lectorSQL.Read();

            CU_LBL_IDTicket.Text = lectorSQL.GetInt16(0).ToString();
            CU_LBL_IDEstacionamiento.Text = lectorSQL.GetInt16(1).ToString();
            CU_LBL_Placa.Text = lectorSQL.GetString(2);
            CU_LBL_FechaEntrada.Text = lectorSQL.GetDateTime(3).ToString();
            bool pension = lectorSQL.GetBoolean(4);

            CU_LBL_FechaSalida.Text = $"{DateTime.Now.ToString("dd/MM/yy")} {DateTime.Now.ToString("HH:mm:ss")}";
            CU_LBL_Total.Text = $"$ {calcularPago(pension)} MXN";
            CU_BTN_EnviarSalida.Enabled = true;

            ConexionBD.Close();
            return true;
        }
        private double calcularPago(bool pension) // CALCULA LA DURACIÓN DE LA ESTANCIA Y EL TOTAL A PAGAR
        {
            DateTime fechaEntrada = DateTime.Parse(CU_LBL_FechaEntrada.Text);
            DateTime fechaSalida = DateTime.Parse(CU_LBL_FechaSalida.Text);
            TimeSpan duracion = (fechaSalida - fechaEntrada);

            CU_LBL_Duracion.Text = $"{duracion.Days}D, {duracion.Hours}H, {duracion.Minutes}M, {duracion.Seconds}S";

            if (pension)
            {
                return Math.Ceiling(duracion.TotalSeconds / 3600) * Estacionamiento.PrecioPension;
            }

            return Math.Ceiling(duracion.TotalSeconds / 3600) * Estacionamiento.PrecioNormal;
        }
        private bool validarTicketSalida(string placa) // VALIDA EL TICKET DE SALIDA Y ACTUALIZA DISPONIBILIDAD
        {
            string idTicket = CU_LBL_IDTicket.Text;
            ConexionBD.Open();
            ConexionBD.Query($"UPDATE tickets SET validado = true WHERE id_ticket = '{idTicket}';");
            ConexionBD.Close();
            ConexionBD.Open();
            ConexionBD.Query($"UPDATE estacionamientos SET lugares_ocupados = lugares_ocupados - 1 WHERE id_estacionamiento = '{Estacionamiento.ID}';");
            ConexionBD.Close();
            return true;
        }
        private void CU_BTN_EnviarSalida_Click(object sender, EventArgs e)
        {
            if (!placaValidada)
            {
                mostrarBarraMensaje("Error: Ingresa la información requerida", Color.FromArgb(245, 0, 87));
                return;
            }

            string placa = CU_LBL_Placa.Text;

            if (!validarTicketSalida(placa))
            {
                mostrarBarraMensaje("Error: No se pudo validar el ticket de salida", Color.FromArgb(245, 0, 87));
                return;
            }

            mostrarBarraMensaje("Exito: Ticket de salida validado", Color.FromArgb(89, 243, 113));

            OnActualizacionBD(EventArgs.Empty);
            ReestablecerFormularioSalida();
            SincronizarEstacionamiento();
            SincronizarControl();
            placaValidada = false;
        }
        private void ReestablecerFormularioIngreso()
        {
            CU_TXB_Placa.Text = "Placa";
            CU_TXB_Marca.Text = "Marca";
            CU_TXB_Modelo.Text = "Modelo";
            CU_TXB_Color.Text = "Color";
            CU_CHB_Pension.Checked = false;
        }
        private void ReestablecerFormularioSalida()
        {
            CU_TXB_PlacaSalida.Text = "Placa";
            CU_LBL_IDTicket.Text = "-";
            CU_LBL_IDEstacionamiento.Text = "-";
            CU_LBL_Placa.Text = "-";
            CU_LBL_FechaEntrada.Text = "-";
            CU_LBL_FechaSalida.Text = "-";
            CU_LBL_Duracion.Text = "-";
            CU_LBL_Total.Text = "-";
            CU_BTN_EnviarSalida.Enabled = false;
        }
    }
}
