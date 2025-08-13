using System.Collections.Generic;
using Tests;
using Xunit;

using Sear
namespace BinarySearch.Tests
{
    public class AlgorithomTests
    {
        [Fact]
        public void BinarySearch_ValuePresent_ReturnsCorrectIndex()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int? result = Binary_Search(numbers, 5);
            Assert.Equal(4, result);
        }

        [Fact]
        public void BinarySearch_ValueNotPresent_ReturnsNull()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int? result = BinarySearch(numbers, 15);
            Assert.Null(result);
        }

        [Fact]
        public void BinarySearch_EmptyList_ReturnsNull()
        {
            var emptyList = new List<int>();
            int? result = BinarySearch(emptyList, 1);
            Assert.Null(result);
        }

        [Fact]
        public void BinarySearch_SingleElementList_ValuePresent_ReturnsZero()
        {
            var singleList = new List<int> { 42 };
            int? result = Algorithom.BinarySearch(singleList, 42);
            Assert.Equal(0, result);
        }

        [Fact]
        public void BinarySearch_SingleElementList_ValueAbsent_ReturnsNull()
        {
            var singleList = new List<int> { 42 };
            int? result = BinarySearch(singleList, 99);
            Assert.Null(result);
        }

        //private int? BinarySearch(List<int> numbers, int target)
        //{
        //    int left = 0, right = numbers.Count - 1;
        //    while (left <= right)
        //    {
        //        int mid = left + (right - left) / 2;
        //        if (numbers[mid] == target)
        //            return mid;
        //        if (numbers[mid] < target)
        //            left = mid + 1;
        //        else
        //            right = mid - 1;
        //    }
        //    return null;
        //}
    }
}