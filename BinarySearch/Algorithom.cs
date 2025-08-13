namespace BinarySearch
{
    internal partial class Program
    {
        public abstract class Algorithom
        {
            public static int? BinarySearch<T>(List<T> list,T keyword) where T : IComparable
            {
                int low = 0;
                int high = list.Count -1;
                int mid;
                T guess;
                while (low <= high){
                    mid = (low +high)/2;
                    guess = list[mid];

                    if (guess.CompareTo(keyword) == 0)
                        return mid;
                    else if (guess.CompareTo(keyword) >0 )
                        high = mid -1;
                    else
                        low = mid +1;

                }
                return null;
            }
        }
    }
}
