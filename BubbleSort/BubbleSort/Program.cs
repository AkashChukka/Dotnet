using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] arr = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        long beforeMemory = GC.GetTotalMemory(true);

        Stopwatch stopwatch = Stopwatch.StartNew();

        BubbleSort(arr);

        stopwatch.Stop();

        long afterMemory = GC.GetTotalMemory(true);

        Console.WriteLine("\nSorted Array:");
        PrintArray(arr);

        Console.WriteLine($"\nTimed run: {arr.Length} elements");
        Console.WriteLine($"Elapsed: {stopwatch.Elapsed.TotalMilliseconds:F3} ms");
        Console.WriteLine($"Allocated: {afterMemory - beforeMemory} bytes");
        Console.WriteLine($"Valid sort: {IsSorted(arr)}");
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static bool IsSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
                return false;
        }
        return true;
    }
}