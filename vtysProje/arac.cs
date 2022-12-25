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
    public partial class arac : Form
    {
        public arac()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=asd; user ID=postgres;");

        private void Form1_Load(object sender, EventArgs e)
        {
            string doldur = "select arac_plaka , sinif , sanziman , kiralama_ucreti , arac_konum from arac";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(doldur, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            araclar.DataSource = ds.Tables[0];

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

        private void daireler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow daRow = araclar.Rows[e.RowIndex];
                txt_aracPlaka.Text = daRow.Cells[0].Value.ToString();
                txt_aracSinif.Text = daRow.Cells[1].Value.ToString();
                txt_sanziman.Text = daRow.Cells[2].Value.ToString();
                txt_aracKonum.Text = daRow.Cells[4].Value.ToString();
                txt_aracUcret.Text = daRow.Cells[3].Value.ToString();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string tablo1 = "select * from only kisi order by kisi_no";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(tablo1, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            tablo1dg.DataSource = ds1.Tables[0];

            string tablo2 = "select * from otel order by otel_no";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(tablo2, baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            tablo2dg.DataSource = ds2.Tables[0];

            string tablo3 = "select * from arac order by sasi_no";
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(tablo3, baglanti);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            tablo3dg.DataSource = ds3.Tables[0];

            string tablo4 = "select * from daire order by daire_no";
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(tablo4, baglanti);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            tablo4dg.DataSource = ds4.Tables[0];

            string tablo5 = "select * from oda order by oda_no";
            NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(tablo5, baglanti);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            tablo5dg.DataSource = ds5.Tables[0];

            string tablo6 = "select * from site order by domain";
            NpgsqlDataAdapter da6 = new NpgsqlDataAdapter(tablo6, baglanti);
            DataSet ds6 = new DataSet();
            da6.Fill(ds6);
            tablo6dg.DataSource = ds6.Tables[0];

        }

        private void btn_rYap_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            txt_min.Text = "0";
            txt_max.Text = "99999";
            cb_sehir.SelectedIndex = -1;
            cb_sehir.Text = "Şehir seçiniz..";

            string doldur = "select arac_plaka , sinif , sanziman , kiralama_ucreti , arac_konum from arac";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(doldur, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            araclar.DataSource = ds.Tables[0];
        }

        public void filtrele()
        {
            string getir = "select arac_plaka , sinif , sanziman , kiralama_ucreti , arac_konum from arac where kiralama_ucreti between " + int.Parse(txt_min.Text) + " and " + int.Parse(txt_max.Text);
            NpgsqlDataAdapter daGetir = new NpgsqlDataAdapter(getir, baglanti);
            DataSet ds = new DataSet();
            daGetir.Fill(ds);
            araclar.DataSource = ds.Tables[0];

            for(int i=0;i<82;i++)
            {
                if (cb_sehir.SelectedIndex+1 == i)
                {
                    string sehiregore = "select arac_plaka , sinif , sanziman , kiralama_ucreti , arac_konum from arac where il= " + i + " and kiralama_ucreti between " + int.Parse(txt_min.Text) + " and " + int.Parse(txt_max.Text);
                    NpgsqlDataAdapter daSehiregore = new NpgsqlDataAdapter(sehiregore, baglanti);
                    DataSet dsSehiregore = new DataSet();
                    daSehiregore.Fill(dsSehiregore);
                    araclar.DataSource = dsSehiregore.Tables[0];
                }
                else
                    continue;
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

