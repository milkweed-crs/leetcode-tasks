namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/range-sum-of-bst/
    public static class RangeSumOfBst
    {
        public class TreeNode
        {
            public int val;
            public TreeNode? left;
            public TreeNode? right;

            public TreeNode(int val = 0,
                            TreeNode? left = null,
                            TreeNode? right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public static int RangeSumBST(TreeNode? root,
                                      int low,
                                      int high)
        {
            if (root == null)
                return 0;

            var value = root.val >= low && root.val <= high
                ? root.val
                : 0;

            return RangeSumBST(root.left, low, high) + value + RangeSumBST(root.right, low, high);
        }
    }
}