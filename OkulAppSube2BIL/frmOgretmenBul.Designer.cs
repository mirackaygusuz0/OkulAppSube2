﻿namespace OkulAppSube2BIL
{
    partial class frmOgretmenBul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgrAra = new System.Windows.Forms.Button();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOgrAra);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ögretmen Bul";
            // 
            // btnOgrAra
            // 
            this.btnOgrAra.Location = new System.Drawing.Point(72, 114);
            this.btnOgrAra.Name = "btnOgrAra";
            this.btnOgrAra.Size = new System.Drawing.Size(75, 23);
            this.btnOgrAra.TabIndex = 2;
            this.btnOgrAra.Text = "Ara";
            this.btnOgrAra.UseVisualStyleBackColor = true;
            this.btnOgrAra.Click += new System.EventHandler(this.btnOgrAra_Click);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(62, 69);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmen TC Kimlik Numarasını giriniz.";
            
            // 
            // frmOgretmenBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 248);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgretmenBul";
            this.Text = "Öğretmen Kaydı Bulma Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOgrAra;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label1;
    }
}