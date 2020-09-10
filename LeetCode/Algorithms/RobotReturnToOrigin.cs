using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class RobotReturnToOrigin
    {
        // LeetCode #657. Robot Return to Origin
        public static void RunCode()
        {
            string moves = "UD";
            Console.WriteLine($"    RobotReturnToOrigin {moves}: {JudgeCircle(moves)}");
            moves = "LL";
            Console.WriteLine($"    RobotReturnToOrigin {moves}: {JudgeCircle(moves)}");
        }

        static bool JudgeCircle(string moves)
        {
            if (moves.Length % 2 == 1)
            {
                return false;
            }

            HashMap<char, int> map = new HashMap<char, int>();

            foreach (char c in  moves.ToCharArray())
            {
                map.Put(c, map.GetOrDefault(c, 0) + 1);
            }
            return map.GetOrDefault('L', 0) == map.GetOrDefault('R', 0) && map.GetOrDefault('U', 0) == map.GetOrDefault('D', 0);
        }
    }
}
