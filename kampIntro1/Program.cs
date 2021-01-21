using System;

namespace kampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type safety-tip güvenliği

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;

            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;



            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayaraları butonu");
            }

            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}
