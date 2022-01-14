namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/running-sum-of-1d-array/
    public static class RunningSumOf1DArray
    {
        public static int[] RunningSum(int[] nums)
        {
            for (var i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }

            return nums;
        }
    }
}