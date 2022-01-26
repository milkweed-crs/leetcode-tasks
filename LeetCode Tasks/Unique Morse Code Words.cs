using System.Collections.Generic;
using System.Text;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/unique-morse-code-words/
    public class UniqueMorseCodeWords
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            var morse = new[]
            {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                "....", "..", ".---", "-.-", ".-..", "--", "-.",
                "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                "...-", ".--", "-..-", "-.--", "--.."
            };

            var seenHashSet = new HashSet<string>();
            
            foreach (var word in words)
            {
                var sb = new StringBuilder();
                foreach (var ch in word.ToCharArray())
                {
                    sb.Append(morse[ch - 'a']);
                }

                seenHashSet.Add(sb.ToString());
            }

            return seenHashSet.Count;
        }
    }
}