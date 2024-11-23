using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region DoubleDegiskenler

            //double number;
            //number = 4.75;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 59.95;
            //orangePrice = 39.95;
            //strawberryPrice = 120.75;
            //patatoPrice = 13.95;
            //tomatoPrice=62.90;

            //Console.WriteLine("----Elma  Birim Fiyatı: "+applePrice+"₺");
            //Console.WriteLine("----Portakal  Birim Fiyatı: " +orangePrice+"₺");
            //Console.WriteLine("----Çilek  Birim Fiyatı: " +strawberryPrice+"₺");
            //Console.WriteLine("----Patates  Birim Fiyatı: " +patatoPrice+"₺");
            //Console.WriteLine("----Domates  Birim Fiyatı: " +tomatoPrice+"₺");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, patatoGram, tomatoGram;
            //appleGram =1.245;
            //orangeGram =2.650;
            //strawGram =0.750;
            //patatoGram =4.859;
            //tomatoGram =3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: "+applePrice+"₺ - Gramaj: "+appleGram+" - Toplam Tutar: "+appleTotalPrice+"₺");
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: "+orangePrice+"₺ - Gramaj: "+orangeGram+" - Toplam Tutar: "+orangeTotalPrice+"₺");
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat: "+strawberryPrice+"₺ - Gramaj: "+strawGram+" - Toplam Tutar: "+strawTotalPrice+"₺");
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: "+patatoPrice+"₺ - Gramaj: " +patatoGram+" - Toplam Tutar: "+patatoTotalPrice+"₺");
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: "+tomatoPrice+"₺ - Gramaj: " +tomatoGram+" - Toplam Tutar: "+tomatoTotalPrice+"₺");
            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawTotalPrice+patatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice);

            #endregion

            #region charDegiskenler

            //char symbol= 'A';
            //Console.WriteLine(symbol);

            #endregion

            #region KlavyedenVeriGirisleriStringDegiskenler

            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Yolcu Kimlik Numarası: "+passangerIdentityNumber+ " Yolcu Ad ve Soyadı: "+passangerName+" "+passangerSurname+" "+passangerDistrict+" / "+passangerCity+" "+passangerAge);

            #endregion

            #region KlavyedenTamSayıGirisileriVeDonusumler

            //int shoesPrice, computersPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computersPrice =20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computersCount, chairCount, tvCount;

            //Console.Write("Lürfen aldığınız ayyakabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lürfen aldığınız bilgisayar sayısını giriniz: ");
            //computersCount = int.Parse(Console.ReadLine());
            //Console.Write("Lürfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lürfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computersCount*computersPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Topam tutar: "+totalPrice);

            #endregion

            #region KlavyedenOndalıklıSayıİşlemleri

            //double exam1,exam2,exam3,avarage;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 =double.Parse(Console.ReadLine());

            //avarage = exam1 + exam2 + exam3 / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalaması: " + avarage);

            #endregion

            #region KlavyedenKarakterGirişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Giriniz: ");
            //gender =char.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion

            Console.ReadKey();
        }
    }
}
