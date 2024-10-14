﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {

        // Sol. Exp.' da ilgili proje üzerine sağ tık > Set as startup project seçtiğimde Start butonuna basınca bu proje çalışır
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            // Dizi : Aynı veri türündeki çok sayıda veriyi tutmak için kullanılan yapılardır.
            // Dizi Syntaxı  ==> DeğişkenTürü[] DiziAdı = new DeğişkenTürü[Eleman Sayısı];
            // [] işareti şöyle yapılır == > Alt Gr + 8 + 9
            // Dizilerdde indeks saymaya sıfırdan başlar dizideki ilk eleman sıfırıncı pozisyondadır.
            // Bir dizi tanımlandığında tüm elemanlarına eleman atama şartı yoktur. Eleman atanmaya bir dizi elemanı çağırıldığında varsayılan olarak sıfır getirir.
            // Dizilerde string ifadeler "" içeriside tanımlanırken, char değişkenler '' içerisinde ve  int ifadeler doğrudan tanımlanır

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.Write(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milan" ;
            //cities[1] = "Budapeşte" ;
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 100;
            //numbers[1] = 88;
            //numbers[2] = 2;
            //numbers[7] = 12;
            //numbers[8] = 50;

            //Console.WriteLine(numbers[3]);

            // Dizilere eleman ataması yukarıdaki gibi yapılabildiği gibi aşağıdaki gibi de yapılabilir.

            //string[] cities = new string[] { "Ankara", "Bursa", "Konya", "Sakarya" };
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları  Listeleme

            //string[] colors = { "Mavi", "Sarı", "Yeşil", "Mor", "Siyah", "Beyaz", "Lacivert" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            // DEĞİŞKEN TANIMLAMA DİZİ DÖNGÜ KARAR YAPISI öRNEK

            //int[] numbers = { 1, 2, 34234, 345, 45, 454, 78, 43, 100, 111, 4567, 3 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbol = { 'a', 'b', 'c', 'd', '*', '@', '#' };
            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //int[] myArray = { 1, 2, 53, 456, 9, 459, 888, 7, 30 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)

            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            #endregion

            #region Dizi Metotlarından Length (bize dizideki eleman sayısını verir)

            //string[] persons = { "Ali", "Can", "İsa", "Joe", "Moe", "Sin", "Tin" };
            //Console.WriteLine(persons.Length);

            #endregion

            #region Dizi Metotlarından Sort (dizideki elememanların artan şekilde  sıralanması)

            //int[]
            //numbers = { 1, 2, 55, 78, 7, 999, 6, 0, 987, 66 };

            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion Dizi Metotlarından Reverse (elememanların sondan başa doğru  sıralanması)

            #region
            //int[] numbers = { 1, 2, 55, 78, 7, 999, 6, 0, 987, 66 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotlarından IndexOf (istediğmiz elemanın indeks sırasını verir)

            //string[] customers = { "Ali", "Can", "İsa", "Joe", "Moe", "Sin", "Tin" };
            //int index = Array.IndexOf(customers, "İsa"); // Buradaki isimde büyük küçük harf yukarıdaki ile aynı olmalı

            //Console.WriteLine(index);

            #endregion

            #region
            //int[] numbers = { 1, 2, 39, 9848, 848484, 399495, 0283647, 123456789, -3 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: "); // $ sembolü sayesinde "" içini tekrar yazmama gerek kalmıyor. Tırnaklar içini ve dışını beraber yazabiliyorum.
            //    cities[i] = Console.ReadLine();                     
            //}
            //Console.WriteLine();
            //Console.WriteLine( "---------------------------- ");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            #endregion

            #region Bir Tam Sayı Dizisi Oluşturup Toplamlarını Bulma

            //int[] numbers = { 10, 20, 30, 40, 50  };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Dizideki Tek Çift Sayıları Ayrı Ayrı Listeleme

            int[] numbers = { 11, 23, 34, 45, 56, 67, 78, 89, 90, 110 };

            Console.WriteLine("Dizideki Çift Sayılar: ");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("Dizideki Tek Sayılar: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion
            Console.Read();
        }
    }
}
