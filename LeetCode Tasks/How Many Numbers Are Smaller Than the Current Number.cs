using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
    public static class HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var sortedArray = nums.OrderBy(x => x).ToArray();
            var dict = new Dictionary<int, int>();
            
            dict.Add(sortedArray[0], 0);
            for (var i = 1; i < sortedArray.Length; i++)
            {
                if (sortedArray[i - 1] < sortedArray[i])
                    dict.Add(sortedArray[i], i);
            }

            var result = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out var count))
                    result[i] = count;
                else
                    result[i] = 0;
            }

            return result;
        }
    }
}