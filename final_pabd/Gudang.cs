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
    public partial class Gudang : Form
    {
        private string stringConnection = "data source =LAPTOP-1JRJB77C\\HMMPRYT;" +
           "database=sewamotor;user ID=sa; password=123";
        private SqlConnection koneksi;
        private string ID, nama, stok;
        public Gudang()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            ID = txtIdgudang.Text;
            nama = txtnama.Text;
            stok = txtstok.Text;

            if (ID == "" )
            {
                MessageBox.Show("Masukkan ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(stok == "")
            {
                MessageBox.Show("Masukkan stok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.gudang (nama_gudang, stok_motor, id_gudang)" + "values(@nama_gudang, @stok_motor, @id_gudang)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("nama_gudang", nama));
                cmd.Parameters.Add(new SqlParameter("stok_motor", stok));
                cmd.Parameters.Add(new SqlParameter("id_gudang", ID));

                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshform();

            }

           
        }

        private void refreshform()
        {
            txtIdgudang.Text = "";
            txtnama.Text = "";
            txtstok.Text = "";
            txtIdgudang.Enabled = true;
            txtnama.Enabled = true;
            txtstok.Enabled = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form_menu fm = new Form_menu();
            fm.Show();
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            datagridview();
            btnRead.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string upd = "UPDATE gudang SET id_gudang = @id_gudang, stok_motor = @stok_motor, nama_gudang = @nama_gudang where id_gudang = @id_gudang";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(upd, conn))
                {
                    cmd.Parameters.AddWithValue("id_gudang", txtIdgudang.Text);
                    cmd.Parameters.AddWithValue("stok_motor", txtstok.Text);
                    cmd.Parameters.AddWithValue("nama_gudang", txtnama.Text);

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            string dlt = "DELETE FROM gudang WHERE id_gudang = @id_gudang";
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(dlt, conn))
                {
                    cmd.Parameters.AddWithValue("id_gudang", txtIdgudang.Text);
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

        private void Gudang_Load(object sender, EventArgs e)
        {

        }
        private void datagridview()
        {
            koneksi.Open();
            string str = "select * from dbo.gudang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
    }
}
