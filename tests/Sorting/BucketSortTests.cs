using Microsoft.Extensions.DependencyInjection;

public class BucketSortTests : IClassFixture<SortingTestFixture>
{
    private readonly BucketSort _sorter;

    public BucketSortTests(SortingTestFixture fixture)
    {
        _sorter = fixture.ServiceProvider.GetRequiredService<BucketSort>();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })] // Already sorted
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })] // Reverse sorted
    [InlineData(new int[] { 7, 7, 7, 7 }, new int[] { 7, 7, 7, 7 })] // All equal
    [InlineData(new int[] { 42 }, new int[] { 42 })] // Single element
    [InlineData(new int[] { }, new int[] { })] // Empty array
    [InlineData(new int[] { 0, 1, 0, 1 }, new int[] { 0, 0, 1, 1 })] // Zeros and ones
    [InlineData(new int[] { 64, 34, 25, 12, 22, 11, 90 }, new int[] { 11, 12, 22, 25, 34, 64, 90 })] // Typical unsorted
    [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })] // All zeros
    [InlineData(new int[] { 1, 0, 1, 0, 1, 0 }, new int[] { 0, 0, 0, 1, 1, 1 })] // Alternating values
    [InlineData(new int[] { 100, 0, 50, 0 }, new int[] { 0, 0, 50, 100 })] // Large/small numbers
    [InlineData(new int[] { 2, 3, 2, 1, 3, 1 }, new int[] { 1, 1, 2, 2, 3, 3 })] // Duplicates
    public void BucketSort_SortsCorrectly(int[] input, int[] expected)
    {
        int[] arr = (int[])input.Clone();
        _sorter.Sort(arr);
        Assert.Equal(expected, arr);
    }
} 