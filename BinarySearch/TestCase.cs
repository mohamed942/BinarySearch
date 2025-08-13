namespace BinarySearch
{
    internal partial class Program
    {
        public class TestCase
        {
            public static bool TestBinarySearch()
            {
                List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //List<string> list1 = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
                int? result1 = Algorithom.BinarySearch(list, 15);
                //int? result = Algorithom.BinarySearch(list1, "e");
                return result1.HasValue;
            }
        }
    }
}
