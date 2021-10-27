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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ProjectTasis.InsideForm
{
    public partial class TransaksiTabungan : Form
    {
        TasisEntities ts;
        public TransaksiTabungan()
        {
            InitializeComponent();
            load_table();
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
        private void Transaksi_Load(object sender, EventArgs e)
        {
            Auto_transaksi();
            LoadTheme();
            ts = new TasisEntities();
            btnSubmit.Visible = false;
            btnCancel.Visible = false;
            panel.Enabled = false;
        }
        void load_table()
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas, Siswa.Alamat, SUM( Setoran - Penarikan ) AS Saldo FROM Transaksi JOIN Siswa on Siswa.ID = No_Rekening GROUP BY Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas , Siswa.Alamat", con))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        DataTable dt = new DataTable();
                        sda.SelectCommand = cmd;
                        sda.Fill(dt);
                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;
                        dataGridView1.DataSource = bs;
                        dataGridView1.Columns[0].HeaderText = "No Rekening";
                        dataGridView1.Columns[4].DefaultCellStyle.Format = "Rp###,###";
                        sda.Update(dt);
                    }
                }
            }
            catch (Exception ead)
            {
                MessageBox.Show(ead.Message);
            }
        }

        private void Auto_transaksi()
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT ID FROM Siswa", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                    while (reader.Read())
                    {
                        MyCollection.Add(reader["ID"].ToString());
                    }
                    txtCari.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtCari.AutoCompleteCustomSource = MyCollection;
                    txtNoRekening.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtNoRekening.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtNoRekening.AutoCompleteCustomSource = MyCollection;
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
                        using (DataTable dt = new DataTable("Transaksi"))
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas, Siswa.Alamat, SUM( Setoran - Penarikan ) AS Saldo FROM Transaksi JOIN Siswa on Siswa.ID = No_Rekening WHERE Siswa.ID=@ID GROUP BY Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas , Siswa.Alamat", cn))
                            {
                                cmd.Parameters.AddWithValue("ID" , txtCari.Text);
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
                MessageBox.Show(ex.Message, "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            btnCancel.Visible = true;
            btnSubmit.Visible = true;
            btnTransaksi.Visible = false;
            comboBoxTransaksi.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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
                            using (SqlCommand cmda = new SqlCommand("SELECT Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas, Siswa.Alamat, SUM( Setoran - Penarikan ) AS Saldo FROM Transaksi JOIN Siswa on Siswa.ID = No_Rekening GROUP BY Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas , Siswa.Alamat", cn))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(cmda);
                                DataTable dsa = new DataTable();
                                adapter.Fill(dsa);
                                dataGridView1.DataSource = dsa;
                            }
                        }
                        using (SqlCommand cmda = new SqlCommand("UPDATE Siswa SET Saldo = ( SELECT SUM(Saldo) FROM Transaksi WHERE Transaksi.No_Rekening = Siswa.ID)", cn))
                        {
                            cmda.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message, "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSubmit.Visible = false;
            btnCancel.Visible = false;
            btnTransaksi.Visible = true;
            panel.Enabled = false;
            txtNoRekening.Clear();
            txtNominal.Clear();
            comboBoxTransaksi.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString))
            {
                  try
                  {
                       if (cn.State == ConnectionState.Closed)
                       {
                           cn.Open();
                           using (DataTable dt = new DataTable("Transaksi"))
                           {
                              if (comboBoxTransaksi.SelectedIndex == 0)
                              {
                                 using (SqlCommand cmds = new SqlCommand("INSERT INTO Transaksi ( No_Rekening, Tanggal, Setoran, Penarikan) VALUES ( @No_Rekening , GETDATE(), @Setoran, DEFAULT)", cn))
                                 {
                                       cmds.Parameters.AddWithValue("No_Rekening", txtNoRekening.Text);
                                       cmds.Parameters.AddWithValue("Setoran", txtNominal.Text);
                                       cmds.ExecuteNonQuery();
                                      if (MessageBox.Show("Berhasil melakukan setoran sebesar : Rp " + txtNominal.Text + "    Note : Jangan lupa tekan tombol refresh !", "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                      {
                                        txtNoRekening.Text = "";
                                        txtNominal.Text = "";
                                        comboBoxTransaksi.SelectedIndex = -1;
                                      } 
                                 }
                              }
                              if (comboBoxTransaksi.SelectedIndex == 1)
                              {
                                    using (SqlCommand cmdpenarikan = new SqlCommand("INSERT INTO Transaksi ( No_Rekening, Tanggal, Setoran, Penarikan) VALUES ( @No_Rekening , GETDATE(), DEFAULT, @Penarikan)", cn))
                                    {
                                        cmdpenarikan.Parameters.AddWithValue("No_Rekening", txtNoRekening.Text);
                                        cmdpenarikan.Parameters.AddWithValue("Penarikan", txtNominal.Text);
                                        cmdpenarikan.ExecuteNonQuery();
                                         if (MessageBox.Show("Berhasil melakukan penarikan sebesar : Rp " + txtNominal.Text + "    Note : Jangan lupa tekan tombol refresh !", "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                         {
                                             txtNoRekening.Text = "";
                                             txtNominal.Text = "";
                                             comboBoxTransaksi.SelectedIndex = -1;
                                         }
                                    }
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
}
