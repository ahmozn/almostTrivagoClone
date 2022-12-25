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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=asd; user ID=postgres;");

        private void mal_sahibi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter dakisi = new NpgsqlDataAdapter("select * from only kisi order by kisi_no", baglanti);
            DataTable dt = new DataTable();
            dakisi.Fill(dt);
            cb_kisiNo.DisplayMember = "kisi_no";
            cb_kisiNo.ValueMember = "kisi_no";
            cb_kisiNo.DataSource = dt;
            cb_kisiNo.SelectedIndex = -1;
            cb_kisiNo.Text = "Kişi seçiniz..";
            baglanti.Close();

            baglanti.Open();
            NpgsqlDataAdapter da_gkisi = new NpgsqlDataAdapter("select * from only kisi order by kisi_no", baglanti);
            DataTable dt1 = new DataTable();
            da_gkisi.Fill(dt1);
            cb_gKisiNo.DisplayMember = "kisi_no";
            cb_gKisiNo.ValueMember = "kisi_no";
            cb_gKisiNo.DataSource = dt1;
            cb_gKisiNo.SelectedIndex = -1;
            cb_gKisiNo.Text = "Kişi seçiniz..";
            baglanti.Close();
        }
        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa anasayfaform = new anasayfa();
            anasayfaform.ShowDialog();
            this.Close();
        }

        private void btn_kisiEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand kisiEkle = new NpgsqlCommand("insert into kisi(ad,soyad,kisi_turu) values(@p1,@p2,@p3) ", baglanti);
            kisiEkle.Parameters.AddWithValue("@p1", txt_ad.Text);
            kisiEkle.Parameters.AddWithValue("@p2", txt_soyad.Text);
            kisiEkle.Parameters.AddWithValue("@p3", txt_kisiTuru.Text);
            kisiEkle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ekleme basarılı");
        }

        private void btn_kisiSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand kisiSil = new NpgsqlCommand("delete from kisi where kisi_no=@p1", baglanti);
            kisiSil.Parameters.AddWithValue("@p1", cb_kisiNo.SelectedValue);
            kisiSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme basarılı");
        }

        private void btn_gkisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand kisiguncelle = new NpgsqlCommand("update kisi set ad=@p1, soyad=@p2, kisi_turu=@p3 where kisi_no=@p4", baglanti);
            kisiguncelle.Parameters.AddWithValue("@p1", txt_gAd.Text);
            kisiguncelle.Parameters.AddWithValue("@p2", txt_gSoyad.Text);
            kisiguncelle.Parameters.AddWithValue("@p3", txt_gKisituru.Text);
            kisiguncelle.Parameters.AddWithValue("@p4", cb_gKisiNo.SelectedValue);
            kisiguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("guncelleme basarılı");
        }
    }
}
