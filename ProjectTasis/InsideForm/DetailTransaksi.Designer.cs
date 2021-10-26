namespace ProjectTasis.InsideForm
{
    partial class DetailTransaksi
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
            this.btnCetak = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCariNama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCetak
            // 
            this.btnCetak.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCetak.BackColor = System.Drawing.SystemColors.Control;
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCetak.Location = new System.Drawing.Point(396, 30);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(47, 23);
            this.btnCetak.TabIndex = 42;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 279);
            this.dataGridView1.TabIndex = 41;
            // 
            // txtCari
            // 
            this.txtCari.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCari.Location = new System.Drawing.Point(91, 32);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(251, 20);
            this.txtCari.TabIndex = 40;
            // 
            // btnCariNama
            // 
            this.btnCariNama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCariNama.BackColor = System.Drawing.SystemColors.Control;
            this.btnCariNama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariNama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCariNama.Location = new System.Drawing.Point(348, 30);
            this.btnCariNama.Name = "btnCariNama";
            this.btnCariNama.Size = new System.Drawing.Size(42, 24);
            this.btnCariNama.TabIndex = 43;
            this.btnCariNama.Text = "Cari";
            this.btnCariNama.UseVisualStyleBackColor = false;
            this.btnCariNama.Click += new System.EventHandler(this.btnCariNama_Click);
            // 
            // DetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 360);
            this.Controls.Add(this.btnCariNama);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCari);
            this.Name = "DetailTransaksi";
            this.Text = "Detail Transaksi";
            this.Load += new System.EventHandler(this.DetailTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCariNama;
    }
}