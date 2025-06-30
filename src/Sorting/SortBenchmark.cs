using System;
using BenchmarkDotNet.Attributes;

// Generic benchmark class for any ISort implementation
public class SortBenchmark<T> where T : ISort, new()
{
    private int[] data;
    private readonly ISort sorter = new T();

    [GlobalSetup]
    public void Setup()
    {
        // Example: 100 random integers
        var rand = new Random(42);
        data = new int[100];
        for (int i = 0; i < data.Length; i++)
            data[i] = rand.Next(0, 1000);
    }

    [Benchmark]
    public void Sort_Benchmark()
    {
        int[] arr = (int[])data.Clone();
        sorter.Sort(arr);
    }
}