using LeetCode.Utils;
using System;

namespace LeetCode.Algorithms
{
    public class RobotReturnToOrigin
    {
        /* LeetCode #657. Robot Return to Origin
         * There is a robot starting at position (0, 0), the origin, on a 2D plane.
         * Given a sequence of its moves, judge if this robot ends up at (0, 0) after it completes its moves.
         * The move sequence is represented by a string, and the character moves[i] represents its ith move.
         * Valid moves are R (right), L (left), U (up), and D (down). If the robot returns to the origin after
         * it finishes all of its moves, return true. Otherwise, return false.
         * Note: The way that the robot is "facing" is irrelevant.
         * "R" will always make the robot move to the right once, "L" will always make it move left, etc.
         * Also, assume that the magnitude of the robot's movement is the same for each move.*/
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
