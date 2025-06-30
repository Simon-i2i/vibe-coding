// Radix Sort Algorithm
// Sorts numbers digit by digit using a stable sort (counting sort) as a subroutine.
// Time Complexity: O(nk) where k is the number of digits
// Pros: Fast for integers, not comparison-based
// Cons: Only works for integers, needs extra memory

public class RadixSort : ISort
{
    // This implementation only works for non-negative integers
    public void Sort(int[] arr)
    {
        if (arr.Length == 0) return;
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > max) max = arr[i];
        for (int exp = 1; max / exp > 0; exp *= 10)
            CountingSortByDigit(arr, exp);
    }

    private void CountingSortByDigit(int[] arr, int exp)
    {
        int n = arr.Length;
        int[] output = new int[n];
        int[] count = new int[10];
        for (int i = 0; i < n; i++)
            count[(arr[i] / exp) % 10]++;
        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (arr[i] / exp) % 10;
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }
        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }
} 