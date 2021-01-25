using System;

namespace ClassMetotDemo
{
    class program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 01;
            musteri1.TC_no = 46202565652;
            musteri1.Adi = "Ayşe merve";
            musteri1.Soyadi = "Karaoğlan";
            musteri1.Tel_no = 05367913256;
            musteri1.Adres = "Gaziantep/şahinbey";

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 02;
            musteri2.TC_no = 48503026975;
            musteri2.Adi = "Emrullah";
            musteri2.Soyadi = "Orhan";
            musteri2.Tel_no = 05347625894;
            musteri2.Adres = "Gaziantep/oğuzeli";

            Musteri musteri3 = new Musteri();
            musteri3.musteriId = 03;
            musteri3.TC_no = 48953261753;
            musteri3.Adi = "Emine ";
            musteri3.Soyadi = "Bozoğlan";
            musteri3.Tel_no = 05361245897;
            musteri3.Adres = "Gaziantep/Şehitkamil";

            Musteri[] musteriler = new Musteri[] 
            { musteri1,musteri2,musteri3};

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriId);
                Console.WriteLine(musteri.TC_no);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Tel_no);
                Console.WriteLine(musteri.Adres);
                Console.WriteLine("--------------------------------------------");

            }

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.ekle(musteri1);
            musterimanager.ekle(musteri2);
            musterimanager.ekle(musteri3);

            Console.WriteLine("------------müşteri listeleme--------------");


            musterimanager.listele(musteri3);


            Console.WriteLine("-----------Müşterileri Silme------------");

            
            musterimanager.delete(musteri2);


            


            
            
        }
    }
}
