using System.Diagnostics;

namespace AlgorithmAnalysis
{

    /*
     *This class includes some sorting&searching algorithms
     */


    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"[{i}]: {arr[i]} ");
            }
            Console.WriteLine();
        }

        static void BubbleSort(int[] arr)
        {
            int tmp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j-1] > arr[j])
                    {
                        tmp = arr[j - 1];
                        arr[j-1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        static void SelectionSort(int[] arr)
        {
            int tmp;
            int min;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                tmp = arr[i];
                arr[i] = arr[min];
                arr[min] = tmp;
            }
        }
    }
}
