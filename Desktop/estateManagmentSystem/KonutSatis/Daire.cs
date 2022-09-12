using System;
using System.Collections.Generic;
using System.Text;

namespace KonutSatis
{
    class Daire
    {
        public string DaireNo;//
        public DateTime YapilisTarihi;//
        public double Fiyat;//
        public double DaireninNetOlcusu;//
        public int DaireninOdaSayisi;//
        public int DaireninSalonSayisi;//
        public string Adres;
        public string DaireninBulunduguIl;//
        public string DaireninBulunduguSemt;//
        public Durum KiradaMiSatildiMi;//
        public SmiKmi IstenenKmiSmi;
        public DateTime KiralandigiGun;
        public DateTime IadeGunu;
        public List<Daire> Daireler = new List<Daire>();


        public Daire(string daireNo, DateTime yapilisT, double fiyat, double daireninOlcu,int DodaSayi, string il,string semt, Durum ks , SmiKmi s, int salon)
        {
            this.DaireNo = daireNo;
            this.YapilisTarihi = yapilisT;
            this.Fiyat = fiyat;
            this.DaireninNetOlcusu = daireninOlcu;
            this.DaireninOdaSayisi = DodaSayi;
            this.DaireninBulunduguIl = il;
            this.DaireninBulunduguSemt = semt;
            this.KiradaMiSatildiMi = ks;
            this.IstenenKmiSmi = s;
            this.DaireninSalonSayisi = salon;
        }
        public Daire()
        {

        }



    }



    enum Durum
    {
        Satildi, Kiralandi, Bosta
    }
    enum SmiKmi
    {
        Kiralik, Satilik
    }
}
