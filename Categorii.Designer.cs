
namespace UnoMD
{
    partial class Categorii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorii));
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unoMDDataSet = new UnoMD.UnoMDDataSet();
            this.categoriiTableAdapter = new UnoMD.UnoMDDataSetTableAdapters.CategoriiTableAdapter();
            this.unoMDDataSet1 = new UnoMD.UnoMDDataSet();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoMDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoMDDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Location = new System.Drawing.Point(791, 516);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(114, 66);
            this.back.TabIndex = 16;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete.Location = new System.Drawing.Point(711, 275);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(168, 89);
            this.delete.TabIndex = 15;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.update.Location = new System.Drawing.Point(711, 146);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(168, 89);
            this.update.TabIndex = 14;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add.Location = new System.Drawing.Point(711, 22);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(168, 89);
            this.add.TabIndex = 13;
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
            this.idCategorieDataGridViewTextBoxColumn,
            this.denCatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 592);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // idCategorieDataGridViewTextBoxColumn
            // 
            this.idCategorieDataGridViewTextBoxColumn.DataPropertyName = "Id_Categorie";
            this.idCategorieDataGridViewTextBoxColumn.HeaderText = "Id_Categorie";
            this.idCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCategorieDataGridViewTextBoxColumn.Name = "idCategorieDataGridViewTextBoxColumn";
            this.idCategorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategorieDataGridViewTextBoxColumn.Width = 117;
            // 
            // denCatDataGridViewTextBoxColumn
            // 
            this.denCatDataGridViewTextBoxColumn.DataPropertyName = "Den_Cat";
            this.denCatDataGridViewTextBoxColumn.HeaderText = "Den_Cat";
            this.denCatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denCatDataGridViewTextBoxColumn.Name = "denCatDataGridViewTextBoxColumn";
            this.denCatDataGridViewTextBoxColumn.Width = 92;
            // 
            // categoriiBindingSource
            // 
            this.categoriiBindingSource.DataMember = "Categorii";
            this.categoriiBindingSource.DataSource = this.unoMDDataSet;
            // 
            // unoMDDataSet
            // 
            this.unoMDDataSet.DataSetName = "UnoMDDataSet";
            this.unoMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriiTableAdapter
            // 
            this.categoriiTableAdapter.ClearBeforeFill = true;
            // 
            // unoMDDataSet1
            // 
            this.unoMDDataSet1.DataSetName = "UnoMDDataSet";
            this.unoMDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(711, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 89);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Categorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categorii";
            this.Text = "Categorii";
            this.Load += new System.EventHandler(this.Categorii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoMDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unoMDDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UnoMDDataSet unoMDDataSet;
        private System.Windows.Forms.BindingSource categoriiBindingSource;
        private UnoMDDataSetTableAdapters.CategoriiTableAdapter categoriiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denCatDataGridViewTextBoxColumn;
        private UnoMDDataSet unoMDDataSet1;
        private System.Windows.Forms.Button button1;
    }
}