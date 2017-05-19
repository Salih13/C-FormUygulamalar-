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
    public partial class YuksekSkorYaptiniz : Form
    {
        public YuksekSkorYaptiniz()
        {
            InitializeComponent();
        }
        Skor skor = new Skor();
        Form1 form1 = (Form1)Application.OpenForms["Form1"];

        int dakika, saniye;
        private void Form2_Load(object sender, EventArgs e)
        {
            dakika = form1.dakika;
            saniye = form1.saniye;
            label3.Text = string.Format(" {0:00} : {1:00} ", dakika, saniye);           
            this.AcceptButton = tamam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skor.Skor_Yuksekmi(textBox1.Text, dakika, saniye);   // metodun parametrelerinde 2 farklı
            this.Close();                                       // formdan değerler ALAMAZSIN.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
