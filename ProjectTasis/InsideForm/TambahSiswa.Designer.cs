namespace ProjectTasis.InsideForm
{
    partial class TambahSiswa
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
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label kelasLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label iDLabel;
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasisDataSet = new ProjectTasis.TasisDataSet();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.kelasComboBox = new System.Windows.Forms.ComboBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.btnCariNama = new System.Windows.Forms.Button();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditShow = new System.Windows.Forms.Button();
            this.siswaTableAdapter = new ProjectTasis.TasisDataSetTableAdapters.SiswaTableAdapter();
            alamatLabel = new System.Windows.Forms.Label();
            kelasLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasisDataSet)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // alamatLabel
            // 
            alamatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(12, 121);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(75, 13);
            alamatLabel.TabIndex = 37;
            alamatLabel.Text = "Alamat           :";
            // 
            // kelasLabel
            // 
            kelasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            kelasLabel.AutoSize = true;
            kelasLabel.Location = new System.Drawing.Point(16, 94);
            kelasLabel.Name = "kelasLabel";
            kelasLabel.Size = new System.Drawing.Size(72, 13);
            kelasLabel.TabIndex = 38;
            kelasLabel.Text = "Kelas            :";
            // 
            // namaLabel
            // 
            namaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(14, 61);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(74, 13);
            namaLabel.TabIndex = 39;
            namaLabel.Text = "Nama            :";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(9, 25);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(79, 13);
            iDLabel.TabIndex = 41;
            iDLabel.Text = "No Rekening  :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(368, 196);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 25);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.kelasDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 98);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "No Rekening";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "Siswa";
            this.siswaBindingSource.DataSource = this.tasisDataSet;
            // 
            // tasisDataSet
            // 
            this.tasisDataSet.DataSetName = "TasisDataSet";
            this.tasisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambah.BackColor = System.Drawing.SystemColors.Control;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Location = new System.Drawing.Point(408, 62);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(63, 30);
            this.btnTambah.TabIndex = 21;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(352, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 30);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cari                 :";
            // 
            // txtCari
            // 
            this.txtCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCari.Location = new System.Drawing.Point(95, 198);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(215, 20);
            this.txtCari.TabIndex = 34;
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alamatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siswaBindingSource, "Alamat", true));
            this.alamatTextBox.Location = new System.Drawing.Point(92, 119);
            this.alamatTextBox.Multiline = true;
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(215, 51);
            this.alamatTextBox.TabIndex = 38;
            // 
            // kelasComboBox
            // 
            this.kelasComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kelasComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.kelasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siswaBindingSource, "Kelas", true));
            this.kelasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelasComboBox.FormattingEnabled = true;
            this.kelasComboBox.Items.AddRange(new object[] {
            "X RPL 1",
            "X RPL 2",
            "X TKJ 1",
            "X TKJ 2",
            "X AKL 1",
            "X AKL 2",
            "X BDP 1",
            "X BDP 2",
            "X OTKP 1",
            "X OTKP 2",
            "XI RPL 1",
            "XI RPL 2",
            "XI TKJ 1",
            "XI TKJ 2",
            "XI AKL 1",
            "XI AKL 2",
            "XI BDP 1",
            "XI BDP 2",
            "XI OTKP 1",
            "XI OTKP 2",
            "XII RPL 1",
            "XII RPL 2",
            "XII TKJ 1",
            "XII TKJ 2",
            "XII AKL 1",
            "XII AKL 2",
            "XII BDP 1",
            "XII BDP 2",
            "XII OTKP 1",
            "XII OTKP 2 "});
            this.kelasComboBox.Location = new System.Drawing.Point(92, 90);
            this.kelasComboBox.Name = "kelasComboBox";
            this.kelasComboBox.Size = new System.Drawing.Size(215, 21);
            this.kelasComboBox.TabIndex = 39;
            // 
            // namaTextBox
            // 
            this.namaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siswaBindingSource, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(92, 56);
            this.namaTextBox.Multiline = true;
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(215, 25);
            this.namaTextBox.TabIndex = 40;
            // 
            // btnCariNama
            // 
            this.btnCariNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariNama.BackColor = System.Drawing.SystemColors.Control;
            this.btnCariNama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariNama.Location = new System.Drawing.Point(316, 196);
            this.btnCariNama.Name = "btnCariNama";
            this.btnCariNama.Size = new System.Drawing.Size(46, 25);
            this.btnCariNama.TabIndex = 41;
            this.btnCariNama.Text = "Cari";
            this.btnCariNama.UseVisualStyleBackColor = false;
            this.btnCariNama.Click += new System.EventHandler(this.btnCariNama_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siswaBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(92, 23);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(215, 20);
            this.iDTextBox.TabIndex = 42;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Control;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(412, 96);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(59, 30);
            this.btnSimpan.TabIndex = 43;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.namaTextBox);
            this.panel.Controls.Add(this.alamatTextBox);
            this.panel.Controls.Add(iDLabel);
            this.panel.Controls.Add(alamatLabel);
            this.panel.Controls.Add(this.iDTextBox);
            this.panel.Controls.Add(this.kelasComboBox);
            this.panel.Controls.Add(kelasLabel);
            this.panel.Controls.Add(namaLabel);
            this.panel.Location = new System.Drawing.Point(3, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(310, 186);
            this.panel.TabIndex = 44;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(352, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 30);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditShow
            // 
            this.btnEditShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShow.Location = new System.Drawing.Point(340, 62);
            this.btnEditShow.Name = "btnEditShow";
            this.btnEditShow.Size = new System.Drawing.Size(62, 30);
            this.btnEditShow.TabIndex = 46;
            this.btnEditShow.Text = "Update";
            this.btnEditShow.UseVisualStyleBackColor = true;
            this.btnEditShow.Click += new System.EventHandler(this.btnEditShow_Click);
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // TambahSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 325);
            this.Controls.Add(this.btnEditShow);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCariNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTambah);
            this.Name = "TambahSiswa";
            this.Text = "Tambah Siswa";
            this.Load += new System.EventHandler(this.DataSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasisDataSet)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.ComboBox kelasComboBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.Button btnCariNama;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditShow;
        private TasisDataSet tasisDataSet;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private TasisDataSetTableAdapters.SiswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
    }
}