using System;

namespace LeetCode.Utils {
    public class Formulae {
        public static int Fib(int n) {
            double Phi = (1 + Math.Sqrt(5)) / 2;
            double phi = (1 - Math.Sqrt(5)) / 2;
            return Convert.ToInt32((Math.Pow(Phi, n) - Math.Pow(phi, n)) / Math.Sqrt(5));
        }

        static int Josephus(int n, int k) {
            if (n == 1) {
                return 1;
            }
            return (Josephus(n - 1, k) + k - 1) % n + 1;
        }

        public static int NChooseK(int N, int K) {
            int result = 1;
            for (int i = 1; i <= K; i++) {
                result *= N - (K - i);
                result /= i;
            }
            return result;
        }
    }
}
