using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    interface IGamerManager
    {
        void Ekle(Gamer gamer, EDevlet eDevlet);
        void Guncelle(Gamer gamer, EDevlet eDevlet);
        void Sil(Gamer gamer);

    }
}
