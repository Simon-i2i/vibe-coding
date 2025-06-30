// Selection Sort Algorithm
// This algorithm sorts an array by repeatedly finding the minimum element from the unsorted part and putting it at the beginning.
// Time Complexity: O(n^2) for all cases
// Pros: Simple to understand and implement, does not require extra memory
// Cons: Inefficient for large datasets, not stable

public class SelectionSort : ISort
{
    public void Sort(int[] arr)
    {
        int n = arr.Length;
        // Move the boundary of the unsorted subarray one by one
        for (int i = 0; i < n - 1; i++)
        {
            // Assume the minimum is the first element
            int minIdx = i;
            // Find the minimum element in the unsorted part
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIdx])
                {
                    minIdx = j;
                }
            }
            // Swap the found minimum element with the first element of the unsorted part
            if (minIdx != i)
            {
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
        }
    }
} 