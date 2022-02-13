using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/split-a-string-in-balanced-strings/
    public class SplitAStringInBalancedStrings
    {
        public static int BalancedStringSplit(string s)
        {
            if (s.Length == 1)
                return 0;
            var stack = new Stack<char>();

            var balancedStringsCount = 0;
            
            foreach (var curChar in s)
            {
                if(!stack.Any() || stack.Peek() == curChar)
                    stack.Push(curChar);
                else
                {
                    stack.Pop();
                    if (!stack.Any())
                    {
                        balancedStringsCount++;
                    }
                }
            }

            return balancedStringsCount;
        }
    }
}