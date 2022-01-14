using System;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/maximum-depth-of-binary-tree/
    public class MaximumDepthOfBinaryTree
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

        public int MaxDepth(RangeSumOfBst.TreeNode? root)
        {
            return root == null
                ? 0
                : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}