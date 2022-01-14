namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/shuffle-string/
    public static class ShuffleString
    {
        public static string RestoreString(string s, int[] indices)
        {
            var resultCharArray = new char[indices.Length];
            
            for (var i = 0; i < indices.Length; i++)
            {
                resultCharArray[indices[i]] = s[i];
            }

            return new string(resultCharArray);
        }
    }
}