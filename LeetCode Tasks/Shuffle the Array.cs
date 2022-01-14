namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/shuffle-the-array/
    public static class ShuffleTheArray
    {
        public static int[] Shuffle(int[] nums,
                                    int n)
        {
            var result = new int[2 * n];
            var innerIndex = 0;
            
            for (var i = 0; i < nums.Length / 2; i++)
            {
                result[innerIndex] = nums[i];
                result[innerIndex + 1] = nums[i + n];
                innerIndex += 2;
            }

            return result;
        }
    }
}