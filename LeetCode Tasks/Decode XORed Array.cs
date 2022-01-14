namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/decode-xored-array/
    public static class DecodeXoredArray
    {
        public static int[] Decode(int[] encoded,
                                   int first)
        {
            var result = new int[encoded.Length + 1];
            result[0] = first;

            for (var i = 0; i < encoded.Length - 1; i++)
            {
                result[i + 1] = encoded[i] ^ result[i];
            }

            return result;
        }
    }
}