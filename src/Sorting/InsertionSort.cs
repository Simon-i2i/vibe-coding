// Insertion Sort Algorithm
// This algorithm builds the sorted array one item at a time by repeatedly inserting the next element into the correct position.
// Time Complexity: Best O(n) (already sorted), Average/Worst O(n^2)
// Pros: Simple, efficient for small or nearly sorted data, in-place, stable
// Cons: Inefficient for large datasets

public class InsertionSort : ISort
{
    public void Sort(int[] arr)
    {
        int n = arr.Length;
        // Start from the second element (first is trivially sorted)
        for (int i = 1; i < n; i++)
        {
            int key = arr[i]; // The element to be inserted
            int j = i - 1;
            // Move elements of arr[0..i-1] that are greater than key to one position ahead
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            // Insert the key at the correct position
            arr[j + 1] = key;
        }
    }
} 