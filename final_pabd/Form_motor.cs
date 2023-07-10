using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace final_pabd
{
    public partial class Form_motor : Form
    {
        Image curimage;
        string curFileName;
        string connectionString = "data source = DESKTOP-BI70IVU;database=sewamotor;MultipleActiveResultSets=True;User ID = sa; Password = sayangmei";
        string savedImageName = "";
        private string nama, warna, nopol, idmotor;
        private SqlConnection koneksi;
        private DateTime waktu;

        public Form_motor()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();
        }
        private void refreshform()
        {
            txtJenismotor.Text = "";
            txtWarna.Text = "";
            txtNopol.Text = "";
            dateTahun.Enabled = false;
            txtIdmotor.Text = "";
            txtJenismotor.Enabled = true;
            txtWarna.Enabled = true;
            txtNopol.Enabled = true;
            txtIdmotor.Enabled = true;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Bw_Click(object sender, EventArgs e)
        {

            OpenFileDialog openDLg = new OpenFileDialog();
            if (openDLg.ShowDialog() == DialogResult.OK)
            {
                curFileName = openDLg.FileName;
                txtFile.Text = curFileName;
            }
        }

        private void DP_Click(object sender, EventArgs e)
        {
            if (txtFile.Text != "")
            {
                string sql = "SELECT Gambar FROM motor WHERE id_motor='1'";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.ConnectionString = connectionString;
                connection.Open();

                FileStream file;
                BinaryWriter bw;

                int bufferSize = 100;
                byte[] outbyte = new byte[bufferSize];
                long retval;
                long startIndex = 0;

                savedImageName = txtFile.Text;

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader myReader = command.ExecuteReader(CommandBehavior.SequentialAccess);

                while (myReader.Read())
                {
                    file = new FileStream(savedImageName, FileMode.OpenOrCreate, FileAccess.Write);
                    bw = new BinaryWriter(file);
                    startIndex = 0;
                    retval = myReader.GetBytes(0, startIndex, outbyte, 0, bufferSize);
                    while (retval == bufferSize)
                    {
                        bw.Write(outbyte);
                        bw.Flush();
                        startIndex += bufferSize;
                        retval = myReader.GetBytes(0, startIndex, outbyte, 0, bufferSize);
                    }
                    bw.Write(outbyte, 0, (int)retval - 1);
                    bw.Flush();
                    bw.Close();
                    file.Close();

                }
                connection.Close();
                curimage = Image.FromFile(savedImageName);
                pictureBox1.Image = curimage;
                pictureBox1.Invalidate();
                connection.Close();


            }
            else MessageBox.Show("Upload the image first");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            nama = txtJenismotor.Text;
            warna = txtWarna.Text;
            nopol = txtNopol.Text;
            waktu = dateTahun.Value;
            idmotor = txtIdmotor.Text;

            koneksi.Open();
            string str = "insert into dbo.motor (id_motor, no_pol, warna, jenis_motor, tahun_buat)" + "values(@id_motor, @no_pol, @warna, @jenis_motor, @tahun_buat)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_motor", idmotor));
            cmd.Parameters.Add(new SqlParameter("no_pol", nopol));
            cmd.Parameters.Add(new SqlParameter("warna", warna));
            cmd.Parameters.Add(new SqlParameter("jenis_motor", nama));
            cmd.Parameters.Add(new SqlParameter("tahun_buat", waktu));


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
