namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/build-array-from-permutation/
    public static class BuildArrayFromPermutation
    {
        public static int[] BuildArray(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums.Length * (nums[nums[i]] % nums.Length);
            }
            
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] /= nums.Length;
            }

            return nums;
        }
    }
}