namespace InterfazConsultaReserva
{
    partial class frmConsulta
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
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConsulta
            // 
            this.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgConsulta.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Location = new System.Drawing.Point(12, 56);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.Size = new System.Drawing.Size(598, 150);
            this.dgConsulta.TabIndex = 0;
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilidad.Location = new System.Drawing.Point(229, 9);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(168, 29);
            this.lblDisponibilidad.TabIndex = 1;
            this.lblDisponibilidad.Text = "Disponibilidad";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(622, 224);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.dgConsulta);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.Label lblDisponibilidad;
    }
}