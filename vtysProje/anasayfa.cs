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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void btn_musteriyim_Click(object sender, EventArgs e)
        {
            this.Hide();
            musteri musteriform = new musteri();
            musteriform.ShowDialog();
            this.Close();
        }

        private void btn_malSahibi_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin adminform = new admin();
            adminform.ShowDialog();
            this.Close();
        }
    }
}
