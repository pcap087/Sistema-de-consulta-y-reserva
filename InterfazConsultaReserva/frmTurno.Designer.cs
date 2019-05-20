namespace InterfazConsultaReserva
{
    partial class frmTurno
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
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiarTurno = new System.Windows.Forms.Button();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnEditarTurno = new System.Windows.Forms.Button();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            this.lstTurnos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(159, 43);
            this.dtpHoraInicio.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpHoraInicio.TabIndex = 9;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(12, 47);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(58, 13);
            this.lblHoraInicio.TabIndex = 8;
            this.lblHoraInicio.Text = "Hora Inicio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(159, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(12, 93);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(47, 13);
            this.lblHoraFin.TabIndex = 8;
            this.lblHoraFin.Text = "Hora Fin";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(159, 89);
            this.dtpHoraFin.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(100, 20);
            this.dtpHoraFin.TabIndex = 9;
            // 
            // btnLimpiarTurno
            // 
            this.btnLimpiarTurno.Location = new System.Drawing.Point(386, 168);
            this.btnLimpiarTurno.Name = "btnLimpiarTurno";
            this.btnLimpiarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarTurno.TabIndex = 24;
            this.btnLimpiarTurno.Text = "Limpiar";
            this.btnLimpiarTurno.UseVisualStyleBackColor = true;
            this.btnLimpiarTurno.Click += new System.EventHandler(this.btnLimpiarTurno_Click);
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.Location = new System.Drawing.Point(257, 168);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTurno.TabIndex = 23;
            this.btnEliminarTurno.Text = "Eliminar";
            this.btnEliminarTurno.UseVisualStyleBackColor = true;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // btnEditarTurno
            // 
            this.btnEditarTurno.Location = new System.Drawing.Point(131, 167);
            this.btnEditarTurno.Name = "btnEditarTurno";
            this.btnEditarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTurno.TabIndex = 22;
            this.btnEditarTurno.Text = "Editar";
            this.btnEditarTurno.UseVisualStyleBackColor = true;
            this.btnEditarTurno.Click += new System.EventHandler(this.btnEditarTurno_Click);
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Location = new System.Drawing.Point(15, 166);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTurno.TabIndex = 21;
            this.btnAgregarTurno.Text = "Agregar";
            this.btnAgregarTurno.UseVisualStyleBackColor = true;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // lstTurnos
            // 
            this.lstTurnos.FormattingEnabled = true;
            this.lstTurnos.Location = new System.Drawing.Point(494, 12);
            this.lstTurnos.Name = "lstTurnos";
            this.lstTurnos.Size = new System.Drawing.Size(271, 407);
            this.lstTurnos.TabIndex = 25;
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTurnos);
            this.Controls.Add(this.btnLimpiarTurno);
            this.Controls.Add(this.btnEliminarTurno);
            this.Controls.Add(this.btnEditarTurno);
            this.Controls.Add(this.btnAgregarTurno);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmTurno";
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.frmTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Button btnLimpiarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.Button btnEditarTurno;
        private System.Windows.Forms.Button btnAgregarTurno;
        private System.Windows.Forms.ListBox lstTurnos;
    }
}