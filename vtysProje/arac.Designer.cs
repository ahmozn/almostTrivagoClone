
namespace vtysProje
{
    partial class arac
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.araclar = new System.Windows.Forms.DataGridView();
            this.lbl_filtreler = new System.Windows.Forms.Label();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_sehir = new System.Windows.Forms.Label();
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.btn_sifirla = new System.Windows.Forms.Button();
            this.tablo1dg = new System.Windows.Forms.DataGridView();
            this.lbl_cizgi = new System.Windows.Forms.Label();
            this.lbl_aracPlaka = new System.Windows.Forms.Label();
            this.txt_aracPlaka = new System.Windows.Forms.TextBox();
            this.lbl_rzvicin = new System.Windows.Forms.Label();
            this.lbl_aracSinif = new System.Windows.Forms.Label();
            this.txt_aracSinif = new System.Windows.Forms.TextBox();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.date_tarih = new System.Windows.Forms.DateTimePicker();
            this.btn_rYap = new System.Windows.Forms.Button();
            this.tablo2dg = new System.Windows.Forms.DataGridView();
            this.tablo3dg = new System.Windows.Forms.DataGridView();
            this.tablo4dg = new System.Windows.Forms.DataGridView();
            this.tablo5dg = new System.Windows.Forms.DataGridView();
            this.tablo6dg = new System.Windows.Forms.DataGridView();
            this.lbl_tablo1 = new System.Windows.Forms.Label();
            this.lbl_tablo2 = new System.Windows.Forms.Label();
            this.lbl_tablo3 = new System.Windows.Forms.Label();
            this.lbl_tablo4 = new System.Windows.Forms.Label();
            this.lbl_tablo5 = new System.Windows.Forms.Label();
            this.lbl_tablo6 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.lbl_sanziman = new System.Windows.Forms.Label();
            this.lbl_aracilce = new System.Windows.Forms.Label();
            this.txt_sanziman = new System.Windows.Forms.TextBox();
            this.lbl_dUcret = new System.Windows.Forms.Label();
            this.txt_aracKonum = new System.Windows.Forms.TextBox();
            this.txt_aracUcret = new System.Windows.Forms.TextBox();
            this.btn_secimsayfasi = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.araclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo2dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo3dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo4dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo5dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo6dg)).BeginInit();
            this.SuspendLayout();
            // 
            // araclar
            // 
            this.araclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.araclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.araclar.Location = new System.Drawing.Point(12, 12);
            this.araclar.Name = "araclar";
            this.araclar.RowTemplate.Height = 25;
            this.araclar.Size = new System.Drawing.Size(682, 426);
            this.araclar.TabIndex = 0;
            this.araclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daireler_CellClick);
            // 
            // lbl_filtreler
            // 
            this.lbl_filtreler.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_filtreler.Location = new System.Drawing.Point(711, 12);
            this.lbl_filtreler.Name = "lbl_filtreler";
            this.lbl_filtreler.Size = new System.Drawing.Size(162, 33);
            this.lbl_filtreler.TabIndex = 1;
            this.lbl_filtreler.Text = "Filtreler";
            this.lbl_filtreler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(746, 96);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(111, 23);
            this.txt_min.TabIndex = 2;
            this.txt_min.Text = "0";
            // 
            // lbl_min
            // 
            this.lbl_min.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_min.Location = new System.Drawing.Point(700, 96);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(47, 25);
            this.lbl_min.TabIndex = 4;
            this.lbl_min.Text = "Min:";
            this.lbl_min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_max
            // 
            this.lbl_max.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_max.Location = new System.Drawing.Point(879, 96);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(51, 25);
            this.lbl_max.TabIndex = 5;
            this.lbl_max.Text = "Max:";
            this.lbl_max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(927, 96);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(111, 23);
            this.txt_max.TabIndex = 6;
            this.txt_max.Text = "99999";
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fiyat.Location = new System.Drawing.Point(844, 68);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(60, 25);
            this.lbl_fiyat.TabIndex = 7;
            this.lbl_fiyat.Text = "Fiyat";
            this.lbl_fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sehir
            // 
            this.lbl_sehir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sehir.Location = new System.Drawing.Point(828, 165);
            this.lbl_sehir.Name = "lbl_sehir";
            this.lbl_sehir.Size = new System.Drawing.Size(76, 25);
            this.lbl_sehir.TabIndex = 9;
            this.lbl_sehir.Text = "Şehir";
            this.lbl_sehir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_sehir
            // 
            this.cb_sehir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Location = new System.Drawing.Point(809, 206);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(121, 23);
            this.cb_sehir.TabIndex = 12;
            this.cb_sehir.Text = "Şehir Seçiniz..";
            // 
            // btn_getir
            // 
            this.btn_getir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_getir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_getir.Location = new System.Drawing.Point(894, 269);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(91, 29);
            this.btn_getir.TabIndex = 14;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // btn_sifirla
            // 
            this.btn_sifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sifirla.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sifirla.Location = new System.Drawing.Point(762, 269);
            this.btn_sifirla.Name = "btn_sifirla";
            this.btn_sifirla.Size = new System.Drawing.Size(91, 29);
            this.btn_sifirla.TabIndex = 15;
            this.btn_sifirla.Text = "Sıfırla";
            this.btn_sifirla.UseVisualStyleBackColor = true;
            this.btn_sifirla.Click += new System.EventHandler(this.btn_sifirla_Click);
            // 
            // tablo1dg
            // 
            this.tablo1dg.AllowUserToAddRows = false;
            this.tablo1dg.AllowUserToDeleteRows = false;
            this.tablo1dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo1dg.Location = new System.Drawing.Point(1068, 41);
            this.tablo1dg.MultiSelect = false;
            this.tablo1dg.Name = "tablo1dg";
            this.tablo1dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tablo1dg.RowTemplate.Height = 25;
            this.tablo1dg.Size = new System.Drawing.Size(282, 188);
            this.tablo1dg.TabIndex = 16;
            // 
            // lbl_cizgi
            // 
            this.lbl_cizgi.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbl_cizgi.Location = new System.Drawing.Point(1044, 12);
            this.lbl_cizgi.Name = "lbl_cizgi";
            this.lbl_cizgi.Size = new System.Drawing.Size(10, 663);
            this.lbl_cizgi.TabIndex = 22;
            // 
            // lbl_aracPlaka
            // 
            this.lbl_aracPlaka.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aracPlaka.Location = new System.Drawing.Point(12, 485);
            this.lbl_aracPlaka.Name = "lbl_aracPlaka";
            this.lbl_aracPlaka.Size = new System.Drawing.Size(108, 25);
            this.lbl_aracPlaka.TabIndex = 23;
            this.lbl_aracPlaka.Text = "Araç plaka:";
            this.lbl_aracPlaka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_aracPlaka
            // 
            this.txt_aracPlaka.Location = new System.Drawing.Point(142, 487);
            this.txt_aracPlaka.Name = "txt_aracPlaka";
            this.txt_aracPlaka.Size = new System.Drawing.Size(111, 23);
            this.txt_aracPlaka.TabIndex = 24;
            // 
            // lbl_rzvicin
            // 
            this.lbl_rzvicin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rzvicin.Location = new System.Drawing.Point(52, 458);
            this.lbl_rzvicin.Name = "lbl_rzvicin";
            this.lbl_rzvicin.Size = new System.Drawing.Size(165, 25);
            this.lbl_rzvicin.TabIndex = 25;
            this.lbl_rzvicin.Text = "Rezervasyon için";
            this.lbl_rzvicin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_aracSinif
            // 
            this.lbl_aracSinif.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aracSinif.Location = new System.Drawing.Point(12, 527);
            this.lbl_aracSinif.Name = "lbl_aracSinif";
            this.lbl_aracSinif.Size = new System.Drawing.Size(108, 25);
            this.lbl_aracSinif.TabIndex = 26;
            this.lbl_aracSinif.Text = "Sınıf:";
            this.lbl_aracSinif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_aracSinif
            // 
            this.txt_aracSinif.Location = new System.Drawing.Point(142, 529);
            this.txt_aracSinif.Name = "txt_aracSinif";
            this.txt_aracSinif.Size = new System.Drawing.Size(111, 23);
            this.txt_aracSinif.TabIndex = 27;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tarih.Location = new System.Drawing.Point(287, 489);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(66, 25);
            this.lbl_tarih.TabIndex = 28;
            this.lbl_tarih.Text = "Tarih:";
            this.lbl_tarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_tarih
            // 
            this.date_tarih.Location = new System.Drawing.Point(359, 491);
            this.date_tarih.MinDate = new System.DateTime(2022, 12, 26, 0, 0, 0, 0);
            this.date_tarih.Name = "date_tarih";
            this.date_tarih.Size = new System.Drawing.Size(200, 23);
            this.date_tarih.TabIndex = 29;
            this.date_tarih.Value = new System.DateTime(2022, 12, 26, 0, 0, 0, 0);
            // 
            // btn_rYap
            // 
            this.btn_rYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rYap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rYap.Location = new System.Drawing.Point(386, 611);
            this.btn_rYap.Name = "btn_rYap";
            this.btn_rYap.Size = new System.Drawing.Size(149, 31);
            this.btn_rYap.TabIndex = 32;
            this.btn_rYap.Text = "Rezervasyon Yap";
            this.btn_rYap.UseVisualStyleBackColor = true;
            this.btn_rYap.Click += new System.EventHandler(this.btn_rYap_Click);
            // 
            // tablo2dg
            // 
            this.tablo2dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo2dg.Location = new System.Drawing.Point(1370, 41);
            this.tablo2dg.Name = "tablo2dg";
            this.tablo2dg.RowTemplate.Height = 25;
            this.tablo2dg.Size = new System.Drawing.Size(282, 188);
            this.tablo2dg.TabIndex = 33;
            // 
            // tablo3dg
            // 
            this.tablo3dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo3dg.Location = new System.Drawing.Point(1068, 264);
            this.tablo3dg.Name = "tablo3dg";
            this.tablo3dg.RowTemplate.Height = 25;
            this.tablo3dg.Size = new System.Drawing.Size(282, 188);
            this.tablo3dg.TabIndex = 34;
            // 
            // tablo4dg
            // 
            this.tablo4dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo4dg.Location = new System.Drawing.Point(1370, 264);
            this.tablo4dg.Name = "tablo4dg";
            this.tablo4dg.RowTemplate.Height = 25;
            this.tablo4dg.Size = new System.Drawing.Size(282, 188);
            this.tablo4dg.TabIndex = 35;
            // 
            // tablo5dg
            // 
            this.tablo5dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo5dg.Location = new System.Drawing.Point(1068, 487);
            this.tablo5dg.Name = "tablo5dg";
            this.tablo5dg.RowTemplate.Height = 25;
            this.tablo5dg.Size = new System.Drawing.Size(282, 188);
            this.tablo5dg.TabIndex = 36;
            // 
            // tablo6dg
            // 
            this.tablo6dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo6dg.Location = new System.Drawing.Point(1370, 487);
            this.tablo6dg.Name = "tablo6dg";
            this.tablo6dg.RowTemplate.Height = 25;
            this.tablo6dg.Size = new System.Drawing.Size(282, 188);
            this.tablo6dg.TabIndex = 37;
            // 
            // lbl_tablo1
            // 
            this.lbl_tablo1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tablo1.Location = new System.Drawing.Point(1068, 13);
            this.lbl_tablo1.Name = "lbl_tablo1";
            this.lbl_tablo1.Size = new System.Drawing.Size(88, 25);
            this.lbl_tablo1.TabIndex = 38;
            this.lbl_tablo1.Text = "Tablo1:";
            this.lbl_tablo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tablo2
            // 
            this.lbl_tablo2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tablo2.Location = new System.Drawing.Point(1370, 13);
            this.lbl_tablo2.Name = "lbl_tablo2";
            this.lbl_tablo2.Size = new System.Drawing.Size(88, 25);
            this.lbl_tablo2.TabIndex = 39;
            this.lbl_tablo2.Text = "Tablo2:";
            this.lbl_tablo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tablo3
            // 
            this.lbl_tablo3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tablo3.Location = new System.Drawing.Point(1068, 236);
            this.lbl_tablo3.Name = "lbl_tablo3";
            this.lbl_tablo3.Size = new System.Drawing.Size(88, 25);
            this.lbl_tablo3.TabIndex = 40;
            this.lbl_tablo3.Text = "Tablo3:";
            this.lbl_tablo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tablo4
            // 
            this.lbl_tablo4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tablo4.Location = new System.Drawing.Point(1370, 236);
            this.lbl_tablo4.Name = "lbl_tablo4";
            this.lbl_tablo4.Size = new System.Drawing.Size(88, 25);
            this.lbl_tablo4.TabIndex = 41;
            this.lbl_tablo4.Text = "Tablo4:";
            this.lbl_tablo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tablo5
            // 
            this.lbl_tablo5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tablo5.Location = new System.Drawing.Point(1068, 458);
            this.lbl_tablo5.Name = "lbl_tablo5";
            this.lbl_tablo5.Size = new System.Drawing.Size(88, 25);
            this.lbl_tablo5.TabIndex = 42;
            this.lbl_tablo5.Text = "Tablo5:";
            this.lbl_tablo5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tablo6
            // 
            this.lbl_tablo6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tablo6.Location = new System.Drawing.Point(1370, 459);
            this.lbl_tablo6.Name = "lbl_tablo6";
            this.lbl_tablo6.Size = new System.Drawing.Size(88, 25);
            this.lbl_tablo6.TabIndex = 43;
            this.lbl_tablo6.Text = "Tablo6:";
            this.lbl_tablo6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_guncelle.Location = new System.Drawing.Point(894, 641);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(144, 29);
            this.btn_guncelle.TabIndex = 48;
            this.btn_guncelle.Text = "Tabloları Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // lbl_sanziman
            // 
            this.lbl_sanziman.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sanziman.Location = new System.Drawing.Point(12, 565);
            this.lbl_sanziman.Name = "lbl_sanziman";
            this.lbl_sanziman.Size = new System.Drawing.Size(108, 25);
            this.lbl_sanziman.TabIndex = 51;
            this.lbl_sanziman.Text = "Sanziman:";
            this.lbl_sanziman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_aracilce
            // 
            this.lbl_aracilce.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aracilce.Location = new System.Drawing.Point(12, 600);
            this.lbl_aracilce.Name = "lbl_aracilce";
            this.lbl_aracilce.Size = new System.Drawing.Size(124, 25);
            this.lbl_aracilce.TabIndex = 52;
            this.lbl_aracilce.Text = "Araç konum:";
            this.lbl_aracilce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_sanziman
            // 
            this.txt_sanziman.Location = new System.Drawing.Point(142, 569);
            this.txt_sanziman.Name = "txt_sanziman";
            this.txt_sanziman.Size = new System.Drawing.Size(111, 23);
            this.txt_sanziman.TabIndex = 53;
            // 
            // lbl_dUcret
            // 
            this.lbl_dUcret.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dUcret.Location = new System.Drawing.Point(12, 641);
            this.lbl_dUcret.Name = "lbl_dUcret";
            this.lbl_dUcret.Size = new System.Drawing.Size(124, 25);
            this.lbl_dUcret.TabIndex = 55;
            this.lbl_dUcret.Text = "Ucret:";
            this.lbl_dUcret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_aracKonum
            // 
            this.txt_aracKonum.Location = new System.Drawing.Point(142, 604);
            this.txt_aracKonum.Name = "txt_aracKonum";
            this.txt_aracKonum.Size = new System.Drawing.Size(111, 23);
            this.txt_aracKonum.TabIndex = 54;
            // 
            // txt_aracUcret
            // 
            this.txt_aracUcret.Location = new System.Drawing.Point(142, 641);
            this.txt_aracUcret.Name = "txt_aracUcret";
            this.txt_aracUcret.Size = new System.Drawing.Size(111, 23);
            this.txt_aracUcret.TabIndex = 56;
            // 
            // btn_secimsayfasi
            // 
            this.btn_secimsayfasi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_secimsayfasi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_secimsayfasi.Location = new System.Drawing.Point(711, 525);
            this.btn_secimsayfasi.Name = "btn_secimsayfasi";
            this.btn_secimsayfasi.Size = new System.Drawing.Size(157, 29);
            this.btn_secimsayfasi.TabIndex = 57;
            this.btn_secimsayfasi.Text = "Seçim ekranına dön";
            this.btn_secimsayfasi.UseVisualStyleBackColor = false;
            this.btn_secimsayfasi.Click += new System.EventHandler(this.btn_secimsayfasi_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_anasayfa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_anasayfa.Location = new System.Drawing.Point(737, 569);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(107, 33);
            this.btn_anasayfa.TabIndex = 58;
            this.btn_anasayfa.Text = "Anasayfa";
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // arac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 682);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.btn_secimsayfasi);
            this.Controls.Add(this.txt_aracUcret);
            this.Controls.Add(this.lbl_dUcret);
            this.Controls.Add(this.txt_aracKonum);
            this.Controls.Add(this.txt_sanziman);
            this.Controls.Add(this.lbl_aracilce);
            this.Controls.Add(this.lbl_sanziman);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.lbl_tablo6);
            this.Controls.Add(this.lbl_tablo5);
            this.Controls.Add(this.lbl_tablo4);
            this.Controls.Add(this.lbl_tablo3);
            this.Controls.Add(this.lbl_tablo2);
            this.Controls.Add(this.lbl_tablo1);
            this.Controls.Add(this.tablo6dg);
            this.Controls.Add(this.tablo5dg);
            this.Controls.Add(this.tablo4dg);
            this.Controls.Add(this.tablo3dg);
            this.Controls.Add(this.tablo2dg);
            this.Controls.Add(this.btn_rYap);
            this.Controls.Add(this.date_tarih);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.txt_aracSinif);
            this.Controls.Add(this.lbl_aracSinif);
            this.Controls.Add(this.lbl_rzvicin);
            this.Controls.Add(this.txt_aracPlaka);
            this.Controls.Add(this.lbl_aracPlaka);
            this.Controls.Add(this.lbl_cizgi);
            this.Controls.Add(this.tablo1dg);
            this.Controls.Add(this.btn_sifirla);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.cb_sehir);
            this.Controls.Add(this.lbl_sehir);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.lbl_filtreler);
            this.Controls.Add(this.araclar);
            this.Name = "arac";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.araclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo2dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo3dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo4dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo5dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo6dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView araclar;
        private System.Windows.Forms.Label lbl_filtreler;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_sehir;
        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Button btn_sifirla;
        private System.Windows.Forms.DataGridView tablo1dg;
        private System.Windows.Forms.Label lbl_cizgi;
        private System.Windows.Forms.Label lbl_aracPlaka;
        private System.Windows.Forms.TextBox txt_aracPlaka;
        private System.Windows.Forms.Label lbl_rzvicin;
        private System.Windows.Forms.Label lbl_aracSinif;
        private System.Windows.Forms.TextBox txt_aracSinif;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.DateTimePicker date_tarih;
        private System.Windows.Forms.Button btn_rYap;
        private System.Windows.Forms.DataGridView tablo2dg;
        private System.Windows.Forms.DataGridView tablo3dg;
        private System.Windows.Forms.DataGridView tablo4dg;
        private System.Windows.Forms.DataGridView tablo5dg;
        private System.Windows.Forms.DataGridView tablo6dg;
        private System.Windows.Forms.Label lbl_tablo1;
        private System.Windows.Forms.Label lbl_tablo2;
        private System.Windows.Forms.Label lbl_tablo3;
        private System.Windows.Forms.Label lbl_tablo4;
        private System.Windows.Forms.Label lbl_tablo5;
        private System.Windows.Forms.Label lbl_tablo6;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label lbl_sanziman;
        private System.Windows.Forms.Label lbl_aracilce;
        private System.Windows.Forms.TextBox txt_sanziman;
        private System.Windows.Forms.Label lbl_dUcret;
        private System.Windows.Forms.TextBox txt_aracKonum;
        private System.Windows.Forms.TextBox txt_aracUcret;
        private System.Windows.Forms.Button btn_secimsayfasi;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}