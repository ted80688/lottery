﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {   
            //產生亂數的變數
            Random rand = new Random();
            //產生裝亂數的變數的變數
            int i = 0;
            while (i<10 )
            {
                int n1 = rand.Next(1, 30);
                int n2 = rand.Next(1, 30);
                int n3 = rand.Next(1, 30);
                int n4 = rand.Next(1, 30);
                int n5 = rand.Next(1, 30);
                int n6 = rand.Next(1, 30);
                Console.WriteLine("號碼 : [{0:00}] {1:00} {2:00} {3:00} {4:00} {5:00} {6:00}", i ,n1, n2, n3, n4, n5, n6);
                i++;
            }
  
            //輸出


            //停住畫面
            Console.ReadLine();

        }
    }
}
