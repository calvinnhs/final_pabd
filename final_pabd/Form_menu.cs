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
    public partial class Form_menu : Form
    {
        
        public Form_menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDatadiri_Click(object sender, EventArgs e)
        {
            Form_DataDiri fm = new Form_DataDiri();
            fm.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form_Order fm = new Form_Order();
            fm.Show();
            this.Hide();
        }

        private void Form_menu_Load(object sender, EventArgs e)
        {

        }

        private void dataKendaraanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_motor fm = new Form_motor();
            fm.Show();
            this.Hide();
        }

        private void dataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_karyawan fk = new Form_karyawan();
            fk.Show();
            this.Hide();    
        }

        private void gudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gudang g = new Gudang();
            g.Show();
            this.Hide();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void pemiliikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pemilik p = new Pemilik();
            p.Show();
            this.Hide();
        }
    }
}
