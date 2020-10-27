using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[] array)
        {
            // TODO #1. Implement the method using a loop statements.
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), "array is null");
            }

            int smallest;
            for (int i = 0; i < array.Length - 1; i++)
            {
                smallest = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }

                int temp = array[i];
                array[i] = array[smallest];
                array[smallest] = temp;
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[] array)
        {
            // TODO #2. Implement the method using recursion algorithm.
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), "array is null");
            }

            Sort(array, 0, 1, 0);
        }

        public static void Sort(this int [] array, int i, int j, int smallest)
        {
            if (i < array.Length - 1)
            {
                if (j < array.Length)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                        Sort(array, i, ++j, smallest);
                    }
                    else
                    {
                        Sort(array, i, ++j, smallest);
                    }
                }
                else
                {
                    int temp = array[i];
                    array[i] = array[smallest];
                    array[smallest] = temp;
                    i++;
                    Sort(array, i, i + 1, i);
                }
            }
            else
            {
                return;
            }
        }
    }
}
