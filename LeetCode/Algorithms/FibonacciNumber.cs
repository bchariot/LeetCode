using System;

namespace LeetCode.Algorithms
{
    public class FibonacciNumber
    {
        /* LeetCode #509. Fibonacci Number
         * The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence,
         * such that each number is the sum of the two preceding ones, starting from 0 and 1*/
        public static void RunCode()
        {
            int n = 3;
            Console.WriteLine($"    FibonacciNumber for {n}: {Fib(n)}, {Fib1(n)}, {Fib2(n)}, {Fib3(n)}");
            n = 4;
            Console.WriteLine($"    FibonacciNumber for {n}: {Fib(n)}, {Fib1(n)}, {Fib2(n)}, {Fib3(n)}");
            n = 5;
            Console.WriteLine($"    FibonacciNumber for {n}: {Fib(n)}, {Fib1(n)}, {Fib2(n)}, {Fib3(n)}");
            n = 6;
            Console.WriteLine($"    FibonacciNumber for {n}: {Fib(n)}, {Fib1(n)}, {Fib2(n)}, {Fib3(n)}");
        }

        static int Fib(int n) {
            double Phi = (1 + Math.Sqrt(5)) / 2;
            double phi = (1 - Math.Sqrt(5)) / 2;
            return Convert.ToInt32((Math.Pow(Phi, n) - Math.Pow(phi, n)) / Math.Sqrt(5));
        }

        static int Fib1(int n) {
            // Time Complexity: Exponential O(2^n) Space: Linear O(n)
            if (n == 0 || n == 1) {
                return n;
            }

            return Fib1(n - 1) + Fib1(n - 2);
        }

        static int Fib2(int n) {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            if (n == 0 || n == 1) {
                return n;
            }

            int[] df = new int[n + 1];
            df[0] = 0;
            df[1] = 1;
            for (int i = 2; i <= n; i++) {
                df[i] = df[i - 1] + df[i - 2];
            }

            return df[n];
        }

        static int Fib3(int n) {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            if (n == 0 || n == 1) {
                return n;
            }

            int prev = 0;
            int current = 1;
            int next = prev + current;

            while (n > 1) {
                prev = current;
                current = next;
                next = prev + current;
                n--;
            }

            return current;
        }
    }
}
