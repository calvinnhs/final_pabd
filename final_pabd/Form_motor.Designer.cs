namespace final_pabd
{
    partial class Form_motor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWarna = new System.Windows.Forms.TextBox();
            this.txtNopol = new System.Windows.Forms.TextBox();
            this.dateTahun = new System.Windows.Forms.DateTimePicker();
            this.txtIdmotor = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxJenismotor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jenis Motor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Warna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "No Pol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tahun Buat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID Motor";
            // 
            // txtWarna
            // 
            this.txtWarna.Location = new System.Drawing.Point(793, 163);
            this.txtWarna.Name = "txtWarna";
            this.txtWarna.Size = new System.Drawing.Size(205, 22);
            this.txtWarna.TabIndex = 7;
            // 
            // txtNopol
            // 
            this.txtNopol.Location = new System.Drawing.Point(793, 207);
            this.txtNopol.Name = "txtNopol";
            this.txtNopol.Size = new System.Drawing.Size(205, 22);
            this.txtNopol.TabIndex = 8;
            // 
            // dateTahun
            // 
            this.dateTahun.Location = new System.Drawing.Point(793, 251);
            this.dateTahun.Name = "dateTahun";
            this.dateTahun.Size = new System.Drawing.Size(205, 22);
            this.dateTahun.TabIndex = 9;
            // 
            // txtIdmotor
            // 
            this.txtIdmotor.Location = new System.Drawing.Point(793, 296);
            this.txtIdmotor.Name = "txtIdmotor";
            this.txtIdmotor.Size = new System.Drawing.Size(205, 22);
            this.txtIdmotor.TabIndex = 10;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(226, 383);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 32);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(525, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(367, 383);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 32);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(943, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 266);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(74, 383);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(88, 32);
            this.btnRead.TabIndex = 18;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Data Kendaraan";
            // 
            // cbxJenismotor
            // 
            this.cbxJenismotor.Location = new System.Drawing.Point(793, 121);
            this.cbxJenismotor.Name = "cbxJenismotor";
            this.cbxJenismotor.Size = new System.Drawing.Size(205, 22);
            this.cbxJenismotor.TabIndex = 21;
            // 
            // Form_motor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 487);
            this.Controls.Add(this.cbxJenismotor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtIdmotor);
            this.Controls.Add(this.dateTahun);
            this.Controls.Add(this.txtNopol);
            this.Controls.Add(this.txtWarna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_motor";
            this.Text = "Add Motor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWarna;
        private System.Windows.Forms.TextBox txtNopol;
        private System.Windows.Forms.DateTimePicker dateTahun;
        private System.Windows.Forms.TextBox txtIdmotor;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cbxJenismotor;
    }
}