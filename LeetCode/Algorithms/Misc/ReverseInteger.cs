using System;

namespace LeetCode.Algorithms
{
    public class ReverseInteger
    {
        // LeetCode #7. Reverse Integer
        public static void RunCode()
        {
            int x = 123;
            Console.WriteLine($"  ReverseInteger {x}: {Reverse(x)}");
            x = -123;
            Console.WriteLine($"  ReverseInteger {x}: {Reverse(x)}");
            x = 120;
            Console.WriteLine($"  ReverseInteger {x}: {Reverse(x)}");
            x = 1534236469;
            Console.WriteLine($"  ReverseInteger {x}: {Reverse(x)}");
        }

        static int Reverse(int x)
        {
            long reversed = 0;
            while (Math.Abs(x) > 0)
            {
                int mod = x % 10;
                x = x / 10;
                reversed = reversed * 10 + mod;
            }

            if (reversed < int.MinValue || reversed > int.MaxValue)
            {
                return 0;
            }

            return (int)reversed;
        }
    }
}
