using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            printarray(arr);
            int l = 0;
            int high = arr.Length;
            sort(arr, l, high - 1);
            printarray(arr);

        }

        private static void printarray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        public static void sort(int[] arr, int l, int high)
        {

            if (l < high)
            {
                int value = Partition(arr, l, high);
                sort(arr, l, value - 1);
                sort(arr, value + 1, high);
            }
        }

        private static int Partition(int[] arr, int l, int high)
        {
            int temp;
            int pivot = high;
            int i = l - 1;

            for (int j = l; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            i++;
            return i;
        }
    }
}


