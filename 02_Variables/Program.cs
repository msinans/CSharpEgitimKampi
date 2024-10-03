using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Starta bastığımızda hangi proje çalışsın istiyorsak yukarıdan Extensions altından onun ismi seçilir. Solution Exp. 'da rengi koyu olan çalışacak olan projedir.
            // double değişkeni ondalıklı sayılar için kullanılır.
            // nokta olarak kod ekranına yazdığım karakter çalıştırdığımda console ekranında virgül olarak gözükür.
            // Klavyeden veri girerken noktaya basarsam onu karakter olarak algılar, O yüzden klavyeden ondalılı sayı girilecekse klavyeden virgül girilmeli
            // Ctrl + space e basarsak bize değişken veya metot isimlerini tamamlama önerileri verir.
            // Ctrl + F ye basarsak  bize istediğimiz kelimeyi bulmayı ve istediğimiz kelime ile değiştirme imkanı verir. (yeni kelime yazılıp Replace All seçilir.)

            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Lİstesi *****");
            //Console.WriteLine();

            //double applePrice, strawberryPrice, orangePrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85 ;
            //orangePrice = 20.95 ;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı -----: " + applePrice + " TL") ;
            //Console.WriteLine("----- Portakal Birim Fiyatı -----: " + orangePrice + " TL") ;
            //Console.WriteLine("----- Çilek Bİrim Fiyatı -----: " + strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Bİrim Fiyatı -----: " + potatoPrice + " TL");
            //Console.WriteLine("----- Domates Bİrim Fiyatı -----: " + tomatoPrice + " TL");

            //Console.WriteLine() ;   
            //Console.WriteLine() ;

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245 ;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram ;
            //double orangeTotalPrice = orangePrice * orangeGram ;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram ;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram ;
            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice ;


            //Console.WriteLine("Alınan Ürün Elma - " + "Birim Fiyat:" + applePrice + " Gramaj:" + appleGram + " Toplam Tutar:" + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün Portakal - " + "Birim Fiyat:" + orangePrice + " Gramaj:" + orangeGram + " Toplam Tutar:" + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün Çilek - " + "Birim Fiyat:" + strawberryPrice + " Gramaj:" + strawberryGram + " Toplam Tutar:" + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün Patates - " + "Birim Fiyat:" + potatoPrice + " Gramaj:" + potatoGram + " Toplam Tutar:" + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün Domates - " + "Birim Fiyat:" + tomatoPrice + " Gramaj:" + tomatoGram + " Toplam Tutar:" + tomatoTotalPrice + " TL");
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar :" + shoppingTotalPrice + " TL");



            #endregion

            #region Char Değişkenler

            // Char Değşkenler karakter türünde değişkenlerdir. 
            // String değişkenler "" tırnak içinde tanımlanırken Char değişkenler '' içinde tanımlanır.

            //char symbol;
            //symbol = 's';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            // Console.ReadLine(); programı çalıştırdıktan sonra klavyeden yazacağımız veriyi ekrana yazdırır.

            //Console.WriteLine("***** CSharp Havayolları Yolcu Bilgi Ekranı *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu Kimlik No: " + passengerIdentityNumber + " Yolcu Bilgileri: " + passengerName + " " + passengerSurname + "  " + passengerDistrict + " / " + passengerCity + "  " + passengerAge);



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            // C# girilen değerleri başlangıçta string olarak kabul ediyor. String haricinde bir değer girilecekse bunun bildirilmesi gerekiyor. Program Konsol ekranına klavyeden veri girişlerini string olarak algıladığından bunun haricinde bir veri girişi için dönşüm yapmak gerekir. Bir çok dönüşüm türü vardır.


            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine()); // Soldaki kod lavyeden girilecek değeri Parse metodu ile integer a dönüştürecek

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız TV Sayısını Giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek Ücret: " + totalPrice + " TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result ;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.Write("YIl Sonu Ortalamanız :" + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.WriteLine("Lütfen Cinsiyet Seçiniz : ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);

            #endregion



            Console.Read();
        }
    }
}
