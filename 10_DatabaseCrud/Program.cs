using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName= Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ITQNVC9;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command =new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarı ile eklendi!");

            #endregion

            #region Ürün Eleme İşlemi

            string productName;
            decimal productPrice;
            //bool productStatus;

            Console.Write("Ürün Adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice= decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ITQNVC9;initial catalog=EgitimKampiDb;integrated security=true");  // Database' e bağlantı oluşturma SqlConnection "Bağlantı nesnesi adı" = new SqlConnection(sunucu adı;database adı;kimlik doğrulama)
            connection.Open();  //bağlanma kodu
            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection); // sql sorgularını c# ta kullanmak için kullandım
            command.Parameters.AddWithValue("@productName", productName);  //AddWithValue metotu
            command.Parameters.AddWithValue("@productPrice",productPrice);
            command.Parameters.AddWithValue("@productStatus",true);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Ürün eklemesi başarılı!");

            #endregion





            Console.ReadKey();
        }
    }
}
