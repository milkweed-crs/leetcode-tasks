using System;

namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/concatenation-of-array/
    public static class ConcatenationOfArray 
    {
        public static int[] GetConcatenation(int[] nums)
        {
            Array.Resize(ref nums, nums.Length * 2);
            Array.Copy(nums, 0, nums, nums.Length / 2, nums.Length / 2);
            
            return nums;
        }
    }
}