using LeetCode_Tasks.CommonDataStructures;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/merge-two-binary-trees/
    public class MergeTwoBinaryTrees
    {
        public TreeNode? MergeTrees(TreeNode? root1,
                                    TreeNode? root2)
        {
            if (root1 == null && root2 == null)
                return null;
            if (root1 == null)
                return root2;
            if (root2 == null)
                return root1;

            return new TreeNode(root1.Val + root2.Val, 
                                MergeTrees(root1.Left, root2.Left), 
                                MergeTrees(root1.Right, root2.Right));
        }
    }
}