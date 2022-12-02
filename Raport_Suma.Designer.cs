
namespace UnoMD
{
    partial class Raport_Suma
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raport_Suma));
            this.SumaFacutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnoMD_Report = new UnoMD.UnoMD_Report();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SumaFacutaTableAdapter = new UnoMD.UnoMD_ReportTableAdapters.SumaFacutaTableAdapter();
            this.UnoMDDataSet = new UnoMD.UnoMDDataSet();
            this.NrComenziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NrComenziTableAdapter = new UnoMD.UnoMDDataSetTableAdapters.NrComenziTableAdapter();
            this.UnoMDDataSet2Rep = new UnoMD.UnoMDDataSet2Rep();
            ((System.ComponentModel.ISupportInitialize)(this.SumaFacutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnoMD_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnoMDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NrComenziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnoMDDataSet2Rep)).BeginInit();
            this.SuspendLayout();
            // 
            // SumaFacutaBindingSource
            // 
            this.SumaFacutaBindingSource.DataMember = "SumaFacuta";
            this.SumaFacutaBindingSource.DataSource = this.UnoMD_Report;
            // 
            // UnoMD_Report
            // 
            this.UnoMD_Report.DataSetName = "UnoMD_Report";
            this.UnoMD_Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SumaFacutaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SumaFacutaBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.SumaFacutaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UnoMD.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SumaFacutaTableAdapter
            // 
            this.SumaFacutaTableAdapter.ClearBeforeFill = true;
            // 
            // UnoMDDataSet
            // 
            this.UnoMDDataSet.DataSetName = "UnoMDDataSet";
            this.UnoMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NrComenziBindingSource
            // 
            this.NrComenziBindingSource.DataMember = "NrComenzi";
            this.NrComenziBindingSource.DataSource = this.UnoMDDataSet;
            // 
            // NrComenziTableAdapter
            // 
            this.NrComenziTableAdapter.ClearBeforeFill = true;
            // 
            // UnoMDDataSet2Rep
            // 
            this.UnoMDDataSet2Rep.DataSetName = "UnoMDDataSet2Rep";
            this.UnoMDDataSet2Rep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Raport_Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raport_Suma";
            this.Text = "Raport_Suma";
            this.Load += new System.EventHandler(this.Raport_Suma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SumaFacutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnoMD_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnoMDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NrComenziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnoMDDataSet2Rep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SumaFacutaBindingSource;
        private UnoMD_Report UnoMD_Report;
        private UnoMD_ReportTableAdapters.SumaFacutaTableAdapter SumaFacutaTableAdapter;
        private System.Windows.Forms.BindingSource NrComenziBindingSource;
        private UnoMDDataSet UnoMDDataSet;
        private UnoMDDataSetTableAdapters.NrComenziTableAdapter NrComenziTableAdapter;
        private UnoMDDataSet2Rep UnoMDDataSet2Rep;
    }
}