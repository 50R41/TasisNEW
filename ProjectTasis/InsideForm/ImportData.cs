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
using System.IO;
using ExcelDataReader;
using Z.Dapper.Plus;
using System.Configuration;

namespace ProjectTasis.InsideForm
{
    public partial class ImportData : Form
    {
        public ImportData()
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

        private void ImportData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tasisDataSet.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.tasisDataSet.Siswa);
            // TODO: This line of code loads data into the 'tasisDataSet.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.tasisDataSet.Siswa);
            // TODO: This line of code loads data into the 'tasisDataSet.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.tasisDataSet.Siswa);
            // TODO: This line of code loads data into the 'tasisDataSet.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.tasisDataSet.Siswa);
            LoadTheme();
        }

        DataTableCollection tableCollection;
        private void btnCariFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog opnfl = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
                {
                    if (opnfl.ShowDialog() == DialogResult.OK)
                    {
                        txtFile.Text = opnfl.FileName;
                        using (var stream = File.Open(opnfl.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                CboSheet.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                    CboSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message, "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFile.Text = "";
            }
        }

        private void CboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tableCollection[CboSheet.SelectedItem.ToString()];
                if (dt != null)
                {
                    List<SiswaImport> siswas = new List<SiswaImport>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SiswaImport siswa = new SiswaImport();
                        siswa.Nama = dt.Rows[i]["Nama"].ToString();
                        siswa.Kelas = dt.Rows[i]["Kelas"].ToString();
                        siswa.Alamat = dt.Rows[i]["Alamat"].ToString();
                        siswas.Add(siswa);
                    }
                    siswaBindingSource.DataSource = siswas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtFile.Text == "")
            {
                MessageBox.Show("Pilih dulu filenya !" , "Tabungan Siswa" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                return;
            }
            if (CboSheet.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih dulu sheetnya !" , "Tabungan Siswa" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                return;
            }
            List<SiswaImport> siswas = siswaBindingSource.DataSource as List<SiswaImport>;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    using (SqlCommand Cmd = new SqlCommand("SELECT * FROM Siswa Where Nama= '" + siswas[0].Nama + "'", cn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(Cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        int i = ds.Tables[0].Rows.Count;
                        if (i > 0)
                        {
                            MessageBox.Show("Data sudah ada !", "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                string con = "Server=localhost;Database=Tasis;Trusted_Connection=True";
                                DapperPlusManager.Entity<SiswaImport>().Table("Siswa");
                                if (siswas != null)
                                {
                                    using (IDbConnection db = new SqlConnection(con))
                                    {
                                        db.BulkInsert(siswas);
                                    }
                                }
                                MessageBox.Show("Berhasil !!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Tabungan Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
