namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/to-lower-case/
    public static class ToLowerCaseProblem
    {
        public static string ToLowerCase(string s)
        {
            var result = s.ToCharArray();
            
            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] >= 'A' && result[i] <= 'Z')
                    result[i] = (char)(result[i] + 32);
            }

            return new string(result);
        }
    }
}