using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class RobotReturnToOrigin
    {
        // LeetCode #. Template
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
            map.Put('L', 0);
            map.Put('R', 0);
            map.Put('U', 0);
            map.Put('D', 0);

            foreach (char c in  moves.ToCharArray())
            {
                map.Put(c, map.GetOrDefault(c, 0) + 1);
            }
            return map.Get('L') == map.Get('R') && map.Get('U') == map.Get('D');
        }
    }
}
