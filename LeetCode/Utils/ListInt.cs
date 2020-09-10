using System;

namespace LeetCode.Utils
{
    public class ListInt : IComparable<ListInt>
    {
        public int[] List { get; set; }

        public ListInt thisOne;

        public ListInt(int[] intList)
        {
            List = intList;
        }

        public int CompareTo(ListInt other)
        {
            return (other.List[0]*other.List[0] + other.List[1]*other.List[1]).CompareTo(List[0]*List[0] + List[1]*List[1]);
        }
    }
}
