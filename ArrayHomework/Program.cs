using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //mimimum numbers from 2D array...

            //int[,] arr = new int[3, 4]
            //{
            //    {1,3,2,4},
            //    {5,7,6,8},
            //    {8,9,10,11},
            //};

            //for (int i=0; i<arr.GetLength(0); i++)
            //{
            //    int minVal= arr[i,0];
            //    for (int j = 0; j < arr.GetLength(1); j++)

            //        if (minVal > arr[i, j])
            //        {
            //            minVal = arr[i,j];
            //        }
            //    Console.WriteLine(minVal);
            //    }

            //}

            //maximum numbers of 2D array
            //int[,] arr = new int[3, 4]
            //{
            //    {1,8,3,4},
            //    {5,6,9,8},
            //    {7,14,9,10},
            //};

            //for(int i=0; i<arr.GetLength(0); i++)
            //{
            //    int maxVal = arr[0,0];

            //    for(int j=0; j < arr.GetLength(1); j++)
            //    {
            //        if (maxVal < arr[i, j])
            //        {
            //            maxVal = arr[i, j];
            //        }
            //    }

            //    Console.WriteLine(maxVal);
            //}

            //duplicate Array....

            //int[] arr = { 1, 2, 3, 4, 1, 6, 3, 4 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            Console.WriteLine(arr[j]);
            //    }
            //}


            //find Dupliplicate / remove element remove number....
            int[] arr = new int[] { 22, 11, 45, 78, 13 };
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    arr[i] = 0;
                    break;
                }
            }
            foreach (var item in arr)
            {
                    Console.WriteLine(item);
            }
        }
            //    int i = 0, j = 0;
            //    int[] arr1 = new int[] { 1, 2, 3, 4, 2, 5 ,1};

            //    for (i = 0; i < arr1.Length; i++)
            //    {
            //        for (j = 0; j < arr1.Length; j++)
            //        {
            //            if (i == j)
            //             continue;
            //            if (arr1[i] == arr1[j])

            //             break;
            //        }
            //        if (arr1.Length == j)
            //        {
            //           Console.WriteLine(arr1[i] + " ");
            //        }
            //    }

            //}

            //minimum number...

            //int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int mini= numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < mini)
            //    {

            //        mini = numbers[i];
            //    }
            //}
            //Console.WriteLine("minimum number is:" + mini);

            //maximum num...

            //int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int max = numbers[3];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {

            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine("maximum number is:" + max);
            //}
        
    }
}
    


