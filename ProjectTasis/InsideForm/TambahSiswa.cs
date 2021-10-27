using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace ProjectTasis.InsideForm
{
    public partial class TambahSiswa : Form
    {
        TasisEntities test;
        public TambahSiswa()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

            this.kelasComboBox.SelectedIndex = -1;
            try
            {
                btnTambah.Visible = false;
                btnEdit.Visible = false;
                iDTextBox.Clear();
                namaTextBox.Clear();
                alamatTextBox.Clear();
                btnSimpan.Visible = true;
                btnCancel.Visible = true;
                panel.Enabled = true;
                btnEditShow.Visible = false;
                namaTextBox.Focus();
                Siswa s = new Siswa();
                test.Siswas.Add(s);
                siswaBindingSource.Add(s);
                siswaBindingSource.MoveLast();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataSiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tasisDataSet.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.tasisDataSet.Siswa);
            panel.Enabled = false;
            btnSimpan.Visible = false;
            btnCancel.Visible = false;
            btnEdit.Visible = false;
            test = new TasisEntities();
            Auto();
            siswaBindingSource.DataSource = test.Siswas.ToList();
            LoadTheme();
        }
        private void Auto()

        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT Nama FROM Siswa", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                    while (reader.Read())
                    {
                        MyCollection.Add(reader["Nama"].ToString());
                    }
                    txtCari.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtCari.AutoCompleteCustomSource = MyCollection;
                    con.Close();
                }
            }
            catch (Exception ead)
            {
                MessageBox.Show(ead.Message);
            }
        }

        private void btnCariNama_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString))
                { 
                if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                        using (DataTable dt = new DataTable("Siswa"))
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Siswa Where Nama LIKE @Nama", cn))
                            {
                                cmd.Parameters.AddWithValue("Nama", string.Format("%{0}%", txtCari.Text));
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Tabungan Siswa" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    using (SqlCommand Cmd = new SqlCommand("SELECT * FROM Siswa Where Nama= '" + namaTextBox.Text + "'" , cn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(Cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        int i = ds.Tables[0].Rows.Count;
                        if (i > 0)
                        {
                            MessageBox.Show("Nama : " + namaTextBox.Text + " Sudah ada !", "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                if (MessageBox.Show("Apakah kamu yakin dan sudah di pastikan semua datanya benar ?", "Tabungan Siwa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    siswaBindingSource.EndEdit();
                                    test.SaveChangesAsync();
                                    panel.Enabled = false;
                                    if (MessageBox.Show("Berhasil Menginput Data !", "Tabungan Siwa", MessageBoxButtons.OK) == DialogResult.OK)
                                    {
                                        namaTextBox.Text = "";
                                        kelasComboBox.SelectedIndex = 1;
                                        alamatTextBox.Text = "";
                                        iDTextBox.Text = "0";
                                        btnCancel.Visible = false;
                                        btnSimpan.Visible = false;
                                        btnEdit.Visible = false;
                                        btnEditShow.Visible = true;
                                        btnTambah.Visible = true;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Lihat lagi datanya, apakah ada yang belum ke input atau enggak ! Note : Double Click kelas yang ingin di pilihnya !", "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            btnCancel.Visible = false;
            btnSimpan.Visible = false;
            btnEdit.Visible = false;
            btnEditShow.Visible = true;
            btnTambah.Visible = true;
            siswaBindingSource.ResetBindings(false);
            iDTextBox.Undo();
            try
            {
                foreach (DbEntityEntry entry in test.ChangeTracker.Entries())
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                        case EntityState.Modified:
                            entry.State = EntityState.Unchanged;
                            break;
                        case EntityState.Deleted:
                            entry.Reload();
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (namaTextBox.Text == "" || alamatTextBox.Text == "")
            {
                MessageBox.Show("Tolong masukan data yang ingin di edit !" , "Tabungan Siswa" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                return;
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString))
                {
                    try
                    {
                        if (cn.State == ConnectionState.Closed)
                        {
                            cn.Open();
                            using (DataTable dt = new DataTable("Siswa"))
                            {
                               using (SqlCommand cmds = new SqlCommand("UPDATE Siswa SET Nama=@Nama , Kelas=@Kelas , Alamat=Alamat WHERE ID=@No_Rekening", cn))
                               {
                                    cmds.Parameters.AddWithValue("No_Rekening", iDTextBox.Text );
                                    cmds.Parameters.AddWithValue("Nama", namaTextBox.Text );
                                    cmds.Parameters.AddWithValue("Kelas" , kelasComboBox.Text);
                                    cmds.Parameters.AddWithValue("Alamat" , alamatTextBox.Text);
                                    cmds.ExecuteNonQuery();
                                    MessageBox.Show("Berhasil Mengupdate data !", "Tabungan Siswa" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                               }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TambahSiswa ss = new TambahSiswa();
            ss.UpdateBounds();
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                        using (DataTable dt = new DataTable("Siswa"))
                        {
                            using (SqlCommand cmda = new SqlCommand("SELECT ID, Nama, Kelas, Alamat FROM Siswa ORDER BY ID ASC", cn))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(cmda);
                                DataTable dsa = new DataTable();
                                adapter.Fill(dsa);
                                dataGridView1.DataSource = dsa;
                            }
                        }
                    }
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Apakah Kamu yakin ingin menghapusnya ?", "Tabungan Siswa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        test.Siswas.Remove(siswaBindingSource.Current as Siswa);
                        siswaBindingSource.RemoveCurrent();
                        test.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               if (e.RowIndex != -1)
               {
                   DataGridViewRow gridView = dataGridView1.Rows[e.RowIndex];
                   iDTextBox.Text = gridView.Cells[0].Value.ToString();
                   namaTextBox.Text = gridView.Cells[1].Value.ToString();
                   kelasComboBox.SelectedItem = gridView.Cells[2].Value.ToString();
                   alamatTextBox.Text = gridView.Cells[3].Value.ToString();
               }
            }
            catch (Exception )
            {
                MessageBox.Show("Pilih datanya dulu di DataGrid !", "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditShow_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            panel.Enabled = true;
            btnEdit.Visible = true;
            btnEditShow.Visible = false;
            btnTambah.Visible = false;
        }
    }
}
