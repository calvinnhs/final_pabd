namespace final_pabd
{
    partial class Gudang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdgudang = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Gudang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Gudang";
            // 
            // txtIdgudang
            // 
            this.txtIdgudang.Location = new System.Drawing.Point(228, 261);
            this.txtIdgudang.Name = "txtIdgudang";
            this.txtIdgudang.Size = new System.Drawing.Size(157, 22);
            this.txtIdgudang.TabIndex = 4;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(228, 310);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(157, 22);
            this.txtstok.TabIndex = 5;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(228, 353);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(157, 22);
            this.txtnama.TabIndex = 6;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(23, 40);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(484, 257);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(484, 303);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 9;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(484, 346);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(610, 303);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Gudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtIdgudang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gudang";
            this.Text = "Gudang";
            this.Load += new System.EventHandler(this.Gudang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdgudang;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}