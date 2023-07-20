namespace final_pabd
{
    partial class Form_DataDiri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNotelp = new System.Windows.Forms.TextBox();
            this.txtNoktp = new System.Windows.Forms.TextBox();
            this.txtplgn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(617, 77);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(210, 22);
            this.txtNama.TabIndex = 0;
            // 
            // txtNotelp
            // 
            this.txtNotelp.Location = new System.Drawing.Point(617, 119);
            this.txtNotelp.Name = "txtNotelp";
            this.txtNotelp.Size = new System.Drawing.Size(210, 22);
            this.txtNotelp.TabIndex = 1;
            // 
            // txtNoktp
            // 
            this.txtNoktp.Location = new System.Drawing.Point(617, 160);
            this.txtNoktp.Name = "txtNoktp";
            this.txtNoktp.Size = new System.Drawing.Size(210, 22);
            this.txtNoktp.TabIndex = 2;
            // 
            // txtplgn
            // 
            this.txtplgn.Location = new System.Drawing.Point(657, 197);
            this.txtplgn.Name = "txtplgn";
            this.txtplgn.Size = new System.Drawing.Size(126, 22);
            this.txtplgn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(536, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(530, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "No telp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(526, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "No KTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(493, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id Pelanggan";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(146, 434);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(89, 29);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(253, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 29);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 29);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(617, 241);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(221, 101);
            this.txtAlamat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(531, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Alamat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(891, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 278);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRead
            // 
            this.btnRead.ForeColor = System.Drawing.Color.Black;
            this.btnRead.Location = new System.Drawing.Point(39, 434);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(89, 29);
            this.btnRead.TabIndex = 15;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data Peminjam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RosyBrown;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(510, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID Karyawan";
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(617, 363);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(121, 24);
            this.cbxNama.TabIndex = 18;
            this.cbxNama.SelectedIndexChanged += new System.EventHandler(this.cbxNama_SelectedIndexChanged);
            // 
            // Form_DataDiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(993, 543);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplgn);
            this.Controls.Add(this.txtNoktp);
            this.Controls.Add(this.txtNotelp);
            this.Controls.Add(this.txtNama);
            this.Name = "Form_DataDiri";
            this.Text = "Form_DataDiri";
            this.Load += new System.EventHandler(this.Form_DataDiri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNotelp;
        private System.Windows.Forms.TextBox txtNoktp;
        private System.Windows.Forms.TextBox txtplgn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxNama;
    }
}