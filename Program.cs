using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //DiziVeSayilar();
            //ornek2();
            //Harfler();
            //stringörnek();

            Console.ReadLine();
        }

        private static void stringörnek()
        {
            Console.WriteLine("cümle yazınız.");
            string cümle = Console.ReadLine();
            char[] dizi = new char[cümle.Length];
            Console.WriteLine("cümle harf uzunluğu {0}", cümle.Length); // iki farklı yazım biçimi
            Console.WriteLine("cümle harf uzunluğu =" + cümle.Length);
            string[] kelimeler = cümle.Split(' ');// verilen ifadeye göre string metni ayırır.
            Console.WriteLine("cümle kelime uzunluğu =" + kelimeler.Length);
        }

        private static void Harfler()
        {
            int sayi1;
            Console.WriteLine("1 pozitif sayı girin");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            char[] harfler = new char[sayi1];
            

            for (int i = 0; i < harfler.Length; i++)
            {
                Console.WriteLine("{0}. sayıyı girin ", i + 1);
                harfler[i] = Convert.ToChar(Console.ReadLine());
            }

            Array.Reverse(harfler); // diziyi ters yapar

            foreach (var item in harfler)
            {
                Console.WriteLine(item);
            }
        }

        private static void ornek2()
        {
            int sayi1;
            Console.WriteLine("1 pozitif sayı girin");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2;
            Console.WriteLine("1 pozitif sayı daha girin");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[sayi1];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0}. sayıyı girin ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in sayilar)
            {
                if (item % sayi2 == 0 || item == sayi2)
                    Console.WriteLine(item);
            }
        }

        private static void DiziVeSayilar()
        {
            int sayi;
            Console.WriteLine("1 pozitif sayı girin");
            sayi = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[sayi];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0}. sayıyı girin ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                    Console.WriteLine(item);
            }
        }
    }
}
