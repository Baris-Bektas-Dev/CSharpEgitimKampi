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
        {
            #region ifElse
            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password = Console.ReadLine(); ;
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara"&&country=="türkiye")
            //{
            //    Console.WriteLine("Veriler Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler Yanlış");
            //}

            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //double exam1, exam2, exam3, avarage;
            //string result="Hata!";

            //Console.Write("1. Sınav Sonucunu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Sonucunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Sonucunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav ortalaması: "+avarage);

            //if(avarage > 0&avarage<=50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (avarage > 84 )
            //{
            //    result = "Sonuç Harika";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir ismi giriniz: ");
            //city = Console.ReadLine();

            //if(city=="adana"|city=="ankara"|city=="bursa"|city=="trabzon")
            //{
            //   Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı geçersiz.");
            //}
            //else
            //{
            //  Console.WriteLine("Hoş Geldiniz...");
            //}

            #endregion

            #region modİslemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1%number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: "+result);

            //Console.Write("lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number%2== 0)
            //{
            //    Console.Write("sayı çift");
            //}
            //else
            //{
            //    Console.Write("sayı tek");
            //}

            #endregion

            #region charDegiskenlerİleKararYapıları

            //char team;
            //Console.Write("Lütfen takım sembolü giriniz: ");
            //team= char.Parse(Console.ReadLine());
            //if (team =='g' |team =='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı giriş");
            //}

            #endregion

            #region OrnekProje

            //Console.WriteLine("***C# Eğitim Kampı Restoran***");
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------");
            //Console.WriteLine();
            //Console.Write("Detaylı görmek istediğiniz menüyü seçin(1/5): ");
            //string menu= Console.ReadLine();
            //Console.WriteLine();
            //if (menu == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Yayla");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //}
            //if (menu == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine("1-Köri Soslu Tavuk ve Makarna");
            //    Console.WriteLine("2-Izgara Köfte ve Pilav");
            //    Console.WriteLine("3-Kuru Fasulye ve Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Mantar Sote");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //}
            //if (menu == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine("1-Margaritha");
            //    Console.WriteLine("2-New york");
            //    Console.WriteLine("3-Hawaii");
            //    Console.WriteLine("4-Ton Balıklı");
            //    Console.WriteLine("5-Pastırmalı");
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //}
            //if (menu == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //}
            //   if (menu == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Baklava");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //}
            //Console.Read();

            #endregion

            #region switchCase

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //    switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region switchCaseHesapMakinesi

            //double number1, number2, result;
            //char symbol;
            //Console.Write("1. Sayıyı Giriniz: ");
            //number1=double.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //number2=double.Parse(Console.ReadLine());

            //Console.Write("İşlem Giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+':
            //        result= number1+ number2;
            //        Console.WriteLine("Toplam: "+result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}
            
            #endregion


            Console.Read();
        }
    }
}
