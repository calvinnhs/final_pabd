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
    public partial class Pemilik : Form
    {
        private string stringConnection = "data source =LAPTOP-1JRJB77C\\HMMPRYT;" +
          "database=sewamotor;user ID=sa; password=123";
        private SqlConnection koneksi;
        private string ID, nama, no;
        public Pemilik()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }
        private void refreshform() 
        {
            txtID.Text = "";
            txtnama.Text = "";
            txtnohp.Text = "";
            txtID.Enabled = true;
            txtnama.Enabled = true;
            txtnohp.Enabled = true;
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            datagridview();
            btnread.Enabled = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form_menu fm = new Form_menu();
            fm.Show();
            this.Close();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            ID = txtID.Text;
            nama = txtnama.Text;
            no = txtnohp.Text;

            if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(no))
            {
                MessageBox.Show("Harap isi semua field terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(no, out _))
            {
                MessageBox.Show("Nomor HP harus berupa Angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(ID, out _))
            {
                MessageBox.Show("ID harus berupa Angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    try
                    {
                        koneksi.Open();
                        string str = "insert into dbo.pemilik (nama, id_pemilik, no_hp) values (@nama, @id_pemilik, @no_hp)";
                        SqlCommand cmd = new SqlCommand(str, koneksi);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("nama", nama));
                        cmd.Parameters.Add(new SqlParameter("no_hp", no));
                        cmd.Parameters.Add(new SqlParameter("id_pemilik", ID));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshform();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string nama = txtnama.Text;
            string no = txtnohp.Text;

            if (!int.TryParse(no, out int noInt))
            {
                MessageBox.Show("No HP harus diisi dengan Angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string upd = "UPDATE pemilik SET id_pemilik = @id_pemilik, nama = @nama, no_hp = @no_hp where id_pemilik = @id_pemilik";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(upd, conn))
                {
                    cmd.Parameters.AddWithValue("id_pemilik", txtID.Text);
                    cmd.Parameters.AddWithValue("nama", txtnama.Text);
                    cmd.Parameters.AddWithValue("no_hp", txtnohp.Text);
                  

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

        private void datagridview()
        {
            koneksi.Open();
            string str = "select * from dbo.pemilik";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void Pemilik_Load(object sender, EventArgs e)
        {

        }
    }
}
