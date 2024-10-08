using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            // Temelde 4 tane döngü vardır. 
            // Döngüler birden fazla tekraını istediğimiz durumlarda kıllanılabilir.

            // For Döngüsü 3 tane parametre alır.
            // for(x;y;z)
            // x: başlangıç değerini tutar.
            // y: bitiş değerini tutar.
            // z: artış veya azalış mitarını tutar.
            // for + tab + tab för döngüsünü kurar

            // BİR YAZIYI 5 KERE YAZDIRMAK;

            //int i; // Döngülerde genellikle i kulanılır.

            //for (i = 1; i <=5; i++) // i++ i ' yi bir bir artır anlamına gelir. Döngü soldaki şartın dışına çıkınca çıkınca süslü parantez altından kod bloğu çalışmaya devam eder.   
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            // 1 - 20 ARASI SAYILARI YAZDIRMAK 

            //for (int i = 1; i <= 20; i++) // Burada olduğu gibi değişken for döngüsünde doğrudan tanımlanabilir.
            //{
            //    Console.WriteLine(i);
            //}

            //  0 İLE 50 ARASINDAKİ 3'E TAM BÖLÜNEBİLEN SAYILAR

            //for (int i = 3; i <= 50; i += 3) // i  += 3 i' ye 3 ekle demek
            //{
            //    Console.WriteLine(i);
            //}

            // CONSOLE EKRANINDAN GİRECEĞİMİZ SAYI KADAR DEĞERİ YAZDIRMAK

            //Console.WriteLine("Lütfen Yazdırmak İstediğiniz Değeri Giriniz: ");

            //int finalValue = int.Parse(Console.ReadLine());

            //for (int i=1; i<=finalValue; i++)
            //{
            //    Console.WriteLine("Merhaba Gençler");
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            // 0 - 100 ARASI BEŞE TAM BÖLÜNEBİLEN SAYILAR

            //    for (int i = 1; i <= 100; i++)
            //    {
            //        if (i % 5 == 0)
            //            {
            //        Console.WriteLine(i);
            //            }   
            //}

            // 1 - 10 ARASI SAYILARIN TOPLAMI

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            // 1 -20 ARASINDAKİ ÇİFT SAYILARIN TOPLAMI

            //int totalValue =0;
            //for (int i = 1; i<=20; i++)

            //{
            //    if (i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----");    
            //Console.WriteLine(totalValue);

            // 1- 50 ARASINDA 7'YE TAM BÖLÜNEN SAYILAR KAÇ ADET

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            // SAAT BAŞI İKİYE BÖLÜNEN BAKTERİLRİN 24 SAAT SONUNDAKİ SAYISI KAÇTIR

            //int bacterium =1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saatin Sonunda: " + bacterium );
            //}

            #endregion

            #region While Döngüsü

            // While şart sağlandığı müddetçe işlemi yapmaya devam eder.

            // While(Şart)
            // { 
            //   İşlemler
            // }
            // şeklinde bir yapısı vardır.

            // BİR YAZIYIY 10 KERE YAZDIRALIM

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            // 1 - 10 ARASINDA 3' e TAM BÖLÜNEN SAYILARI BULALIM

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}

            // 1 - 10 ARASI SAYILARIN TOPLAMI NEDİR

            //int total = 0;
            //int i = 1;

            //while (i <= 10)
            //{
            //    total += i;
            //    i++;
            //}
            //Console.WriteLine(total);

            #endregion

            #region Örnek Sınav Sorusu

            // KLAVYEDEN GİRİLEN ÜÇ BASAMAKLI SAYININ BASAMAKLARINDAKİ SAYILARIN TOPLAMI NEDİR?

            
            Console.Write("3 basamaklı bir sayı yazınız: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds, sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100; // int kullandığımızdan yüzler basamağından sonraki kısım virgülden sonra kalacağından onu dikkate almaz
            
            Console.WriteLine("Bu sayının basamakları: " + ones +  "-" + tens + "-" + hundreds);

            sum = ones + tens + hundreds;


            Console.WriteLine("Bunların toplamı: " + sum);






            #endregion
            Console.Read();
        }
    }
}
