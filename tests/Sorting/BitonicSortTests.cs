using Microsoft.Extensions.DependencyInjection;

public class BitonicSortTests : IClassFixture<SortingTestFixture>
{
    private readonly BitonicSort _sorter;

    public BitonicSortTests(SortingTestFixture fixture)
    {
        _sorter = fixture.ServiceProvider.GetRequiredService<BitonicSort>();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 7, 7, 7, 7 }, new int[] { 7, 7, 7, 7 })]
    [InlineData(new int[] { 42 }, new int[] { 42 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { -3, -1, -7, -4, -5 }, new int[] { -7, -5, -4, -3, -1 })]
    [InlineData(new int[] { 64, 34, 25, 12, 22, 11, 90 }, new int[] { 11, 12, 22, 25, 34, 64, 90 })]
    [InlineData(new int[] { int.MaxValue, int.MinValue, 0 }, new int[] { int.MinValue, 0, int.MaxValue })]
    [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
    [InlineData(new int[] { 1, 0, 1, 0, 1, 0 }, new int[] { 0, 0, 0, 1, 1, 1 })]
    [InlineData(new int[] { 1000000, -1000000, 500, -500 }, new int[] { -1000000, -500, 500, 1000000 })]
    [InlineData(new int[] { 2, 3, 2, 1, 3, 1 }, new int[] { 1, 1, 2, 2, 3, 3 })]
    public void BitonicSort_SortsCorrectly(int[] input, int[] expected)
    {
        int[] arr = (int[])input.Clone();
        _sorter.Sort(arr);
        Assert.Equal(expected, arr);
    }

    [Fact]
    public void BitonicSort_ThrowsOnNonPowerOfTwoLength()
    {
        ISort sorter = new BitonicSort();
        Assert.Throws<ArgumentException>(() => sorter.Sort(new int[] { 1, 2, 3 }));
        Assert.Throws<ArgumentException>(() => sorter.Sort(new int[] { 1, 2, 3, 4, 5 }));
    }
} 