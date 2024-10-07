using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("1. Sınav Notunu Giriniz :");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz :");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz :");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavın Ortalaması :  " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = " Sonuç Kötü";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = " Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            // Veya işareti bu bilgisayarda Alt Gr + Backspace solundaki tuşla yapılır

            //string city;
            //Console.Write("Bir Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "adana" | city == "antalya" | city == "ağrı")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.Write(" Şehir Mevcut Değil!");
            //}

            // Eşit değil demek için != kullanılır.

            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();

            //if (username!= "admin")
            //{
            //    Console.Write("Hatalı Kullanıcı Adı!");
            //}
            //else
            //{
            //    Console.Write("Kulanıcı adı doğru");
            //}

            #endregion

            #region Mod Alma İşlemleri

            // Mod işlemi iki sayının birbirine bölümünden kalanı verir.
            // Mod alma işlemi için  % operatörü kulanılır.

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());


            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir.");
            //}
            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            //if (team == 'g' | team == 'G') 
            //{
            //    Console.Write("Galatasaray");
            //}

            #endregion


            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restauraut *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("1- Çorbalar"); ;
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("----------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını Görmek İstediğininz Menüyü Seçiniz ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------- Çorbalar ---------");
            //    Console.WriteLine("1- Domates Çorbası");
            //    Console.WriteLine("2- Mercimek Çorbası");
            //    Console.WriteLine("3- Pirinç Çorbası");
            //    Console.WriteLine("4- Mantar Çorbası");
            //    Console.WriteLine("5- Tarhana Çorbası");
            //    Console.WriteLine("--------- Çorbalar ---------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------- Ana Yemekler ---------");
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("--------- Ana Yemekler ---------");


            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------- Pizzalar ---------");
            //    Console.WriteLine("1- Vejeteryan Pizza");
            //    Console.WriteLine("2- Sucuklu Pizza");
            //    Console.WriteLine("3- Ton Balıklı Pizza");

            //    Console.WriteLine("--------- Pizzalar ---------");


            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------- İçecekler ---------");
            //    Console.WriteLine("1- Ayran");
            //    Console.WriteLine("2- Su");
            //    Console.WriteLine("3- Kola");
            //    Console.WriteLine("4- Soda");

            //    Console.WriteLine("--------- İçecekler ---------");


            //    Console.WriteLine();

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------- Tatlılar ---------");
            //    Console.WriteLine("1- Kadayıf");
            //    Console.WriteLine("2- Sufle");
            //    Console.WriteLine("3- Fıstıklı Baklava");
            //    Console.WriteLine("4- Cevizli Baklava");

            //    Console.WriteLine("--------- Tatlılar ---------");


            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case 
            // Switch kod bloğumuzun anahtar kısmını,  Case kısmı ise bu anahtarın durumarını gösterir.
            // Switch + tab + tab kod bloğnu getirir.

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi Yaptınız"); break;
            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Birinci sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seçiniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " +  result);
            //        break;

            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //        case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //        case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

                    
            //}





            #endregion

            Console.Read();
        }
    }
}
