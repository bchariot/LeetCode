using System;

namespace LeetCode.Utils
{
    public class ListInt : IComparable<ListInt>
    {
        public int[] MyList { get; set; }

        public int CompareTo(ListInt other)
        {
            return (other.MyList[0]).CompareTo(MyList[0]);
        }

        public ListInt thisOne;

        public ListInt(int[] intList)
        {
            MyList = intList;
        }
    }
}
