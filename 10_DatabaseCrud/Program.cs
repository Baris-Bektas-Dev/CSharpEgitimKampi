using System;
using System.Collections.Generic;
using System.Data;
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

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice= decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ITQNVC9;initial catalog=EgitimKampiDb;integrated security=true");  // Database' e bağlantı oluşturma SqlConnection "Bağlantı nesnesi adı" = new SqlConnection(sunucu adı;database adı;kimlik doğrulama)
            //connection.Open();  //bağlanma kodu
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection); // sql sorgularını c# ta kullanmak için kullandım
            //command.Parameters.AddWithValue("@productName", productName);  //AddWithValue metotu
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ITQNVC9;initial catalog=EgitimKampiDb;integrated security=true"); // Sunucu ve database yolu tanıtıldı
            //connection.Open(); // bağlantı açıldı

            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);//tablo seçildi ve veri çekme komudu yazıldı 
            //SqlDataAdapter adapter = new SqlDataAdapter(command);// databaseden veri çekmek için sqladapter komutu kullanıldı
            //DataTable dataTable = new DataTable();// databaseden çekilen veriyi ram bellek'te depolamak için datatable sınıfı ile değişkeni kullanıldı
            //adapter.Fill(dataTable);//datatable'a adapterdan çekilen veriler dolduruldu

            //foreach (DataRow row in dataTable.Rows)// datatable daki her bir satırı data row un rowuna al(satır sayısı tutan bir variable)
            //{
            //    foreach (var item in row.ItemArray)//satırdaki itemleri sırasına göre item değişkenine yazar
            //    {
            //        Console.WriteLine(item.ToString()+" ");// item değişkenini yazar
            //    }

            //}



            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silenecek ürünün ID'sini girin: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ITQNVC9;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Veri Silindi");



            #endregion

            #region Ürün Güncelleme 

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productID=int.Parse(Console.ReadLine());

            //Console.Write("Güncellencek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ITQNVC9;initial catalog=EgitimKampiDb;integrated security=true"); 
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId",productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı!");

            #endregion

            Console.ReadKey();
        }
    }
}
