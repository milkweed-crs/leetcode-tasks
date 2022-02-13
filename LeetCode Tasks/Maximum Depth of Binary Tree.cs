using System;
using LeetCode_Tasks.CommonDataStructures;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/maximum-depth-of-binary-tree/
    public class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode? root)
        {
            return root == null
                ? 0
                : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}