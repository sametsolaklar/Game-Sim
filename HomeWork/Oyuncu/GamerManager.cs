using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeWork
{
    class GamerManager:IGamerManager
    {

        Dictionary<int, string> gamerList = new Dictionary<int, string>();

        public void Ekle(Gamer gamer, EDevlet eDevlet)
        {
            gamerList.Add(gamer.Id,gamer.TakmaAdi);
            eDevlet.Kontrol(gamer);
            Console.WriteLine(gamer.TakmaAdi + " İsimli Hesabın Kayıt işlemi tamamlandı.");
            foreach (var item in gamerList)
            {
                Console.WriteLine(item);
            }
        }
        public void Sil(Gamer gamer)
        {
            
            gamerList.Remove(gamer.Id);
            Console.WriteLine(gamer.TakmaAdi + " İsimli Kullanıcı Silindi.");
        }
        public void Guncelle(Gamer gamer, EDevlet eDevlet)
        {          
            eDevlet.Kontrol(gamer);
            Console.WriteLine(gamer.TakmaAdi + " İsimli Hesap bilgileri güncellendi.");
            foreach (var item in gamerList)
            {
                Console.WriteLine(item);
            }
        }


    }

}
