namespace final_pabd
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.masukanDataDiriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputMotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masukanDataDiriToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.inputDataKaryawanToolStripMenuItem,
            this.inputMotorToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(65, 24);
            this.toolStripDropDownButton1.Text = "MENU";
            // 
            // masukanDataDiriToolStripMenuItem
            // 
            this.masukanDataDiriToolStripMenuItem.Name = "masukanDataDiriToolStripMenuItem";
            this.masukanDataDiriToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.masukanDataDiriToolStripMenuItem.Text = "Masukan Data Diri";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // inputDataKaryawanToolStripMenuItem
            // 
            this.inputDataKaryawanToolStripMenuItem.Name = "inputDataKaryawanToolStripMenuItem";
            this.inputDataKaryawanToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.inputDataKaryawanToolStripMenuItem.Text = "Input Data Karyawan";
            // 
            // inputMotorToolStripMenuItem
            // 
            this.inputMotorToolStripMenuItem.Name = "inputMotorToolStripMenuItem";
            this.inputMotorToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.inputMotorToolStripMenuItem.Text = "Input Motor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form_meu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem masukanDataDiriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputMotorToolStripMenuItem;
    }
}

