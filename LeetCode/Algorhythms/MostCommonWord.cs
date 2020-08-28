using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorhythms
{
    public class MostCommonWord
    {
        public static void RunCode()
        {
            string paragraph = @"
                Now is the winter of our discontent
                Made glorious summer by this sun of York;
                And all the clouds that lour'd upon our house
                In the deep bosom of the ocean buried.
                Now are our brows bound with victorious wreaths;
                Our bruised arms hung up for monuments;
                Our stern alarums changed to merry meetings,
                Our dreadful marches to delightful measures.
                Grim-visaged war hath smooth'd his wrinkled front;
                And now, instead of mounting barbed steeds
                To fright the souls of fearful adversaries,
                He capers nimbly in a lady's chamber
                To the lascivious pleasing of a lute.";
            string[] banned = new string[] { "this", "that", "these", "those", "the", "a" };
            Console.WriteLine($"    MostCommonWord from:\n{paragraph}\n\n           *** {GetMostCommonWord(paragraph, banned)} ***");
        }

        static string GetMostCommonWord(string paragraph, string[] banned)
        {
            HashSet<string> bannedWords = new HashSet<string>();
            foreach (string word in banned)
            {
                bannedWords.Add(word);
            }

            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in paragraph.Replace("[^a-zA-Z]", "").Split(" "))
            {
                if (!bannedWords.Contains(word))
                {
                    if (counts.ContainsKey(word))
                    {
                        //Java: count.put(word, counts.getOrDefault(word, 0) + 1);
                        counts[word] = counts[word] + 1;
                    }
                    else
                    {
                        counts[word] = 1;
                    }
                }
            }

            string result = "";
            foreach (string key in counts.Keys)
            {
                if (result.Equals("") || counts.GetValueOrDefault(key, 0) > counts.GetValueOrDefault(result, 0))
                {
                    result = key;
                }
            }

            return result;
        }
    }
}
