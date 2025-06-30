// Bitonic Sort Algorithm (Educational Version)
// Parallel sorting algorithm, works for arrays of length that is a power of two.
// Time Complexity: O(log^2 n)
// Pros: Highly parallelizable, used in hardware
// Cons: Only for power-of-two lengths, not efficient for general use

public class BitonicSort : ISort
{
    public void Sort(int[] arr)
    {
        if (arr.Length == 0) return;
        if ((arr.Length & (arr.Length - 1)) != 0)
            throw new ArgumentException("Bitonic sort only works for arrays of length that is a power of two.");
        BitonicSortRecursive(arr, 0, arr.Length, true);
    }

    private void BitonicSortRecursive(int[] arr, int low, int cnt, bool dir)
    {
        if (cnt > 1)
        {
            int k = cnt / 2;
            BitonicSortRecursive(arr, low, k, true);
            BitonicSortRecursive(arr, low + k, k, false);
            BitonicMerge(arr, low, cnt, dir);
        }
    }

    private void BitonicMerge(int[] arr, int low, int cnt, bool dir)
    {
        if (cnt > 1)
        {
            int k = cnt / 2;
            for (int i = low; i < low + k; i++)
            {
                if ((dir && arr[i] > arr[i + k]) || (!dir && arr[i] < arr[i + k]))
                {
                    int temp = arr[i];
                    arr[i] = arr[i + k];
                    arr[i + k] = temp;
                }
            }
            BitonicMerge(arr, low, k, dir);
            BitonicMerge(arr, low + k, k, dir);
        }
    }
} 