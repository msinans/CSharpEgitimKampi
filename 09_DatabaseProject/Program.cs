using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.Net 
            // Ado. Net bizim C# Programlama dilinde SQL yapılarını kullanmamızı sağlayan bir çatıdır.
            // SQL bağlantısı için kullanılacak olan komutun ismi Sqlconnection
            // OOP Nesne Odaklı Programlamada 3 tane temel yapı var. 1- Sınıf 2- Nesne 3 Property (Nitelik)
            // Sınıflar nitelikleri içinde barındırır.
            // Sınıflara erişim sağlamak için önce o sınıftan bir nesne örneği türetmek gerekiyor
            // Aşağıdaki Sqlconnection bir sınıf ve connection da bir nesne
            // Bir sınıfın üzerine gelince düğüm sembolü çıkar.
            // initial Catalog veritabanının ismi. Bunu SQL'den alacağız.
            // integrated security=true bağlantının güvenilir olduğunu anlatır.
            // Önce sunucu ismi sonra veritabanına verdiğimiz isim ve integrated security=true eklenir.
            // SqlDataAdapter C#' ta oluşturduğum sorgu ile veritabanı arasında köprü görevi gören sınıf.
            // DataTable verilerimi RAM belleğe almayı sağlar.
            // var değişken türü bütün değişken türlerini üzerini alabilir.

            Console.WriteLine("***** C# Veri Tabanlı Ürün - Kategori Bilgi Sitemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("-----------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------");

            SqlConnection connection = new SqlConnection("Data Source= (localdb)\\MSSQLLocalDB; initial Catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            connection.Close();

            foreach (DataRow row in datatable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
