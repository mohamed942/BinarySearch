using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace BinarySearch
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            
            bool result = TestCase.TestBinarySearch();
            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}
