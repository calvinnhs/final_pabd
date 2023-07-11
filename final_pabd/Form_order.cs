using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_pabd
{
    public partial class Form_Order : Form
    {
        private string stringConnection = "data source =DESKTOP-BI70IVU;" +
           "database=sewamotor;user ID=sa; password=sayangmei";
        private SqlConnection koneksi;
        private string Nama, Notelp, Noid, Noktp;

        public Form_Order()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshfrom();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form_menu().Show();
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

            refreshfrom();
        }

        private void refreshfrom()
        {
            txtIdorder.Text = "";
            txtJumlahmotor.Text = "";
            txtplatnomor.Text = "";
            txtJenismotor.Text = "";
            txtAlamat.Text = "";
            txtIdPelanggan.Text = "";
            txtIdmotor.Text = "";
            txtLamasewa.Text = "";
            txtIdorder.Enabled = true;
            txtJumlahmotor.Enabled = true;
            txtplatnomor.Enabled = true;
            txtJenismotor.Enabled = true;
            txtAlamat.Enabled = true;
            txtIdPelanggan.Enabled = true;
            txtIdmotor.Enabled = true;
            txtLamasewa.Enabled = true;
            btnInsert.Enabled = true;
           
        }
    }
}
