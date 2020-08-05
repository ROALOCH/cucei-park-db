using System;
using System.Data.Common;
using System.Windows.Forms;

namespace parkDB
{
    public partial class CU_Detalles : UserControl
    {
        public CU_Detalles()
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

        public void SincronizarControl()
        {
            sincronizarListaTickets();
            sincronizarDetalles();
        }
        private void sincronizarListaTickets()
        {
            CU_LSV_Tickets.Items.Clear();
            ConexionBD.Open();
            DbDataReader lectorSQL = ConexionBD.Query($"SELECT * FROM tickets WHERE validado = 'FALSE' AND id_estacionamiento = '{Estacionamiento.ID}' ORDER BY placa ASC;");

            if (!lectorSQL.HasRows)
            {
                return;
            }

            while (lectorSQL.Read())
            {
                string modoPension = "NO";
                if (lectorSQL.GetBoolean(4))
                {
                    modoPension = "SI";
                }

                string[] registro =
                {
                    $"{lectorSQL["placa"]}",
                    $"{lectorSQL["fecha_entrada"]}",
                    modoPension
                };

                var item = new ListViewItem(registro);
                CU_LSV_Tickets.Items.Add(item);
            }

            ConexionBD.Close();
        }
        private void sincronizarDetalles()
        {
            CU_LBL_Estacionamiento.Text = Estacionamiento.Nombre;
            CU_LBL_Total.Text = CU_LSV_Tickets.Items.Count.ToString();
            CU_LBL_TotalIngresos.Text = $"${calcularIngresosEstimados()} MXN";
        }
        private double calcularIngresosEstimados()
        {
            double ingresosEstimados = 0;

            foreach (ListViewItem item in CU_LSV_Tickets.Items)
            {
                // CALCULAR TIEMPO DE ESTACIONAMIENTO //

                DateTime fechaEntrada = DateTime.Parse(item.SubItems[1].Text);
                DateTime fechaSalida = DateTime.Now;
                TimeSpan duracion = (fechaSalida - fechaEntrada);

                bool modoPension = false;

                if (item.SubItems[2].Text == "SI")
                {
                    modoPension = true;
                }

                if (modoPension)
                {
                    ingresosEstimados += Math.Ceiling(duracion.TotalSeconds / 3600) * Estacionamiento.PrecioPension;
                }
                else
                {
                    ingresosEstimados += Math.Ceiling(duracion.TotalSeconds / 3600) * Estacionamiento.PrecioNormal;
                }
            }

            return ingresosEstimados;
        }
    }
}
