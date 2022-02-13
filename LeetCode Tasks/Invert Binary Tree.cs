using LeetCode_Tasks.CommonDataStructures;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/invert-binary-tree/
    public class InvertBinaryTree
    {
        public TreeNode? InvertTree(TreeNode? root)
        {
            if (root != null && root.left == null && root.right == null)
                return root;
            
            if (root?.left == null && root?.right == null)
                return null;

            var tmp = root.left;
            root.left = root.right;
            root.right = tmp;
            
            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}