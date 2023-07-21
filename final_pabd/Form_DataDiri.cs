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
    public partial class Form_DataDiri : Form
    {
        private string stringConnection = "data source =LAPTOP-1JRJB77C\\HMMPRYT;" +
            "database=sewamotor;user ID=sa; password=123";
        private SqlConnection koneksi;
        private string Nama, Notelp, Noktp, Idpelanggan, Alamat, karyawan;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id_pelanggan = txtplgn.Text;
            string nama_plgn = txtNama.Text;
            string no_hp = txtNotelp.Text;
            string no_ktp = txtNoktp.Text;
            string alamat = txtAlamat.Text;

            if (!int.TryParse(no_hp, out int no_hpInt))
            {
                MessageBox.Show("No. HP harus diisi dengan Angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(no_ktp, out int no_ktpInt))
            {
                MessageBox.Show("No. KTP harus diisi dengan Angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string upd = "UPDATE pelanggan SET id_pelanggan = @id_pelanggan, nama_plgn = @nama_plgn, no_hp = @no_hp, no_ktp = @no_ktp, alamat= @alamat where id_pelanggan = @id_pelanggan";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(upd, conn))
                {
                    cmd.Parameters.AddWithValue("id_pelanggan", txtplgn.Text);
                    cmd.Parameters.AddWithValue("nama_plgn", txtNama.Text);
                    cmd.Parameters.AddWithValue("no_hp", txtNotelp.Text);
                    cmd.Parameters.AddWithValue("no_ktp", txtNoktp.Text);
                    cmd.Parameters.AddWithValue("alamat", txtAlamat.Text);
                    
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil di Updated");
                        datagridview();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occured: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured: " + ex.Message);
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form_DataDiri_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void datagridview()
        {
            koneksi.Open();
            string str = "select * from dbo.pelanggan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridview();
            btnRead.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_menu fm = new Form_menu();
            fm.Show();
            this.Close();
        }

        private void cbxNama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form_DataDiri()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtNama.Text = "";
            txtNotelp.Text = "";
            txtNoktp.Text = "";
            txtplgn.Text = "";
            txtAlamat.Text = ""; 
            txtNama.Enabled = true;
            txtNotelp.Enabled = true;
            txtNoktp.Enabled = true;
            txtplgn.Enabled = true;
            txtAlamat.Enabled = true;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
            cbid_karyawan();
        }

        private void cbid_karyawan()
        {
            koneksi.Open();
            string str = "select no_id from dbo.karyawan";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxNama.DisplayMember = "no_id";
            cbxNama.ValueMember = "no_id";
            cbxNama.DataSource = ds.Tables[0];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Nama = txtNama.Text;
            Notelp = txtNotelp.Text;
            Noktp = txtNoktp.Text;
            Idpelanggan = txtplgn.Text;
            Alamat = txtAlamat.Text;
            karyawan = cbxNama.Text;


            if (string.IsNullOrEmpty(Nama) || string.IsNullOrEmpty(Notelp) || string.IsNullOrEmpty(Noktp) || string.IsNullOrEmpty(Idpelanggan) || string.IsNullOrEmpty(Alamat)
             || string.IsNullOrEmpty(karyawan))
            {
                MessageBox.Show("Harap isi semua field terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(Notelp, out int NotelpNumber))
            {
                MessageBox.Show("Nomor HP harus berupa Angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(Noktp, out _))
            {
                MessageBox.Show("Nomor Ktp harus berupa Angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(Idpelanggan, out _))
            {
                MessageBox.Show("Id Pelanggan harus berupa Angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    try
                    {
                        koneksi.Open();
                        string str = "insert into dbo.pelanggan (nama_plgn, no_hp, no_ktp , Id_pelanggan, alamat, no_id)" +
                    "values(@nama_plgn, @no_hp, @no_ktp , @Id_pelanggan, @alamat, @no_id)";
                        SqlCommand cmd = new SqlCommand(str, koneksi);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("nama_plgn", Nama));
                        cmd.Parameters.Add(new SqlParameter("no_hp", NotelpNumber));
                        cmd.Parameters.Add(new SqlParameter("no_ktp", Noktp));
                        cmd.Parameters.Add(new SqlParameter("Id_pelanggan", Idpelanggan));
                        cmd.Parameters.Add(new SqlParameter("alamat", Alamat));
                        cmd.Parameters.Add(new SqlParameter("no_id", karyawan));

                        cmd.ExecuteNonQuery();
                        koneksi.Close();

                        MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        refreshform();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dlt = "DELETE FROM pelanggan WHERE Id_pelanggan = @Id_pelanggan";
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(dlt, conn))
                {
                    cmd.Parameters.AddWithValue("Id_pelanggan", txtplgn.Text);
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        datagridview();

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


    }
}
