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
            Load_table();
        }
        void Load_table()
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT Transaksi.No_Rekening, Siswa.Nama, Transaksi.Tanggal, Transaksi.Setoran,Transaksi.Penarikan , Siswa.Saldo FROM Transaksi JOIN Siswa on Siswa.ID = No_Rekening GROUP BY Transaksi.No_Rekening, Siswa.Nama, Transaksi.Tanggal , Transaksi.Setoran , Transaksi.Penarikan, Siswa.Saldo", con);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                    dataGridView1.Columns[0].HeaderText = "No Rekening";
                    dataGridView1.Columns[4].DefaultCellStyle.Format = "C0";
                    dataGridView1.Columns[3].DefaultCellStyle.Format = "C0";
                    dataGridView1.Columns[5].DefaultCellStyle.Format = "Rp###,###";
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
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TasisCon"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                        using (DataTable dt = new DataTable("Transaksi"))
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT Transaksi.No_Rekening, Siswa.Nama, Transaksi.Tanggal, Transaksi.Setoran,Transaksi.Penarikan , Siswa.Saldo FROM Transaksi JOIN Siswa on Siswa.ID = No_Rekening WHERE Siswa.ID=@ID GROUP BY Transaksi.No_Rekening, Siswa.Nama, Transaksi.Tanggal , Transaksi.Setoran , Transaksi.Penarikan, Siswa.Saldo", cn))
                            {
                                cmd.Parameters.AddWithValue("ID", txtCari.Text);
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
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 2] = "No Rekening";
            xlWorkSheet.Cells[1, 3] = "Nama";
            xlWorkSheet.Cells[1, 4] = "Tanggal";
            xlWorkSheet.Cells[1, 5] = "Setoran";
            xlWorkSheet.Cells[1, 6] = "Penarikan";
            xlWorkSheet.Cells[1, 7] = "Saldo";
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[2, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
