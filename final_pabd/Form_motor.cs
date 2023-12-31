﻿using System;
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
        string connectionString = "data source =LAPTOP-1JRJB77C\\HMMPRYT;" +
            "database=sewamotor;user ID=sa; password=123";
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
            cbxJenismotor.Text = "";
            txtWarna.Text = "";
            txtNopol.Text = "";
            dateTahun.Value = DateTime.Today;
            txtidMotor.Text = "";
            cbxJenismotor.Enabled = true;
            txtWarna.Enabled = true;
            txtNopol.Enabled = true;
            txtidMotor.Enabled = true;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
            dateTahun.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            string upd = "UPDATE motor SET id_motor = @id_motor, jenis_motor = @jenis_motor where id_motor = @id_motor";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(upd, conn))
                {
                    cmd.Parameters.AddWithValue("id_motor", txtidMotor.Text);
                    cmd.Parameters.AddWithValue("jenis_motor", cbxJenismotor.Text);

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

        private void Bw_Click(object sender, EventArgs e)
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            datagridview();
            btnRead.Enabled = true;
        }

        private void DP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_menu fm = new Form_menu();
            fm.Show();
            this.Close();
        }

        private void Form_motor_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            nama = cbxJenismotor.Text;
            warna = txtWarna.Text;
            nopol = txtNopol.Text;
            waktu = dateTahun.Value;
            idmotor = txtidMotor.Text;


            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(warna) || string.IsNullOrEmpty(idmotor))
            {
                MessageBox.Show("Harap isi semua field terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(idmotor, out _))
            {
                MessageBox.Show("Id Motor harus berupa Angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection koneksi = new SqlConnection(connectionString))
                {
                    try
                    {
                        nama = cbxJenismotor.Text;
                        warna = txtWarna.Text;
                        nopol = txtNopol.Text;
                        waktu = dateTahun.Value;
                        idmotor = txtidMotor.Text;

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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dlt = "DELETE FROM motor WHERE id_motor = @id_motor";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(dlt, conn)) 
                {
                    cmd.Parameters.AddWithValue("id_motor", txtidMotor.Text);
                    try 
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        datagridview();

                    }
                    catch (SqlException ex) 
                    {
                        MessageBox.Show("An Error Occurred: " + ex.Message +  ("Error Code: " + ex.Number ));
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("An Error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void datagridview()
        {
            koneksi.Open();
            string str = "select * from dbo.motor";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
    }
}
