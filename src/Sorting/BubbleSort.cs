using System;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

// Bubble Sort Algorithm
// This is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in the wrong order.
// Time Complexity: Best O(n), Average/Worst O(n^2)
// Pros: Very easy to understand and implement
// Cons: Very slow for large datasets

public class BubbleSort : ISort
{
    // Instance method to perform Bubble Sort on an integer array
    public void Sort(int[] arr)
    {
        int n = arr.Length;
        // Outer loop for each pass
        for (int i = 0; i < n - 1; i++)
        {
            // Flag to check if any swapping happened in this pass
            bool swapped = false;
            // Inner loop for comparing adjacent elements
            for (int j = 0; j < n - i - 1; j++)
            {
                // If the current element is greater than the next, swap them
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            // If no two elements were swapped in the inner loop, the array is sorted
            if (!swapped)
                break;
        }
    }
}