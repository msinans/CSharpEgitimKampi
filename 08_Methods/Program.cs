using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {   // Bir yapının metot olduğunu anlamak için üzerine geldiğimizde mor renkli bir küp çıkması gerekir.
        // Metotların sonunda mutlaka () bulunur.
        // Metodu yazıp onu metot dşından çağırmak gerek
        // İki tür metot vardır;
        // 1 - Void (Geriye değer döndürmeyen metotlar)
        //     Geriye değer döndürmeyen metotlar, beli işlemleri tekrar tekrar yazmamızı gerek                   bırakmadığından için faydalıdır.

        // 2 - Geriye Değer Döndüren Metotlar
        //     Bunlar geriye bir değer, değişken, liste vs. döndürür.
        //     Bunlar bir değişken veya sınıf türü ile tanımlanır.
        //     Geriye değer döndürme işlemi return ile yapılır.

        static void Main(string[] args)
        {
            #region Void Metotlat

            //void customerList()
            //{
            //    Console.WriteLine("Ali Can");
            //    Console.WriteLine("Can Can");
            //    Console.WriteLine("Veli Can");
            //    Console.WriteLine("Deli Can");
            //    Console.WriteLine();

            //}
            //customerList(); // Metodu yazıp onu metot dşından çağırmak gerek
            //customerList();
            //customerList();
            //customerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void writeMethod (string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Ali Can");

            //void customerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + surname);
            //}
            //customerCard("Ali ", "Can");
            //customerCard("Veli ", "Can");
            //customerCard("Deli ", "Can");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(1, 3, 5);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Can Can";
            //}

            //customerName(); // Bu şekilde yazdığımızda bize ekrana Can Can yazmaz

            // string studentCard ()
            // {
            //     string name = "Ali";
            //     string surname = "Kaya";
            //     return name + " " + surname;
            // }

            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " -Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x,y,z));
            //Console.WriteLine(countryCard("Türkiye", "Ankara", "Kırmızı + Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int sum (int number1 , int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(45, 90));
            //Console.WriteLine(sum(55, 100));
            //Console.WriteLine(sum(65, 110));
            //Console.WriteLine(sum(75, 120));
            #endregion

            #region Örnek Uygulama

            string examResult (string studentName, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3 ;
                if (result >= 50)
                {
                    return studentName + " isimli öğrenci sınavı geçti. " + "Sınav ortalaması: " + result;
                }
                else
                {
                    return studentName +" isimli öğrenci sınavı geçemedi. " + "Sınav ortalaması: " + result;
                }
            }
            Console.WriteLine(examResult("Jo Johnson", 33, 45, 67));
            Console.WriteLine(examResult("Bo Johnson", 66, 44, 11));
            Console.WriteLine(examResult("Jo James", 45, 78, 100));            


            #endregion

            Console.Read();
        }
    }
}
