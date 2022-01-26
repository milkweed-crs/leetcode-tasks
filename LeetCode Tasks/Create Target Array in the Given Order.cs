using System.Collections.Generic;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/create-target-array-in-the-given-order/
    public static class CreateTargetArrayInTheGivenOrder
    {
        public static int[] CreateTargetArray(int[] nums,
                                       int[] index)
        {
            var result = new List<int>(nums.Length);

            for (var i = 0; i < nums.Length; i++)
            {
                result.Insert(index[i], nums[i]);
            }

            return result.ToArray();
        }
    }
}