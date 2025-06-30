// Merge Sort Algorithm
// A divide-and-conquer algorithm that splits the array, sorts each half, and merges them.
// Time Complexity: O(n log n) for all cases
// Pros: Stable, always O(n log n), good for linked lists
// Cons: Uses extra memory (O(n)), slower for small arrays

public class MergeSort : ISort
{
    public void Sort(int[] arr)
    {
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