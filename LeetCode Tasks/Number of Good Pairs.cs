using System.Linq;

namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/number-of-good-pairs/
    public static class NumberOfGoodPairs
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            return nums.GroupBy(num => num)
                .Sum(group => group.Count() > 1
                         ? (group.Count() * (group.Count() - 1)) / 2
                         : 0);
        }
    }
}