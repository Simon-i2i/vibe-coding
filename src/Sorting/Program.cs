using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<SortBenchmark<BubbleSort>>();
        BenchmarkRunner.Run<SortBenchmark<SelectionSort>>();
        BenchmarkRunner.Run<SortBenchmark<InsertionSort>>();
        BenchmarkRunner.Run<SortBenchmark<ShellSort>>();
        BenchmarkRunner.Run<SortBenchmark<MergeSort>>();
        BenchmarkRunner.Run<SortBenchmark<QuickSort>>();
        BenchmarkRunner.Run<SortBenchmark<HeapSort>>();
        BenchmarkRunner.Run<SortBenchmark<CountingSort>>();
        BenchmarkRunner.Run<SortBenchmark<BucketSort>>();
        BenchmarkRunner.Run<SortBenchmark<RadixSort>>();
        BenchmarkRunner.Run<SortBenchmark<TimSort>>();
        BenchmarkRunner.Run<SortBenchmark<ExternalMergeSort>>();
        BenchmarkRunner.Run<SortBenchmark<BitonicSort>>();
    }
}