﻿using LeetCode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms
{
    public class AsteroidCollision
    {
        // LeetCode #735. Asteroid Collision
        public static void RunCode()
        {
            int[] asteroids = new int[] { 5, 10, -5 };
            Console.WriteLine($"    AsteroidCollision stack {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision1(asteroids))}");
            Console.WriteLine($"    AsteroidCollision array {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision2(asteroids))}");
            asteroids = new int[] { 8, -8 };
            Console.WriteLine($"    AsteroidCollision stack {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision1(asteroids))}");
            Console.WriteLine($"    AsteroidCollision array {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision2(asteroids))}");
            asteroids = new int[] { 10, 2, -5 };
            Console.WriteLine($"    AsteroidCollision stack {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision1(asteroids))}");
            Console.WriteLine($"    AsteroidCollision array {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision2(asteroids))}");
            asteroids = new int[] { -2, -1, 1, 2 };
            Console.WriteLine($"    AsteroidCollision stack {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision1(asteroids))}");
            Console.WriteLine($"    AsteroidCollision array {Print.IntArray(asteroids)}: {Print.IntArray(GetAsteroidCollision2(asteroids))}");
        }

        static int[] GetAsteroidCollision1(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();

            int i = 0;
            while (i < asteroids.Length)
            {
                if (asteroids[i] > 0)
                {
                    stack.Push(asteroids[i]);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroids[i]))
                    {
                        stack.Pop();
                    }
                    if (stack.Count == 0 || stack.Peek() < 0)
                    {
                        stack.Push(asteroids[i]);
                    }
                    else if (stack.Peek() == Math.Abs(asteroids[i]))
                    {
                        stack.Pop();
                    }
                }
                i++;
            }

            int[] result = new int[stack.Count];
            /*for (i = stack.Count - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }*/
            int count = stack.Count;
            for (i = 0; i < count; i++)
            {
                result[count - 1 - i] = stack.Pop();
            }
            return result;
        }

        static int[] GetAsteroidCollision2(int[] asteroids)
        {
            List<int> intsA = asteroids.ToList();
            List<int> intsB = new List<int>();
            while (intsA.Count - intsB.Count > 0)
            {
                for (int i = 0; i < intsA.Count; i++)
                {
                    int first = intsA[i];
                    int second;
                    if (i == intsA.Count - 1)
                    {
                        second = first;
                    }
                    else
                    {
                        second = intsA[i + 1];
                    }

                    // both position or both negative or first negative and second positive
                    // add first
                    // go to next iteration
                    if ((first < 0 && second < 0) || (first > 0 && second > 0) || (first < 0 && second > 0))
                    {
                        intsB.Add(first);
                    }
                    // first positive second negative
                    // add combined
                    // go to 2 next iteration
                    else if (first > 0 && second < 0 && first + second != 0)
                    {
                        intsB.Add(Math.Abs(first) > Math.Abs(second) ? first : second);
                        i++;
                    }
                    // first and second are opposities of each other
                    // go to 2 next iteration
                    else
                    {
                        i++;
                    }
                }

                if (intsA.Count == intsB.Count)
                {
                    break;
                }

                intsA = intsB;
                intsB = new List<int>();
            }
            return intsB.ToArray();
        }
    }
}