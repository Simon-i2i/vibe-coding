// Quick Sort Algorithm
// A divide-and-conquer algorithm that partitions the array and sorts the partitions recursively.
// Time Complexity: Best/Average O(n log n), Worst O(n^2)
// Pros: In-place, fast in practice
// Cons: Not stable, worst case O(n^2)

public class QuickSort : ISort
{
    public void Sort(int[] arr)
    {
        QuickSortRecursive(arr, 0, arr.Length - 1);
    }

    private void QuickSortRecursive(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSortRecursive(arr, low, pi - 1);
            QuickSortRecursive(arr, pi + 1, high);
        }
    }

    private int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;
        return i + 1;
    }
} 