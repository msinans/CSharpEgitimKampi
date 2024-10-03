using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Dünya"); // WriteLine imleci alt satıra indirir
            //Console.Write("Selam"); // Write metodunda imleç yazının sonunda kalır alt satıra inmez.
            // Yukarıda Search altında Comment out ile başlayan seçenek seçilen satırları açıklama satırı haline getirir.
            // #region ile #endregion arasına yazacaklarımız solda çıkacak olan ok veya eksi ile kapatılabilir

            #region Yazdırma Komutları

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar"); // Ctrl + d yapıldığında o satırı kopyalayıp aşağı satıra yapıştırır.
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            // string değişken verilerimizi alfabetik olarak tutacağımız veri türü
            // Degisken_Adi Degisken_Turu; şeklinde kullanılır.
            // Değişken adı verilirken arada boşluk bırakılmaz bitişik veya alt çizgili yazılabilir.
            // Bir satırdan birden fazla aynı türde değişken tanımlanabilir.


            //string name;
            //name = "Sinan";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Can";
            //customerPhone = "532 5320532";
            //customerEmail = "alican@gmail.com";
            //district = "Tuzla";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();


            //customerName = "Ayşe";
            //customerSurname = "Can";
            //customerPhone = "542 542 0 542";
            //customerEmail = "aysecan@gmail.com";
            //district = "Pendik";
            //city = "İstanbul";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);


            //Console.WriteLine("-------------------------------------------------");




            #endregion

            #region Int Değişkenler

            // int değişkenler tam sayı türündeki değişkenlerdir.

            //int number;
            //number = 2024;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterprice = 10;
            int friesprice = 50;
            int pizzaprice = 250;
            int lemonadeprice = 30;

            Console.WriteLine("***** Restoran Menü Fiyat Listesi *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Kola: " + cokePrice + " TL");
            Console.WriteLine("Su: " + waterprice + " TL");
            Console.WriteLine("Kızartma: " + friesprice + " TL");
            Console.WriteLine("Limonata: " + lemonadeprice + " TL");

            Console.WriteLine() ;
            Console.WriteLine("***** Müşteri Toplam Ücret *****");
            Console.WriteLine("----------------------------------------");

            int hamburgerCount ;
            int cokeCount ;
            int waterCount ;
            int friesCount ;
            int pizzaCount ;
            int lemonadeCount ;

            int totalHamburgerPrice ;
            int totalCokePrice ;
            int totalWaterPrice;
            int totalFriesprice ;
            int totalPizzaprice ;
            int totalLemonadePrice ;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterprice;
            totalFriesprice = friesCount * friesprice;
            totalPizzaprice = pizzaCount * pizzaprice;
            totalLemonadePrice = lemonadeCount * lemonadeprice;

            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesprice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaprice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesprice + totalPizzaprice + totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");      

            #endregion
            Console.Read(); // Read metodu yazının ekranda görünüp kalmasını sağlar

            // Projeyi Github hesabına yüklemek için Solution ismi üzerine sağ tık > Create Git Repository seçilir.
            // Solution üzerinde ekleme yaparsak bunu güncelemek için yukarıdan View > Git Changes > Push tuşuna basılır.
            // Solution a yeni proje eklemek için solution üzrine sağ tık > Add New Project ve devamı yapılır.
        }
    }
}
