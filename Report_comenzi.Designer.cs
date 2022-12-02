
namespace UnoMD
{
    partial class Report_comenzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_comenzi));
            this.NrComenziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnoMDDataSet = new UnoMD.UnoMDDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NrComenziTableAdapter = new UnoMD.UnoMDDataSetTableAdapters.NrComenziTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NrComenziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnoMDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // NrComenziBindingSource
            // 
            this.NrComenziBindingSource.DataMember = "NrComenzi";
            this.NrComenziBindingSource.DataSource = this.UnoMDDataSet;
            // 
            // UnoMDDataSet
            // 
            this.UnoMDDataSet.DataSetName = "UnoMDDataSet";
            this.UnoMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NrComenziBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UnoMD.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // NrComenziTableAdapter
            // 
            this.NrComenziTableAdapter.ClearBeforeFill = true;
            // 
            // Report_comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_comenzi";
            this.Text = "Report_comenzi";
            this.Load += new System.EventHandler(this.Report_comenzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NrComenziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnoMDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NrComenziBindingSource;
        private UnoMDDataSet UnoMDDataSet;
        private UnoMDDataSetTableAdapters.NrComenziTableAdapter NrComenziTableAdapter;
    }
}