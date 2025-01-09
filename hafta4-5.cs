using System;

namespace ParamsOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            double ortalama1 = OrtalamaHesapla(1, 2, 3, 4, 5);
            double ortalama2 = OrtalamaHesapla(10, 20, 30);

            Console.WriteLine($"Ortalama 1: {ortalama1}");
            Console.WriteLine($"Ortalama 2: {ortalama2}");
        }

        static double OrtalamaHesapla(params double[] sayilar)
        {
            double toplam = 0;
            foreach (double sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam / sayilar.Length;
            Console.ReadKey();
        }
    }
}