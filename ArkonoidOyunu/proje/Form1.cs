using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Skor skor = new Skor();
        Raket raket = new Raket();
        Top top = new Top();
        UstPanel ustPanel = new UstPanel();
        public Sure sure = new Sure();
        YuksekSkorlar yuksekSkorlar = new YuksekSkorlar();
        OyunBasla oyunBasla = new OyunBasla();
        SoundPlayer ses = new SoundPlayer();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            yuksekSkorlar.Click += delegate (object se, EventArgs en)
            {
                YuksekSkor yuksek = new YuksekSkor();
                yuksek.Show();
            };

            Controls.Add(ustPanel);
            panel1.Controls.Add(raket);
            ustPanel.Controls.Add(sure);
            ustPanel.Controls.Add(yuksekSkorlar);
            ustPanel.Controls.Add(oyunBasla);  
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {          
            if ((e.X + raket.Width / 2) < (panel1.Width) && e.X - raket.Width / 2 > 0)
            {
                raket.Left = e.X - (raket.Width / 2);                
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            top.Location = new Point(raket.Location.X + raket.Width / 2, panel1.Height - 40);           
            timer1.Start();
            panel1.Controls.Add(top);
            timer2.Start();
            ses.SoundLocation = "baslamasesi.wav";
            ses.Play();
        }

        public int saniye = 0;
        public int dakika = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            sure.Text = string.Format(" {0:00} : {1:00} ", dakika, saniye);
        }

        double x = 4, y = -4;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Cursor.Hide();
            top.Left += (int)x;
            top.Top += (int)y;

            if (top.Top < 0)
            {
                y *= -1;                  // burada ki -1 zıt yönünde git demek
                ses.SoundLocation = "topsesi.wav";  // x eksenine dokunmadık y ekseninin yönünü değiştirdik.
                ses.Play();
            }
            if (top.Left < 0 || top.Left + 40 > Width)
            {
                x *= -1;
                ses.SoundLocation = "topsesi.wav";
                ses.Play();
            }
            if ((raket.Left + raket.Width >= top.Left && raket.Left <= top.Left) && (raket.Top >= top.Top && raket.Top <= top.Top + 20))
            {
                y *= -1;                
                ses.SoundLocation = "raketsesi1.wav";
                ses.Play();
                x = x + (x / 10);
                y = y + (y / 10);              
            }
            if (top.Bottom + 10 > panel1.Height)
            {                
                timer1.Stop();             
                timer2.Stop();  
                            
                YuksekSkorYaptiniz form2 = new YuksekSkorYaptiniz();
                if (skor.Skor_Yuksekmi("ISIMSIZ", dakika, saniye) == true)
                    form2.Show();

                saniye = 0;
                dakika = 0;

                x = 4;   // bu x in eski değerini belitritr yazmazsak ilk yönü değişirhep
                y = -4;

                ses.SoundLocation = "yanmasesi.wav";
                ses.Play();               
            }
        }

    }
}
