﻿namespace RaceX__2_
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreAuto = new System.Windows.Forms.TextBox();
            this.cmbTipoAuto = new System.Windows.Forms.ComboBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.cmbClima = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciarCarrera = new System.Windows.Forms.Button();
            this.btnSiguienteTurno = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreAuto
            // 
            this.txtNombreAuto.Location = new System.Drawing.Point(161, 61);
            this.txtNombreAuto.Name = "txtNombreAuto";
            this.txtNombreAuto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreAuto.TabIndex = 0;
            // 
            // cmbTipoAuto
            // 
            this.cmbTipoAuto.FormattingEnabled = true;
            this.cmbTipoAuto.Items.AddRange(new object[] {
            "Deportivo",
            "Todoterreno",
            "Híbrido"});
            this.cmbTipoAuto.Location = new System.Drawing.Point(161, 116);
            this.cmbTipoAuto.Name = "cmbTipoAuto";
            this.cmbTipoAuto.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoAuto.TabIndex = 1;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(108, 176);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarAuto.TabIndex = 2;
            this.btnAgregarAuto.Text = "Agregar Vehículo";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del auto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de auto:";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(48, 239);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 24;
            this.dgvVehiculos.Size = new System.Drawing.Size(455, 150);
            this.dgvVehiculos.TabIndex = 5;
            // 
            // cmbClima
            // 
            this.cmbClima.FormattingEnabled = true;
            this.cmbClima.Items.AddRange(new object[] {
            "Soleado,",
            "Lluvia",
            "Ventoso"});
            this.cmbClima.Location = new System.Drawing.Point(491, 52);
            this.cmbClima.Name = "cmbClima";
            this.cmbClima.Size = new System.Drawing.Size(121, 24);
            this.cmbClima.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clima";
            // 
            // btnIniciarCarrera
            // 
            this.btnIniciarCarrera.Location = new System.Drawing.Point(317, 175);
            this.btnIniciarCarrera.Name = "btnIniciarCarrera";
            this.btnIniciarCarrera.Size = new System.Drawing.Size(102, 23);
            this.btnIniciarCarrera.TabIndex = 8;
            this.btnIniciarCarrera.Text = "Iniciar Carrera";
            this.btnIniciarCarrera.UseVisualStyleBackColor = true;
            this.btnIniciarCarrera.Click += new System.EventHandler(this.btnIniciarCarrera_Click);
            // 
            // btnSiguienteTurno
            // 
            this.btnSiguienteTurno.Location = new System.Drawing.Point(500, 175);
            this.btnSiguienteTurno.Name = "btnSiguienteTurno";
            this.btnSiguienteTurno.Size = new System.Drawing.Size(112, 23);
            this.btnSiguienteTurno.TabIndex = 9;
            this.btnSiguienteTurno.Text = "Siguiente Turno";
            this.btnSiguienteTurno.UseVisualStyleBackColor = true;
            this.btnSiguienteTurno.Click += new System.EventHandler(this.btnSiguienteTurno_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(524, 239);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(88, 16);
            this.lblMensaje.TabIndex = 11;
            this.lblMensaje.Text = "Mensaje aquí";
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(524, 278);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(89, 16);
            this.lblGanador.TabIndex = 12;
            this.lblGanador.Text = "Ganador aquí";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnSiguienteTurno);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbClima);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.cmbTipoAuto);
            this.Controls.Add(this.txtNombreAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreAuto;
        private System.Windows.Forms.ComboBox cmbTipoAuto;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.ComboBox cmbClima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciarCarrera;
        private System.Windows.Forms.Button btnSiguienteTurno;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblGanador;
    }
}

