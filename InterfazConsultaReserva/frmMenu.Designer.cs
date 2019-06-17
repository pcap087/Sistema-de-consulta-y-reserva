namespace InterfazConsultaReserva
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.clinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCita = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(100, 26);
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.holaToolStripMenuItem.Text = "Hola";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMedico,
            this.tsmPaciente,
            this.tsmFuncionario,
            this.tsmTurno,
            this.clinicaToolStripMenuItem,
            this.ciudadToolStripMenuItem,
            this.consultorioToolStripMenuItem,
            this.disponibilidadToolStripMenuItem,
            this.tsmReserva,
            this.tsmCita});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // tsmMedico
            // 
            this.tsmMedico.Name = "tsmMedico";
            this.tsmMedico.Size = new System.Drawing.Size(180, 22);
            this.tsmMedico.Text = "Medico";
            this.tsmMedico.Click += new System.EventHandler(this.tsmMedico_Click);
            // 
            // tsmPaciente
            // 
            this.tsmPaciente.Name = "tsmPaciente";
            this.tsmPaciente.Size = new System.Drawing.Size(180, 22);
            this.tsmPaciente.Text = "Paciente";
            this.tsmPaciente.Click += new System.EventHandler(this.tsmPaciente_Click);
            // 
            // tsmFuncionario
            // 
            this.tsmFuncionario.Name = "tsmFuncionario";
            this.tsmFuncionario.Size = new System.Drawing.Size(180, 22);
            this.tsmFuncionario.Text = "Funcionario";
            this.tsmFuncionario.Click += new System.EventHandler(this.tsmFuncionario_Click);
            // 
            // tsmTurno
            // 
            this.tsmTurno.Name = "tsmTurno";
            this.tsmTurno.Size = new System.Drawing.Size(180, 22);
            this.tsmTurno.Text = "Turno";
            this.tsmTurno.Click += new System.EventHandler(this.tsmTurno_Click);
            // 
            // clinicaToolStripMenuItem
            // 
            this.clinicaToolStripMenuItem.Name = "clinicaToolStripMenuItem";
            this.clinicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clinicaToolStripMenuItem.Text = "Clinica";
            this.clinicaToolStripMenuItem.Click += new System.EventHandler(this.clinicaToolStripMenuItem_Click);
            // 
            // ciudadToolStripMenuItem
            // 
            this.ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            this.ciudadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ciudadToolStripMenuItem.Text = "Ciudad";
            this.ciudadToolStripMenuItem.Click += new System.EventHandler(this.ciudadToolStripMenuItem_Click);
            // 
            // consultorioToolStripMenuItem
            // 
            this.consultorioToolStripMenuItem.Name = "consultorioToolStripMenuItem";
            this.consultorioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultorioToolStripMenuItem.Text = "Consultorio";
            this.consultorioToolStripMenuItem.Click += new System.EventHandler(this.consultorioToolStripMenuItem_Click);
            // 
            // disponibilidadToolStripMenuItem
            // 
            this.disponibilidadToolStripMenuItem.Name = "disponibilidadToolStripMenuItem";
            this.disponibilidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disponibilidadToolStripMenuItem.Text = "Disponibilidad";
            this.disponibilidadToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadToolStripMenuItem_Click);
            // 
            // tsmReserva
            // 
            this.tsmReserva.Name = "tsmReserva";
            this.tsmReserva.Size = new System.Drawing.Size(180, 22);
            this.tsmReserva.Text = "Reserva";
            this.tsmReserva.Click += new System.EventHandler(this.tsmReserva_Click);
            // 
            // tsmCita
            // 
            this.tsmCita.Name = "tsmCita";
            this.tsmCita.Size = new System.Drawing.Size(180, 22);
            this.tsmCita.Text = "Cita";
            this.tsmCita.Click += new System.EventHandler(this.tsmCita_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 425);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "Sistema de Citas y Reservas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.contextMenuStrip3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmMedico;
        private System.Windows.Forms.ToolStripMenuItem tsmPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmFuncionario;
        private System.Windows.Forms.ToolStripMenuItem tsmTurno;
        private System.Windows.Forms.ToolStripMenuItem clinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmReserva;
        private System.Windows.Forms.ToolStripMenuItem tsmCita;
    }
}

