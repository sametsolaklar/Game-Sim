using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class SatisManager : IGameManager
    {
        public void KampanyaTutariHesapla(Kampanya kampanya, Oyunlar oyun)
        {
            Console.WriteLine(oyun.OyunAdi + " Oyunu kampanya ile satın alındı.");
        }

        public void OyunIadeEt(Gamer gamer ,Oyunlar oyun)
        {
            Console.WriteLine(oyun.OyunAdi + " Oyunu " + gamer.TakmaAdi + " Hesabından iade edildi.");
        }

        public void OyunSatinAl(Gamer gamer,Oyunlar oyun)
        {
            Console.WriteLine(oyun.OyunAdi + " Oyunu " + gamer.TakmaAdi + " Hesabına Satın alındı.");
        }
        public void KampanyaliOyunSatinAl(Gamer gamer,Kampanya kampanya, Oyunlar oyun)
        {
            Console.WriteLine(oyun.OyunAdi + " Oyunu indirimli bir şekilde " + gamer.TakmaAdi + " Hesabına satın alındı.");
        }
    }
}
