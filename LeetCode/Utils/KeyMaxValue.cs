using System;

namespace LeetCode.Utils
{
    public class KeyMaxValue : IComparable<KeyMaxValue>
    {
        public char Key { get; set; }
        public int Value { get; set; }

        public int CompareTo(KeyMaxValue other)
        {
            return (other.Value).CompareTo(Value);
        }

        public KeyMaxValue(char ch, int count)
        {
            Key = ch;
            Value = count;
        }
    }
}
