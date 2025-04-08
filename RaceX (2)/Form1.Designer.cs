namespace RaceX__2_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.lblNovedad = new System.Windows.Forms.Label();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.btnIniciarCarrera = new System.Windows.Forms.Button();
            this.btnSiguienteTurno = new System.Windows.Forms.Button();
            this.gbClima = new System.Windows.Forms.GroupBox();
            this.rbVentoso = new System.Windows.Forms.RadioButton();
            this.rbLluvioso = new System.Windows.Forms.RadioButton();
            this.rbSoleado = new System.Windows.Forms.RadioButton();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnReiniciarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.gbClima.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreAuto
            // 
            this.txtNombreAuto.Location = new System.Drawing.Point(116, 24);
            this.txtNombreAuto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreAuto.Name = "txtNombreAuto";
            this.txtNombreAuto.Size = new System.Drawing.Size(92, 20);
            this.txtNombreAuto.TabIndex = 0;
            this.txtNombreAuto.TextChanged += new System.EventHandler(this.txtNombreAuto_TextChanged);
            // 
            // cmbTipoAuto
            // 
            this.cmbTipoAuto.FormattingEnabled = true;
            this.cmbTipoAuto.Items.AddRange(new object[] {
            "Deportivo",
            "Todoterreno",
            "Híbrido"});
            this.cmbTipoAuto.Location = new System.Drawing.Point(116, 50);
            this.cmbTipoAuto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoAuto.Name = "cmbTipoAuto";
            this.cmbTipoAuto.Size = new System.Drawing.Size(92, 21);
            this.cmbTipoAuto.TabIndex = 1;
            this.cmbTipoAuto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoAuto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del auto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de auto:";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(378, 24);
            this.dgvVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 24;
            this.dgvVehiculos.Size = new System.Drawing.Size(341, 122);
            this.dgvVehiculos.TabIndex = 5;
            // 
            // lblNovedad
            // 
            this.lblNovedad.AutoSize = true;
            this.lblNovedad.Location = new System.Drawing.Point(444, 164);
            this.lblNovedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNovedad.Name = "lblNovedad";
            this.lblNovedad.Size = new System.Drawing.Size(0, 13);
            this.lblNovedad.TabIndex = 11;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(27, 141);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(121, 36);
            this.btnAgregarAuto.TabIndex = 13;
            this.btnAgregarAuto.Text = "AGREGAR AUTO";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // btnIniciarCarrera
            // 
            this.btnIniciarCarrera.Location = new System.Drawing.Point(27, 183);
            this.btnIniciarCarrera.Name = "btnIniciarCarrera";
            this.btnIniciarCarrera.Size = new System.Drawing.Size(121, 36);
            this.btnIniciarCarrera.TabIndex = 14;
            this.btnIniciarCarrera.Text = "INICIAR CARRERA";
            this.btnIniciarCarrera.UseVisualStyleBackColor = true;
            this.btnIniciarCarrera.Click += new System.EventHandler(this.btnIniciarCarrera_Click);
            // 
            // btnSiguienteTurno
            // 
            this.btnSiguienteTurno.Location = new System.Drawing.Point(27, 226);
            this.btnSiguienteTurno.Name = "btnSiguienteTurno";
            this.btnSiguienteTurno.Size = new System.Drawing.Size(121, 36);
            this.btnSiguienteTurno.TabIndex = 14;
            this.btnSiguienteTurno.Text = "SIGUIENTE TURNO";
            this.btnSiguienteTurno.UseVisualStyleBackColor = true;
            this.btnSiguienteTurno.Click += new System.EventHandler(this.btnSiguienteTurno_Click);
            // 
            // gbClima
            // 
            this.gbClima.Controls.Add(this.rbVentoso);
            this.gbClima.Controls.Add(this.rbLluvioso);
            this.gbClima.Controls.Add(this.rbSoleado);
            this.gbClima.Location = new System.Drawing.Point(27, 76);
            this.gbClima.Name = "gbClima";
            this.gbClima.Size = new System.Drawing.Size(311, 48);
            this.gbClima.TabIndex = 15;
            this.gbClima.TabStop = false;
            this.gbClima.Text = "Clima:";
            // 
            // rbVentoso
            // 
            this.rbVentoso.AutoSize = true;
            this.rbVentoso.Location = new System.Drawing.Point(195, 19);
            this.rbVentoso.Name = "rbVentoso";
            this.rbVentoso.Size = new System.Drawing.Size(64, 17);
            this.rbVentoso.TabIndex = 2;
            this.rbVentoso.TabStop = true;
            this.rbVentoso.Text = "Ventoso";
            this.rbVentoso.UseVisualStyleBackColor = true;
            this.rbVentoso.CheckedChanged += new System.EventHandler(this.rbSeleccionarClima_Changed);
            // 
            // rbLluvioso
            // 
            this.rbLluvioso.AutoSize = true;
            this.rbLluvioso.Location = new System.Drawing.Point(104, 19);
            this.rbLluvioso.Name = "rbLluvioso";
            this.rbLluvioso.Size = new System.Drawing.Size(64, 17);
            this.rbLluvioso.TabIndex = 1;
            this.rbLluvioso.TabStop = true;
            this.rbLluvioso.Text = "Lluvioso";
            this.rbLluvioso.UseVisualStyleBackColor = true;
            this.rbLluvioso.CheckedChanged += new System.EventHandler(this.rbSeleccionarClima_Changed);
            // 
            // rbSoleado
            // 
            this.rbSoleado.AutoSize = true;
            this.rbSoleado.Location = new System.Drawing.Point(13, 19);
            this.rbSoleado.Name = "rbSoleado";
            this.rbSoleado.Size = new System.Drawing.Size(64, 17);
            this.rbSoleado.TabIndex = 0;
            this.rbSoleado.TabStop = true;
            this.rbSoleado.Text = "Soleado";
            this.rbSoleado.UseVisualStyleBackColor = true;
            this.rbSoleado.CheckedChanged += new System.EventHandler(this.rbSeleccionarClima_Changed);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(375, 164);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(50, 13);
            this.lblMensaje.TabIndex = 16;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // btnReiniciarTodo
            // 
            this.btnReiniciarTodo.Location = new System.Drawing.Point(590, 226);
            this.btnReiniciarTodo.Name = "btnReiniciarTodo";
            this.btnReiniciarTodo.Size = new System.Drawing.Size(128, 43);
            this.btnReiniciarTodo.TabIndex = 17;
            this.btnReiniciarTodo.Text = "REINICIAR TODO";
            this.btnReiniciarTodo.UseVisualStyleBackColor = true;
            this.btnReiniciarTodo.Click += new System.EventHandler(this.btnReiniciarTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 281);
            this.Controls.Add(this.btnReiniciarTodo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gbClima);
            this.Controls.Add(this.btnSiguienteTurno);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.lblNovedad);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoAuto);
            this.Controls.Add(this.txtNombreAuto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.gbClima.ResumeLayout(false);
            this.gbClima.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreAuto;
        private System.Windows.Forms.ComboBox cmbTipoAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Label lblNovedad;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Button btnIniciarCarrera;
        private System.Windows.Forms.Button btnSiguienteTurno;
        private System.Windows.Forms.GroupBox gbClima;
        private System.Windows.Forms.RadioButton rbVentoso;
        private System.Windows.Forms.RadioButton rbLluvioso;
        private System.Windows.Forms.RadioButton rbSoleado;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnReiniciarTodo;
    }
}

