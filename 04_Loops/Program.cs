using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region forDöngüsü

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz değeri giriniz");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 0; i <= finishValue; i++) 
            //{
            //    Console.WriteLine("Yaşasın Cumhiriyet");
            //}
            #endregion

            #region forDöngüsüİleKararYapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if  (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i <=10; i++) 

            //{
            //    totalValue += i;

            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i <20; i++)

            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);

            //int totalCount= 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i%7 == 0)
            //    {
            //        totalCount++;
            //    }
            //}
            //Console.WriteLine(totalCount);

            //int bacterium = 1;
            //for (int i = 1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //     Console.WriteLine(i+". Saatin sonunda Bakteri Sayısı: " + bacterium);

            //}



            #endregion

            #region whileDöngüsü

            //int i = 1;

            //while (i<=10)
            //{
            //    Console.WriteLine("Mehaba Döngüler");
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int total = 0;
            //while (i<=10)
            //{
            ////    total +=i;
            ////    i++;
            //}
            //Console.WriteLine(total);

            #endregion

            #region ÖrnekSınavSorusu

            //Console.Write("Sayıyı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds, sum;

            //ones = number % 10;
            //tens = (number %100)/10;
            //hundreds = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum=ones + tens + hundreds;
            //Console.WriteLine(sum);
            #endregion

            #region Loops Tekrar

            //kullanıcıdan alınan sayıları 1 den n'e akdar olacak şekilde toplayan uygulama

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int n =int.Parse(Console.ReadLine());
            //int total=0;
            //string counter = "";
            //for (int i = 1;i < n; i++)
            //{

            //    total += i;
            //    if (i == n) // Son elemansa toplama işareti ekleme
            //    {
            //        counter += i;
            //    }
            //    else // Diğer durumlarda toplama işareti koy
            //    {
            //        counter += i + " + ";
            //    }

            //}
            //Console.WriteLine("Toplam: " + total);
            //Console.WriteLine("(" + counter + " = " + total + ")");


            // kalvyeden girilen sayıyı tahmin etme oyunu

            //Random random= new Random();
            //int randomnumber = random.Next(1,100);

            //Console.Write("Bir sayı tahmin edin: ");
            //int guessnumber = int.Parse(Console.ReadLine());
            //while (guessnumber != randomnumber)
            //{
            //    Console.Write("Bir sayı tahmin edin: ");
            //    guessnumber = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Sayıyı buldunuz.");

            //kullanıcıdan alınan sayının çarpım tablosunu yapan program
            //Console.Write("Bir sayı giriniz: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    int result;
            //    result = i * n;
            //    Console.WriteLine(n+"x"+i+"="+result);

            //}

            //1 den 10 a kadar olan sayıların çarpım tablosu

            //for (int n=1;n<=10;n++) 
            //{

            //    for (int i = 1; i <= 10; i++)
            //    {
            //        int result;
            //        result = i * n;
            //        Console.Write("|"+n + " x " + i + " = " + result + "|  ");

            //    }
            //    Console.WriteLine();
            //}
            // Üçgenler
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i < 6; i++)
            //{
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int j = 1; j <= 5; j++)
            //{
            //    for (int l =5;l>=j;l--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}






            #endregion

            Console.Read();
            
        }
    }
}
