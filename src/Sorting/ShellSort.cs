// Shell Sort Algorithm
// Improves on insertion sort by allowing exchanges of far-apart elements.
// Time Complexity: Best O(n log n), Worst O(n^2) (depends on gap sequence)
// Pros: Simple, in-place, faster than insertion/bubble/selection for medium arrays
// Cons: Not stable, performance depends on gap sequence

public class ShellSort : ISort
{
    public void Sort(int[] arr)
    {
        int n = arr.Length;
        // Start with a big gap, then reduce the gap
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            // Do a gapped insertion sort for this gap size
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j;
                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                {
                    arr[j] = arr[j - gap];
                }
                arr[j] = temp;
            }
        }
    }
} 