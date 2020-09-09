using System;

namespace LeetCode.Algorithms
{
    public class ValidPalindrome
    {
        // LeetCode #125. Valid Palindrome
        public static void RunCode()
        {
            string s = "Madam, I'm Adam";
            Console.WriteLine($"    ValidPalindrome \"{s}\": {IsPalindrome(s)}");
            s = "A man, a plan, a canal, Panama";
            Console.WriteLine($"    ValidPalindrome \"{s}\": {IsPalindrome(s)}");
            s = "race a car";
            Console.WriteLine($"    ValidPalindrome \"{s}\": {IsPalindrome(s)}");
        }

        static bool IsPalindrome(string s)
        {
            char[] chars = s.ToLower().ToCharArray();
            int i = 0;
            int j = chars.Length - 1;
            while (i < j)
            {
                while (i < j && !Char.IsLetterOrDigit(chars[i]))
                {
                    i++;
                }
                while (i < j && !Char.IsLetterOrDigit(chars[j]))
                {
                    j--;
                }
                if (chars[i] != chars[j])
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }

            return true;
        }
    }
}
