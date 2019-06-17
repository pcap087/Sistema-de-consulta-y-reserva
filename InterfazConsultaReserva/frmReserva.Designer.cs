namespace InterfazConsultaReserva
{
    partial class frmReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstReservas = new System.Windows.Forms.ListBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(271, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 48;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(418, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 47;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(497, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 23);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(418, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 23);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 436);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 23);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(93, 436);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 436);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstReservas
            // 
            this.lstReservas.FormattingEnabled = true;
            this.lstReservas.Location = new System.Drawing.Point(12, 12);
            this.lstReservas.Name = "lstReservas";
            this.lstReservas.Size = new System.Drawing.Size(237, 407);
            this.lstReservas.TabIndex = 41;
            this.lstReservas.Click += new System.EventHandler(this.lstReservas_Click);
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(418, 49);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(121, 21);
            this.cmbPaciente.TabIndex = 39;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(274, 49);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 38;
            this.lblPaciente.Text = "Paciente";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(418, 292);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 34;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(274, 293);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 33;
            this.lblMonto.Text = "Monto";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(418, 168);
            this.dtpFechaRegistro.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaRegistro.TabIndex = 32;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(271, 171);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(94, 13);
            this.lblFechaRegistro.TabIndex = 31;
            this.lblFechaRegistro.Text = "Fecha de Registro";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(576, 364);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(418, 91);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(121, 21);
            this.cmbMedico.TabIndex = 51;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(274, 91);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(42, 13);
            this.lblMedico.TabIndex = 50;
            this.lblMedico.Text = "Medico";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(418, 130);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cmbFuncionario.TabIndex = 53;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(274, 130);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 52;
            this.lblFuncionario.Text = "Funcionario";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(271, 212);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(95, 13);
            this.lblFechaReserva.TabIndex = 31;
            this.lblFechaReserva.Text = "Fecha de Reserva";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaReserva.Location = new System.Drawing.Point(418, 209);
            this.dtpFechaReserva.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaReserva.TabIndex = 32;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(418, 252);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 55;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Location = new System.Drawing.Point(274, 250);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(40, 13);
            this.lblEstados.TabIndex = 54;
            this.lblEstados.Text = "Estado";
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 489);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.cmbFuncionario);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstReservas);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.lblFechaRegistro);
            this.Name = "frmReserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstReservas;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstados;
    }
}