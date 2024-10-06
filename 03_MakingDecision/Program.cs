using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {   // if bir karar yapısıdır.
            // Karar yapılarından sonra ; kullanılmaz. Çünkü cümleye başlamış ama henüz bitirmemişizdir. (Eğer şöyleyse...)
            // == operatörü eşit mi? anlamındadır.
            // Ctrl + k + d yapınca kodlar düzenlenir, muntazzam görünür.

            #region If Else

            //Console.Write("Lütfen Şifreyi Girinz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password== "abcd") // Konsol ekranında şifreyi yazarken kod ekranındaki büyük küçük harfler birerbir aynı olmalı 
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz : ");
            //country = Console.ReadLine();

            //if (capital== "ankara" & country== "türkiye") // iki tane şartı koyarken ve anlamında & kullanılır.
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Veri Girişi!");
            //}    

            //int number;
            //Console.Write("Bir Sayı Giriniz : ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.Write("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı!");
            //}

            int exam1, exam2, exam3, average;
            string result = "Hata!";

            Console.Write("1. Sınav Notunu Giriniz :");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sınav Notunu Giriniz :");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sınav Notunu Giriniz :");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavın Ortalaması :  " + average);

            if (average > 0 & average <= 50)
            {
                result = " Sonuç Kötü";
            }

            if (average > 50 & average <= 70)
            {
                result = "Sonuç Orta";
            }
            if (average > 70 & average <= 84)
            {
                result = "Sonuç İyi";
            }
            if (average > 84 & average <= 100)
            {
                result = " Sonuç Çok İyi";
            }

            Console.WriteLine(result);

            Console.Read();


            #endregion
        }
    }
}
