// Counting Sort Algorithm
// Non-comparison sort for non-negative integers. Counts occurrences and reconstructs the sorted array.
// Time Complexity: O(n + k) where k is the range of input
// Pros: Very fast for small integer ranges, stable
// Cons: Only works for integers in a known, small range; uses extra memory

public class CountingSort : ISort
{
    // This implementation only works for non-negative integers
    public void Sort(int[] arr)
    {
        if (arr.Length == 0) return;
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > max) max = arr[i];
        int[] count = new int[max + 1];
        for (int i = 0; i < arr.Length; i++)
            count[arr[i]]++;
        int idx = 0;
        for (int i = 0; i < count.Length; i++)
            while (count[i]-- > 0)
                arr[idx++] = i;
    }
} 