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

namespace final_pabd
{

    public partial class Form_karyawan : Form
    {
        private string stringConnection = "data source =DESKTOP-BI70IVU;" +
           "database=sewamotor;user ID=sa; password=sayangmei";
        private SqlConnection koneksi;
        private string Nama, Notelp, Noid, Noktp;

        public Form_karyawan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dlt = "DELETE FROM karyawan WHERE no_id = @no_id";
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(dlt, conn))
                {
                    cmd.Parameters.AddWithValue("no_id", txtNoid.Text);
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        DataGridView();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An Error Occurred: " + ex.Message + ("Error Code: " + ex.Number));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An Error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Nama = txtNama.Text;
            Notelp = txtNotelp.Text;
            Noktp = txtNoktp.Text;
            Noid = txtNoid.Text;

            koneksi.Open();
            string str = "insert into dbo.karyawan (nama_karyawan, no_telp, no_ktp , no_id)" + "values(@nama_karyawan, @no_telp, @no_ktp , @no_id)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("nama_karyawan", Nama));
            cmd.Parameters.Add(new SqlParameter("no_telp", Notelp));
            cmd.Parameters.Add(new SqlParameter("no_ktp", Noktp));
            cmd.Parameters.Add(new SqlParameter("no_id", Noid));

            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form_menu().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void refreshform()
        {
            txtNama.Text = "";
            txtNotelp.Text = "";
            txtNoktp.Text = "";
            txtNoid.Text = "";
            txtNama.Enabled = true;
            txtNotelp.Enabled = true;
            txtNoktp.Enabled = true;
            txtNoid.Enabled = true;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView();
            btnRead.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.karyawan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
    }
}
