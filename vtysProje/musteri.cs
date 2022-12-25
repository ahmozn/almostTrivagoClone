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
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }

        private void btn_otelform_Click(object sender, EventArgs e)
        {
            this.Hide();
            otel otelform = new otel();
            otelform.ShowDialog();
            this.Close();
        }

        private void btn_aracform_Click(object sender, EventArgs e)
        {
            this.Hide();
            arac aracform = new arac();
            aracform.ShowDialog();
            this.Close();
        }

        private void btn_daireform_Click(object sender, EventArgs e)
        {
            this.Hide();
            daire daireform = new daire();
            daireform.ShowDialog();
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
