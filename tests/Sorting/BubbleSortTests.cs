using System;
using Xunit;
using Sorting;

namespace Sorting.Tests
{
    public class BubbleSortTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })] // Already sorted
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })] // Reverse sorted
        [InlineData(new int[] { 7, 7, 7, 7 }, new int[] { 7, 7, 7, 7 })] // All equal
        [InlineData(new int[] { 42 }, new int[] { 42 })] // Single element
        [InlineData(new int[] { }, new int[] { })] // Empty array
        [InlineData(new int[] { -3, -1, -7, -4, -5 }, new int[] { -7, -5, -4, -3, -1 })] // Negative numbers
        [InlineData(new int[] { 64, 34, 25, 12, 22, 11, 90 }, new int[] { 11, 12, 22, 25, 34, 64, 90 })] // Typical unsorted
        public void BubbleSort_SortsCorrectly(int[] input, int[] expected)
        {
            int[] arr = (int[])input.Clone();
            BubbleSort.Sort(arr);
            Assert.Equal(expected, arr);
        }
    }
}