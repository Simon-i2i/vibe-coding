using System;
using Xunit;

public class BitonicSortTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })] // Already sorted
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })] // Reverse sorted
    [InlineData(new int[] { 7, 7, 7, 7 }, new int[] { 7, 7, 7, 7 })] // All equal
    [InlineData(new int[] { 42, 0, 42, 0 }, new int[] { 0, 0, 42, 42 })] // Duplicates and zeros
    [InlineData(new int[] { 0, 1, 0, 1 }, new int[] { 0, 0, 1, 1 })] // Zeros and ones
    [InlineData(new int[] { 8, 4, 2, 6, 1, 3, 5, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })] // Typical unsorted
    [InlineData(new int[] { 16, 8, 4, 2, 1, 3, 5, 7 }, new int[] { 1, 2, 3, 4, 5, 7, 8, 16 })] // Large/small numbers
    public void BitonicSort_SortsCorrectly(int[] input, int[] expected)
    {
        int[] arr = (int[])input.Clone();
        ISort sorter = new BitonicSort();
        sorter.Sort(arr);
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