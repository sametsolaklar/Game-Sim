using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    interface IGameManager
    {
        void OyunSatinAl(Gamer gamer,Oyunlar oyun);
        void KampanyaliOyunSatinAl(Gamer gamer,Kampanya kampanya, Oyunlar oyun);
        void OyunIadeEt(Gamer gamer,Oyunlar oyun);
        void KampanyaTutariHesapla(Kampanya kampanya, Oyunlar oyun);

    }
}
