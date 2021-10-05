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

            //Length // string dizi uzunluğu verir.
            //ToUpper , hepsini büyük yapar. // ToLower , hepsini küçük yapar.
            //Concat(değişken,"merhaba") , değişkeni yanındaki string ile birleştirir.
            //CompareTo(değişken.CompareTo(değişken2)) ilk değişken ikincisine eşitse 0 döner. 1>2 ise 1 döner. 1<2 ise -1 döner.
            //string.Compare(değişken, değişken2,true-false) , true büyük küçük harf duyarlı değil demek , false ise duyarlıdır demektir.
            //değişken.Contains("dklasdas") , değişkende verilen ifade var mıdır? sonuç true yada false döner.
            //değişken.EndsWith("MMM") , değişken bununla mı bitiyor? sonuç true-false döner.
            //değişken.StartsWith("dasdad") , değişken bununla mı başlıyor? sonuç true-false döner.
            //değişken.IndexOf("cxa") , değişken içinde bu var mı? ilk bulduğu yerde ifadenin ilk index sırasını verir. bulamaz ise -1 verir.
            //değişken.Insert(0, "dsada") , sıfırıncı indexden başlayarak stringin devamıne kelimeyi ekler.
            //değişken.LastIndexOf("dadasdasda") , cümlede birden fazla bu kelime var ise sonuncunun index sırasını getirir.
            //değişken.Remove(10) , 10. indexten sonuna kadar siler.
            //değişken.Remove(10, 3) , 10. başlar ve 3 karakter siler.
            //değişken.Replace("asdasdas", "xxxxx") , birinci string ile ikinci olanları değiştir.
            //değişken.Split(' '[1]) , boşluklara göre bunları parçala ve 1. indexteki değeri göster.
            //değişken.SubString(4) , 4. indexten başlayarak cümlenin sonuna kadar getirir.
            //değişken.SubString(4,6) , 4. indexten başlayarak 6 karakter getirir.

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