using System.Linq;

namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/jewels-and-stones/
    public static class JewelsAndStones
    {
        public static int NumJewelsInStones(string jewels, string stones)
        {
            var hashsetOfJewels = jewels.ToHashSet();

            return stones.Count(stone => hashsetOfJewels.Contains(stone));
        }
    }
}