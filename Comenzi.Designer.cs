
namespace UnoMD
{
    partial class Comenzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comenzi));
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idComandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrComenziiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataComenziiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comenziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unoMDDataSet = new UnoMD.UnoMDDataSet();
            this.comenziTableAdapter = new UnoMD.UnoMDDataSetTableAdapters.ComenziTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoMDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Location = new System.Drawing.Point(858, 513);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(114, 66);
            this.back.TabIndex = 12;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete.AutoSize = true;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete.Location = new System.Drawing.Point(778, 268);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(168, 89);
            this.delete.TabIndex = 11;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update.AutoSize = true;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.update.Location = new System.Drawing.Point(778, 139);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(168, 89);
            this.update.TabIndex = 10;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.AutoSize = true;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add.Location = new System.Drawing.Point(778, 15);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(168, 89);
            this.add.TabIndex = 9;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComandaDataGridViewTextBoxColumn,
            this.nrComenziiDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn,
            this.dataComenziiDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comenziBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 588);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idComandaDataGridViewTextBoxColumn
            // 
            this.idComandaDataGridViewTextBoxColumn.DataPropertyName = "Id_Comanda";
            this.idComandaDataGridViewTextBoxColumn.HeaderText = "Id_Comanda";
            this.idComandaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idComandaDataGridViewTextBoxColumn.Name = "idComandaDataGridViewTextBoxColumn";
            this.idComandaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idComandaDataGridViewTextBoxColumn.Width = 116;
            // 
            // nrComenziiDataGridViewTextBoxColumn
            // 
            this.nrComenziiDataGridViewTextBoxColumn.DataPropertyName = "Nr_Comenzii";
            this.nrComenziiDataGridViewTextBoxColumn.HeaderText = "Nr_Comenzii";
            this.nrComenziiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrComenziiDataGridViewTextBoxColumn.Name = "nrComenziiDataGridViewTextBoxColumn";
            this.nrComenziiDataGridViewTextBoxColumn.Width = 117;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "Id_Produs";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "Id_Produs";
            this.idProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.Width = 101;
            // 
            // dataComenziiDataGridViewTextBoxColumn
            // 
            this.dataComenziiDataGridViewTextBoxColumn.DataPropertyName = "DataComenzii";
            this.dataComenziiDataGridViewTextBoxColumn.HeaderText = "DataComenzii";
            this.dataComenziiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataComenziiDataGridViewTextBoxColumn.Name = "dataComenziiDataGridViewTextBoxColumn";
            this.dataComenziiDataGridViewTextBoxColumn.Width = 124;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 82;
            // 
            // comenziBindingSource
            // 
            this.comenziBindingSource.DataMember = "Comenzi";
            this.comenziBindingSource.DataSource = this.unoMDDataSet;
            // 
            // unoMDDataSet
            // 
            this.unoMDDataSet.DataSetName = "UnoMDDataSet";
            this.unoMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comenziTableAdapter
            // 
            this.comenziTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(778, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 89);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comenzi";
            this.Text = "Comenzi";
            this.Load += new System.EventHandler(this.Comenzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoMDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UnoMDDataSet unoMDDataSet;
        private System.Windows.Forms.BindingSource comenziBindingSource;
        private UnoMDDataSetTableAdapters.ComenziTableAdapter comenziTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrComenziiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataComenziiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}