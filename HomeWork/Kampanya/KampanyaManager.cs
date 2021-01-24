using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class KampanyaManager : IKampanyaManager
    {
        public void KampanyaEkle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " 'sı eklendi");
        }

        public void KampanyaGuncelle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " 'sı güncellendi.");
        }

        public void KampanyaSil(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " 'sı silindi.");
        }
    }
}
