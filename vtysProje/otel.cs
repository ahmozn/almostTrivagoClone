using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtysProje
{
    public partial class otel : Form
    {
        public otel()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=asd; user ID=postgres;");

        private void Form1_Load(object sender, EventArgs e)
        {
            string sorgu = "select otel_ad, otel_adres, yildiz, oda_turu, yatak, oda_numara, oda_ucret, domain from otel LEFT OUTER JOIN oda on otel.otel_no=oda.otel_no";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            oteller.DataSource = ds.Tables[0];

            baglanti.Open();
            NpgsqlDataAdapter daSehir = new NpgsqlDataAdapter("select * from il order by plaka", baglanti);
            DataTable dt = new DataTable();
            daSehir.Fill(dt);
            cb_sehir.DisplayMember = "il_adi";
            cb_sehir.ValueMember = "plaka";
            cb_sehir.DataSource = dt;
            cb_sehir.SelectedIndex = -1;
            cb_sehir.Text = "Şehir seçiniz..";
            baglanti.Close();
        }

        private void oteller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                DataGridViewRow daRow = oteller.Rows[e.RowIndex];
                txt_otelAd.Text = daRow.Cells[0].Value.ToString();
                txt_otelAdres.Text = daRow.Cells[1].Value.ToString();
                txt_yildiz.Text = daRow.Cells[2].Value.ToString();
                txt_odaNumara.Text = daRow.Cells[5].Value.ToString();
                txt_odaTuru.Text = daRow.Cells[3].Value.ToString();
                txt_yatakSayisi.Text = daRow.Cells[4].Value.ToString();
                txt_odaUcret.Text = daRow.Cells[6].Value.ToString();
                txt_domain.Text = daRow.Cells[7].Value.ToString();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string tablo1 = "select * from only kisi";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(tablo1, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            tablo1dg.DataSource = ds1.Tables[0];
            
            string tablo2 = "select * from otel";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(tablo2, baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            tablo2dg.DataSource = ds2.Tables[0];
            
            string tablo3 = "select * from arac";
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(tablo3, baglanti);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            tablo3dg.DataSource = ds3.Tables[0];
            
            string tablo4 = "select * from daire";
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(tablo4, baglanti);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            tablo4dg.DataSource = ds4.Tables[0];
            
            string tablo5 = "select * from oda";
            NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(tablo5, baglanti);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            tablo5dg.DataSource = ds5.Tables[0];
            
            string tablo6 = "select * from site";
            NpgsqlDataAdapter da6 = new NpgsqlDataAdapter(tablo6, baglanti);
            DataSet ds6 = new DataSet();
            da6.Fill(ds6);
            tablo6dg.DataSource = ds6.Tables[0];

        }

        private void btn_rYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand otel_rYap = new NpgsqlCommand("insert into rezervasyon(rezervasyon_tarihi,rezervasyon_turu, domain, kisi_no, rezervasyon_no) values (@p1,arac,@p3,@p4,@p5)", baglanti);
            otel_rYap.Parameters.AddWithValue("@p1", date_tarih.Value.Date);
            otel_rYap.Parameters.AddWithValue("@p3", txt_domain.Text);
            otel_rYap.Parameters.AddWithValue("@p4", 1);
            otel_rYap.Parameters.AddWithValue("@p5", 2);
            baglanti.Close();
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            txt_min.Text = "0";
            txt_max.Text = "99999";
            cb_sehir.SelectedIndex = -1;
            cb_sehir.Text = "Şehir seçiniz..";

            string doldur = "select otel_ad, otel_adres, yildiz, oda_turu, yatak, oda_numara, oda_ucret, domain from otel LEFT OUTER JOIN oda on otel.otel_no=oda.otel_no";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(doldur, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            oteller.DataSource = ds.Tables[0];
        }

        public void filtrele()
        {
            if (cb_sehir.SelectedIndex == -1)
            {
                string getir = "select otel_ad, otel_adres, yildiz, oda_turu, yatak, oda_numara, oda_ucret, domain from otel LEFT OUTER JOIN oda on otel.otel_no=oda.otel_no where oda_ucret between " + int.Parse(txt_min.Text) + " and " + int.Parse(txt_max.Text);
                NpgsqlDataAdapter daGetir = new NpgsqlDataAdapter(getir, baglanti);
                DataSet ds = new DataSet();
                daGetir.Fill(ds);
                oteller.DataSource = ds.Tables[0];
            }

            else
            {
                for (int i = 0; i < 82; i++)
                {
                    if (cb_sehir.SelectedIndex + 1 == i)
                    {
                        string sehiregore = "select otel_ad, otel_adres, yildiz, oda_turu, yatak, oda_numara, oda_ucret, domain from otel LEFT OUTER JOIN oda on otel.otel_no=oda.otel_no where il= " + i + " and oda_ucret between " + int.Parse(txt_min.Text) + " and " + int.Parse(txt_max.Text);
                        NpgsqlDataAdapter daSehiregore = new NpgsqlDataAdapter(sehiregore, baglanti);
                        DataSet dsSehiregore = new DataSet();
                        daSehiregore.Fill(dsSehiregore);
                        oteller.DataSource = dsSehiregore.Tables[0];
                    }
                    else
                        continue;
                }
            }
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            filtrele();
        }

        private void btn_secimsayfasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            musteri musteriForm = new musteri();
            musteriForm.ShowDialog();
            this.Close();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa anasayfaform = new anasayfa();
            anasayfaform.ShowDialog();
            this.Close();
        }
    }
}
