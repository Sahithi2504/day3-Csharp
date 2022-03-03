using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {        //passing an array to a method
             //static void Result(int[] arr)
             //{
             //    for (int i = 0; i < arr.Length; i++)
             //    {
             //        Console.WriteLine("Array Elements: " + arr[i]);
             //    }
             //}
             //public static void Main()
             //{
             //    int[] arr = { 1, 2, 3, 4, 5 };
             //    Result(arr);
             //    Console.ReadLine();
             //}

        //  ---------------------Jagged array with 2D-----

        //    public void Assign(int m, int n, int[,] arr)
        //    {
        //        for (int i = 0; i < m; i++)
        //        {
        //            for (int j = 0; j < n; j++)
        //            {
        //                arr[i, j] = i + j;

        //            }

        //        }
        //    }

        //    //Program to pass the 2D array to a function in C

        //public static void Main()
        //    {
        //        Program p = new Program();
        //        int m = 5;
        //        int n = 5;

        //        int[,] arr = new int[m, n];

        //        p.Assign(m, n, arr);

        //        // print 2D array
        //        for (int i = 0; i < m; i++)
        //        {
        //            for (int j = 0; j < n; j++)
        //            {
        //                Console.Write(arr[i, j]);
        //            }
        //            Console.WriteLine("\n");
        //            Console.ReadLine();
        //        }
        //    }

        //----ArrayList------
        static void Main(string[] args)
        {
            var data = new ArrayList();
            data.Add("Demo");
            data.Add(1);
            data.Add(5);
            data.Add(26);
            data.Add(56.4);
            data.Add(32);
            data.Remove(5);
            foreach (object obj in data)
            {
                Console.WriteLine(obj);
                Console.ReadLine();
            }
        }

    }
}
