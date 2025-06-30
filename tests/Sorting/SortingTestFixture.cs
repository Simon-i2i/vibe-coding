using Microsoft.Extensions.DependencyInjection;

public class SortingTestFixture : IDisposable
{
    public ServiceProvider ServiceProvider { get; }

    public SortingTestFixture()
    {
        var services = new ServiceCollection();
        services.AddTransient<BubbleSort>();
        services.AddTransient<SelectionSort>();
        services.AddTransient<InsertionSort>();
        services.AddTransient<ShellSort>();
        services.AddTransient<MergeSort>();
        services.AddTransient<QuickSort>();
        services.AddTransient<HeapSort>();
        services.AddTransient<CountingSort>();
        services.AddTransient<BucketSort>();
        services.AddTransient<RadixSort>();
        services.AddTransient<TimSort>();
        services.AddTransient<ExternalMergeSort>();
        services.AddTransient<BitonicSort>();
        ServiceProvider = services.BuildServiceProvider();
    }

    public void Dispose()
    {
        ServiceProvider.Dispose();
    }
} 