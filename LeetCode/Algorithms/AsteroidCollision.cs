using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms {
    public class AsteroidCollision {
        /* LeetCode #735. Asteroid Collision
         * We are given an array asteroids of integers representing asteroids in a row.
         * For each asteroid, the absolute value represents its size, and the sign represents its direction
         * (positive meaning right, negative meaning left). Each asteroid moves at the same speed.
         * Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode.
         * If both are the same size, both will explode. Two asteroids moving in the same direction will never meet. */
        public static void RunCode() {
            int[] asteroids = new int[] { 5, 10, -5 };
            Console.WriteLine($"    AsteroidCollision stack {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision1(asteroids))}");
            Console.WriteLine($"    AsteroidCollision array {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision2(asteroids))}");
            asteroids = new int[] { 8, -8 };
            Console.WriteLine($"    AsteroidCollision stack {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision1(asteroids))}");
            Console.WriteLine($"    AsteroidCollision array {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision2(asteroids))}");
            asteroids = new int[] { -2, -1, 1, 2 };
            Console.WriteLine($"    AsteroidCollision stack {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision1(asteroids))}");
            Console.WriteLine($"    AsteroidCollision array {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision2(asteroids))}");
        }

        static int[] GetAsteroidCollision1(int[] asteroids) {
            // Time Complexity: Linear O(n) Space: Linear O(n)
            Stack<int> stack = new Stack<int>();
            int i = 0;
            while (i < asteroids.Length) {
                if (asteroids[i] > 0) {
                    stack.Push(asteroids[i]);
                } else {
                    while (!stack.IsEmpty() && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroids[i])) {
                        stack.Pop();
                    }
                    if (stack.Count == 0 || stack.Peek() < 0) {
                        stack.Push(asteroids[i]);
                    } else if (stack.Peek() == Math.Abs(asteroids[i])) {
                        stack.Pop();
                    }
                }
                i++;
            }
            // return whatever is left in the stack
            int[] result = new int[stack.Count];
            int count = stack.Count;
            for (i = 0; i < count; i++) {
                result[count - 1 - i] = stack.Pop();
            }
            return result;
        }

        static int[] GetAsteroidCollision2(int[] asteroids) {
            // Time Complexity: Linear O(n) Space: Constant O(1)
            List<int> intsA = asteroids.ToList();
            List<int> intsB = new List<int>();
            while (intsA.Count - intsB.Count > 0) {
                for (int i = 0; i < intsA.Count; i++) {
                    int first = intsA[i];
                    int second;
                    if (i == intsA.Count - 1) {
                        second = first;
                    } else {
                        second = intsA[i + 1];
                    }
                    if ((first < 0 && second < 0) || (first > 0 && second > 0) || (first < 0 && second > 0)) {
                        intsB.Add(first); // both + or both - or first + and second -, add first, go to next
                    } else if (first > 0 && second < 0 && first + second != 0) {
                        intsB.Add(Math.Abs(first) > Math.Abs(second) ? first : second);
                        i++; // first + second -, add combined, go to 2 next
                    } else {
                        i++; // first and second are opposities of each other, go to 2 next
                    }
                }
                if (intsA.Count == intsB.Count) {
                    break;
                }
                intsA = intsB;
                intsB = new List<int>();
            }
            return intsB.ToArray();
        }
    }
}
