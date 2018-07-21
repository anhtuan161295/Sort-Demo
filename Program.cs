using System;

namespace Sort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] data = { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            // int[] data = { 10, 7, 8, 9, 1, 5 };
            // BubbleSort s = new BubbleSort();
            // InsertionSort s = new InsertionSort();
            // SelectionSort s = new SelectionSort();
            // MergeSort s = new MergeSort();
            QuickSort s = new QuickSort();

            int[] result = s.doSort(data);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                Console.Write(" ");
            }
            Console.WriteLine("");
            Console.WriteLine("Inversion index: " + s.inversionCount);
            Console.WriteLine("Loop count: " + s.loopCount);
        }
    }
}
