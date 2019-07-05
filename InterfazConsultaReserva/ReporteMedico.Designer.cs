namespace InterfazConsultaReserva
{
    partial class ReporteMedico
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConsultaMedicaDataSet = new InterfazConsultaReserva.ConsultaMedicaDataSet();
            this.MedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MedicoTableAdapter = new InterfazConsultaReserva.ConsultaMedicaDataSetTableAdapters.MedicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaMedicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MedicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InterfazConsultaReserva.reporteMedico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(631, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConsultaMedicaDataSet
            // 
            this.ConsultaMedicaDataSet.DataSetName = "ConsultaMedicaDataSet";
            this.ConsultaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MedicoBindingSource
            // 
            this.MedicoBindingSource.DataMember = "Medico";
            this.MedicoBindingSource.DataSource = this.ConsultaMedicaDataSet;
            // 
            // MedicoTableAdapter
            // 
            this.MedicoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 386);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteMedico";
            this.Text = "ReporteMedico";
            this.Load += new System.EventHandler(this.ReporteMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaMedicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MedicoBindingSource;
        private ConsultaMedicaDataSet ConsultaMedicaDataSet;
        private ConsultaMedicaDataSetTableAdapters.MedicoTableAdapter MedicoTableAdapter;
    }
}