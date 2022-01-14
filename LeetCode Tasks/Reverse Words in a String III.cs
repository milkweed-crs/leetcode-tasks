namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/reverse-words-in-a-string-iii/
    public class ReverseWordsInAStringIII
    {
        public static string ReverseWords(string s)
        {
            var words = s.Split(' ');
            var resultCharArray = new char[s.Length];

            var curIdx = 0;
            foreach (var word in words)
            {
                for (var i = 0; i < word.Length; i++)
                {
                    resultCharArray[curIdx] = word[word.Length - i - 1];
                    curIdx++;
                }
                if(curIdx < s.Length)
                    resultCharArray[curIdx] = ' ';
                
                curIdx++;
            }

            return new string(resultCharArray);
        }
    }
}