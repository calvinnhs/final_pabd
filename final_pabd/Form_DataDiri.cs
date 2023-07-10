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
        private string stringConnection = "data source =DESKTOP-BI70IVU;" +
            "database=sewamotor;user ID=sa; password=sayangmei";
        private SqlConnection koneksi;
        private string Nama, Notelp, Noktp, Idpelanggan, Alamat;

        private void btnUpdate_Click(object sender, EventArgs e)
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
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Nama = txtNama.Text;
            Notelp = txtNotelp.Text; 
            Noktp = txtNoktp.Text;
            Idpelanggan = txtplgn.Text;
            Alamat = txtAlamat.Text;

            koneksi.Open();
            string str = "insert into dbo.pelanggan (nama_plgn, no_hp, no_ktp , Id_pelanggan, alamat)" + "values(@nama_plgn, @no_hp, @no_ktp , @Id_pelanggan, @alamat)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("nama_plgn", Nama));
            cmd.Parameters.Add(new SqlParameter("no_hp", Notelp));
            cmd.Parameters.Add(new SqlParameter("no_ktp", Noktp));
            cmd.Parameters.Add(new SqlParameter("Id_pelanggan", Idpelanggan));
            cmd.Parameters.Add(new SqlParameter("alamat", Alamat));
     
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            refreshform();
        }


    }
}
