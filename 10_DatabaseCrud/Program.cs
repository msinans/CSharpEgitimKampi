using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD Create - Read - Update _ Delete
            // insert into SQL' de ekleme işlemi için kullanılıyor.
            // @ sembolü SQL tarafında değişken tanımlamak için kullanılan bir karakter. 31. satırda var. Bunun solundaki parantez sıralamasıyla eşleşerek gider.

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("----------------------------------");
            #region Kategori Ekleme İşleme
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial catalog = EgitimKampiDb; integrated security = true"); // bağlantımı yazdım

            //connection.Open(); // bağlantımı açtım

            //// Ekleme işlemi için önce aşağıda sorgumu yazıyorum
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection); // connection yazarak sorguyu veritabanı ile ilişkilendiriyorum.
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); // koşulsuz bir şekilde sorguyu çalıştır anlamındadır.
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi!");
            #endregion


            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values(@productName, @productPrice, @productstatus)", connection);
            //command.Parameters.AddWithValue("productName", productName);
            //command.Parameters.AddWithValue("productPrice", productPrice);
            //command.Parameters.AddWithValue("productStatus", true); // dışarıdan almıyorum başlangıçta hepsi true olacak
            //command.ExecuteNonQuery(); // değişiklikleri kaydet ve bunları veritabanına yansıt anlamındadır.
            //connection.Close();

            //Console.Write("Ürün eklendi!");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); // SQL den veri çekerken köprü görevi gören komut SqlDataAdapter. 
            //DataTable dataTable = new DataTable(); // Verileri geçici belleğe alır.
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine() ;
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            Console.Write("Silinecek Ürün Id: ");

            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial catalog = EgitimKampiDb; integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productId");    



            connection.Close();



            #endregion

            Console.Read();






        }
    }
}
