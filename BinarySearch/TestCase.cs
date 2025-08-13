using System;
using System.Collections.Generic;

namespace BinarySearch
{
    internal partial class Program
    {
        /// <summary>
        /// Provides test cases for the BinarySearch algorithm.
        /// </summary>
        public static class TestCase
        {
            /// <summary>
            /// Runs several binary search test cases and outputs results.
            /// </summary>
            /// <returns>True if all test cases pass; otherwise, false.</returns>
            public static bool TestBinarySearch()
            {
                bool allPassed = true;

                // Test 1: Value present in the list
                var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int? foundIndex = Algorithom.BinarySearch(numbers, 5);
                if (foundIndex != 4)
                {
                    Console.WriteLine("Test 1 Failed: Expected index 4 for value 5.");
                    allPassed = false;
                }

                // Test 2: Value not present in the list
                int? notFoundIndex = Algorithom.BinarySearch(numbers, 15);
                if (notFoundIndex.HasValue)
                {
                    Console.WriteLine("Test 2 Failed: Expected null for value 15.");
                    allPassed = false;
                }

                // Test 3: Empty list
                var emptyList = new List<int>();
                int? emptyResult = Algorithom.BinarySearch(emptyList, 1);
                if (emptyResult.HasValue)
                {
                    Console.WriteLine("Test 3 Failed: Expected null for empty list.");
                    allPassed = false;
                }

                // Test 4: Single element list, value present
                var singleList = new List<int> { 42 };
                int? singleFound = Algorithom.BinarySearch(singleList, 42);
                if (singleFound != 0)
                {
                    Console.WriteLine("Test 4 Failed: Expected index 0 for value 42.");
                    allPassed = false;
                }

                // Test 5: Single element list, value absent
                int? singleNotFound = Algorithom.BinarySearch(singleList, 99);
                if (singleNotFound.HasValue)
                {
                    Console.WriteLine("Test 5 Failed: Expected null for value 99.");
                    allPassed = false;
                }

                return allPassed;
            }
        }
    }
}
