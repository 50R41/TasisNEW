namespace ProjectTasis.InsideForm
{
    partial class TransaksiTabungan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoRekening = new System.Windows.Forms.TextBox();
            this.comboBoxTransaksi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCariNama = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.tasisDataSet = new ProjectTasis.TasisDataSet();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter = new ProjectTasis.TasisDataSetTableAdapters.TransaksiTableAdapter();
            this.noRekeningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setoranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penarikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(373, 138);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 25);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noRekeningDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.setoranDataGridViewTextBoxColumn,
            this.penarikanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaksiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 154);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransaksi.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Location = new System.Drawing.Point(375, 59);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(68, 29);
            this.btnTransaksi.TabIndex = 27;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = false;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Cari                  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "No Rekening    : ";
            // 
            // txtNoRekening
            // 
            this.txtNoRekening.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoRekening.Location = new System.Drawing.Point(94, 19);
            this.txtNoRekening.Name = "txtNoRekening";
            this.txtNoRekening.Size = new System.Drawing.Size(222, 20);
            this.txtNoRekening.TabIndex = 36;
            // 
            // comboBoxTransaksi
            // 
            this.comboBoxTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTransaksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransaksi.FormattingEnabled = true;
            this.comboBoxTransaksi.Items.AddRange(new object[] {
            "Setoran",
            "Penarikan"});
            this.comboBoxTransaksi.Location = new System.Drawing.Point(94, 58);
            this.comboBoxTransaksi.Name = "comboBoxTransaksi";
            this.comboBoxTransaksi.Size = new System.Drawing.Size(222, 21);
            this.comboBoxTransaksi.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Jenis Transaksi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nominal            : ";
            // 
            // txtNominal
            // 
            this.txtNominal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNominal.Location = new System.Drawing.Point(94, 94);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(222, 20);
            this.txtNominal.TabIndex = 42;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(363, 59);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(50, 29);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCariNama
            // 
            this.btnCariNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCariNama.BackColor = System.Drawing.SystemColors.Control;
            this.btnCariNama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariNama.Location = new System.Drawing.Point(322, 139);
            this.btnCariNama.Name = "btnCariNama";
            this.btnCariNama.Size = new System.Drawing.Size(45, 25);
            this.btnCariNama.TabIndex = 46;
            this.btnCariNama.Text = "Cari";
            this.btnCariNama.UseVisualStyleBackColor = false;
            this.btnCariNama.Click += new System.EventHandler(this.btnCariNama_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtNoRekening);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.txtNominal);
            this.panel.Controls.Add(this.comboBoxTransaksi);
            this.panel.Location = new System.Drawing.Point(0, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(319, 126);
            this.panel.TabIndex = 45;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(420, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 29);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCari
            // 
            this.txtCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCari.Location = new System.Drawing.Point(94, 143);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(215, 20);
            this.txtCari.TabIndex = 49;
            // 
            // tasisDataSet
            // 
            this.tasisDataSet.DataSetName = "TasisDataSet";
            this.tasisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.tasisDataSet;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // noRekeningDataGridViewTextBoxColumn
            // 
            this.noRekeningDataGridViewTextBoxColumn.DataPropertyName = "No_Rekening";
            this.noRekeningDataGridViewTextBoxColumn.HeaderText = "No Rekening";
            this.noRekeningDataGridViewTextBoxColumn.Name = "noRekeningDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // setoranDataGridViewTextBoxColumn
            // 
            this.setoranDataGridViewTextBoxColumn.DataPropertyName = "Setoran";
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.setoranDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.setoranDataGridViewTextBoxColumn.HeaderText = "Setoran";
            this.setoranDataGridViewTextBoxColumn.Name = "setoranDataGridViewTextBoxColumn";
            // 
            // penarikanDataGridViewTextBoxColumn
            // 
            this.penarikanDataGridViewTextBoxColumn.DataPropertyName = "Penarikan";
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.penarikanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.penarikanDataGridViewTextBoxColumn.HeaderText = "Penarikan";
            this.penarikanDataGridViewTextBoxColumn.Name = "penarikanDataGridViewTextBoxColumn";
            // 
            // TransaksiTabungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 325);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCariNama);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTransaksi);
            this.Controls.Add(this.panel);
            this.Name = "TransaksiTabungan";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoRekening;
        private System.Windows.Forms.ComboBox comboBoxTransaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCariNama;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCari;
        private TasisDataSet tasisDataSet;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private TasisDataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noRekeningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setoranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penarikanDataGridViewTextBoxColumn;
    }
}