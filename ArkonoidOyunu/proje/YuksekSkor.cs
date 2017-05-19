using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class YuksekSkor : Form
    {
        public YuksekSkor()
        {
            InitializeComponent();
        }
        Skor skor = new Skor();

        private void YuksekSkor_Load(object sender, EventArgs e)
        {          
            label3.Text = skor.kisiler[0].Ad;
            label5.Text = skor.kisiler[1].Ad;
            label7.Text = skor.kisiler[2].Ad;
            label9.Text = skor.kisiler[3].Ad;
            label11.Text = skor.kisiler[4].Ad;
            label4.Text = string.Format(" {0:00} : {1:00} ", skor.kisiler[0].Dakika, skor.kisiler[0].Saniye);
            label6.Text = string.Format(" {0:00} : {1:00} ", skor.kisiler[1].Dakika, skor.kisiler[1].Saniye);
            label8.Text = string.Format(" {0:00} : {1:00} ", skor.kisiler[2].Dakika, skor.kisiler[2].Saniye);
            label10.Text = string.Format(" {0:00} : {1:00} ", skor.kisiler[3].Dakika, skor.kisiler[3].Saniye);
            label12.Text = string.Format(" {0:00} : {1:00} ", skor.kisiler[4].Dakika, skor.kisiler[4].Saniye);        
        }

       
    }
}
