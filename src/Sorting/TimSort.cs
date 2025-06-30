// TimSort Algorithm (Educational Version)
// Hybrid of insertion sort and merge sort. Used in Python/Java standard sort.
// Time Complexity: O(n log n) average/worst, O(n) best
// Pros: Very fast for real-world data, stable
// Cons: Complex, uses extra memory

public class TimSort : ISort
{
    private const int RUN = 32; // Small run size for educational purposes

    public void Sort(int[] arr)
    {
        int n = arr.Length;
        // Sort small runs with insertion sort
        for (int i = 0; i < n; i += RUN)
            InsertionSort(arr, i, Math.Min((i + RUN - 1), (n - 1)));
        // Merge runs
        for (int size = RUN; size < n; size = 2 * size)
        {
            for (int left = 0; left < n; left += 2 * size)
            {
                int mid = left + size - 1;
                int right = Math.Min((left + 2 * size - 1), (n - 1));
                if (mid < right)
                    Merge(arr, left, mid, right);
            }
        }
    }

    private void InsertionSort(int[] arr, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int temp = arr[i];
            int j = i - 1;
            while (j >= left && arr[j] > temp)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = temp;
        }
    }

    private void Merge(int[] arr, int l, int m, int r)
    {
        int len1 = m - l + 1, len2 = r - m;
        int[] left = new int[len1];
        int[] right = new int[len2];
        Array.Copy(arr, l, left, 0, len1);
        Array.Copy(arr, m + 1, right, 0, len2);
        int i = 0, j = 0, k = l;
        while (i < len1 && j < len2)
            arr[k++] = (left[i] <= right[j]) ? left[i++] : right[j++];
        while (i < len1)
            arr[k++] = left[i++];
        while (j < len2)
            arr[k++] = right[j++];
    }
} 