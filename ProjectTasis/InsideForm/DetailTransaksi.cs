using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProjectTasis.InsideForm
{
    public partial class DetailTransaksi : Form
    {
        public DetailTransaksi()
        {
            InitializeComponent();
            load_table();
        }
        void load_table()
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas, Siswa.Alamat, SUM( Setoran - Penarikan ) AS Saldo FROM Transaksi JOIN Siswa on Siswa.ID = No_Rekening GROUP BY Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas , Siswa.Alamat", con);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[4].DefaultCellStyle.Format = "Rp###,###";
                    sda.Update(dt);
                }
            }
            catch (Exception ead)
            {
                MessageBox.Show(ead.Message);
            }

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

        private void DetailTransaksi_Load(object sender, EventArgs e)
        {
            LoadTheme();
            Auto();
        }
        private void Auto()

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
            //try
            //{
            //    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString))
            //    {
            //        if (cn.State == ConnectionState.Closed)
            //        {
            //            cn.Open();
            //            using (DataTable dt = new DataTable("Transaksi"))
            //            {
            //                using (SqlCommand cmd = new SqlCommand("SELECT Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas, Siswa.Alamat, SUM( Setoran - Penarikan ) AS Saldo FROM Transaksi JOIN Siswa on Siswa.ID = No_Rekening GROUP BY Transaksi.No_Rekening, Siswa.Nama, Siswa.Kelas , Siswa.Alamat WHERE Siswa.ID=@ID", cn))
            //                {
            //                    cmd.Parameters.AddWithValue("ID", txtCari.Text);
            //                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //                    adapter.Fill(dt);
            //                    dataGridView1.DataSource = dt;
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
