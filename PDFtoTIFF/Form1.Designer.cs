namespace PDFtoTIFF
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
            this.grbDosyaSecimi = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.pbSend = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblKalanText = new System.Windows.Forms.Label();
            this.grbDosyaSecimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSend)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDosyaSecimi
            // 
            this.grbDosyaSecimi.Controls.Add(this.lblKalanText);
            this.grbDosyaSecimi.Controls.Add(this.lblKalan);
            this.grbDosyaSecimi.Controls.Add(this.progressBar1);
            this.grbDosyaSecimi.Controls.Add(this.txtDosya);
            this.grbDosyaSecimi.Controls.Add(this.pbSend);
            this.grbDosyaSecimi.Controls.Add(this.btnChoose);
            this.grbDosyaSecimi.Location = new System.Drawing.Point(12, 12);
            this.grbDosyaSecimi.Name = "grbDosyaSecimi";
            this.grbDosyaSecimi.Size = new System.Drawing.Size(260, 100);
            this.grbDosyaSecimi.TabIndex = 0;
            this.grbDosyaSecimi.TabStop = false;
            this.grbDosyaSecimi.Text = "Dosya Seçimi";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(88, 20);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(166, 20);
            this.txtDosya.TabIndex = 2;
            this.txtDosya.Text = "Seçiniz..";
            // 
            // pbSend
            // 
            this.pbSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSend.Image = global::PDFtoTIFF.Properties.Resources.convert;
            this.pbSend.Location = new System.Drawing.Point(202, 48);
            this.pbSend.Name = "pbSend";
            this.pbSend.Size = new System.Drawing.Size(52, 46);
            this.pbSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSend.TabIndex = 1;
            this.pbSend.TabStop = false;
            this.pbSend.Click += new System.EventHandler(this.pbSend_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(6, 19);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Seç";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(6, 48);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(40, 13);
            this.lblKalan.TabIndex = 4;
            this.lblKalan.Text = "Kalan :";
            // 
            // lblKalanText
            // 
            this.lblKalanText.AutoSize = true;
            this.lblKalanText.Location = new System.Drawing.Point(52, 48);
            this.lblKalanText.Name = "lblKalanText";
            this.lblKalanText.Size = new System.Drawing.Size(47, 13);
            this.lblKalanText.TabIndex = 5;
            this.lblKalanText.Text = "Veri Yok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.grbDosyaSecimi);
            this.Name = "Form1";
            this.Text = "PDFtoTIFF";
            this.grbDosyaSecimi.ResumeLayout(false);
            this.grbDosyaSecimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDosyaSecimi;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.PictureBox pbSend;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblKalanText;
        private System.Windows.Forms.Label lblKalan;
    }
}

