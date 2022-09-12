using System;
using System.Collections.Generic;
using System.Text;

namespace KonutSatis
{
    class Musteri
    {
        public string MusteriNo;
        public string Isim;
        public string Soyisim;
        public string MusteriIl;
        public string MusteriIlce;
        public string MusteriMahalle;
        public double MusteriButcesi;
        public string MusterininDaireAradigiSehir;
        public Cinsiyet Cns;
        public List<Musteri> Musteriler = new List<Musteri>();
        public DurumMusteri MusteriNiyeti;
        public IslemAdi YapilanIslem;

        public Musteri(string musteriNo,string isim, string soyisim, string il, string ilce, string mahalle, double musteriButcesi,string arananSehir, DurumMusteri a,IslemAdi z)
        {
            this.MusteriNo = musteriNo;
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.MusteriIl = il;
            this.MusteriIlce = ilce;
            this.MusteriMahalle = mahalle;
            this.MusteriButcesi = musteriButcesi;
            this.MusterininDaireAradigiSehir = arananSehir;
            this.MusteriNiyeti = a;
            this.YapilanIslem = z;

        }

      

        public Musteri()
        {
            
        }
    }

   

    enum Cinsiyet
    {
        Kadin, Erkek
    }
    enum DurumMusteri
    {
        Ariyor,Aramiyor
    }
    enum IslemAdi
    {
        SatinAlindi,Kiralandi,Islemsiz
    }

}
