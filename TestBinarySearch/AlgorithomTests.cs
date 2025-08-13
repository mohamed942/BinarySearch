using Xunit;
using BinarySearch;

namespace TestBinarySearch
{
    public class AlgorithomTests
    {
        [Fact]
        public void BinarySearch_ValuePresent_ReturnsCorrectIndex()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int? result = Algorithm.BinarySearch(numbers, 5);
            Assert.Equal(4, result);
        }

        [Fact]
        public void BinarySearch_ValueNotPresent_ReturnsNull()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int? result = Algorithm.BinarySearch(numbers, 15);
            Assert.Null(result);
        }

        [Fact]
        public void BinarySearch_EmptyList_ReturnsNull()
        {
            var emptyList = new List<int>();
            int? result = Algorithm.BinarySearch(emptyList, 1);
            Assert.Null(result);
        }

        [Fact]
        public void BinarySearch_SingleElementList_ValuePresent_ReturnsZero()
        {
            var singleList = new List<int> { 42 };
            int? result = Algorithm.BinarySearch(singleList, 42);
            Assert.Equal(0, result);
        }

        [Fact]
        public void BinarySearch_SingleElementList_ValueAbsent_ReturnsNull()
        {
            var singleList = new List<int> { 42 };
            int? result = Algorithm.BinarySearch(singleList, 99);
            Assert.Null(result);
        }
    }
}