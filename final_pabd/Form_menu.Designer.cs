﻿namespace final_pabd
{
    partial class Form_menu
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
            this.btnDatadiri = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnDatakaryawan = new System.Windows.Forms.Button();
            this.btnDatamotor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU SEWA MOTOR ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDatadiri
            // 
            this.btnDatadiri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatadiri.Location = new System.Drawing.Point(190, 183);
            this.btnDatadiri.Name = "btnDatadiri";
            this.btnDatadiri.Size = new System.Drawing.Size(176, 40);
            this.btnDatadiri.TabIndex = 2;
            this.btnDatadiri.Text = "Masukan data diri";
            this.btnDatadiri.UseVisualStyleBackColor = true;
            this.btnDatadiri.Click += new System.EventHandler(this.btnDatadiri_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(190, 251);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(176, 40);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDatakaryawan
            // 
            this.btnDatakaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatakaryawan.Location = new System.Drawing.Point(394, 251);
            this.btnDatakaryawan.Name = "btnDatakaryawan";
            this.btnDatakaryawan.Size = new System.Drawing.Size(176, 40);
            this.btnDatakaryawan.TabIndex = 4;
            this.btnDatakaryawan.Text = "Data karyawan";
            this.btnDatakaryawan.UseVisualStyleBackColor = true;
            this.btnDatakaryawan.Click += new System.EventHandler(this.btnDatakaryawan_Click);
            // 
            // btnDatamotor
            // 
            this.btnDatamotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatamotor.Location = new System.Drawing.Point(394, 183);
            this.btnDatamotor.Name = "btnDatamotor";
            this.btnDatamotor.Size = new System.Drawing.Size(176, 40);
            this.btnDatamotor.TabIndex = 5;
            this.btnDatamotor.Text = "Data kendaraan";
            this.btnDatamotor.UseVisualStyleBackColor = true;
            this.btnDatamotor.Click += new System.EventHandler(this.btnDatamotor_Click);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDatamotor);
            this.Controls.Add(this.btnDatakaryawan);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDatadiri);
            this.Controls.Add(this.label1);
            this.Name = "Form_menu";
            this.Text = "Form_meu";
            this.Load += new System.EventHandler(this.Form_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatadiri;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnDatakaryawan;
        private System.Windows.Forms.Button btnDatamotor;
    }
}

