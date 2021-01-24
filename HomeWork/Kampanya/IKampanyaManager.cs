using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    interface IKampanyaManager
    {
        void KampanyaEkle(Kampanya kampanya);
        void KampanyaSil(Kampanya kampanya);
        void KampanyaGuncelle(Kampanya kampanya);
    }
}
