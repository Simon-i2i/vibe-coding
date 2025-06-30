// Heap Sort Algorithm
// Builds a max heap and repeatedly extracts the maximum element to sort the array.
// Time Complexity: O(n log n) for all cases
// Pros: In-place, no extra memory needed
// Cons: Not stable, slower than quick/merge in practice

public class HeapSort : ISort
{
    public void Sort(int[] arr)
    {
        int n = arr.Length;
        // Build max heap
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);
        // Extract elements from heap
        for (int i = n - 1; i > 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            Heapify(arr, i, 0);
        }
    }

    private void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int l = 2 * i + 1;
        int r = 2 * i + 2;
        if (l < n && arr[l] > arr[largest]) largest = l;
        if (r < n && arr[r] > arr[largest]) largest = r;
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
            Heapify(arr, n, largest);
        }
    }
} 