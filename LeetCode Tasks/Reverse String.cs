namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/reverse-string/
    public class ReverseStringSolution
    {
        public static void ReverseString(char[] s)
        {
            for (var i = 0; i < s.Length / 2; i++)
            {
                var temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }
    }
}