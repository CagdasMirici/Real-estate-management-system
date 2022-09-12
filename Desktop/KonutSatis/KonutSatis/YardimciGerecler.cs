using System;
using System.Collections.Generic;
using System.Text;

namespace KonutSatis
{
    class YardimciGerecler
    {
        public bool Donsun = true;
        public void OzgunDaireNo(int DaireninIntDegeri, string daireninStringDegeri)
        {
            //    Daire daire ;
            //    int yeniDaireNoInt = 0;
            //    int sayac = 0;
            //    int sayacEsit = 0;

            //    do
            //    {


            //        foreach (Daire item in daire.Daireler)// daireler sinifindaki listeye ulasilamiyor nasil yapabilirim ?
            //        {
            //            if (item.DaireNo != DaireninIntDegeri.ToString())
            //            {
            //                sayac++;

            //            }
            //            else
            //            {
            //                DaireninIntDegeri++;
            //                sayacEsit++;
            //                sayac = 0;
            //            }
            //        }

            //    } while (sayac != daire.Daireler.Count);

            //    if (sayacEsit == 0)
            //    {
            //        Console.WriteLine("Sisteme " + DaireninIntDegeri + " Numarali daire basarili bir sekilde eklenmistir...");
            //        sayacEsit = 0;
            //        daire.DaireNo = DaireninIntDegeri.ToString();
            //        daire.Daireler.Add(daire);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sistemde " + daireninStringDegeri + " numaralı daire olduğu için verdiğiniz daire no " + DaireninIntDegeri + " olarak değiştirildi.");
            //        daire.DaireNo = yeniDaireNoInt.ToString();
            //        daire.Daireler.Add(daire);
            //    }
            //}
        }

        public string IlkHarfBuyuk(string a)
        {

            a.ToCharArray();

            if (a == null || a == "")
            {
                return "Null";
            }
            else
            {
                string acaba = a[0].ToString().ToUpper() + a.Substring(1, a.Length - 1).ToLower();
                return acaba;

            }


        }

        public void dondur()
        {

            Console.WriteLine("Menüyü tekrar listelemek için “liste”, çıkış yapmak için “çıkış” yazın.");
            bool sor = true;
            do
            {
                Console.Write("Yapmak istediginiz islemi secin: ");
                string islem = IlkHarfBuyuk(Console.ReadLine());
                switch (islem)
                {
                    case "Liste":
                        Donsun = true;
                        sor = false;
                        break;
                    case "Cikis":
                        Donsun = false;
                        sor = false;
                        break;
                    case "Null":
                        Console.WriteLine("Lutfen alani bos birakmayiniz.");
                        break;
                    default:
                        Console.WriteLine("Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                        break;
                } 
            } while (sor);
        }


    }
}