using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //foreach (1;2;3;4)

            //    1:Değişken Türü
            //    2:Değişken Adı
            //    3:In
            //    4:List,Collection,Array

            //string[] cities = { "tokyo", "londra", "Washington DC", "Berlin" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24 };

            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            //int total= 0;

            //foreach(int i in numbers)

            //{
            //total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Selamlar";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması


            //// klavyeden öğrenci sayısı alınacak, öğrencilerin isimleri alınacaki sınav notları alınıp ortalamaları hesaplanacak
            //// Kendi Çözüm Denemem
            //Console.Write("Öğrenci Sayısı Giriniz: ");
            //int numberOfStudents = int.Parse(Console.ReadLine());
            //string[] namesOfStudents= new string[numberOfStudents];
            //int[] exam1 = new int[numberOfStudents];
            //int[] exam2 = new int[numberOfStudents];
            //int[] exam3 = new int[numberOfStudents];
            //int[] avg = new int[numberOfStudents];
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");

            //for (int i = 0; i < namesOfStudents.Length; i++)
            //{
            //    Console.Write($"Lürfen {i + 1}. Öğrenci Adı Giriniz: ");
            //    namesOfStudents[i] = Console.ReadLine();
            
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0; i < namesOfStudents.Length; i++)
            //{
            //    Console.Write($"Lürfen {i + 1}. Öğrencinin 1. sınav sonucunu giriniz: ");
            //    exam1[i] =int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0; i < namesOfStudents.Length; i++)
            //{
            //    Console.Write($"Lürfen {i + 1}. Öğrencinin 2. sınav sonucunu giriniz: ");
            //    exam2[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0; i < namesOfStudents.Length; i++)
            //{
            //    Console.Write($"Lürfen {i + 1}. Öğrencinin 3. sınav sonucunu giriniz: ");
            //    exam3[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0;i < namesOfStudents.Length;i++)
            //{
            //    avg[i] =( exam1[i] + exam2[i] + exam3[i])/3;
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0; i < namesOfStudents.Length; i++)
            //{
            //    Console.WriteLine(namesOfStudents[i]+" İsimli Öğrencinin 1. Sınavı: " + exam1[i] +" 2. Sınavı: " + exam2[i]+" 3. Sınavı: " + exam3[i]+" Puan Ortalaması: "+avg[i]);

            //}




            // //Murat Hocanın uygulaması
            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki Öğrenci Sayısını alan kod
            //Console.WriteLine("---------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentcount =int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------");

            //Console.WriteLine() ;
            //Console.WriteLine() ;
            //Console.WriteLine() ;
            //string[] studentNames = new string[studentcount];
            //double[] studentExamAvg = new double[studentcount];

            //for (int i = 0;i<studentcount;i++)
            //{
            //    Console.Write($"{i + 1}. Öğrencinin adını giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult =0;

            //    //her öğrenci için 3 sınav notu girişi


            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} İsimli Öğrencinin {j+1}. sınav notunu giriniz: ");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult += value; // notların toplanması
            //        Console.WriteLine();

            //    }
            //    studentExamAvg[i] = totalExamResult/3;

            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0; i<studentcount;i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin not ortalaması: {studentExamAvg[i]}");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");

            //    }

            //}



            #endregion


            Console.Read();

        }
    }
}
