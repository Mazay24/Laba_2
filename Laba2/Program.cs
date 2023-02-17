﻿using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rand = new Random();
            Console.Write("Первоначальный массив: ");
            for (int qq = 0; qq < 5; qq++)
            {
                array[qq] = rand.Next(1, 6);
                Console.Write(array[qq] + " , ");
            }


            for (int i = 1; i < array.Length; i++)
            {
                int k = array[i];
                int zxc = i - 1;

                while (zxc >= 0 && array[zxc] > k)
                {
                    array[zxc + 1] = array[zxc];
                    zxc--;
                }
                array[zxc + 1] = k;
            }

            Console.WriteLine();
            Console.Write("Полученный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " , ");
            }


        }
    }
}
        
    

