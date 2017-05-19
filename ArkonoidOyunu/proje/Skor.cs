using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proje
{
    public struct Kisi
    {
        public string Ad;
        public int Dakika;
        public int Saniye;
        public int Toplam_saniye;
    };
    class Skor
    {
        public Kisi[] kisiler;
        Kisi degistir;
        int sayac;
        StreamWriter skor_yaz;
        StreamReader skor_oku;


        public Skor()
        {
            kisiler = new Kisi[6];     // 6 elemanlı dizi oluşturduk.
            sayac = 0;
            Dosyadan_Oku();
        }

        void Dosyadan_Oku()
        {
            if (File.Exists("SKOR.txt") == false)      // eğer dosya yoksa
            {
                Dosyaya_Yaz();
            }

            skor_oku = File.OpenText("SKOR.txt");

            for (int i = 0; i < 5; i++)
            {
                kisiler[i].Ad = skor_oku.ReadLine();
                kisiler[i].Dakika = int.Parse(skor_oku.ReadLine());
                kisiler[i].Saniye = int.Parse(skor_oku.ReadLine());
            }
            skor_oku.Close();
        }

        void Dosyaya_Yaz()
        {
            if (File.Exists("SKOR.txt") == false)   // eğer dosya varsa
            {
                Sifirla();                     // dosya varsa sıfırlıyor
            }                                  // yani default değerleri ekleniyor


            File.Delete("SKOR.txt");

            skor_yaz = File.AppendText("SKOR.txt");
            for (int i = 0; i < 5; i++)
            {
                skor_yaz.WriteLine(kisiler[i].Ad);
                skor_yaz.WriteLine(kisiler[i].Dakika);
                skor_yaz.WriteLine(kisiler[i].Saniye);
            }
            skor_yaz.Close();
        }
        public bool Skor_Yuksekmi(string ad, int dakika, int saniye)
        {

            kisiler[5].Ad = ad;
            kisiler[5].Dakika = dakika;
            kisiler[5].Saniye = saniye;

            Toplam_Saniye_Hesapla();

            for (int i = 0; i < 5; i++)
            {
                if (kisiler[5].Toplam_saniye > kisiler[i].Toplam_saniye)
                {
                    Siralama();
                    Dosyaya_Yaz();
                    return true;
                }

            }
            return false;
        }

        void Sifirla()
        {
            for (int i = 0; i < 6; i++)
            {
                kisiler[i].Ad = "ISIMSIZ";
                kisiler[i].Dakika = 0;
                kisiler[i].Saniye = 0;
            }
            sayac = 0;
        }

        void Toplam_Saniye_Hesapla()
        {
            for (int i = 0; i < 6; i++)
                kisiler[i].Toplam_saniye = (kisiler[i].Dakika * 60) + (kisiler[i].Saniye);

        }

        void Siralama()
        {
            Toplam_Saniye_Hesapla();
            for (int i = 0; i < 6; i++)
            {
                Toplam_Saniye_Hesapla();
                for (int j = 0; j < 5; j++)
                    if (kisiler[j + 1].Toplam_saniye > kisiler[j].Toplam_saniye)
                        Degistir(j, j + 1);
            }
        }

       

        void Degistir(int indis1, int indis2)
        {
            degistir.Ad = kisiler[indis1].Ad;
            degistir.Dakika = kisiler[indis1].Dakika;
            degistir.Saniye = kisiler[indis1].Saniye;

            kisiler[indis1].Ad = kisiler[indis2].Ad;
            kisiler[indis1].Dakika = kisiler[indis2].Dakika;
            kisiler[indis1].Saniye = kisiler[indis2].Saniye;

            kisiler[indis2].Ad = degistir.Ad;
            kisiler[indis2].Dakika = degistir.Dakika;
            kisiler[indis2].Saniye = degistir.Saniye;

        }
    }


}
