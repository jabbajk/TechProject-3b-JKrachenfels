/* 
  Assignment: Tech Project 3b
  Author: Jared Krachenfels
  Class: ISM 3400
  Date: 9/24/2020
 */
using System;

namespace TechProject_3b_JKrachenfels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This array will iterate by itself:");

            // Below is automatic array input
            int[] numbers2 = new int[26];
            int pop_array = 1;
            // For loop used to iterate through automatic array without user input
            for(int i=1; i < 26; i++)
            {
                numbers2[i] = pop_array;
                Console.WriteLine("Element value = " + i + " ");
            }

            // Below is alternative array for maunual input of information
            /* 
             int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
             Console.WriteLine("Element value = " + i + " ");

            // For each loop to interate through manual array
            foreach(int i in numbers)
             {
             Console.WriteLine("Element value = " + i + " ");
             }
            */
        } // End of Main
    } // End of Class
} // End of Namespace
