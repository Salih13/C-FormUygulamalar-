using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salih_Güngör_G140910053_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int skor = 0;
        int sure;
        int mayinSayisi;
        private void btn_baslat_Click(object sender, EventArgs e)
        {
            mayinSayisi = Convert.ToInt32(num_mayinSayisi.Value);
            int bombaSayisi = Convert.ToInt32(num_bombaSayisi.Value);
            MayinlariYerlestir(mayinSayisi, bombaSayisi);
        }
        void MayinlariYerlestir(int mayin, int bomba)
        {

            sure = (int)num_mayinSayisi.Value * 30;
            timer_sure.Start();
            flowLayoutPanel1.Controls.Clear();
            int[] bombalar = new int[bomba];
            Random random = new Random();
            for (int i = 0; i < bomba; i++)
            {
                int secilen = random.Next(mayin * 5);
                if (bombalar.Contains(secilen))
                {
                    i--;
                }
                else
                {
                    bombalar[i] = secilen;
                }
            }
            for (int i = 0; i < mayin * 5; i++)
            {
                Tarla buton = new Tarla();
                buton.Text = (i+1).ToString();
                buton.Tag = bombalar.Contains(i);
                buton.Click += mayinaTikla;
                flowLayoutPanel1.Controls.Add(buton);
            }
        }

        void mayinaTikla(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            bool durum = (bool)tiklanan.Tag;
            if (durum)
            {
                tiklanan.BackColor = Color.Red;                
                OyunBitir();
                txt_sure.Clear();

            }
            else
            {
                tiklanan.BackColor = Color.Green;
                skor++;
                txt_skor.Text = skor.ToString();              
            }
        }
        void OyunBitir()
        {
            skor = 0;
            timer_sure.Stop();
            foreach (Button buton in flowLayoutPanel1.Controls)
            {
                bool durum = (bool)buton.Tag;
                if (durum)
                {
                    buton.BackColor = Color.Red;
                }
                else
                {
                    buton.BackColor = Color.Green;
                }
                buton.Enabled = false;
            }
            DialogResult sonuc = MessageBox.Show("Oyun Bitti ! Tekrar oynamak ister misiniz ?", "Seçiminiz", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                txt_sure.Clear();
                txt_skor.Clear();
                int mayinSayisi = Convert.ToInt32(num_mayinSayisi.Value);
                int bombaSayisi = Convert.ToInt32(num_bombaSayisi.Value);
                MayinlariYerlestir(mayinSayisi, bombaSayisi);
            }
            else if (sonuc == DialogResult.No)
            {
                txt_sure.Clear();
                txt_skor.Clear();
                num_bombaSayisi.Value = 0;
                num_mayinSayisi.Value = 0;
            }
        }

        private void timer_sure_Tick(object sender, EventArgs e)
        {
            sure--;
            if (sure == 0)
            {
                OyunBitir();
                DialogResult sonuc = MessageBox.Show("Süre Doldu Oyunu Kaybettiniz.", "Oyun Bitti", MessageBoxButtons.OK);
            }
            txt_sure.Text = string.Format(" {0} ", sure);
        }

        private void btn_yeniOyun_Click(object sender, EventArgs e)
        {
            txt_sure.Clear();
            txt_skor.Clear();
            num_bombaSayisi.Value = 0;
            num_mayinSayisi.Value = 0;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Close();
        }       
    }
}
