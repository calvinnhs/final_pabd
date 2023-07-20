namespace final_pabd
{
    partial class Form_Order
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdorder = new System.Windows.Forms.TextBox();
            this.txtJumlahmotor = new System.Windows.Forms.TextBox();
            this.txtplatnomor = new System.Windows.Forms.TextBox();
            this.txtJenismotor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxMotor = new System.Windows.Forms.ComboBox();
            this.cbxPelanggan = new System.Windows.Forms.ComboBox();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(474, 443);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(114, 37);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(850, 486);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data Order Kendaraan";
            // 
            // txtIdorder
            // 
            this.txtIdorder.Location = new System.Drawing.Point(235, 120);
            this.txtIdorder.Name = "txtIdorder";
            this.txtIdorder.Size = new System.Drawing.Size(248, 22);
            this.txtIdorder.TabIndex = 15;
            this.txtIdorder.TextChanged += new System.EventHandler(this.txtIdorder_TextChanged);
            // 
            // txtJumlahmotor
            // 
            this.txtJumlahmotor.Location = new System.Drawing.Point(235, 163);
            this.txtJumlahmotor.Name = "txtJumlahmotor";
            this.txtJumlahmotor.Size = new System.Drawing.Size(90, 22);
            this.txtJumlahmotor.TabIndex = 16;
            // 
            // txtplatnomor
            // 
            this.txtplatnomor.Location = new System.Drawing.Point(235, 202);
            this.txtplatnomor.Name = "txtplatnomor";
            this.txtplatnomor.Size = new System.Drawing.Size(263, 22);
            this.txtplatnomor.TabIndex = 17;
            this.txtplatnomor.TextChanged += new System.EventHandler(this.txtplatnomor_TextChanged);
            // 
            // txtJenismotor
            // 
            this.txtJenismotor.Location = new System.Drawing.Point(235, 245);
            this.txtJenismotor.Name = "txtJenismotor";
            this.txtJenismotor.Size = new System.Drawing.Size(142, 22);
            this.txtJenismotor.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Jumlah motor";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.RosyBrown;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(96, 202);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 22);
            this.label.TabIndex = 21;
            this.label.Text = "plat nomor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Jenis motor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(235, 291);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(263, 84);
            this.txtAlamat.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 22);
            this.label8.TabIndex = 31;
            this.label8.Text = "Waktu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.RosyBrown;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(537, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "Id Motor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.RosyBrown;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(537, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Id Pelanggan";
            // 
            // cbxMotor
            // 
            this.cbxMotor.FormattingEnabled = true;
            this.cbxMotor.Location = new System.Drawing.Point(662, 163);
            this.cbxMotor.Name = "cbxMotor";
            this.cbxMotor.Size = new System.Drawing.Size(121, 24);
            this.cbxMotor.TabIndex = 33;
            // 
            // cbxPelanggan
            // 
            this.cbxPelanggan.FormattingEnabled = true;
            this.cbxPelanggan.Location = new System.Drawing.Point(662, 120);
            this.cbxPelanggan.Name = "cbxPelanggan";
            this.cbxPelanggan.Size = new System.Drawing.Size(121, 24);
            this.cbxPelanggan.TabIndex = 34;
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(662, 202);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(200, 22);
            this.dtpicker.TabIndex = 35;
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(951, 530);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.cbxPelanggan);
            this.Controls.Add(this.cbxMotor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJenismotor);
            this.Controls.Add(this.txtplatnomor);
            this.Controls.Add(this.txtJumlahmotor);
            this.Controls.Add(this.txtIdorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form_Order";
            this.Text = "Form_Order";
            this.Load += new System.EventHandler(this.Form_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdorder;
        private System.Windows.Forms.TextBox txtJumlahmotor;
        private System.Windows.Forms.TextBox txtplatnomor;
        private System.Windows.Forms.TextBox txtJenismotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxMotor;
        private System.Windows.Forms.ComboBox cbxPelanggan;
        private System.Windows.Forms.DateTimePicker dtpicker;
    }
}