﻿namespace AkademikApp
{
    partial class FrmMahasiswa
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
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.grouBox1 = new System.Windows.Forms.GroupBox();
            this.grouBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.Location = new System.Drawing.Point(7, 22);
            this.lvwMahasiswa.Margin = new System.Windows.Forms.Padding(4);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(590, 343);
            this.lvwMahasiswa.TabIndex = 0;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(19, 384);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(524, 28);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Hitung";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // grouBox1
            // 
            this.grouBox1.Controls.Add(this.lvwMahasiswa);
            this.grouBox1.Location = new System.Drawing.Point(12, 2);
            this.grouBox1.Name = "grouBox1";
            this.grouBox1.Size = new System.Drawing.Size(604, 375);
            this.grouBox1.TabIndex = 2;
            this.grouBox1.TabStop = false;
            this.grouBox1.Text = "[ Hasil ]";
            // 
            // FrmMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 425);
            this.Controls.Add(this.grouBox1);
            this.Controls.Add(this.btnTambah);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.Load += new System.EventHandler(this.FrmMahasiswa_Load);
            this.grouBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox grouBox1;
    }
}

