using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Foreach  Döngüsü
            // Foreach döngüsü 4 tane parametre alır
            // Foreach(1; 2; 3; 4)
            // 1- Değişken Türü
            // 2- Değişken Adı
            // 3- In
            // 4- Liste Koleksiyon veya Dizi Adı

            // DİZİ OLUŞTURUP ELEMANLARINI EKRANDA GÖSTERELİM

            //string[] cities = { "Ankara", "BUrsa", "Sakarya", "Frankfurt", "Köln", "Bonn" };

            //foreach (string x in cities) 
            //{ 
            //    Console.WriteLine(x); // Burada x değişkeni sırayla dizi elemanlarını üzerine alır.
            //}

            //int[] numbers = {3, 5, 6, 101, 345, 7575758, 1000000001, 0000007,3, 8};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // DİZİDEKİ ÇİFT SAYILARI GÖSTERELİM

            //int[] numbers = { 3, 5, 6, 101, 345, 7575758, 1000000001, 0000007, 3, 8 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            // DİZİDEKİ SAYILARIN TOPLAMI

            //int[] numbers = { 3, 5, 6, 101, 345, 7, 10, 17, 2, 4 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            // LİSTELER DİZİLERE BENZER BİR ÖRNEKĞİ AŞAĞIDADIR.
            // Foreach döngüsü listelerle de çalışır.

            //List<int> list = new List<int>() // tipi belirtilerek bir yenisi oluşturulur.
            //{
            //    1,2,3,4,5,6,7,8,9
            //};
            //foreach (int number in list)
            //{
            //    Console.WriteLine(number);
            //}

            // BİR KELİMEYİ HARFLERİNE AYIRALIM

            //string word = "merhaba";
            //foreach (char c in word) // her bir harfi c 'ye atar 
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Klavyeden Üğrenci Sayısı, İsmi, Sınav Notlarını Alıp Ortalama Hesaplayalım


            Console.WriteLine(" ***** C# EĞİTİM KAMPI SINAV UYGULAMASI *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Kullanıcıdan Öğrenci Sayısını Alma
            Console.WriteLine("---------------------------------------");
            Console.Write("Sınıfınızdaki Öğrenci Sayısını Giriniz: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            // Öğrenci İsimlerini ve Not Ortalamalarını Saklayacak Diziler

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adını Giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her Öğrenci İçin 3 Sınav Notu Girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // Öğrencinin notlarını topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            // Sınav Ortalamaları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                // Öğrencilerin Geçip Kalma Durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci sınıfı geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("------------------------------------");
            }

            #endregion


            Console.Read();
        }
    }
}
