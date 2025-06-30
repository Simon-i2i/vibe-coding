// External Merge Sort Algorithm (Simulated)
// Used for sorting data that doesn't fit in memory (big data). Here, we simulate it in-memory.
// Time Complexity: O(n log n)
// Pros: Can handle huge datasets (with real file I/O)
// Cons: Slower due to disk I/O (not shown here), complex

public class ExternalMergeSort : ISort
{
    public void Sort(int[] arr)
    {
        // In a real external sort, data would be split into sorted chunks on disk, then merged.
        // Here, we just use merge sort for demonstration.
        if (arr.Length <= 1) return;
        MergeSortRecursive(arr, 0, arr.Length - 1);
    }

    private void MergeSortRecursive(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortRecursive(arr, left, mid);
            MergeSortRecursive(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    private void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] L = new int[n1];
        int[] R = new int[n2];
        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);
        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j]) arr[k++] = L[i++];
            else arr[k++] = R[j++];
        }
        while (i < n1) arr[k++] = L[i++];
        while (j < n2) arr[k++] = R[j++];
    }
} 