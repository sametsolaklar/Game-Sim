using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerManager gamerManager = new GamerManager();
            IGameManager gameSatisManager = new SatisManager();
            IKampanyaManager kampanyaManager = new KampanyaManager();
            EDevlet eDevlet = new EDevlet();

            Kampanya kampanya1 = new Kampanya { KampanyaAdi = "Kara Cuma Kampanyası", KampanyaYuzdeTutar = 8 };
            Kampanya kampanya2 = new Kampanya { KampanyaAdi = "Şanslı Saatler Kampanyası", KampanyaYuzdeTutar = 5 };
            Kampanya kampanya3 = new Kampanya { KampanyaAdi = "Kış Kampanyası", KampanyaYuzdeTutar = 5 };
            Kampanya kampanya4 = new Kampanya { KampanyaAdi = "HaftaSonu Kampanyası", KampanyaYuzdeTutar = 5 };
            kampanyaManager.KampanyaEkle(kampanya3);
            kampanyaManager.KampanyaEkle(kampanya4);



            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.Adi = "Samet";
            gamer1.SoyAdi = "Solaklar";
            gamer1.TakmaAdi = "SolakSamet";
            gamer1.TcNo = "00000000001";
            gamer1.Sifre = "samet1234";
            gamer1.DogumYili = new DateTime(2002, 05, 12);

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.Adi = "Safa";
            gamer2.SoyAdi = "Solaklar";
            gamer2.TakmaAdi = "SolakSafa";
            gamer2.TcNo = "00000000002";
            gamer2.Sifre = "safa1234";
            gamer2.DogumYili = new DateTime(2005, 12, 11);

            Gamer gamer3 = new Gamer();
            gamer3.Id = 3;
            gamer3.Adi = "Salih";
            gamer3.SoyAdi = "Solaklar";
            gamer3.TakmaAdi = "SolakSalih";
            gamer3.TcNo = "00000000003";
            gamer3.Sifre = "salih1234";
            gamer3.DogumYili = new DateTime(1998, 01, 06);

            Gamer gamer4 = new Gamer();
            gamer4.Id = 2;
            gamer4.Adi = "Melis";
            gamer4.SoyAdi = "Polat";
            gamer4.TakmaAdi = "PolatMelis";
            gamer4.TcNo = "00000000003";
            gamer4.Sifre = "Melis1234";
            gamer4.DogumYili = new DateTime(2010, 07, 22);
            Console.WriteLine("//////EKLEME İŞLEMİ///////");
            gamerManager.Ekle(gamer1, eDevlet);
            gamerManager.Ekle(gamer2, eDevlet);
            gamerManager.Ekle(gamer3, eDevlet);
            
            Console.WriteLine("//////SİLME İŞLEMİ///////");
            gamerManager.Sil(gamer2);
            Console.WriteLine("//////GÜNCELLEME İŞLEMİ///////");
            gamerManager.Guncelle(gamer1, eDevlet);//güncellenen hesap bilgileri tekrar edevlet üzerinden doğrulanıyor. 
            Console.WriteLine("//////EKLEME İŞLEMİ///////");
            gamerManager.Ekle(gamer4, eDevlet);

            Oyunlar oyun1 = new Oyunlar { OyunAdi = "Rainbow 6 Siege", OyunFiyati = 89 };
            Oyunlar oyun2 = new Oyunlar { OyunAdi = "Sea Of Thieves", OyunFiyati = 61 };
            Oyunlar oyun3 = new Oyunlar { OyunAdi = "Counter Strike ", OyunFiyati = 74 };

            gameSatisManager.KampanyaTutariHesapla(kampanya3,oyun1);
            gameSatisManager.OyunSatinAl(gamer1,oyun2);
            gameSatisManager.KampanyaliOyunSatinAl(gamer2,kampanya4, oyun3);
            gameSatisManager.OyunIadeEt(gamer1,oyun2);
            
        }
    }
}
