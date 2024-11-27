using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //siyah, kırmızı, yeşil, mavi, beyaz
            //değişken türü[] diziadı= new değişkenTürü[elemansayısı]
            //---------------------------------------------------------

            //string[] colors = new string[4];
            //colors[0]= "Kırmızı";
            //colors[1]= "Siyah";
            //colors[2]= "Sarı";
            //colors[3]= "Mor";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "İstanbul";
            //cities[1] = "Berlin";
            //cities[2] = "Tokyo";
            //cities[3] = "New York";
            //cities[4] = "Londra";

            //Console.WriteLine(cities[5]);

            //int[] numbers=new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[4]);

            //string[] cities = {"Roma","Madrid","Frankfurt","Paris" };
            //Console.WriteLine(cities[3]);



            #endregion

            #region Dizideki Tüm Elemnanları Listeleme
            //string[] colors = {"kırmızı","mavi","sarı","pembe","yeşil","beyaz","siyah"};
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c','*','/' };
            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //Dizideki en büyük elemanı bulan program

            //int[] numbers = { 12, 23, 64, 77, 223, 0, 14, 666, 9 };
            //int MaxValue = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > MaxValue)
            //    {
            //        MaxValue = numbers[i];
            //    }
            //}
            //Console.WriteLine("en büyük değer: " + MaxValue);

            //Array'deki item sayısını yazdırma

            //string[] persons = { "ali", "ahmet", "sait", "rıza" };
            //Console.WriteLine(persons.Length+" kişi var.");

            //int[] numbers = { 1, 2, 8, 5, 4, 7, 9, 3, 6 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 2, 8, 5, 4, 7, 9, 3, 6 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotlar 

            //Dizideki itemin kaçıncı sırada olduğunu yazan program

            //string[] customers = { "ali", "ayşe", "rıza", "Serdar", "recep", "kenan", "yusuf" };
            //int index = Array.IndexOf(customers, "rıza");
            //Consol e.WriteLine(index);

            //Dizinin en büyük ve küçük  sayılarını yazdıran uygulama

            //int[] numbers = { 214, 223, 422, 617, 615, 345, 123, 658, 344, 678, 346, 753, 951 };

            //Console.WriteLine("en büyük sayı: " + numbers.Max() );
            //Console.WriteLine("en Küçük sayı: " + numbers.Min() );


            #endregion

            #region Kullanıcıdan Değer Alma

            kullanıcının girdiği şehirleri yazan program

            string[] cities = new string[5];
            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"lürfen {i + 1}. şehiri giriniz: ");
                cities[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }



            //int[] numbers = {10,20,30,40,50};
            //int sum = 0;
            //for (int i = 0;i<numbers.Length;i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers = { 11, 42, 33, 44, 55, 66, 77, 88, 99 };
            //Console.WriteLine("çift sayılar");
            //Console.WriteLine("------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("tek sayılar");
            //Console.WriteLine("------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}




            #endregion


            Console.Read();
        }
    }
}
