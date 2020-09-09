using System;
using System.Collections.Generic;

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

            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('L', 0);
            map.Add('R', 0);
            map.Add('U', 0);
            map.Add('D', 0);

            foreach (char c in  moves.ToCharArray())
            {
                map[c] = map[c] + 1;
            }
            return map['L'] == map['R'] && map['U'] == map['D'];
        }
    }
}
