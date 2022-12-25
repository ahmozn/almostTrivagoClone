
namespace vtysProje
{
    partial class admin
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
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.btn_kisiEkle = new System.Windows.Forms.Button();
            this.lbl_kisiNo = new System.Windows.Forms.Label();
            this.cb_kisiNo = new System.Windows.Forms.ComboBox();
            this.btn_kisiSil = new System.Windows.Forms.Button();
            this.btn_gkisi = new System.Windows.Forms.Button();
            this.txt_gSoyad = new System.Windows.Forms.TextBox();
            this.txt_gAd = new System.Windows.Forms.TextBox();
            this.lbl_gSoyad = new System.Windows.Forms.Label();
            this.lbl_gAd = new System.Windows.Forms.Label();
            this.cb_gKisiNo = new System.Windows.Forms.ComboBox();
            this.lbl_gKisiNo = new System.Windows.Forms.Label();
            this.txt_gKisituru = new System.Windows.Forms.TextBox();
            this.lbl_gKisituru = new System.Windows.Forms.Label();
            this.txt_kisiTuru = new System.Windows.Forms.TextBox();
            this.lbl_kisiTuru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_anasayfa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_anasayfa.Location = new System.Drawing.Point(386, 405);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(107, 33);
            this.btn_anasayfa.TabIndex = 5;
            this.btn_anasayfa.Text = "Anasayfa";
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(12, 24);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(25, 15);
            this.lbl_ad.TabIndex = 6;
            this.lbl_ad.Text = "Ad:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(12, 65);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(42, 15);
            this.lbl_soyad.TabIndex = 7;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(79, 15);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 23);
            this.txt_ad.TabIndex = 12;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(79, 62);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 23);
            this.txt_soyad.TabIndex = 13;
            // 
            // btn_kisiEkle
            // 
            this.btn_kisiEkle.Location = new System.Drawing.Point(79, 133);
            this.btn_kisiEkle.Name = "btn_kisiEkle";
            this.btn_kisiEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_kisiEkle.TabIndex = 19;
            this.btn_kisiEkle.Text = "Kişi Ekle";
            this.btn_kisiEkle.UseVisualStyleBackColor = true;
            this.btn_kisiEkle.Click += new System.EventHandler(this.btn_kisiEkle_Click);
            // 
            // lbl_kisiNo
            // 
            this.lbl_kisiNo.AutoSize = true;
            this.lbl_kisiNo.Location = new System.Drawing.Point(12, 219);
            this.lbl_kisiNo.Name = "lbl_kisiNo";
            this.lbl_kisiNo.Size = new System.Drawing.Size(45, 15);
            this.lbl_kisiNo.TabIndex = 20;
            this.lbl_kisiNo.Text = "Kişi no:";
            // 
            // cb_kisiNo
            // 
            this.cb_kisiNo.FormattingEnabled = true;
            this.cb_kisiNo.Location = new System.Drawing.Point(79, 219);
            this.cb_kisiNo.Name = "cb_kisiNo";
            this.cb_kisiNo.Size = new System.Drawing.Size(121, 23);
            this.cb_kisiNo.TabIndex = 21;
            // 
            // btn_kisiSil
            // 
            this.btn_kisiSil.Location = new System.Drawing.Point(94, 273);
            this.btn_kisiSil.Name = "btn_kisiSil";
            this.btn_kisiSil.Size = new System.Drawing.Size(75, 23);
            this.btn_kisiSil.TabIndex = 22;
            this.btn_kisiSil.Text = "Kişi Sil";
            this.btn_kisiSil.UseVisualStyleBackColor = true;
            this.btn_kisiSil.Click += new System.EventHandler(this.btn_kisiSil_Click);
            // 
            // btn_gkisi
            // 
            this.btn_gkisi.Location = new System.Drawing.Point(385, 211);
            this.btn_gkisi.Name = "btn_gkisi";
            this.btn_gkisi.Size = new System.Drawing.Size(87, 23);
            this.btn_gkisi.TabIndex = 23;
            this.btn_gkisi.Text = "Kişi Güncelle";
            this.btn_gkisi.UseVisualStyleBackColor = true;
            this.btn_gkisi.Click += new System.EventHandler(this.btn_gkisi_Click);
            // 
            // txt_gSoyad
            // 
            this.txt_gSoyad.Location = new System.Drawing.Point(373, 104);
            this.txt_gSoyad.Name = "txt_gSoyad";
            this.txt_gSoyad.Size = new System.Drawing.Size(100, 23);
            this.txt_gSoyad.TabIndex = 27;
            // 
            // txt_gAd
            // 
            this.txt_gAd.Location = new System.Drawing.Point(373, 57);
            this.txt_gAd.Name = "txt_gAd";
            this.txt_gAd.Size = new System.Drawing.Size(100, 23);
            this.txt_gAd.TabIndex = 26;
            // 
            // lbl_gSoyad
            // 
            this.lbl_gSoyad.AutoSize = true;
            this.lbl_gSoyad.Location = new System.Drawing.Point(306, 107);
            this.lbl_gSoyad.Name = "lbl_gSoyad";
            this.lbl_gSoyad.Size = new System.Drawing.Size(42, 15);
            this.lbl_gSoyad.TabIndex = 25;
            this.lbl_gSoyad.Text = "Soyad:";
            // 
            // lbl_gAd
            // 
            this.lbl_gAd.AutoSize = true;
            this.lbl_gAd.Location = new System.Drawing.Point(306, 66);
            this.lbl_gAd.Name = "lbl_gAd";
            this.lbl_gAd.Size = new System.Drawing.Size(25, 15);
            this.lbl_gAd.TabIndex = 24;
            this.lbl_gAd.Text = "Ad:";
            // 
            // cb_gKisiNo
            // 
            this.cb_gKisiNo.FormattingEnabled = true;
            this.cb_gKisiNo.Location = new System.Drawing.Point(372, 16);
            this.cb_gKisiNo.Name = "cb_gKisiNo";
            this.cb_gKisiNo.Size = new System.Drawing.Size(121, 23);
            this.cb_gKisiNo.TabIndex = 29;
            // 
            // lbl_gKisiNo
            // 
            this.lbl_gKisiNo.AutoSize = true;
            this.lbl_gKisiNo.Location = new System.Drawing.Point(305, 16);
            this.lbl_gKisiNo.Name = "lbl_gKisiNo";
            this.lbl_gKisiNo.Size = new System.Drawing.Size(45, 15);
            this.lbl_gKisiNo.TabIndex = 28;
            this.lbl_gKisiNo.Text = "Kişi no:";
            // 
            // txt_gKisituru
            // 
            this.txt_gKisituru.Location = new System.Drawing.Point(372, 152);
            this.txt_gKisituru.Name = "txt_gKisituru";
            this.txt_gKisituru.Size = new System.Drawing.Size(100, 23);
            this.txt_gKisituru.TabIndex = 31;
            // 
            // lbl_gKisituru
            // 
            this.lbl_gKisituru.AutoSize = true;
            this.lbl_gKisituru.Location = new System.Drawing.Point(305, 155);
            this.lbl_gKisituru.Name = "lbl_gKisituru";
            this.lbl_gKisituru.Size = new System.Drawing.Size(53, 15);
            this.lbl_gKisituru.TabIndex = 30;
            this.lbl_gKisituru.Text = "Kişi türü:";
            // 
            // txt_kisiTuru
            // 
            this.txt_kisiTuru.Location = new System.Drawing.Point(79, 99);
            this.txt_kisiTuru.Name = "txt_kisiTuru";
            this.txt_kisiTuru.Size = new System.Drawing.Size(100, 23);
            this.txt_kisiTuru.TabIndex = 32;
            // 
            // lbl_kisiTuru
            // 
            this.lbl_kisiTuru.AutoSize = true;
            this.lbl_kisiTuru.Location = new System.Drawing.Point(12, 107);
            this.lbl_kisiTuru.Name = "lbl_kisiTuru";
            this.lbl_kisiTuru.Size = new System.Drawing.Size(53, 15);
            this.lbl_kisiTuru.TabIndex = 33;
            this.lbl_kisiTuru.Text = "Kişi türü:";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.lbl_kisiTuru);
            this.Controls.Add(this.txt_kisiTuru);
            this.Controls.Add(this.txt_gKisituru);
            this.Controls.Add(this.lbl_gKisituru);
            this.Controls.Add(this.cb_gKisiNo);
            this.Controls.Add(this.lbl_gKisiNo);
            this.Controls.Add(this.txt_gSoyad);
            this.Controls.Add(this.txt_gAd);
            this.Controls.Add(this.lbl_gSoyad);
            this.Controls.Add(this.lbl_gAd);
            this.Controls.Add(this.btn_gkisi);
            this.Controls.Add(this.btn_kisiSil);
            this.Controls.Add(this.cb_kisiNo);
            this.Controls.Add(this.lbl_kisiNo);
            this.Controls.Add(this.btn_kisiEkle);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.btn_anasayfa);
            this.Name = "admin";
            this.Text = "ADMIN PANEL";
            this.Load += new System.EventHandler(this.mal_sahibi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Button btn_kisiEkle;
        private System.Windows.Forms.Label lbl_kisiNo;
        private System.Windows.Forms.ComboBox cb_kisiNo;
        private System.Windows.Forms.Button btn_kisiSil;
        private System.Windows.Forms.Button btn_gkisi;
        private System.Windows.Forms.TextBox txt_gSoyad;
        private System.Windows.Forms.TextBox txt_gAd;
        private System.Windows.Forms.Label lbl_gSoyad;
        private System.Windows.Forms.Label lbl_gAd;
        private System.Windows.Forms.ComboBox cb_gKisiNo;
        private System.Windows.Forms.Label lbl_gKisiNo;
        private System.Windows.Forms.TextBox txt_gKisituru;
        private System.Windows.Forms.Label lbl_gKisituru;
        private System.Windows.Forms.TextBox txt_kisiTuru;
        private System.Windows.Forms.Label lbl_kisiTuru;
    }
}