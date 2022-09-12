using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KonutSatis
{
    class Uygulama
    {
        YardimciGerecler yrdm = new YardimciGerecler();
        Daire daire = new Daire();
        Musteri musteri = new Musteri();
        List<Daire> KiralanmisVeyaSatilmisList = new List<Daire>();
        public void Calistir()
        {
            do
            {
                Console.WriteLine("-------Gayrimenkul Yönetim Sistemi------");
                Console.WriteLine("1-Daire Ekle");
                Console.WriteLine("2-Müşteri Ekle");
                Console.WriteLine("3-Daire kirala veya satın al");
                Console.WriteLine("4-Bütün Müşterileri Listele");
                Console.WriteLine("5-Bütün Daireleri Listele");
                Console.WriteLine("6-Kiralık Daireleri Listele");
                Console.WriteLine("7-Satılık Daireleri Listele");
                Console.WriteLine("8-Dairenin Bilgilerini Görüntüle");
                Console.WriteLine("9-Fiyat Aralığına Göre Daireleri Listele");
                Console.WriteLine("10-Şu Tarihten Sonra Yapılan Daireleri Listele");
                Console.WriteLine("11-Adrese Göre Daireleri Listele");
                Console.WriteLine("12-En Pahalı ve Satılık 5 Daireyi Listele");
                Console.WriteLine("13-En Pahalı ve Kiralık 5 Daireyi Listele");
                Console.WriteLine("14-En Ucuz ve Satılık 3 Daireyi Listele");
                Console.WriteLine("15-En Ucuz ve Kiralık 3 Daireyi Listele");
                Console.WriteLine("16-Kiralanan Son Daireyi Gör");
                Console.WriteLine("17-Satılan Son Daireyi Gör");
                Console.WriteLine("18-Daire Güncelle");
                Console.WriteLine("19-Müşteri Güncelle");
                Console.WriteLine("20-Daire Sil");
                Console.WriteLine("21-Müşteri Sil");
                Console.WriteLine();
                Console.Write("Secim: ");
                SahteMusteri();
                SahteVeriDaire();
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        DaireEkle();
                        yrdm.dondur();

                        break;
                    case "2":
                        MusteriEkle();
                        yrdm.dondur();
                        break;
                    case "3":
                        DaireKiralaVeyaSatinAl();
                        yrdm.dondur();
                        break;
                    case "4":
                        ButunMusterileriListele();
                        yrdm.dondur();
                        break;
                    case "5":
                        ButunDaireleriListele();
                        yrdm.dondur();
                        break;
                    case "6":
                        KiralikDaireleriListele();
                        yrdm.dondur();
                        break;
                    case "7":
                        SatilikDaireleriListele();
                        yrdm.dondur();
                        break;
                    case "8":
                        DaireninBilgileriniGoruntule();
                        yrdm.dondur();
                        break;
                    case "9":
                        FiyatAraliginaGoreDaireleriListele();
                        yrdm.dondur();
                        break;
                    case "10":
                        SuTarihtenSonraYapilanDaireleriListele();
                        yrdm.dondur();
                        break;
                    case "11":
                        AdreseGoreDaireListele();
                        yrdm.dondur();
                        break;
                    case "12":
                        EnPahaliVeSatilik5Daire();
                        yrdm.dondur();
                        break;
                    case "13":
                        EnPahaliVeKiralik5Daire();
                        yrdm.dondur();
                        break;
                    case "14":
                        EnUcuzveSatılık3DaireyiListele();
                        yrdm.dondur();
                        break;
                    case "15":
                        EnUcuzVeKiralik3DaireyiListele();
                        yrdm.dondur();
                        break;
                    case "16":
                        KiralananSonDaireyiGor();
                        yrdm.dondur();
                        break;
                    case "17":
                        SatilanSonDaireyiGor();
                        yrdm.dondur();
                        break;
                    case "18":
                        DaireGuncelle();
                        yrdm.dondur();
                        break;
                    case "19":
                        MusteriGuncelle();
                            yrdm.dondur();
                        break;
                    case "20":
                        DaireSil();
                        yrdm.dondur();
                        break;
                    case "21":
                        MusteriSil();
                        yrdm.dondur();
                        break;
                    case "":
                        Console.WriteLine("Lutfen alani bos birakmayiniz. ");
                        break;
                    default:
                        Console.WriteLine("Yanlis bir deger girdiniz lutfen tekrar deneyin.");
                        break;

                }

            } while (yrdm.Donsun);
        }

        public void DaireEkle()
        {
            Console.WriteLine("Daire Ekle".PadRight(30, '-'));
            bool don = true;
            do
            {
                Console.Write("Daire numarasi: ");

                string daireNo = Console.ReadLine();
                int daireNoInt;
                if (int.TryParse(daireNo, out daireNoInt))
                {
                    don = false;
                    bool yapilisTarihiSorgula = true;
                    do
                    {
                        Console.Write("Dairenin yapilis tarihi: ");

                        string yTarihi = Console.ReadLine();
                        DateTime yTarihiDt;
                        if (DateTime.TryParse(yTarihi, out yTarihiDt))
                        {
                            yapilisTarihiSorgula = false;
                            daire.YapilisTarihi = yTarihiDt;


                            Console.WriteLine("Musteri Adresi:");
                            bool IlDondur = true;

                            do
                            {
                                Console.Write("Dairenin bulundugu il: ");
                                string il = Console.ReadLine();
                                int ilInt;
                                int sayac = 0;

                                for (int i = 0; i < il.Length; i++)
                                {
                                    if (int.TryParse(il.ToCharArray()[i].ToString(), out ilInt))
                                    {
                                        Console.WriteLine("Gecersiz bir deger girdiniz lutfen tekrar deneyin...");
                                        break;
                                    }
                                    else if (il == null)
                                    {
                                        Console.WriteLine("Dairenin bulundugu il kisimini bos birakamazsiniz...");
                                        break;
                                    }
                                    else
                                    {
                                        sayac++;
                                    }
                                }

                                if (sayac == il.Length)
                                {
                                    IlDondur = false;
                                    string SonDaireIl = yrdm.IlkHarfBuyuk(il);
                                    daire.DaireninBulunduguIl = SonDaireIl;



                                }
                                else
                                {
                                    break;
                                }
                            } while (IlDondur);
                            bool semtDondur = true;
                            do
                            {
                                Console.Write("Dairenin bulundugu semt: ");
                                string semt = Console.ReadLine();
                                int semtInt;
                                int sayac1 = 0;

                                for (int i = 0; i < semt.Length; i++)
                                {
                                    if (int.TryParse(semt.ToCharArray()[i].ToString(), out semtInt))
                                    {
                                        Console.WriteLine("Rakamlarla semt kiremezsin.");
                                    }
                                    else if (semt == null)
                                    {
                                        Console.WriteLine("Semt kisimini bos birakamazsin...");
                                    }
                                    else
                                    {
                                        sayac1++;
                                    }

                                    if (semt.Length == sayac1)
                                    {
                                        semtDondur = false;
                                        string sonSemt = yrdm.IlkHarfBuyuk(semt);
                                        daire.DaireninBulunduguSemt = sonSemt;

                                    }
                                }
                            } while (semtDondur);

                            bool KyadaSsorgulama = true;
                            do
                            {
                                Console.Write("Daire turu (Satilik(S) / Kuralik(K) ) : ");

                                string tur = Console.ReadLine().ToUpper();
                                switch (tur)
                                {
                                    case "S":
                                        daire.IstenenKmiSmi = SmiKmi.Satilik;
                                        KyadaSsorgulama = false;
                                        break;
                                    case "K":
                                        daire.IstenenKmiSmi = SmiKmi.Kiralik;
                                        KyadaSsorgulama = false;
                                        break;
                                    default:
                                        Console.WriteLine("Yanlis bir deger girdiniz, veya bos girdiniz. Lutfen tekrar deneyin.");
                                        break;
                                }
                            } while (KyadaSsorgulama);

                            bool DaireFiyatSorgula = true;
                            do
                            {
                                Console.Write("Dairenin fiyati: ");

                                string fiyat = Console.ReadLine();
                                double fiyatDouble;
                                if (double.TryParse(fiyat, out fiyatDouble) && fiyatDouble > 0)
                                {
                                    DaireFiyatSorgula = false;
                                    daire.Fiyat = fiyatDouble;
                                    bool daireOlcuSorgula = true;
                                    do
                                    {
                                        Console.Write("Dairenin net olcusu(m²)");
                                        string daireOlcu = Console.ReadLine();
                                        double daireOlcuDouble;

                                        if (double.TryParse(daireOlcu, out daireOlcuDouble))
                                        {
                                            daireOlcuSorgula = false;
                                            daire.DaireninNetOlcusu = daireOlcuDouble;

                                            bool odaSayisiSorgula = true;
                                            do
                                            {
                                                Console.Write("Dairenin oda sayisi: ");
                                                string odaSayisi = Console.ReadLine();
                                                int odaSayisiInt;

                                                if (int.TryParse(odaSayisi, out odaSayisiInt))
                                                {
                                                    bool salonDondur = true;
                                                    do
                                                    {
                                                        Console.Write("Dairenin salon sayisi: ");
                                                        string salon = Console.ReadLine();
                                                        int salonInt;

                                                        if (int.TryParse(salon, out salonInt))
                                                        {
                                                            odaSayisiSorgula = false;
                                                            salonDondur = false;
                                                            daire.DaireninOdaSayisi = odaSayisiInt;
                                                            daire.DaireninSalonSayisi = salonInt;
                                                            int yeniDaireNoInt = 0;
                                                            int sayac = 0;
                                                            int sayacEsit = 0;

                                                            do
                                                            {


                                                                foreach (Daire item in daire.Daireler)
                                                                {
                                                                    if (item.DaireNo != daireNoInt.ToString())
                                                                    {
                                                                        sayac++;

                                                                    }
                                                                    else
                                                                    {
                                                                        daireNoInt++;
                                                                        sayacEsit++;
                                                                        sayac = 0;
                                                                    }
                                                                }

                                                            } while (sayac != daire.Daireler.Count);

                                                            if (sayacEsit == 0)
                                                            {
                                                                Console.WriteLine("Sisteme " + daireNoInt + " Numarali daire basarili bir sekilde eklenmistir...");
                                                                sayacEsit = 0;
                                                                daire.DaireNo = daireNoInt.ToString();
                                                                daire.Daireler.Add(daire);
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Sistemde " + daireNo + " numaralı daire olduğu için verdiğiniz daire no " + daireNoInt + " olarak değiştirildi.");
                                                                daire.DaireNo = yeniDaireNoInt.ToString();
                                                                daire.Daireler.Add(daire);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Salon sayisi yerine yanlis bir deger girdiniz. Lutfen tekrar deneyin");
                                                        }
                                                    } while (salonDondur);


                                                }
                                                else
                                                {
                                                    Console.Write("Oda sayisi kisimina yanlis bir deger girdiniz veya bos biraktiniz. Lutfen tekrar deneyin");

                                                }
                                            } while (odaSayisiSorgula);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Net olcu kisimina yanlis bir deger girdiniz veya bos biraktiniz. Lutfen tekrar deneyin");
                                        }
                                    } while (daireOlcuSorgula);

                                }
                                else
                                {
                                    Console.WriteLine("Yanlis bir deger girdiniz veya bos biraktiniz. Lutfen tekrar deneyin...");
                                }
                            } while (DaireFiyatSorgula);

                        }
                        else
                        {
                            Console.WriteLine("Lutfen dairenin yapildigi tarih kisimina gecerli bir parametre giriniz veya bos birakmayiniz");
                        }
                    } while (yapilisTarihiSorgula);

                }
                else
                {
                    Console.WriteLine("Lutfen sadece rakamlari kullanarak daire numarasi giriniz veya bos birakmayiniz...");
                }
            } while (don);


        }

        public void SahteVeriDaire()
        {
            Daire dr = new Daire("1", new DateTime(1996, 08, 24), 20, 200, 3, "Ankara", "Cankaya", daire.KiradaMiSatildiMi = Durum.Satildi, daire.IstenenKmiSmi = SmiKmi.Satilik, 1);
            daire.Daireler.Add(dr);
            Daire dm = new Daire("2", new DateTime(2021, 01, 05), 15, 200, 3, "Albacete", "Iris", daire.KiradaMiSatildiMi = Durum.Bosta, daire.IstenenKmiSmi = SmiKmi.Satilik, 1);
            daire.Daireler.Add(dm);
            Daire a = new Daire("3", new DateTime(2010, 08, 24), 10, 200, 3, "Alanya", "Kestel", daire.KiradaMiSatildiMi = Durum.Bosta, daire.IstenenKmiSmi = SmiKmi.Kiralik, 1);
            daire.Daireler.Add(a);
            Daire b = new Daire("4", new DateTime(2009, 08, 24), 5, 200, 3, "Kaposvar", "Kebap", daire.KiradaMiSatildiMi = Durum.Kiralandi, daire.IstenenKmiSmi = SmiKmi.Kiralik, 1);
            daire.Daireler.Add(b);
            //Daire c = new Daire("5", new DateTime(2008, 08, 24), 3000, 200, 3, "Ankara", "Cankaya", daire.KiradaMiSatildiMi = Durum.Bosta, daire.IstenenKmiSmi = SmiKmi.Kiralik, 1);
            //daire.Daireler.Add(c);
            //Daire d = new Daire("6", new DateTime(2007, 08, 24), 2020, 200, 3, "Ankara", "Cankaya", daire.KiradaMiSatildiMi = Durum.Kiralandi, daire.IstenenKmiSmi = SmiKmi.Kiralik, 1);
            //daire.Daireler.Add(d);
            //Daire e = new Daire("7", new DateTime(2006, 08, 24), 80, 200, 3, "Ankara", "Cankaya", daire.KiradaMiSatildiMi = Durum.Bosta, daire.IstenenKmiSmi = SmiKmi.Kiralik, 1);
            //daire.Daireler.Add(e);
            //Daire f = new Daire("8", new DateTime(2005, 08, 24), 10, 200, 3, "Ankara", "Cankaya", daire.KiradaMiSatildiMi = Durum.Satildi, daire.IstenenKmiSmi = SmiKmi.Satilik, 1);
            //daire.Daireler.Add(f);
            //Daire g = new Daire("9", new DateTime(2004, 08, 24), 8, 200, 3, "Ankara", "Cankaya", daire.KiradaMiSatildiMi = Durum.Bosta, daire.IstenenKmiSmi = SmiKmi.Kiralik, 1);
            //daire.Daireler.Add(g);
            //Daire h = new Daire("10", new DateTime(2003, 08, 24), 7, 200, 3, "Ankara", "Cankaya", daire.KiradaMiSatildiMi = Durum.Bosta, daire.IstenenKmiSmi = SmiKmi.Satilik, 1);
            //daire.Daireler.Add(h);
        }

        public void SahteMusteri()
        {
            Musteri SahteMus = new Musteri("1", "Cagdas", "Mirici", "Ankara", "Cankaya", "Yukari dikmen", 2000, "Ankara", DurumMusteri.Ariyor,IslemAdi.Islemsiz);
            musteri.Musteriler.Add(SahteMus);
        }

        public void MusteriEkle()
        {
            bool MusteriNoDondur = true;
            do
            {
                Console.WriteLine("2-Musteri Ekle".PadRight(30, '-'));
                Console.Write("Musteri numarasi: ");
                string no = Console.ReadLine();
                int noInt;
                if (int.TryParse(no, out noInt)) //numara en altta sorgulanip ciktisi alinacak
                {

                    MusteriNoDondur = false;
                    bool MusteriAdiDondur = true;
                    do
                    {
                        Console.Write("Musteri adi: ");
                        string ad = Console.ReadLine();
                        int sayac0 = 0;
                        for (int i = 0; i < ad.Length; i++)
                        {
                            ad.ToCharArray();
                            if (int.TryParse(ad.ToCharArray()[i].ToString(), out noInt))
                            {
                                Console.WriteLine("Musteri ismi kisimina herhangi bir numara giremezsin. Lutfen tekrar dene...");
                                break;
                            }
                            else if (ad == null)
                            {

                                Console.WriteLine("Musteri adi kismini bos birakamazsin...");
                                break;
                            }
                            else
                            {
                                sayac0++;
                            }
                            if (sayac0 == ad.Length)
                            {
                                string SonIsim = yrdm.IlkHarfBuyuk(ad);
                                musteri.Isim = SonIsim;
                                MusteriAdiDondur = false;
                                int sayac = 0;
                                bool MusteriSoyadiDondur = true;
                                string soyad;
                                do
                                {
                                    Console.Write("Musteri soyadi: ");
                                    soyad = Console.ReadLine();
                                    int soyadInt;

                                    for (int a = 0; a < soyad.Length; a++)
                                    {
                                        if (int.TryParse(soyad.ToCharArray()[a].ToString(), out soyadInt))
                                        {
                                            Console.WriteLine("Musteri soyismi kisimina herhangi bir numara ile giris yapamazsin lutfen tekrar dene...");
                                            break;
                                        }
                                        else if (soyad == null)
                                        {
                                            Console.WriteLine("Musteri soyadi kismini bos birakamazsin...");
                                            break;
                                        }
                                        else
                                        {
                                            sayac++;
                                        }
                                        if (sayac == soyad.Length)
                                        {
                                            MusteriSoyadiDondur = false;
                                            string SonSoyad = yrdm.IlkHarfBuyuk(soyad);
                                            musteri.Soyisim = SonSoyad;

                                            bool CinsiyetDondur = true;
                                            do
                                            {
                                                Console.Write("Musteri cinsiyeti(K/E): ");
                                                string cinsiyet = Console.ReadLine().ToUpper();
                                                switch (cinsiyet)
                                                {
                                                    case "K":
                                                        musteri.Cns = Cinsiyet.Kadin;
                                                        CinsiyetDondur = false;
                                                        break;
                                                    case "E":
                                                        musteri.Cns = Cinsiyet.Erkek;
                                                        CinsiyetDondur = false;
                                                        break;
                                                    case null:
                                                        Console.WriteLine("Musteri cinsiyeti kismini bos birakamazsiniz....");
                                                        break;
                                                    default:
                                                        Console.WriteLine("Yanlis bir deger gidiniz...");
                                                        break;
                                                }
                                            } while (CinsiyetDondur);


                                            Console.WriteLine("Musteri Adresi:");
                                            bool IlDondur = true;
                                            do
                                            {
                                                Console.Write("Il: ");
                                                int sayac1 = 0;
                                                string il = Console.ReadLine();
                                                int IlInt;
                                                for (int b = 0; b < il.Length; b++)
                                                {
                                                    if (int.TryParse(il.ToCharArray()[a].ToString(), out IlInt))
                                                    {
                                                        Console.WriteLine("Musterinin ikamet ettigi il kisimina herhangi bir sayi giremezsin. Lutfen tekrar deneyin...");
                                                        break;
                                                    }
                                                    else if (il == null)
                                                    {
                                                        Console.WriteLine("Musterinin ikamet ettigi il kismini bos birakamazsin...");
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        sayac1++;
                                                    }
                                                    if (sayac1 == il.Length)
                                                    {
                                                        string sonIl = yrdm.IlkHarfBuyuk(il);
                                                        IlDondur = false;
                                                        musteri.MusteriIl = sonIl;
                                                        int sayac2 = 0;

                                                        bool ilceDondur = true;
                                                        do
                                                        {
                                                            Console.Write("Ilce: ");
                                                            string ilce = Console.ReadLine();
                                                            int IlceInt;
                                                            for (int c = 0; c < ilce.Length; c++)
                                                            {
                                                                if (int.TryParse(ilce.ToCharArray()[c].ToString(), out IlceInt))
                                                                {
                                                                    Console.WriteLine("Musterinin ikamet ettigi ilce kisimina herhangi bir sayi giremezsin. Lutfen tekrar deneyin...");
                                                                    break;
                                                                }
                                                                else if (ilce == null)
                                                                {
                                                                    Console.WriteLine("Musterinin ikamet ettigi ilce kisimini bos birakamazsin...");
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    sayac2++;
                                                                }
                                                            }
                                                            if (sayac2 == ilce.Length)
                                                            {
                                                                ilceDondur = false;
                                                                string sonIlce = yrdm.IlkHarfBuyuk(ilce);
                                                                musteri.MusteriIlce = sonIlce;
                                                                Console.Write("Mahalle: ");
                                                                string mahalle = Console.ReadLine();
                                                                string sonMahalle = yrdm.IlkHarfBuyuk(mahalle);
                                                                musteri.MusteriMahalle = sonMahalle;

                                                                bool butceDondur = true;
                                                                do
                                                                {
                                                                    Console.Write("Musteri butcesi: ");
                                                                    string butce = Console.ReadLine();
                                                                    double butceInt;
                                                                    if (double.TryParse(butce, out butceInt) && butceInt > 0)
                                                                    {
                                                                        butceDondur = false;
                                                                        musteri.MusteriButcesi = butceInt;
                                                                        bool DaireArananSehirDondur = true;
                                                                        do
                                                                        {
                                                                            Console.Write("Daire aranan sehir: ");
                                                                            string arananSehir = Console.ReadLine();
                                                                            int arananSehirInt;
                                                                            int sayac3 = 0;
                                                                            for (int k = 0; k < arananSehir.Length; k++)
                                                                            {
                                                                                if (int.TryParse(arananSehir.ToCharArray()[k].ToString(), out arananSehirInt))
                                                                                {
                                                                                    Console.WriteLine("Daire aranan sehir kisimina numara ile giris yapamazsin lutfen tekrar dene...");
                                                                                    break;
                                                                                }
                                                                                else if (arananSehir == null)
                                                                                {
                                                                                    Console.WriteLine("Dairenin arandigi sehir kisimini bos birakamazsin...");
                                                                                    break;
                                                                                }
                                                                                else
                                                                                {
                                                                                    sayac3++;
                                                                                }
                                                                            }
                                                                            if (sayac3 == arananSehir.Length)
                                                                            {
                                                                                DaireArananSehirDondur = false;
                                                                                string sonArananSehir = yrdm.IlkHarfBuyuk(arananSehir);
                                                                                musteri.MusterininDaireAradigiSehir = sonArananSehir;
                                                                                int sayac4 = 0;
                                                                                int sayacEsit = 0;


                                                                                do
                                                                                {
                                                                                    foreach (Musteri item in musteri.Musteriler)
                                                                                    {
                                                                                        if (item.MusteriNo != no)
                                                                                        {
                                                                                            sayac4++;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            noInt++;
                                                                                            sayacEsit++;
                                                                                            sayac4 = 0;
                                                                                        }
                                                                                    }
                                                                                } while (sayac4 != musteri.Musteriler.Count);

                                                                                if (sayacEsit == 0)
                                                                                {
                                                                                    Console.WriteLine("Sisteme " + noInt + " Numarali daire basarili bir sekilde eklenmistir...");
                                                                                    sayacEsit = 0;
                                                                                    musteri.MusteriNo = noInt.ToString();
                                                                                    musteri.MusteriNiyeti = DurumMusteri.Ariyor;
                                                                                    musteri.YapilanIslem = IslemAdi.Islemsiz;
                                                                                    musteri.Musteriler.Add(musteri);
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Sistemde " + no + " numaralı daire olduğu için verdiğiniz daire no " + noInt + " olarak değiştirildi.");
                                                                                    musteri.MusteriNo = noInt.ToString();
                                                                                    musteri.MusteriNiyeti = DurumMusteri.Ariyor;
                                                                                    musteri.YapilanIslem = IslemAdi.Islemsiz;
                                                                                    musteri.Musteriler.Add(musteri);
                                                                                }
                                                                                Console.WriteLine();
                                                                                Console.WriteLine("Bilgiler sisteme girilmistir...");


                                                                            }
                                                                        } while (DaireArananSehirDondur);

                                                                    }
                                                                    else if (butce == null)
                                                                    {
                                                                        Console.WriteLine("Musteri butcesi girilmelidir");
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("butceyi yalnizca rakamlarla girebilirsiniz...");
                                                                    }
                                                                } while (butceDondur);


                                                            }

                                                        } while (ilceDondur);


                                                    }
                                                }
                                            } while (IlDondur);

                                        }
                                    }
                                } while (sayac != soyad.Length);

                            }
                        }
                    } while (MusteriAdiDondur);


                }
                else if (no == null)
                {
                    Console.WriteLine("Musteri numarasini bos birakamazsiniz...");
                }
                else
                {
                    Console.WriteLine("Yanlis bir deger girdiniz lutfen tekrar deneyiniz...");
                }
            } while (MusteriNoDondur);
        }

        public void DaireKiralaVeyaSatinAl()
        {
            Console.WriteLine("Daire Kirala/Satin Al ".PadRight(30, '-'));
            bool MusteriNoDondur = true;
            do
            {
                Console.Write("Musteri numarasi: ");
                string no = Console.ReadLine().Trim();
                int noInt;
                if (int.TryParse(no, out noInt))
                {


                    Musteri mus = musteri.Musteriler.Where(x => x.MusteriNo == no).FirstOrDefault();

                    if (mus != null)
                    {
                        MusteriNoDondur = false;
                        bool DaireTuru = true;
                        do
                        {
                            Console.Write("Daire turu(Kiralik(K)/Satilik(S): ");
                            string Tur = Console.ReadLine();
                            string sonTur = yrdm.IlkHarfBuyuk(Tur);
                            switch (sonTur)
                            {
                                case "K":
                                    DaireTuru = false;
                                    List<Daire> KiralikDaireler = daire.Daireler.Where(x => x.IstenenKmiSmi == SmiKmi.Kiralik && x.KiradaMiSatildiMi == Durum.Bosta).ToList();

                                    Console.WriteLine("Aranan adres: ");
                                    bool sehirDondur = true;

                                    int sayacSemtli = 0;
                                    int sayacSemtsiz = 0;

                                    if (KiralikDaireler != null)
                                    {
                                        do
                                        {

                                        don:;
                                            Console.Write("Sehir: ");
                                            string sehir = Console.ReadLine();
                                            string sonSehir = yrdm.IlkHarfBuyuk(sehir);
                                            switch (sonSehir)
                                            {
                                                case "Null":
                                                    Console.WriteLine("Sehir girilmesi gereken kisimi bos birakamazsin");
                                                    goto don;
                                                    break;

                                            }

                                            Console.Write("Semt: ");
                                            string semt = Console.ReadLine();
                                            string sonSemt = yrdm.IlkHarfBuyuk(semt);



                                            foreach (Daire item in KiralikDaireler)
                                            {
                                                if (item.DaireninBulunduguIl == sonSehir && item.DaireninBulunduguSemt == sonSemt)
                                                {
                                                    sayacSemtli++;
                                                    sehirDondur = false;
                                                }
                                                else if (item.DaireninBulunduguIl == sonSehir && sonSemt == "Null")
                                                {
                                                    sayacSemtsiz++;
                                                    sehirDondur = false;
                                                }
                                                //else
                                                //{
                                                //    Console.WriteLine("Lutfen tekrar deneyin...");
                                                //    break;
                                                //}
                                            }



                                            if (sayacSemtli > 0)
                                            {
                                                List<Daire> d = KiralikDaireler.Where(x => x.DaireninBulunduguSemt == sonSemt && x.DaireninBulunduguIl == sonSehir && x.IstenenKmiSmi == SmiKmi.Kiralik && x.KiradaMiSatildiMi == Durum.Bosta).ToList();
                                                if (d.Count > 0)
                                                {
                                                    bool minFiyatSorgula = true;
                                                    do
                                                    {
                                                        Console.Write("Minimum fiyat: ");
                                                        string minFiyat = Console.ReadLine();
                                                        double minFiyatDouble;
                                                        if (double.TryParse(minFiyat, out minFiyatDouble))
                                                        {

                                                            if (minFiyatDouble > 0)
                                                            {
                                                                minFiyatSorgula = false;
                                                                bool maxFiyatSorgula = true;
                                                                do
                                                                {
                                                                    Console.Write("Maksimum fiyat: ");
                                                                    string maxFiyat = Console.ReadLine();
                                                                    double maxFiyatDouble;
                                                                    if (double.TryParse(maxFiyat, out maxFiyatDouble))
                                                                    {
                                                                        if (minFiyatDouble < maxFiyatDouble && minFiyatDouble > 0)//fiyat kisimi icin en captulation da 0 dan buyuk olmasi kontrolu yapilacak
                                                                        {

                                                                            Console.WriteLine("Daire No".PadRight(20, ' ') + "Olcusu".PadRight(20, ' ') + "Oda Sayisi".PadRight(20, ' ') + "Yapilis Tarihi".PadRight(20, ' ') + "Sehir".PadRight(20, ' ') + "Semt".PadRight(20, ' ') + "S / K".PadRight(20, ' ') + "Fiyat".PadRight(20, ' '));
                                                                            List<Daire> drl = d.Where(x => x.Fiyat <= maxFiyatDouble && x.Fiyat >= minFiyatDouble).ToList();

                                                                            if (drl.Count > 0)
                                                                            {
                                                                                maxFiyatSorgula = false;
                                                                                foreach (Daire item in drl)
                                                                                {
                                                                                    Console.WriteLine(item.DaireNo.ToString().PadRight(20, ' ') + item.DaireninNetOlcusu.ToString() + "m²".PadRight(20, ' ') + item.DaireninOdaSayisi.ToString().PadRight(20, ' ') + item.YapilisTarihi.ToString("d").PadRight(20, ' ') + item.DaireninBulunduguIl.PadRight(20, ' ') + item.DaireninBulunduguSemt.PadRight(20, ' ') + item.IstenenKmiSmi.ToString().PadRight(20, ' ') + item.Fiyat.ToString());

                                                                                }

                                                                                Console.WriteLine("Yukarida bilgilerini gordugunuz dairelerden herhangi birini secip kiralamak icin secim kisimina dairenin numarasini giriniz...");
                                                                                bool secimDondur = true;
                                                                                do
                                                                                {
                                                                                    Console.Write("Secim: ");
                                                                                    string secim = Console.ReadLine();
                                                                                    int secimInt;
                                                                                    if (int.TryParse(secim, out secimInt))
                                                                                    {


                                                                                        foreach (Daire item in drl)
                                                                                        {
                                                                                            if (item.DaireNo == secimInt.ToString())
                                                                                            {
                                                                                                bool GunSorgula = true;
                                                                                                do
                                                                                                {
                                                                                                    secimDondur = false;
                                                                                                    Console.Write("Kiralanmak istenen gun sayisi: ");
                                                                                                    string sure = Console.ReadLine();
                                                                                                    double sureInt;
                                                                                                    if (double.TryParse(sure, out sureInt))
                                                                                                    {
                                                                                                        GunSorgula = false;
                                                                                                        mus.YapilanIslem = IslemAdi.Kiralandi;
                                                                                                        item.KiradaMiSatildiMi = Durum.Kiralandi;
                                                                                                        item.KiralandigiGun = DateTime.Now;
                                                                                                        item.IadeGunu = item.KiralandigiGun.AddDays(sureInt);
                                                                                                        mus.MusteriNiyeti = DurumMusteri.Aramiyor;
                                                                                                        KiralanmisVeyaSatilmisList.Add(item);


                                                                                                        Console.WriteLine(item.DaireNo + " Numarali daire " + mus.Isim + " Adina " + sureInt + " Gun kadar kiralanmistir. Daireyi teslim alma tarhi " + item.IadeGunu + " Dir");
                                                                                                        Console.WriteLine("Sisteme basariyla kaydedildi");
                                                                                                        return;

                                                                                                    }
                                                                                                    else if (sure == null)
                                                                                                    {
                                                                                                        Console.WriteLine("Lutfen kiralanmak istenen gun kisimini bos birakmayiniz...");
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        Console.WriteLine("Gun kisimina sadece rakamlarla giris yapabilirsiniz.");
                                                                                                    }
                                                                                                } while (GunSorgula);
                                                                                            }

                                                                                        }
                                                                                        foreach (Daire item in drl)
                                                                                        {
                                                                                            if (item.DaireNo != secimInt.ToString())
                                                                                            {
                                                                                                Console.WriteLine("Cikarilan fiyat listesinde bu numarali bir daire yoktur lutfen dogru girdiginizden emin olun.");
                                                                                            }
                                                                                        }

                                                                                    }
                                                                                    else if (secim == null)
                                                                                    {
                                                                                        Console.WriteLine("Lutfen alani bos birakmayiniz...");

                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        Console.WriteLine("Sadece rakamlarla giris yapabilirsiniz..");
                                                                                    }
                                                                                } while (secimDondur);

                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Girdiginiz fiyat araliginda herhangi bir daire bulunmamaktadir.");
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("maksimum fiyat kisimini yalnizca rakamlarla giriniz. Veya alani bos birakmayiniz.");
                                                                    }
                                                                } while (maxFiyatSorgula);

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("1 Sayisindan daha kucuk bir sayi giremezsin lutfen tekrar dene");

                                                            }

                                                        }
                                                    } while (minFiyatSorgula);

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Minimum fiyati yalnizca rakamlari kullanarak giriniz veya alani bos birakmayiniz");
                                                }

                                            }

                                            else if (sayacSemtsiz > 0)
                                            {
                                                List<Daire> da = KiralikDaireler.Where(x => x.DaireninBulunduguIl == sonSehir && x.IstenenKmiSmi == SmiKmi.Kiralik && x.KiradaMiSatildiMi == Durum.Bosta).ToList();

                                                if (da.Count > 0)
                                                {
                                                    bool MinFiyatSorgula = true;
                                                    do
                                                    {
                                                        Console.Write("Minimum fiyat: ");
                                                        string minFiyat = Console.ReadLine();
                                                        double minFiyatDouble;
                                                        if (double.TryParse(minFiyat, out minFiyatDouble))
                                                        {
                                                            MinFiyatSorgula = false;
                                                            bool MaxFiyatSorgula = true;
                                                            do
                                                            {

                                                                Console.Write("Maksimum fiyat: ");
                                                                string maxFiyat = Console.ReadLine();
                                                                double maxFiyatDouble;
                                                                if (double.TryParse(maxFiyat, out maxFiyatDouble))
                                                                {

                                                                    if (minFiyatDouble < maxFiyatDouble && minFiyatDouble > 0)//fiyat kisimi icin en captulation da 0 dan buyuk olmasi kontrolu yapilacak
                                                                    {
                                                                        MaxFiyatSorgula = false;
                                                                        Console.WriteLine("Daire No".PadRight(20, ' ') + "Olcusu".PadRight(20, ' ') + "Oda Sayisi".PadRight(20, ' ') + "Yapilis Tarihi".PadRight(20, ' ') + "Sehir".PadRight(20, ' ') + "Semt".PadRight(20, ' ') + "S / K".PadRight(20, ' ') + "Fiyat".PadRight(20, ' '));
                                                                        List<Daire> fList = da.Where(x => x.Fiyat >= minFiyatDouble && x.Fiyat <= maxFiyatDouble).ToList();
                                                                        foreach (Daire item in fList)
                                                                        {
                                                                            if (maxFiyatDouble >= item.Fiyat && item.Fiyat >= minFiyatDouble)
                                                                            {
                                                                                Console.WriteLine(item.DaireNo.ToString().PadRight(20, ' ') + item.DaireninNetOlcusu.ToString() + "m²".PadRight(20, ' ') + item.DaireninOdaSayisi.ToString().PadRight(20, ' ') + item.YapilisTarihi.ToString().PadRight(20, ' ') + item.DaireninBulunduguIl.PadRight(20, ' ') + item.DaireninBulunduguSemt.PadRight(20, ' ') + item.IstenenKmiSmi.ToString().PadRight(20, ' ') + item.Fiyat.ToString());
                                                                            }

                                                                        }
                                                                        if (fList.Count <= 0)
                                                                        {
                                                                            Console.WriteLine("Sectiginiz fiyat araliginda daire bulunmamaktadir.");

                                                                        }


                                                                        Console.WriteLine("Yukarida bilgilerini gordugunuz dairelerden herhangi birini secip kiralamak icin secim kisimina dairenin numarasini giriniz...");
                                                                        bool secimDondur = true;
                                                                        do
                                                                        {
                                                                            Console.Write("Secim: ");
                                                                            string secim = Console.ReadLine();
                                                                            int secimInt;
                                                                            if (int.TryParse(secim, out secimInt))
                                                                            {


                                                                                foreach (Daire item in fList)
                                                                                {
                                                                                    if (item.DaireNo == secimInt.ToString())
                                                                                    {
                                                                                        bool GunSorgula = true;
                                                                                        do
                                                                                        {
                                                                                            secimDondur = false;
                                                                                            Console.Write("Kiralanmak istenen gun sayisi: ");
                                                                                            string sure = Console.ReadLine();
                                                                                            double sureInt;
                                                                                            if (double.TryParse(sure, out sureInt))
                                                                                            {
                                                                                                GunSorgula = false;
                                                                                                mus.YapilanIslem = IslemAdi.Kiralandi;
                                                                                                item.KiradaMiSatildiMi = Durum.Kiralandi;
                                                                                                item.KiralandigiGun = DateTime.Now;
                                                                                                item.IadeGunu = item.KiralandigiGun.AddDays(sureInt);
                                                                                                mus.MusteriNiyeti = DurumMusteri.Aramiyor;
                                                                                                KiralanmisVeyaSatilmisList.Add(item);


                                                                                                Console.WriteLine(item.DaireNo + " Numarali daire " + mus.Isim + " Adina " + sureInt + " Gun kadar kiralanmistir. Daireyi teslim alma tarhi " + item.IadeGunu + " Dir");
                                                                                                Console.WriteLine("Sisteme basariyla kaydedildi");
                                                                                                return;

                                                                                            }
                                                                                            else if (sure == null)
                                                                                            {
                                                                                                Console.WriteLine("Lutfen kiralanmak istenen gun kisimini bos birakmayiniz...");
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.WriteLine("Gun kisimina sadece rakamlarla giris yapabilirsiniz.");
                                                                                            }
                                                                                        } while (GunSorgula);
                                                                                    }

                                                                                }
                                                                                foreach (Daire item in fList)
                                                                                {
                                                                                    if (item.DaireNo != secimInt.ToString())
                                                                                    {
                                                                                        Console.WriteLine("Cikarilan fiyat listesinde bu numarali bir daire yoktur lutfen dogru girdiginizden emin olun.");
                                                                                    }
                                                                                }

                                                                            }
                                                                            else if (secim == null)
                                                                            {
                                                                                Console.WriteLine("Lutfen alani bos birakmayiniz...");

                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Sadece rakamlarla giris yapabilirsiniz..");
                                                                            }
                                                                        } while (secimDondur);
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Maksimum fiyat kisimini yalnizca rakamlarla giriniz. Veya alani bos birakmayiniz.");
                                                                }
                                                            } while (MaxFiyatSorgula);

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Minimum fiyati yalnizca rakamlari kullanarak giriniz veya alani bos birakmayiniz");
                                                        }
                                                    } while (MinFiyatSorgula);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Bu sehirde kiralik daire bulunmamaktadir");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Bu semtte veya sehirde kiralik dairemiz bulunmamaktadir");

                                            }

                                        } while (sehirDondur);

                                    }
                                    else
                                    {
                                        Console.WriteLine("Sistemde kiralik daire bulunmamaktadir.");
                                    }
                                    break;
                                case "S":
                                    List<Daire> SatilikDaireList = daire.Daireler.Where(x => x.IstenenKmiSmi == SmiKmi.Satilik && x.KiradaMiSatildiMi == Durum.Bosta).ToList();
                                    DaireTuru = false;
                                    Console.WriteLine("Aranan adres: ");
                                    bool sehirDondur2 = true;

                                    int sayacSemtli2 = 0;
                                    int sayacSemtsiz2 = 0;

                                    if (SatilikDaireList != null)
                                    {
                                        do
                                        {
                                        don2:;
                                            Console.Write("Sehir: ");
                                            string sehir = Console.ReadLine();
                                            string sonSehir = yrdm.IlkHarfBuyuk(sehir);
                                            switch (sonSehir)
                                            {
                                                case "Null":
                                                    Console.WriteLine("Sehir girilmesi gereken kisimi bos birakamazsin");
                                                    goto don2;
                                                    break;

                                            }
                                            Console.Write("Semt: ");
                                            string semt = Console.ReadLine();
                                            string sonSemt = yrdm.IlkHarfBuyuk(semt);



                                            foreach (Daire item in SatilikDaireList)
                                            {
                                                if (item.DaireninBulunduguIl == sonSehir && item.DaireninBulunduguSemt == sonSemt)
                                                {
                                                    sehirDondur2 = false;
                                                    sayacSemtli2++;
                                                    sehirDondur = false;
                                                }
                                                else if (item.DaireninBulunduguIl == sonSehir && sonSemt == "Null")
                                                {
                                                    sehirDondur2 = false;
                                                    sayacSemtsiz2++;
                                                    sehirDondur = false;
                                                }
                                                //else
                                                //{
                                                //    Console.WriteLine("Lutfen tekrar deneyin...");
                                                //    break;
                                                //}
                                            }



                                            if (sayacSemtli2 > 0)
                                            {
                                                List<Daire> d = SatilikDaireList.Where(x => x.DaireninBulunduguSemt == sonSemt && x.DaireninBulunduguIl == sonSehir && x.IstenenKmiSmi == SmiKmi.Satilik && x.KiradaMiSatildiMi == Durum.Bosta).ToList();
                                                if (d.Count > 0)
                                                {
                                                    bool minFiyatSorgula = true;
                                                    do
                                                    {
                                                    don3:;
                                                        Console.Write("Minimum fiyat: ");
                                                        string minFiyat = Console.ReadLine();
                                                        double minFiyatDouble;
                                                        if (double.TryParse(minFiyat, out minFiyatDouble))
                                                        {
                                                            if (minFiyatDouble > 0)
                                                            {
                                                                minFiyatSorgula = false;
                                                                bool maxFiyatSorgula = true;
                                                                do
                                                                {
                                                                    Console.Write("Maksimum fiyat: ");
                                                                    string maxFiyat = Console.ReadLine();
                                                                    double maxFiyatDouble;
                                                                    if (double.TryParse(maxFiyat, out maxFiyatDouble))
                                                                    {

                                                                        if (minFiyatDouble < maxFiyatDouble)//fiyat kisimi icin en captulation da 0 dan buyuk olmasi kontrolu yapilacak
                                                                        {
                                                                            maxFiyatSorgula = false;
                                                                            Console.WriteLine("Daire No".PadRight(20, ' ') + "Olcusu".PadRight(20, ' ') + "Oda Sayisi".PadRight(20, ' ') + "Yapilis Tarihi".PadRight(20, ' ') + "Sehir".PadRight(20, ' ') + "Semt".PadRight(20, ' ') + "S / K".PadRight(20, ' ') + "Fiyat".PadRight(20, ' '));
                                                                            List<Daire> SatiliklaraListe = d.Where(x => x.Fiyat >= minFiyatDouble && x.Fiyat <= maxFiyatDouble).ToList();
                                                                            foreach (Daire item in SatiliklaraListe)
                                                                            {
                                                                                if (SatiliklaraListe.Count > 0)
                                                                                {
                                                                                    Console.WriteLine(item.DaireNo.ToString().PadRight(20, ' ') + item.DaireninNetOlcusu.ToString() + "m²".PadRight(20, ' ') + item.DaireninOdaSayisi.ToString().PadRight(20, ' ') + item.YapilisTarihi.ToString().PadRight(20, ' ') + item.DaireninBulunduguIl.PadRight(20, ' ') + item.DaireninBulunduguSemt.PadRight(20, ' ') + item.IstenenKmiSmi.ToString().PadRight(20, ' ') + item.Fiyat.ToString());
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Sectiginiz fiyat araliginda daire bulunmamaktadir.");
                                                                                }
                                                                            }
                                                                            Console.WriteLine("Yukarida bilgilerini gordugunuz dairelerden herhangi birini secip satin almak icin secim kisimina dairenin numarasini giriniz...");
                                                                            bool secimDondur = true;
                                                                            do
                                                                            {
                                                                                Console.Write("Secim: ");
                                                                                string secim = Console.ReadLine();
                                                                                int secimInt;
                                                                                if (int.TryParse(secim, out secimInt))
                                                                                {

                                                                                    foreach (Daire item in SatiliklaraListe)
                                                                                    {
                                                                                        if (item.DaireNo == secimInt.ToString())
                                                                                        {
                                                                                            secimDondur = false;
                                                                                            mus.YapilanIslem = IslemAdi.SatinAlindi;
                                                                                            item.KiradaMiSatildiMi = Durum.Satildi;
                                                                                            item.KiralandigiGun = DateTime.Now;

                                                                                            mus.MusteriNiyeti = DurumMusteri.Aramiyor;
                                                                                            KiralanmisVeyaSatilmisList.Add(item);


                                                                                            Console.WriteLine(item.DaireNo + " Numarali daire " + mus.Isim + " Adina " + item.Fiyat + "TL ye Satin alinmistir ");
                                                                                            Console.WriteLine("Sisteme basariyla kaydedildi");


                                                                                        }

                                                                                    }
                                                                                    foreach (Daire item in SatiliklaraListe)
                                                                                    {
                                                                                        if (item.DaireNo != secimInt.ToString())
                                                                                        {
                                                                                            Console.WriteLine("Cikarilan fiyat listesinde bu numarali bir daire yoktur lutfen dogru girdiginizden emin olun.");
                                                                                        }
                                                                                    }

                                                                                }
                                                                                else if (secim == null)
                                                                                {
                                                                                    Console.WriteLine("Lutfen alani bos birakmayiniz...");

                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Sadece rakamlarla giris yapabilirsiniz..");
                                                                                }
                                                                            } while (secimDondur);






                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Lutfen maksimum ve minimum degerlerine dikkat edip tekrar girmeyi deneyin.");
                                                                            goto don3;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("maksimum fiyat kisimini yalnizca rakamlarla giriniz. Veya alani bos birakmayiniz.");
                                                                    }
                                                                } while (maxFiyatSorgula);
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("minimum fiyat kisimina 1 den daha kucuk bir sayi giremezsiniz.");
                                                            }
                                                        }
                                                        else if (minFiyat == null)
                                                        {
                                                            Console.WriteLine("Minimum fiyat kisimini bos birakamazsiniz");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Yanlis bir deger girdiniz lutfen tekrar deneyin");
                                                        }
                                                    } while (minFiyatSorgula);

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Minimum fiyati yalnizca rakamlari kullanarak giriniz veya alani bos birakmayiniz");
                                                }

                                            }
                                            else if (sayacSemtsiz2 > 0)
                                            {
                                                List<Daire> da = SatilikDaireList.Where(x => x.DaireninBulunduguIl == sonSehir && x.IstenenKmiSmi == SmiKmi.Satilik && x.KiradaMiSatildiMi == Durum.Bosta).ToList();

                                                if (da.Count > 0)
                                                {
                                                    bool MinFiyatSorgula = true;
                                                    do
                                                    {
                                                        Console.Write("Minimum fiyat: ");
                                                        string minFiyat = Console.ReadLine();
                                                        double minFiyatDouble;
                                                        if (double.TryParse(minFiyat, out minFiyatDouble))
                                                        {
                                                            if (minFiyatDouble > 0)
                                                            {
                                                                MinFiyatSorgula = false;
                                                                bool MaxFiyatSorgula = true;
                                                                do
                                                                {
                                                                    MaxFiyatSorgula = false;
                                                                    Console.Write("Maksimum fiyat: ");
                                                                    string maxFiyat = Console.ReadLine();
                                                                    double maxFiyatDouble;
                                                                    if (double.TryParse(maxFiyat, out maxFiyatDouble))
                                                                    {
                                                                        if (minFiyatDouble < maxFiyatDouble)//fiyat kisimi icin en captulation da 0 dan buyuk olmasi kontrolu yapilacak
                                                                        {

                                                                            Console.WriteLine("Daire No".PadRight(20, ' ') + "Olcusu".PadRight(20, ' ') + "Oda Sayisi".PadRight(20, ' ') + "Yapilis Tarihi".PadRight(20, ' ') + "Sehir".PadRight(20, ' ') + "Semt".PadRight(20, ' ') + "S / K".PadRight(20, ' ') + "Fiyat".PadRight(20, ' '));
                                                                            List<Daire> cekCikar = da.Where(x => x.Fiyat >= minFiyatDouble && x.Fiyat <= maxFiyatDouble).ToList();
                                                                            foreach (Daire item in cekCikar)
                                                                            {
                                                                                if (cekCikar.Count > 0)
                                                                                {
                                                                                    Console.WriteLine(item.DaireNo.ToString().PadRight(20, ' ') + item.DaireninNetOlcusu.ToString() + "m²".PadRight(20, ' ') + item.DaireninOdaSayisi.ToString().PadRight(20, ' ') + item.YapilisTarihi.ToString().PadRight(20, ' ') + item.DaireninBulunduguIl.PadRight(20, ' ') + item.DaireninBulunduguSemt.PadRight(20, ' ') + item.IstenenKmiSmi.ToString().PadRight(20, ' ') + item.Fiyat.ToString());
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Sectiginiz fiyat araliginda daire bulunmamaktadir.");
                                                                                }

                                                                            }

                                                                            Console.WriteLine("Yukarida bilgilerini gordugunuz dairelerden herhangi birini secip satin almak icin secim kisimina dairenin numarasini giriniz...");
                                                                            bool secimDondur = true;
                                                                            do
                                                                            {
                                                                                Console.Write("Secim: ");
                                                                                string secim = Console.ReadLine();
                                                                                int secimInt;
                                                                                if (int.TryParse(secim, out secimInt))
                                                                                {


                                                                                    foreach (Daire item in cekCikar)
                                                                                    {
                                                                                        if (item.DaireNo == secimInt.ToString())
                                                                                        {

                                                                                            secimDondur = false;
                                                                                            item.KiralandigiGun = DateTime.Now;
                                                                                            item.KiradaMiSatildiMi = Durum.Satildi;
                                                                                            mus.YapilanIslem = IslemAdi.SatinAlindi;
                                                                                            mus.MusteriNiyeti = DurumMusteri.Aramiyor;
                                                                                            KiralanmisVeyaSatilmisList.Add(item);

                                                                                            Console.WriteLine(item.DaireNo + " Numarali daire " + mus.Isim + " Adina satin alinmistir");
                                                                                            Console.WriteLine("Sisteme basariyla kaydedildi.");


                                                                                        }


                                                                                    }

                                                                                }
                                                                                else if (secim == null)
                                                                                {
                                                                                    Console.WriteLine("Lutfen alani bos birakmayiniz...");

                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Sadece rakamlarla giris yapabilirsiniz..");
                                                                                }
                                                                            } while (secimDondur);
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Minimum girdiginiz fiyat maksimum girilen giyattan yuksek olamaz");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Maksimum fiyat kisimini yalnizca rakamlarla giriniz. Veya alani bos birakmayiniz.");
                                                                    }
                                                                } while (MaxFiyatSorgula);

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Minimum fiyata 1 den daha kucuk bir rakam giremezsin");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Minimum fiyati yalnizca rakamlari kullanarak giriniz veya alani bos birakmayiniz");
                                                        }
                                                    } while (MinFiyatSorgula);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Bu sehirde kiralik daire bulunmamaktadir");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Su anda hic kiralik daire kalmamistir.");
                                            }
                                        } while (sehirDondur2);

                                    }
                                    else
                                    {
                                        Console.WriteLine("Sistemde kiralik daire bulunmamaktadir.");
                                    }

                                    break;
                                case null:
                                    Console.WriteLine("Bulmak istedigin daireyi kiralik veya satilik belirtmelisin");
                                    break;
                                default:
                                    Console.WriteLine("Yanlis bir deger girdin lutfen tekrar dene");
                                    break;
                            }
                        } while (DaireTuru);
                    }
                    else
                    {
                        Console.WriteLine("Bu numarada musteri sistemde kayitli degildir.");
                    }
                }
                else if (no == null)
                {
                    Console.WriteLine("Lutfen musteri numara kisimini bos birakmayiniz...");
                }
                else
                {
                    Console.WriteLine("Sadece rakamlarla giris yapabilirsiniz. Lutfen tekrar deneyiniz");
                }
            } while (MusteriNoDondur);
        }

        public void ButunMusterileriListele()
        {
            Console.WriteLine("Butun Musterileri Listele ".PadRight(50, '-'));

            if (musteri.Musteriler.Count > 0)
            {
                Console.WriteLine(" No ".PadRight(20, ' ') + "   Adi Soyadi".PadRight(30, ' ') + "   Musteri Butcesi".PadRight(30, ' ') + " Aranan Sehir".PadRight(25, ' ') + " Durum");
                Console.WriteLine("----".PadRight(20, ' ') + "----------------".PadRight(33, ' ') + "----------------".PadRight(26, ' ') + "----------------".PadRight(25, ' ') + "---------");
                foreach (Musteri item in musteri.Musteriler)
                {
                    Console.WriteLine(item.MusteriNo.PadRight(20, ' ') + item.Isim + " " + item.Soyisim.PadRight(33, ' ') + item.MusteriButcesi.ToString().PadRight(26, ' ') + item.MusterininDaireAradigiSehir.PadRight(20, ' ') + item.MusteriNiyeti.ToString().PadRight(30, ' '));
                }
            }
            else
            {
                Console.WriteLine("Su an icin sistemde hicbir musteri bulunmamaktadir");
            }
        }

        public void ButunDaireleriListele()
        {
            Console.WriteLine("Butun Daireleri Listele ".PadRight(50, '-'));

            if (daire.Daireler.Count > 0)
            {

                Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
                Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
                foreach (Daire item in daire.Daireler)
                {
                    if (item.IstenenKmiSmi != SmiKmi.Kiralik)
                    {
                        Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString().PadRight(21, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                    }
                    else
                    {
                        Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                    }

                }
            }
            else
            {
                Console.WriteLine("Su an icin sistemde hicbir daire bulunmamaktadir");
            }
        }

        public void KiralikDaireleriListele()
        {
            Console.WriteLine("Kiralik Daireleri Listele ".PadRight(50, '-'));

            List<Daire> Kiraliklar = daire.Daireler.Where(x => x.IstenenKmiSmi == SmiKmi.Kiralik).ToList();

            if (Kiraliklar.Count > 0)
            {

                Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
                Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
                foreach (Daire item in Kiraliklar)
                {
                    Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                }
            }
            else
            {
                Console.WriteLine("Su an icin sistemde kiralik hicbir daire bulunmamaktadir");
            }




        }

        public void SatilikDaireleriListele()
        {
            Console.WriteLine("Satilik Daireler ".PadRight(50, '-'));

            List<Daire> Satiliklar = daire.Daireler.Where(x => x.IstenenKmiSmi == SmiKmi.Satilik).ToList();

            if (Satiliklar.Count > 0)
            {

                Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
                Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
                foreach (Daire item in Satiliklar)
                {

                    Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString().PadRight(21, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);

                }
            }
            else
            {
                Console.WriteLine("Su an icin sistemde satilik hicbir daire bulunmamaktadir");
            }
        }

        public void DaireninBilgileriniGoruntule()
        {


            Console.WriteLine("Dairenin Bilgilerini Goruntule ".PadRight(50, '-'));
            bool NoSorgula = true;
            do
            {
                Console.Write("Lutfen bilgierini goruntulemek istediginiz dairenin numarasini giriniz: ");
                string daireNo = Console.ReadLine();
                int daireNoInt;
                if (int.TryParse(daireNo, out daireNoInt))
                {
                    Daire bul = daire.Daireler.Where(x => x.DaireNo == daireNo).FirstOrDefault();

                    if (bul != null)
                    {
                        NoSorgula = false;
                        Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
                        Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");

                        if (bul.IstenenKmiSmi != SmiKmi.Kiralik)
                        {
                            Console.WriteLine(bul.DaireNo.PadRight(17, ' ') + bul.DaireninNetOlcusu.ToString().PadRight(23, ' ') + bul.DaireninOdaSayisi.ToString() + "+" + bul.DaireninSalonSayisi.ToString().PadRight(17, ' ') + bul.Fiyat.ToString().PadRight(21, ' ') + bul.IstenenKmiSmi.ToString().PadRight(25, ' ') + bul.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + bul.DaireninBulunduguIl + " / " + bul.DaireninBulunduguSemt);
                        }
                        else
                        {
                            Console.WriteLine(bul.DaireNo.PadRight(17, ' ') + bul.DaireninNetOlcusu.ToString().PadRight(23, ' ') + bul.DaireninOdaSayisi.ToString() + "+" + bul.DaireninSalonSayisi.ToString().PadRight(17, ' ') + bul.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + bul.IstenenKmiSmi.ToString().PadRight(25, ' ') + bul.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + bul.DaireninBulunduguIl + " / " + bul.DaireninBulunduguSemt);
                        }

                    }

                }
                else if (daireNo == null)
                {
                    Console.WriteLine("Lutfen alani bos birakmayiniz");
                }
                else
                {
                    Console.WriteLine("Lutfen sadece rakamlaarla giris yapiniz");
                }

            } while (NoSorgula);



        }

        public void FiyatAraliginaGoreDaireleriListele()
        {
            Console.WriteLine("9-Fiyat Aralığına Göre Daireleri Listele ".PadRight(50, '-'));

            bool KiralikSatilikSorgula = true;
            do
            {
                Console.Write("Daire turu(K/S)");
                string tur = Console.ReadLine();
                string sonTur = yrdm.IlkHarfBuyuk(tur);
                switch (sonTur)
                {
                    case "S":

                        bool maxSorgula = true;
                        do
                        {
                            Console.WriteLine("Maksimum fiyat: ");
                            string max = Console.ReadLine();
                            double maxDouble;
                            if (double.TryParse(max, out maxDouble))
                            {
                                maxSorgula = false;
                                bool minSorgula = true;
                                do
                                {
                                    Console.WriteLine("Minimum fiyat: ");
                                    string min = Console.ReadLine();
                                    double minDouble;
                                    if (double.TryParse(min, out minDouble))
                                    {
                                        minSorgula = false;

                                        List<Daire> FiyatList = daire.Daireler.Where(x => x.Fiyat >= minDouble && x.Fiyat <= maxDouble && x.IstenenKmiSmi == SmiKmi.Satilik).ToList();

                                        if (FiyatList.Count > 0)
                                        {
                                            KiralikSatilikSorgula = false;
                                            Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
                                            Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
                                            foreach (Daire item in FiyatList)
                                            {
                                                if (item.IstenenKmiSmi != SmiKmi.Kiralik)
                                                {
                                                    Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString().PadRight(21, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                                                }
                                                else
                                                {
                                                    Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Sectiginiz fiyat araliginda satilik daire bulunmamaktadir.");
                                            KiralikSatilikSorgula = false;
                                        }


                                    }
                                    else if (min == null)
                                    {
                                        Console.WriteLine("Minimum fiyat alanini bos birakmayiniz");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sadece rakamlarla giris yapabilirsiniz");
                                    }
                                } while (minSorgula);
                            }
                            else if (max == null)
                            {
                                Console.WriteLine("Lutfen max fiyat alanini bos birakmayiniz");
                            }
                            else
                            {
                                Console.WriteLine("Sadece rakamlari kullanarak giris yapabilirsiniz.");
                            }
                        } while (maxSorgula);


                        break;
                    case "K":

                        bool maxSorgula2 = true;
                        do
                        {
                            Console.WriteLine("Maksimum fiyat: ");
                            string max = Console.ReadLine();
                            double maxDouble;
                            if (double.TryParse(max, out maxDouble))
                            {
                                maxSorgula2 = false;
                                bool minSorgula = true;
                                do
                                {
                                    Console.WriteLine("Minimum fiyat: ");
                                    string min = Console.ReadLine();
                                    double minDouble;
                                    if (double.TryParse(min, out minDouble))
                                    {
                                        minSorgula = false;

                                        List<Daire> FiyatList = daire.Daireler.Where(x => x.Fiyat >= minDouble && x.Fiyat <= maxDouble && x.IstenenKmiSmi == SmiKmi.Kiralik).ToList();

                                        if (FiyatList.Count > 0)
                                        {
                                            KiralikSatilikSorgula = false;
                                            Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
                                            Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
                                            foreach (Daire item in FiyatList)
                                            {
                                                if (item.IstenenKmiSmi != SmiKmi.Kiralik)
                                                {
                                                    Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString().PadRight(21, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                                                }
                                                else
                                                {
                                                    Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            KiralikSatilikSorgula = false;
                                            Console.WriteLine("Sectiginiz fiyat araliginda kiralik daire bulunmamaktadir.");
                                        }


                                    }
                                    else if (min == null)
                                    {
                                        Console.WriteLine("Minimum fiyat alanini bos birakmayiniz");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sadece rakamlarla giris yapabilirsiniz");
                                    }
                                } while (minSorgula);
                            }
                            else if (max == null)
                            {
                                Console.WriteLine("Lutfen max fiyat alanini bos birakmayiniz");
                            }
                            else
                            {
                                Console.WriteLine("Sadece rakamlari kullanarak giris yapabilirsiniz.");
                            }
                        } while (maxSorgula2);

                        break;

                    case null:
                        Console.WriteLine("Lutfen daire turu yerini bos birakmayiniz.");
                        break;

                    default:

                        Console.WriteLine("Yanlis bir deger girdiniz lutfen tekrar deneyin");

                        break;
                }
            } while (KiralikSatilikSorgula);

        }

        public void SuTarihtenSonraYapilanDaireleriListele()
        {
            bool TarihSorgula = true;
            do
            {
                Console.WriteLine("10-Hangi tarihten sonra yapilan evleri listelemek icin tarih giriniz.");
                string tarih = Console.ReadLine();
                DateTime dt;
                if (DateTime.TryParse(tarih, out dt))
                {
                    TarihSorgula = false;
                    dt.ToString("d, yyy");

                    List<Daire> dtr = daire.Daireler.Where(x => x.YapilisTarihi >= dt).ToList();

                    if (dtr.Count > 0)
                    {
                        Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
                        Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
                        foreach (Daire item in dtr)
                        {
                            if (item.IstenenKmiSmi != SmiKmi.Kiralik)
                            {
                                Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString().PadRight(21, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                            }
                            else
                            {
                                Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sistemde girdiginiz tarihten sonra yapilan herhangi bir daire bulunmamaktadir.");
                    }


                }
                else if (tarih == null)
                {
                    Console.WriteLine("Lutfen tarih girilen kisimi bos birakmayiniz.");
                }
                else
                {
                    Console.WriteLine("Yanlis bir parametre girdiniz.");
                }
            } while (TarihSorgula);
        }

        public void AdreseGoreDaireListele()
        {
            Console.WriteLine("11 - Adrese Göre Daireleri Listele".PadRight(50, '-'));
            bool IlDondur = true;
            do
            {
                Console.Write("Il: ");
                Console.WriteLine();
                string il = Console.ReadLine();
                string SonIl = yrdm.IlkHarfBuyuk(il);
                if (il != null)
                {
                    List<Daire> ilDaire = daire.Daireler.Where(x => x.DaireninBulunduguIl == SonIl).ToList();

                    if (ilDaire.Count > 0)
                    {
                        Console.Write("Ilce: ");
                        string ilce = Console.ReadLine();
                        string SonIlce = yrdm.IlkHarfBuyuk(ilce);
                        if (ilce != null)
                        {
                            List<Daire> ilceDaire = ilDaire.Where(x => x.DaireninBulunduguSemt == SonIlce).ToList();
                            if (ilceDaire.Count > 0)
                            {
                                IlDondur = false;
                                Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
                                Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
                                foreach (Daire item in ilceDaire)
                                {
                                    if (item.IstenenKmiSmi != SmiKmi.Kiralik)
                                    {
                                        Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString().PadRight(21, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                                    }
                                    else
                                    {
                                        Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bu ilceye kayitli herhangi bir daire yoktur");
                            }
                        }
                        else
                        {
                            IlDondur = false;
                            Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
                            Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
                            foreach (Daire item in ilDaire)
                            {
                                if (item.IstenenKmiSmi != SmiKmi.Kiralik)
                                {
                                    Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString().PadRight(21, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                                }
                                else
                                {
                                    Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sistemde bu isimde bir il bulunamadi");
                    }

                }
                else
                {
                    Console.WriteLine("Lutfen alani bos birakmayiniz");
                }
            } while (IlDondur);

        }

        public void EnPahaliVeSatilik5Daire()
        {
            Console.WriteLine("12-En Pahalı ve Satılık 5 Daireyi Listele".PadRight(50, '-'));

            List<Daire> fiyat = daire.Daireler.Where(a => a.IstenenKmiSmi == SmiKmi.Satilik).OrderByDescending(x => x.Fiyat).Take(5).ToList();

            Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
            Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
            foreach (Daire item in fiyat)
            {

                Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString().PadRight(21, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);

            }


        }

        public void EnPahaliVeKiralik5Daire()
        {

            Console.WriteLine("12-En Pahalı Ve Kiralik 5 Daireyi Listele".PadRight(50, '-'));

            List<Daire> fiyat = daire.Daireler.Where(a => a.IstenenKmiSmi == SmiKmi.Kiralik).OrderByDescending(x => x.Fiyat).Take(5).ToList();

            Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
            Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
            foreach (Daire item in fiyat)
            {
                Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);

            }
        }

        public void EnUcuzveSatılık3DaireyiListele()
        {
            Console.WriteLine("En Ucuz Ve Satilik 3 Daireyi Listele".PadRight(50, '-'));

            List<Daire> fiyat = daire.Daireler.Where(a => a.IstenenKmiSmi == SmiKmi.Satilik).OrderBy(x => x.Fiyat).Take(3).ToList();

            Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
            Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
            foreach (Daire item in fiyat)
            {

                Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString().PadRight(21, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);

            }
        }

        public void EnUcuzVeKiralik3DaireyiListele()
        {
            Console.WriteLine("15-En Ucuz Ve Kiralik 3 Daireyi Listele".PadRight(50, '-'));

            List<Daire> fiyat = daire.Daireler.Where(a => a.IstenenKmiSmi == SmiKmi.Kiralik).OrderBy(x => x.Fiyat).Take(5).ToList();

            Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
            Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");
            foreach (Daire item in fiyat)
            {
                Console.WriteLine(item.DaireNo.PadRight(17, ' ') + item.DaireninNetOlcusu.ToString().PadRight(23, ' ') + item.DaireninOdaSayisi.ToString() + "+" + item.DaireninSalonSayisi.ToString().PadRight(17, ' ') + item.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + item.IstenenKmiSmi.ToString().PadRight(25, ' ') + item.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + item.DaireninBulunduguIl + " / " + item.DaireninBulunduguSemt);

            }
        }

        public void KiralananSonDaireyiGor()
        {
            Console.WriteLine("16-Kiralanan Son Daireyi Gor ".PadRight(50, '-'));
            Console.WriteLine();
            Daire sonVeriKiralik = daire.Daireler.Where(x => x.KiradaMiSatildiMi == Durum.Kiralandi).FirstOrDefault();
            Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
            Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");


            Console.WriteLine(sonVeriKiralik.DaireNo.PadRight(17, ' ') + sonVeriKiralik.DaireninNetOlcusu.ToString().PadRight(23, ' ') + sonVeriKiralik.DaireninOdaSayisi.ToString() + "+" + sonVeriKiralik.DaireninSalonSayisi.ToString().PadRight(17, ' ') + sonVeriKiralik.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + sonVeriKiralik.IstenenKmiSmi.ToString().PadRight(25, ' ') + sonVeriKiralik.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + sonVeriKiralik.DaireninBulunduguIl + " / " + sonVeriKiralik.DaireninBulunduguSemt);





        }

        public void SatilanSonDaireyiGor()
        {
            Console.WriteLine("17-Satılan Son Daireyi Gör ".PadRight(50, '-'));
            Console.WriteLine();
            Daire sonVeriKiralik = daire.Daireler.Where(x => x.KiradaMiSatildiMi == Durum.Kiralandi).FirstOrDefault();
            Console.WriteLine(" No ".PadRight(10, ' ') + "   Net Olcu(m²)".PadRight(23, ' ') + "   Oda Sayisi".PadRight(23, ' ') + " Fiyati".PadRight(24, ' ') + " Turu".PadRight(24, ' ') + "Durum".PadRight(24, ' ') + " Adresi");
            Console.WriteLine("----".PadRight(12, ' ') + "----------------".PadRight(21, ' ') + "----------------".PadRight(21, ' ') + "------------".PadRight(25, ' ') + "---------".PadRight(25, ' ') + "---------".PadRight(24, ' ') + "-------------");


            Console.WriteLine(sonVeriKiralik.DaireNo.PadRight(17, ' ') + sonVeriKiralik.DaireninNetOlcusu.ToString().PadRight(23, ' ') + sonVeriKiralik.DaireninOdaSayisi.ToString() + "+" + sonVeriKiralik.DaireninSalonSayisi.ToString().PadRight(17, ' ') + sonVeriKiralik.Fiyat.ToString() + "(Gunluk)".PadRight(18, ' ') + sonVeriKiralik.IstenenKmiSmi.ToString().PadRight(25, ' ') + sonVeriKiralik.KiradaMiSatildiMi.ToString().PadRight(24, ' ') + sonVeriKiralik.DaireninBulunduguIl + " / " + sonVeriKiralik.DaireninBulunduguSemt);


        }

        public void DaireGuncelle()
        {
            Console.WriteLine("18-Daire Guncelle ".PadRight(50, '-'));
            Console.WriteLine();
            bool noDondur = true;
            do
            {
                Console.Write("Guncellemek istediginiz dairenin numarasini giriniz: ");
                string no = Console.ReadLine();
                int noInt;
                if (int.TryParse(no, out noInt))
                {
                    Daire daireGetir = daire.Daireler.Where(x => x.DaireNo == noInt.ToString()).FirstOrDefault();

                    if (daireGetir.DaireNo != null)
                    {
                        noDondur = false;
                        bool yapilisTarihiSorgula = true;
                        do
                        {
                            Console.Write("Dairenin yapilis tarihi: ");
                            string yT = Console.ReadLine();
                            DateTime yTdate;
                            int sayac = 0;
                            if (DateTime.TryParse(yT, out yTdate))
                            {
                                daireGetir.YapilisTarihi = yTdate;
                                sayac++;
                            }
                            else if (yT == "")
                            {
                                sayac++;

                            }
                            else
                            {
                                Console.WriteLine("Lutfen tarih bazinda giris yapiniz.");

                            }

                            if (sayac > 0)
                            {
                                yapilisTarihiSorgula = false;
                                int sayac2 = 0;
                                bool turSorgula = true;
                                do
                                {
                                    Console.Write("Daire türü(Satılık(S)/Kiralık(K)): ");
                                    string tur = Console.ReadLine();
                                    string sonTur = yrdm.IlkHarfBuyuk(tur);
                                    if (sonTur == "K")
                                    {
                                        daireGetir.IstenenKmiSmi = SmiKmi.Kiralik;
                                        sayac2++;
                                    }
                                    else if (sonTur == "S")
                                    {
                                        daireGetir.IstenenKmiSmi = SmiKmi.Satilik;
                                        sayac2++;
                                    }
                                    else if (sonTur == "Null")
                                    {
                                        sayac2++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlis bir deger girdiniz lutfen tekrar deneyin");
                                    }

                                    if (sayac2 > 0)
                                    {
                                        turSorgula = false;
                                        bool fiyatSorgula = true;
                                        int sayac3 = 0;
                                        do
                                        {
                                            Console.Write("Dairenin fiyati: ");
                                            string fiyat = Console.ReadLine();
                                            double fiyatDouble;
                                            if (double.TryParse(fiyat, out fiyatDouble))
                                            {
                                                sayac3++;
                                                daireGetir.Fiyat = fiyatDouble;
                                            }
                                            else if (fiyat == "")
                                            {
                                                sayac3++;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Sadece rakamlarla fiyat girebilirsiniz.");
                                            }

                                            if (sayac3 > 0)
                                            {
                                                fiyatSorgula = false;
                                                bool olcuSorgula = true;
                                                int sayac4 = 0;
                                                do
                                                {
                                                    Console.Write("Dairenin net olcusu(m²): ");
                                                    string olcu = Console.ReadLine();
                                                    double olcuDouble;
                                                    if (double.TryParse(olcu, out olcuDouble))
                                                    {
                                                        daireGetir.DaireninNetOlcusu = olcuDouble;
                                                        sayac4++;
                                                    }
                                                    else if (olcu == "")
                                                    {
                                                        sayac4++;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Sadece rakamlarla m² girebilirsiniz.");
                                                    }

                                                    if (sayac4 > 0)
                                                    {
                                                        olcuSorgula = false;
                                                        int sayac5 = 0;
                                                        bool odaAdediSorgula = true; ;
                                                        do
                                                        {
                                                            Console.Write("Dairenin oda sayisi: ");
                                                            string oda = Console.ReadLine();
                                                            int odaInt;
                                                            if (int.TryParse(oda, out odaInt))
                                                            {
                                                                if (odaInt > 0)
                                                                {
                                                                    sayac5++;
                                                                    daireGetir.DaireninOdaSayisi = odaInt;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("yanlis oda adedi girdin lutfen kontrol edin");
                                                                }
                                                            }
                                                            else if (oda == "")
                                                            {
                                                                sayac5++;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Lutfen oda sayisini sadece rakamlari kullanarak giriniz.");
                                                            }

                                                            if (sayac5 > 0)
                                                            {
                                                                odaAdediSorgula = false;
                                                                int sayac6 = 0;
                                                                bool salonSorgula = true;
                                                                do
                                                                {
                                                                    Console.Write("Dairenin salon sayisi: ");
                                                                    string salon = Console.ReadLine();
                                                                    int salonInt;
                                                                    if (int.TryParse(salon, out salonInt))
                                                                    {
                                                                        if (salonInt > 0)
                                                                        {
                                                                            sayac6++;
                                                                            daireGetir.DaireninSalonSayisi = salonInt;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Salon sayisina 0 yada eksili bir karekter giremezsin");
                                                                        }
                                                                    }
                                                                    else if (salon == "")
                                                                    {
                                                                        sayac6++;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Lutfen sadece rakamlari kullanarak salon sayisini giriniz.");
                                                                    }

                                                                    if (sayac6 > 0)
                                                                    {
                                                                        salonSorgula = false;

                                                                        bool ilSorgula = true;
                                                                        do
                                                                        {
                                                                            Console.Write("Dairenin bulundugu il: ");
                                                                            string il = Console.ReadLine();
                                                                            string sonIl = yrdm.IlkHarfBuyuk(il);
                                                                            int sonIlInt;
                                                                            int stringMi = 0;
                                                                            int sayacc = 0;
                                                                            for (int i = 0; i < sonIl.Length; i++)
                                                                            {
                                                                                sonIl.ToArray();
                                                                                if (int.TryParse(sonIl[i].ToString(), out sonIlInt))
                                                                                {
                                                                                    Console.WriteLine("Il bolumune herhangi bir rakam giremezsin");
                                                                                    break;
                                                                                }
                                                                                else
                                                                                {
                                                                                    stringMi++;
                                                                                }

                                                                            }
                                                                            if (sonIl == "Null")
                                                                            {
                                                                                sayacc++;
                                                                            }
                                                                            else if (sonIl.Length == stringMi && sonIl != "Null")
                                                                            {

                                                                                daireGetir.DaireninBulunduguIl = sonIl;
                                                                                sayacc++;

                                                                            }

                                                                            if (sayacc > 0)
                                                                            {
                                                                                bool ilceSorgula = true;
                                                                                do
                                                                                {
                                                                                    ilSorgula = false;
                                                                                    Console.Write("Dairenin bulundugu ilce: ");
                                                                                    string ilce = Console.ReadLine();
                                                                                    string sonIlcce = yrdm.IlkHarfBuyuk(ilce);
                                                                                    int sonIlceInt;
                                                                                    int stringMiKi = 0;
                                                                                    int ilceSayac = 0;
                                                                                    for (int i = 0; i < sonIlcce.Length; i++)
                                                                                    {
                                                                                        sonIlcce.ToCharArray();
                                                                                        if (int.TryParse(sonIlcce[i].ToString(), out sonIlceInt))
                                                                                        {
                                                                                            Console.WriteLine("Ilce bolumune herhangi bir rakam giremezsin");
                                                                                            break;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            stringMiKi++;
                                                                                        }
                                                                                    }
                                                                                    if (sonIlcce == "Null")
                                                                                    {
                                                                                        ilceSayac++;
                                                                                    }
                                                                                    else if (sonIlcce.Length == stringMiKi && sonIlcce != "Null")
                                                                                    {

                                                                                        daireGetir.DaireninBulunduguSemt = sonIlcce;
                                                                                        ilceSayac++;
                                                                                    }

                                                                                    int sayac7 = 0;
                                                                                    bool durumSorgula = true;
                                                                                    do
                                                                                    {
                                                                                        ilceSorgula = false;
                                                                                        Console.Write("Dairenin durumunu giriniz(Kiralandiysa(K)/Satildiysa(S)/Bostaysa(B)): ");
                                                                                        string yanit = Console.ReadLine();
                                                                                        string sonYanit = yrdm.IlkHarfBuyuk(yanit);

                                                                                        if (sonYanit == "K")
                                                                                        {
                                                                                            daireGetir.KiradaMiSatildiMi = Durum.Kiralandi;
                                                                                            sayac7++;
                                                                                        }
                                                                                        else if (sonYanit == "S")
                                                                                        {
                                                                                            daireGetir.KiradaMiSatildiMi = Durum.Satildi;
                                                                                            sayac7++;

                                                                                        }
                                                                                        else if (sonYanit == "B")
                                                                                        {
                                                                                            daireGetir.KiradaMiSatildiMi = Durum.Bosta;
                                                                                            sayac7++;
                                                                                        }
                                                                                        else if (sonYanit == "Null")
                                                                                        {
                                                                                            sayac7++;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Console.WriteLine("Yanlis bir deger girdiniz lutfen tekrar deneyin");
                                                                                        }

                                                                                        if (sayac7 > 0)
                                                                                        {
                                                                                            durumSorgula = false;
                                                                                            Console.WriteLine();

                                                                                            Console.WriteLine("Daire Guncellendi.....");
                                                                                        }
                                                                                    } while (durumSorgula);




                                                                                } while (ilceSorgula);
                                                                            }



                                                                        } while (ilSorgula);

                                                                    }
                                                                } while (salonSorgula);
                                                            }
                                                        } while (odaAdediSorgula);
                                                    }

                                                } while (olcuSorgula);
                                            }
                                        } while (fiyatSorgula);

                                    }
                                } while (turSorgula);
                            }
                        } while (yapilisTarihiSorgula);
                    }
                    else
                    {
                        Console.WriteLine("Bu numarada bir daire bulunmamaktadir");
                    }


                }
                else if (no == null)
                {
                    Console.WriteLine("Ogrenci numarasi kismini bos birakamazsiniz");
                }
                else
                {
                    Console.WriteLine("Lutfen sadece rakamlarla giris yaptiginizdan emin olun veya alani bos birakmayin");
                }
            } while (noDondur);

        }

        public void MusteriGuncelle()
        {
            Console.WriteLine("19 - Müşteri Güncelle ".PadRight(50, '-'));
            bool musteriNoSorgula = true;
            do
            {
                Console.Write("Musteri numarasi: ");
                string no = Console.ReadLine();
                int noInt;

                if (int.TryParse(no, out noInt))
                {
                    Musteri mstr = musteri.Musteriler.Where(x => x.MusteriNo == noInt.ToString()).FirstOrDefault();

                    if (mstr != null)
                    {
                        musteriNoSorgula = false;
                        bool isimSorgula = true;
                        do
                        {
                            Console.Write("Musteri adi: ");
                            string ad = Console.ReadLine();
                            string sonAd = yrdm.IlkHarfBuyuk(ad);
                            int sayac = 0;
                            int sonAdInt;
                            for (int i = 0; i < sonAd.ToCharArray()[i].ToString().Length; i++)
                            {
                                if (int.TryParse(sonAd, out sonAdInt))
                                {
                                    Console.WriteLine("Musteri adi kisimina rakamlarla giris yapamazsin.");
                                    break;
                                }
                                else if (sonAd == "Null")
                                {
                                    sayac++;

                                }
                                else
                                {
                                    musteri.Isim = sonAd;
                                    sayac++;

                                }
                            }
                            if (sonAd.Length == sayac)
                            {
                                isimSorgula = false;
                                bool SoyadSorgula = true;
                                do
                                {
                                    Console.WriteLine("Musteri soyadi: ");
                                    string soyad = Console.ReadLine();
                                    string sonSoyad = yrdm.IlkHarfBuyuk(soyad);
                                    int sayac2 = 0;
                                    int sonSoyadInt;
                                    for (int i = 0; i < sonAd.Length; i++)
                                    {
                                        if (int.TryParse(sonSoyad.ToCharArray()[i].ToString(), out sonSoyadInt))
                                        {
                                            Console.WriteLine("Musteri soyadi kisimina rakamla giris yapamazsin.");
                                            break;
                                        }
                                        else if (sonSoyad == "Null")
                                        {
                                            sayac2++;

                                        }
                                        else
                                        {
                                            musteri.Soyisim = sonSoyad;
                                            sayac2++;

                                        }
                                    }
                                    if (sonAd.Length == sayac2)
                                    {
                                        SoyadSorgula = false;
                                        bool cinsiyetSorgula = true;
                                        do
                                        {
                                            Console.WriteLine("Musteri cinsiyeti(K/E): ");
                                            string cinsiyet = Console.ReadLine();
                                            string sonCins = yrdm.IlkHarfBuyuk(cinsiyet);
                                            int sayac3 = 0;
                                            switch (sonCins)
                                            {
                                                case "K":
                                                    musteri.Cns = Cinsiyet.Kadin;
                                                    sayac3++;
                                                    cinsiyetSorgula = false;
                                                    break;
                                                case "E":
                                                    musteri.Cns = Cinsiyet.Erkek;
                                                    sayac3++;
                                                    cinsiyetSorgula = false;
                                                    break;
                                                case "Null":
                                                    sayac3++;
                                                    cinsiyetSorgula = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Yanlis bir deger girdiniz lutfen tekrar deneyin.");
                                                    break;
                                            }
                                            if (sayac3 < 0)
                                            {
                                                bool musteriButSorgula = true;
                                                do
                                                {
                                                    Console.WriteLine("Musteri butcesi: ");
                                                    cinsiyetSorgula = false;
                                                    string musteriButce = Console.ReadLine();
                                                    double musteriButDouble;
                                                    int sayac4 = 0;
                                                    if (double.TryParse(musteriButce, out musteriButDouble))
                                                    {
                                                        musteri.MusteriButcesi = musteriButDouble;
                                                        sayac4++;

                                                    }
                                                    else if (musteriButce == "")
                                                    {
                                                        sayac4++;


                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Lutfen sadece rakamlari kullanarak musteri butcesi giriniz.");
                                                    }
                                                    if (sayac4 > 0)
                                                    {
                                                        musteriButSorgula = false;
                                                        bool arananSehirSorgula = true;
                                                        do
                                                        {
                                                            Console.Write("Daire aranan sehir: ");
                                                            string arananSehir = Console.ReadLine();
                                                            string sonArananSehir = yrdm.IlkHarfBuyuk(arananSehir);
                                                            int sayac5 = 0;
                                                            int sonArananSehirInt;

                                                            for (int i = 0; i < sonArananSehir.Length; i++)
                                                            {
                                                                if (int.TryParse(sonArananSehir.ToCharArray()[i].ToString(), out sonArananSehirInt))
                                                                {
                                                                    Console.WriteLine("Musterinin daire aradigi sehir alanina herhangi bir rakam giremezsiniz.");
                                                                    break;
                                                                }
                                                                else if (sonArananSehir == "Null")
                                                                {
                                                                    sayac5++;
                                                                }
                                                                else
                                                                {
                                                                    musteri.MusterininDaireAradigiSehir = sonArananSehir;
                                                                    sayac5++;
                                                                }
                                                            }
                                                            if (sayac5 == sonArananSehir.Length)
                                                            {
                                                                arananSehirSorgula = false;
                                                                bool kayitlisSehirSorgula = true;
                                                                do
                                                                {
                                                                    Console.Write("Musterinin kayitli oldugu il: ");
                                                                    string kayitliSehir = yrdm.IlkHarfBuyuk(Console.ReadLine());
                                                                    int sayac6 = 0;
                                                                    int kayitliSehirInt;
                                                                    for (int i = 0; i < kayitliSehir.Length; i++)
                                                                    {
                                                                        if (int.TryParse(kayitliSehir.ToCharArray()[i].ToString(), out kayitliSehirInt))
                                                                        {
                                                                            Console.WriteLine("Musterinin kayitli oldugu sehri rakamla giremezsiniz lutfen tekrar deneyin.");
                                                                            break;
                                                                        }
                                                                        else if (kayitliSehir == "Null")
                                                                        {
                                                                            sayac6++;
                                                                        }
                                                                        else
                                                                        {
                                                                            musteri.MusteriIl = kayitliSehir;
                                                                            sayac6++;
                                                                        }
                                                                    }
                                                                    if (sayac6 == kayitliSehir.Length)
                                                                    {
                                                                        kayitlisSehirSorgula = false;
                                                                        bool SemtSorgula = true;
                                                                        do
                                                                        {
                                                                            Console.Write("Musterinin kayitli oldugu semt: ");
                                                                            string kayitliSemt = yrdm.IlkHarfBuyuk(Console.ReadLine());

                                                                            int sayac7 = 0;
                                                                            int sonKayitliSemtInt;

                                                                            for (int i = 0; i < sonArananSehir.Length; i++)
                                                                            {
                                                                                if (int.TryParse(kayitliSemt.ToCharArray()[i].ToString(), out sonKayitliSemtInt))
                                                                                {
                                                                                    Console.WriteLine("Musterinin kayitli oldugu semti rakamla giremezsiniz lutfen tekrar deneyin.");
                                                                                    break;
                                                                                }
                                                                                else if (kayitliSemt == "Null")
                                                                                {
                                                                                    sayac7++;
                                                                                }
                                                                                else
                                                                                {
                                                                                    musteri.MusteriIlce = kayitliSemt;
                                                                                    sayac7++;
                                                                                }
                                                                            }
                                                                            if (kayitliSemt.Length == sayac7)
                                                                            {
                                                                                SemtSorgula = false;
                                                                                bool mahalleSorgula = true;
                                                                                do
                                                                                {
                                                                                    Console.Write("Musterinin kayitli oldugu mahalle: ");
                                                                                    string kayitliMahalle = yrdm.IlkHarfBuyuk(Console.ReadLine());

                                                                                    int sayac8 = 0;
                                                                                    int sonKayitliMahalleInt;

                                                                                    for (int i = 0; i < sonArananSehir.Length; i++)
                                                                                    {
                                                                                        if (int.TryParse(kayitliMahalle.ToCharArray()[i].ToString(), out sonKayitliMahalleInt))
                                                                                        {
                                                                                            Console.WriteLine("Musterinin kayitli oldugu mahalle rakamla giremezsiniz lutfen tekrar deneyin.");
                                                                                            break;
                                                                                        }
                                                                                        else if (kayitliMahalle == "Null")
                                                                                        {
                                                                                            sayac7++;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            musteri.MusteriMahalle = kayitliMahalle;
                                                                                            sayac7++;
                                                                                        }
                                                                                        if (kayitliMahalle.Length == sayac7)
                                                                                        {
                                                                                            mahalleSorgula = false;
                                                                                            bool musteriDurumSorgula = true;
                                                                                            do
                                                                                            {
                                                                                               
                                                                                                int sayac9 = 0;
                                                                                                Console.WriteLine("Musteri daire ariyorsa(A)/Aramiyorsa(X) i tuslayin: ");
                                                                                                string secim = yrdm.IlkHarfBuyuk(Console.ReadLine());
                                                                                                switch (secim)
                                                                                                {
                                                                                                    case "X":
                                                                                                        musteri.MusteriNiyeti = DurumMusteri.Aramiyor;
                                                                                                        sayac9++;
                                                                                                        break;
                                                                                                    case "A":
                                                                                                        musteri.MusteriNiyeti = DurumMusteri.Ariyor;
                                                                                                        sayac9++;
                                                                                                        break;
                                                                                                    case "Null":
                                                                                                        sayac9++;
                                                                                                        break;
                                                                                                    default:
                                                                                                        Console.WriteLine("Yanlis bir karekterle giris yaptiniz lutfen tekrar deneyin.");
                                                                                                        break;
                                                                                                }
                                                                                                if (sayac9 > 0)
                                                                                                {
                                                                                                    musteriDurumSorgula = false;
                                                                                                    Console.WriteLine();
                                                                                                    Console.WriteLine("Musteri bilgileri guncellenmistir");
                                                                                                }
                                                                                            } while (musteriDurumSorgula);

                                                                                        }
                                                                                    }
                                                                                } while (mahalleSorgula);

                                                                            }
                                                                        } while (SemtSorgula);

                                                                    }
                                                                } while (kayitlisSehirSorgula);
                                                            }
                                                        } while (arananSehirSorgula);
                                                    }

                                                } while (musteriButSorgula);

                                            }

                                        } while (cinsiyetSorgula);
                                    }
                                } while (SoyadSorgula);
                            }
                        } while (isimSorgula);


                    }
                    else
                    {
                        Console.WriteLine("Ne yazik ki girdiginiz musteri numarasinda hic bir musteri bulunmamaktadir.");
                    }

                }
                else
                {
                    Console.WriteLine("Musteri numarasi guncelleme icin gereklidir lutfen musteri numarasini giriniz.");
                }
            } while (musteriNoSorgula);
        }

        public void DaireSil()
        {
            Console.Write("Silinmesini istedigin daire numarasini gir: ");
            string no = Console.ReadLine();
            int noInt;
            if (int.TryParse(no , out noInt))
            {
                Daire d = daire.Daireler.Where(x => x.DaireNo == noInt.ToString()).FirstOrDefault();
                if (d != null)
                {
                    if (d.KiradaMiSatildiMi == Durum.Bosta)
                    {
                        daire.Daireler.Remove(d);
                    }
                    else
                    {
                        Console.WriteLine("Bu daire islem gordugu icin sistemden silinememektedir.");
                    }
                }
                else
                {
                    Console.WriteLine("Ne yazikki bu numarada bir daire bulunmamaktadir.");
                }
            }
            else if (no == "")
            {
                Console.WriteLine("Lutfen alani bos birakmayiniz");
            }
            else
            {
                Console.WriteLine("Sadece rakamlarla daire numarasini girebilirsiniz.");
            }
        }

        public void MusteriSil()
        {
            Console.Write("Silinmesini istedigin musteri numarasini gir: ");
            string no = Console.ReadLine();
            int noInt;
            if (int.TryParse(no, out noInt))
            {
                Musteri d = musteri.Musteriler.Where(x => x.MusteriNo == noInt.ToString()).FirstOrDefault();
                if (d != null)
                {
                    if (d.YapilanIslem == IslemAdi.Islemsiz)
                    {
                        musteri.Musteriler.Remove(d);
                    }
                    else
                    {
                        Console.WriteLine("Bu musteri islem yaptigi icin sistemden silinememektedir.");
                    }
                }
                else
                {
                    Console.WriteLine("Ne yazikki bu numarada bir musteri bulunmamaktadir.");
                }
            }
            else if (no == "")
            {
                Console.WriteLine("Lutfen alani bos birakmayiniz");
            }
            else
            {
                Console.WriteLine("Sadece rakamlarla musteri numarasini girebilirsiniz.");
            }
        }

    }
}
