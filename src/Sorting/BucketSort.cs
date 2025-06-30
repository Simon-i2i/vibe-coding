// Bucket Sort Algorithm
// Distributes elements into buckets, sorts each bucket, and concatenates them.
// Time Complexity: O(n + k) best, O(n^2) worst (depends on distribution and bucket sort)
// Pros: Fast for uniformly distributed data, stable if bucket sort is stable
// Cons: Not good for non-uniform data, needs extra memory, only for known range

public class BucketSort : ISort
{
    // This implementation only works for non-negative integers in a small range
    public void Sort(int[] arr)
    {
        if (arr.Length == 0) return;
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > max) max = arr[i];
        int bucketCount = Math.Max(1, arr.Length / 2);
        var buckets = new List<int>[bucketCount];
        for (int i = 0; i < bucketCount; i++)
            buckets[i] = new List<int>();
        foreach (var num in arr)
        {
            int bucketIdx = (int)((long)num * bucketCount / (max + 1));
            buckets[bucketIdx].Add(num);
        }
        int idx = 0;
        foreach (var bucket in buckets)
        {
            bucket.Sort(); // Using List.Sort (insertion sort for small lists)
            foreach (var num in bucket)
                arr[idx++] = num;
        }
    }
}