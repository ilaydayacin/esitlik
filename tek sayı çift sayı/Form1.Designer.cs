namespace tek_sayı_çift_sayı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSayi = new System.Windows.Forms.TrackBar();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblTb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSayi
            // 
            this.tbSayi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSayi.Location = new System.Drawing.Point(27, 27);
            this.tbSayi.Maximum = 100;
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(490, 45);
            this.tbSayi.TabIndex = 0;
            this.tbSayi.Value = 1;
            this.tbSayi.Scroll += new System.EventHandler(this.tbSayi_Scroll);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(163, 124);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(227, 112);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Sayının türünü \r\nöğren\r\n";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblTb
            // 
            this.lblTb.AutoSize = true;
            this.lblTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTb.Location = new System.Drawing.Point(524, 27);
            this.lblTb.Name = "lblTb";
            this.lblTb.Size = new System.Drawing.Size(18, 20);
            this.lblTb.TabIndex = 2;
            this.lblTb.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(600, 280);
            this.Controls.Add(this.lblTb);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.tbSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbSayi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblTb;
    }
}

