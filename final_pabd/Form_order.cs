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
        private string stringConnection = "data source =LAPTOP-1JRJB77C\\HMMPRYT;" +
            "database=sewamotor;user ID=sa; password=123";
        private SqlConnection koneksi;
        private string id_transaksi, jml_motor, no_pol, jenis_motor, id_pelanggan, id_motor, lama_sewa;

        private void txtplatnomor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Order_Load(object sender, EventArgs e)
        {

        }

        private void txtIdorder_TextChanged(object sender, EventArgs e)
        {

        }

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
            Form_menu fm = new Form_menu();
            fm.Show();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            id_transaksi = txtIdorder.Text;
            jml_motor = txtJumlahmotor.Text;
            no_pol = txtplatnomor.Text;
            jenis_motor = txtJenismotor.Text;
            id_pelanggan = cbxPelanggan.Text;
            id_motor = cbxMotor.Text;
            lama_sewa = dtpicker.Text;

            koneksi.Open();
            string str = "insert into dbo.transaksi (id_transaksi, jml_motor, no_pol, jenis_motor, id_pelanggan, id_motor, lama_sewa)" +
                "values(@id_transaksi, @jml_motor, @no_pol, @jenis_motor, @id_pelanggan, @id_motor, @lama_sewa)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_transaksi", id_transaksi));
            cmd.Parameters.Add(new SqlParameter("jml_motor", jml_motor));
            cmd.Parameters.Add(new SqlParameter("no_pol", no_pol));
            cmd.Parameters.Add(new SqlParameter("jenis_motor", jenis_motor));
            cmd.Parameters.Add(new SqlParameter("id_pelanggan", id_pelanggan));
            cmd.Parameters.Add(new SqlParameter("id_motor", id_motor));
            cmd.Parameters.Add(new SqlParameter("lama_sewa", lama_sewa));

            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshfrom();
        }
        private void cbid_pelanggan()
        {
            koneksi.Open();
            string str = "select id_pelanggan from dbo.pelanggan";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxPelanggan.DisplayMember = "id_pelanggan";
            cbxPelanggan.ValueMember = "id_pelanggan";
            cbxPelanggan.DataSource = ds.Tables[0];
        }
        private void cbid_motor()
        {
            koneksi.Open();
            string str = "select id_motor from dbo.motor";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxMotor.DisplayMember = "id_motor";
            cbxMotor.ValueMember = "id_motor";
            cbxMotor.DataSource = ds.Tables[0];
        }


        private void refreshfrom()
        {
            txtIdorder.Text = "";
            txtJumlahmotor.Text = "";
            txtplatnomor.Text = "";
            txtJenismotor.Text = "";
            txtAlamat.Text = "";
            cbxPelanggan.Enabled = true;
            cbxMotor.Enabled = true;
            txtIdorder.Enabled = true;
            txtJumlahmotor.Enabled = true;
            txtplatnomor.Enabled = true;
            txtJenismotor.Enabled = true;
            txtAlamat.Enabled = true;
            cbxPelanggan.SelectedIndex = -1;
            cbxMotor.SelectedIndex = -1;
            dtpicker.Enabled = true;
            btnInsert.Enabled = true;
            cbid_pelanggan();
            cbid_motor();
        }
    }
}
