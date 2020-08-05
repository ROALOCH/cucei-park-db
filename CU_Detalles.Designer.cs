namespace parkDB
{
    partial class CU_Detalles
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
            this.CU_LBL_VehiculosEst = new System.Windows.Forms.Label();
            this.CU_LSV_Tickets = new System.Windows.Forms.ListView();
            this.placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CU_LBL_Estacionamiento = new System.Windows.Forms.Label();
            this.CU_LBL_Total = new System.Windows.Forms.Label();
            this.CU_LBL_TotalIngresos = new System.Windows.Forms.Label();
            this.CU_LBL_Visualizando = new System.Windows.Forms.Label();
            this.CU_LBL_TotalVehiculos = new System.Windows.Forms.Label();
            this.CU_LBL_IngresosEstimados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CU_LBL_VehiculosEst
            // 
            this.CU_LBL_VehiculosEst.Font = new System.Drawing.Font("Uber Move", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LBL_VehiculosEst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(53)))));
            this.CU_LBL_VehiculosEst.Location = new System.Drawing.Point(103, 31);
            this.CU_LBL_VehiculosEst.Name = "CU_LBL_VehiculosEst";
            this.CU_LBL_VehiculosEst.Size = new System.Drawing.Size(986, 41);
            this.CU_LBL_VehiculosEst.TabIndex = 18;
            this.CU_LBL_VehiculosEst.Text = "Vehículos Estacionados";
            // 
            // CU_LSV_Tickets
            // 
            this.CU_LSV_Tickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CU_LSV_Tickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.placa,
            this.fechaEntrada,
            this.pension});
            this.CU_LSV_Tickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CU_LSV_Tickets.Font = new System.Drawing.Font("Uber Move", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LSV_Tickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CU_LSV_Tickets.FullRowSelect = true;
            this.CU_LSV_Tickets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CU_LSV_Tickets.HideSelection = false;
            this.CU_LSV_Tickets.LabelWrap = false;
            this.CU_LSV_Tickets.Location = new System.Drawing.Point(110, 93);
            this.CU_LSV_Tickets.MultiSelect = false;
            this.CU_LSV_Tickets.Name = "CU_LSV_Tickets";
            this.CU_LSV_Tickets.Size = new System.Drawing.Size(601, 541);
            this.CU_LSV_Tickets.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CU_LSV_Tickets.TabIndex = 19;
            this.CU_LSV_Tickets.UseCompatibleStateImageBehavior = false;
            this.CU_LSV_Tickets.View = System.Windows.Forms.View.Details;
            // 
            // placa
            // 
            this.placa.Text = "Placa";
            this.placa.Width = 150;
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.Text = "Fecha de Entrada";
            this.fechaEntrada.Width = 300;
            // 
            // pension
            // 
            this.pension.Text = "Modo Pensión";
            this.pension.Width = 150;
            // 
            // CU_LBL_Estacionamiento
            // 
            this.CU_LBL_Estacionamiento.BackColor = System.Drawing.Color.Transparent;
            this.CU_LBL_Estacionamiento.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LBL_Estacionamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CU_LBL_Estacionamiento.Location = new System.Drawing.Point(743, 122);
            this.CU_LBL_Estacionamiento.Name = "CU_LBL_Estacionamiento";
            this.CU_LBL_Estacionamiento.Size = new System.Drawing.Size(346, 35);
            this.CU_LBL_Estacionamiento.TabIndex = 20;
            this.CU_LBL_Estacionamiento.Text = "_nombre_estacionamiento";
            this.CU_LBL_Estacionamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CU_LBL_Total
            // 
            this.CU_LBL_Total.BackColor = System.Drawing.Color.Transparent;
            this.CU_LBL_Total.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LBL_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CU_LBL_Total.Location = new System.Drawing.Point(743, 210);
            this.CU_LBL_Total.Name = "CU_LBL_Total";
            this.CU_LBL_Total.Size = new System.Drawing.Size(346, 29);
            this.CU_LBL_Total.TabIndex = 21;
            this.CU_LBL_Total.Text = "_total_de_autos";
            this.CU_LBL_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CU_LBL_TotalIngresos
            // 
            this.CU_LBL_TotalIngresos.BackColor = System.Drawing.Color.Transparent;
            this.CU_LBL_TotalIngresos.Font = new System.Drawing.Font("Uber Move", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LBL_TotalIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CU_LBL_TotalIngresos.Location = new System.Drawing.Point(743, 292);
            this.CU_LBL_TotalIngresos.Name = "CU_LBL_TotalIngresos";
            this.CU_LBL_TotalIngresos.Size = new System.Drawing.Size(346, 29);
            this.CU_LBL_TotalIngresos.TabIndex = 22;
            this.CU_LBL_TotalIngresos.Text = "_ingresos_estimados";
            this.CU_LBL_TotalIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CU_LBL_Visualizando
            // 
            this.CU_LBL_Visualizando.BackColor = System.Drawing.Color.Transparent;
            this.CU_LBL_Visualizando.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LBL_Visualizando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CU_LBL_Visualizando.Location = new System.Drawing.Point(739, 93);
            this.CU_LBL_Visualizando.Name = "CU_LBL_Visualizando";
            this.CU_LBL_Visualizando.Size = new System.Drawing.Size(281, 29);
            this.CU_LBL_Visualizando.TabIndex = 23;
            this.CU_LBL_Visualizando.Text = "Visualizando";
            this.CU_LBL_Visualizando.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CU_LBL_TotalVehiculos
            // 
            this.CU_LBL_TotalVehiculos.BackColor = System.Drawing.Color.Transparent;
            this.CU_LBL_TotalVehiculos.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LBL_TotalVehiculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CU_LBL_TotalVehiculos.Location = new System.Drawing.Point(739, 181);
            this.CU_LBL_TotalVehiculos.Name = "CU_LBL_TotalVehiculos";
            this.CU_LBL_TotalVehiculos.Size = new System.Drawing.Size(281, 29);
            this.CU_LBL_TotalVehiculos.TabIndex = 24;
            this.CU_LBL_TotalVehiculos.Text = "Total de Vehículos";
            this.CU_LBL_TotalVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CU_LBL_IngresosEstimados
            // 
            this.CU_LBL_IngresosEstimados.BackColor = System.Drawing.Color.Transparent;
            this.CU_LBL_IngresosEstimados.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CU_LBL_IngresosEstimados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CU_LBL_IngresosEstimados.Location = new System.Drawing.Point(739, 263);
            this.CU_LBL_IngresosEstimados.Name = "CU_LBL_IngresosEstimados";
            this.CU_LBL_IngresosEstimados.Size = new System.Drawing.Size(281, 29);
            this.CU_LBL_IngresosEstimados.TabIndex = 25;
            this.CU_LBL_IngresosEstimados.Text = "Ingresos Estimados";
            this.CU_LBL_IngresosEstimados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CU_Detalles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CU_LBL_IngresosEstimados);
            this.Controls.Add(this.CU_LBL_TotalVehiculos);
            this.Controls.Add(this.CU_LBL_Visualizando);
            this.Controls.Add(this.CU_LBL_TotalIngresos);
            this.Controls.Add(this.CU_LBL_Total);
            this.Controls.Add(this.CU_LBL_Estacionamiento);
            this.Controls.Add(this.CU_LSV_Tickets);
            this.Controls.Add(this.CU_LBL_VehiculosEst);
            this.Font = new System.Drawing.Font("Uber Move", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CU_Detalles";
            this.Size = new System.Drawing.Size(1126, 705);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CU_LBL_VehiculosEst;
        private System.Windows.Forms.ListView CU_LSV_Tickets;
        private System.Windows.Forms.ColumnHeader placa;
        private System.Windows.Forms.ColumnHeader fechaEntrada;
        private System.Windows.Forms.ColumnHeader pension;
        private System.Windows.Forms.Label CU_LBL_Estacionamiento;
        private System.Windows.Forms.Label CU_LBL_Total;
        private System.Windows.Forms.Label CU_LBL_TotalIngresos;
        private System.Windows.Forms.Label CU_LBL_Visualizando;
        private System.Windows.Forms.Label CU_LBL_TotalVehiculos;
        private System.Windows.Forms.Label CU_LBL_IngresosEstimados;
    }
}
