﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 Tane Yıldız Oluşturma

            //for (int i=1;i <= 10;i++)
            //{
            //    Console.WriteLine("*");

            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1;i<=10;i++)
            // {
            //     Console.Write("*");
            // }

            #endregion

            #region Alt alta 10 tane her satırda 10 yıldız olacak şekilde oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}


            #endregion

            #region Dik Üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters Dik Üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Dik Ve Ters Dik Üçgen

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region baklava Dilim
            //int n = 5;
            ////üst kısım
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //// alt kısım
            //for (int i = n-1; i>= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k<=2*i-1 ;k++)
            //    {

            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Piramit

            //int n = 5; 
            //for (int i = 1; i <= n; i++) 
            //{
            //    for (int j = 1; j <= n - i; j++) 
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= (2 * i - 1); k++) 
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}





            #endregion

            #region Ters Piramit

            //int n = 5; 

            //for (int i = 0; i < n; i++) 
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < (2 * (n - i) - 1); k++)
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
