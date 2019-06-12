namespace ProyectoReservasConsultas
{
    partial class frmCiudad
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
            this.txtDescCiudad = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCiudad = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescCiudad
            // 
            this.txtDescCiudad.Location = new System.Drawing.Point(101, 110);
            this.txtDescCiudad.Name = "txtDescCiudad";
            this.txtDescCiudad.Size = new System.Drawing.Size(159, 20);
            this.txtDescCiudad.TabIndex = 27;
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(101, 64);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(159, 20);
            this.txtciudad.TabIndex = 26;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(461, 189);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAg
            // 
            this.btnAg.Location = new System.Drawing.Point(41, 189);
            this.btnAg.Name = "btnAg";
            this.btnAg.Size = new System.Drawing.Size(75, 23);
            this.btnAg.TabIndex = 22;
            this.btnAg.Text = "Agregar";
            this.btnAg.UseVisualStyleBackColor = true;
            this.btnAg.Click += new System.EventHandler(this.btnAg_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Codigo Ciudad";
            // 
            // lstCiudad
            // 
            this.lstCiudad.FormattingEnabled = true;
            this.lstCiudad.Location = new System.Drawing.Point(288, 21);
            this.lstCiudad.Name = "lstCiudad";
            this.lstCiudad.Size = new System.Drawing.Size(248, 134);
            this.lstCiudad.TabIndex = 28;
            this.lstCiudad.Click += new System.EventHandler(this.lstCiudad_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(371, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(286, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 23);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 308);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstCiudad);
            this.Controls.Add(this.txtDescCiudad);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmCiudad";
            this.Text = "Ciudad";
            this.Load += new System.EventHandler(this.frmCiudad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescCiudad;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCiudad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}