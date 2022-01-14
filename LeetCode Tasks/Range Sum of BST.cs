using LeetCode_Tasks.CommonDataStructures;

namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/range-sum-of-bst/
    public static class RangeSumOfBst
    {
        public static int RangeSumBST(TreeNode? root,
                                      int low,
                                      int high)
        {
            if (root == null)
                return 0;

            var value = root.Val >= low && root.Val <= high
                ? root.Val
                : 0;

            return RangeSumBST(root.Left, low, high) + value + RangeSumBST(root.Right, low, high);
        }
    }
}