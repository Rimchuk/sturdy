using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 3, 7, 1, 5, 4, 8, 2, 6, 0 };
            foreach (int ar in arr)
                Console.Write(ar + " ");
            Console.WriteLine("\nСортировка");
            Sort(arr, 0, arr.Length - 1);
            foreach (int ar in arr)
                Console.Write(ar + " ");

        }

        static void Sort(int[] arr, int left, int right)
        {
            //i и j нужны для цикла
            int i = left;
            int j = right;
            int x = arr[(left + right) / 2]; //Опорная arr[(last - first) / 2 + first];
                                             //Цикл сортировка

            while (i <= j)
            {
                //Деление на меньше и больше опорного
                while (arr[i] < x) i++;
                while (arr[j] > x) j--;
                //Если i<=j:
                if (i <= j)
                {
                    //меняем значение элемонтов
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;

                }

            }
            //Рекурсия
            if (left < j) Sort(arr, left, j);
            if (i < right) Sort(arr, i, right);
        }

    }
}
