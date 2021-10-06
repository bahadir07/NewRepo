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
            //Ornek2();
            //Harfler();
            //StringOrnek();

            List<int> sayilar = new List<int>();
            sayilar.Add(3);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(8);

            List<string> renkler = new List<string>();
            renkler.Add("sarı");
            renkler.Add("kırmızı");
            renkler.Add("mavi");
            renkler.Add("mor");
            renkler.Add("turuncu");

            Console.WriteLine(renkler.Count);
            Console.WriteLine(sayilar.Count);

            foreach (var item in renkler)  // değişik yönde kullanımı elemanları sıralar
            {
                Console.WriteLine(item);
            }

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            sayilar.Remove(4); // var olan değeri sil 
            renkler.Remove("mor");
            sayilar.RemoveAt(1); // var olan indexteki değeri sil
            renkler.RemoveAt(2);

            sayilar.ForEach(sayi => Console.WriteLine(sayi)); // değişik yönde kullanımı elemanları sıralar
            renkler.ForEach(renk => Console.WriteLine(renk));

            if (sayilar.Contains(3)) // contains içinde yazılandaki elemanı dizide arar.
            {
                Console.WriteLine("sayı var");
            }

            Console.WriteLine(renkler.BinarySearch("turuncu")); // turuncunun indexini verir.

            string[] hayvanlar = { "kedi", "köpek", "aslan", "fare", "yılan", "kuş" };

            List<string> hayvanlarlistesi = new List<string>(hayvanlar); // hayvanlar dizisini hayvanlar listesine çevirir.

            hayvanlarlistesi.Clear(); // tüm listeyi temizler.

            List<Kullanıcılar> kullanıcılars = new List<Kullanıcılar>(); // kullanıcılar listesinden nesne oluşturarak kullanıcıları ekledik.
            Kullanıcılar kullanıcılar1 = new Kullanıcılar();
            kullanıcılar1.Isim = "asda";
            kullanıcılar1.Soyisim = "ksdamd";
            kullanıcılar1.Yas = 33;

            Kullanıcılar kullanıcılar2 = new Kullanıcılar();
            kullanıcılar2.Isim = "aa";
            kullanıcılar2.Soyisim = "bb";
            kullanıcılar2.Yas = 22;

            kullanıcılars.Add(kullanıcılar1);
            kullanıcılars.Add(kullanıcılar2);

            List<Kullanıcılar> yeniliste = new List<Kullanıcılar>(); // farklı ve pratik şekilde kullanıcı ekleme
            yeniliste.Add(new Kullanıcılar()
            {
                Isim = "dee",
                Soyisim="dad",
                Yas=33
            });

            foreach (var item in kullanıcılars)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
        private static void Nots()
        {
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
            //değişken.ToString , ifadeyi string olarak getirir.
            //DateTime.Now.DayOfWeek , günü string olarak verir.
            //Date.Time.Now.DayOfYear , yılın kaçıncı gününde olduğumuzu verir.
            //Date.Time.Now.ToLongDateString() , günü string yazarak tüm formatı string verir. SATURDAY APTİL 2 2021
            //Date.Time.Now.ToShortDateString() , 4/24/2021 şeklinde verir.
            //Date.Time.Now.ToString("dd") , //24 getirir, "ddd" sat getirir. "dddd" saturday getirir.
            //Date.Time.Now.ToString("mm") , //24 getirir, "mmm" sat getirir. "mmmm" saturday getirir.
            //Date.Time.Now.ToString("yy") , //21 getirir, "yyyy" 2021 getirir.
            //Math.Abs(-25) , 25 olarak pozitif getirir.
            //Math.Celling(22,3) üste yuvarlar tam sayı 23 olur .
            //Math.Round(22,3) 22 olur  22,7 olsa 23 verir.
            //Math.Floor(22,7) 22 verir.
            //Math.Max(2,6) büyük olan sayıyı verir.
            //Math.Min(2,6) küçük olan sayıyı verir.
            //Math.Pow(3,4) 3^4 verir = 81
            //Math.Sqrt(9) karekök alır. =3
            //Math.Log(9) 9 un e tanındaki logaritmik karşılığıdır.
            //Math.Exp(3) e üzeri 3 ü verir.
            //Math.Log10(10) 10 un logaritma 10 tabanındaki karşılığıdır.

        }
        private static void StringOrnek()
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
        private static void Ornek2()
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
    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}