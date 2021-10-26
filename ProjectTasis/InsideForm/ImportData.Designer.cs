namespace ProjectTasis.InsideForm
{
    partial class ImportData
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.btnCariFile = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.CboSheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tasisDataSet = new ProjectTasis.TasisDataSet();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswaTableAdapter = new ProjectTasis.TasisDataSetTableAdapters.SiswaTableAdapter();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFile.Location = new System.Drawing.Point(133, 20);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(226, 27);
            this.txtFile.TabIndex = 1;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItems.AutoGenerateColumns = false;
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaDataGridViewTextBoxColumn,
            this.kelasDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dgItems.DataSource = this.siswaBindingSource;
            this.dgItems.Location = new System.Drawing.Point(0, 98);
            this.dgItems.Name = "dgItems";
            this.dgItems.Size = new System.Drawing.Size(499, 222);
            this.dgItems.TabIndex = 2;
            // 
            // btnCariFile
            // 
            this.btnCariFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCariFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariFile.Location = new System.Drawing.Point(365, 20);
            this.btnCariFile.Name = "btnCariFile";
            this.btnCariFile.Size = new System.Drawing.Size(34, 27);
            this.btnCariFile.TabIndex = 39;
            this.btnCariFile.Text = "....";
            this.btnCariFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCariFile.UseVisualStyleBackColor = true;
            this.btnCariFile.Click += new System.EventHandler(this.btnCariFile_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Control;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSimpan.Location = new System.Drawing.Point(340, 51);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(59, 27);
            this.btnSimpan.TabIndex = 38;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // CboSheet
            // 
            this.CboSheet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSheet.FormattingEnabled = true;
            this.CboSheet.Location = new System.Drawing.Point(133, 57);
            this.CboSheet.Name = "CboSheet";
            this.CboSheet.Size = new System.Drawing.Size(121, 21);
            this.CboSheet.TabIndex = 40;
            this.CboSheet.SelectedIndexChanged += new System.EventHandler(this.CboSheet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nama File :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Sheet :";
            // 
            // tasisDataSet
            // 
            this.tasisDataSet.DataSetName = "TasisDataSet";
            this.tasisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "Siswa";
            this.siswaBindingSource.DataSource = this.tasisDataSet;
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // kelasDataGridViewTextBoxColumn
            // 
            this.kelasDataGridViewTextBoxColumn.DataPropertyName = "Kelas";
            this.kelasDataGridViewTextBoxColumn.HeaderText = "Kelas";
            this.kelasDataGridViewTextBoxColumn.Name = "kelasDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 320);
            this.Controls.Add(this.btnCariFile);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboSheet);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.txtFile);
            this.Name = "ImportData";
            this.Text = "Impor Data";
            this.Load += new System.EventHandler(this.ImportData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Button btnCariFile;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ComboBox CboSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TasisDataSet tasisDataSet;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private TasisDataSetTableAdapters.SiswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
    }
}