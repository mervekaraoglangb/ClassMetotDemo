using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public  void ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi, bizi tercih ettiğiniz için teşekkürler");

        }

        public void listele(Musteri musterilistele)
        {
            Console.WriteLine(musterilistele.musteriId+ musterilistele.TC_no+musterilistele.Adi+musterilistele.Soyadi+musterilistele.Tel_no+musterilistele.Adres+"istediğiniz veriler listelendi...");
        }
        public void delete(Musteri musterisil)
        {
            Console.WriteLine(musterisil.musteriId+"ID'li musteri silindi");

        }

    }
}
