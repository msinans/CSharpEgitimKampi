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
            // == operatörü eşit mi? anlamaındadır.

            #region If Else

            Console.Write("Lütfen Şifreyi Girinz: ");
            string password;
            password = Console.ReadLine();

            if (password== "abcd")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            Console.Read();


            #endregion
        }
    }
}
