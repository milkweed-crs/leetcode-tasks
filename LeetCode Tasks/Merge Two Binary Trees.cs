namespace LeetCode_Tasks
{
    public class MergeTwoBinaryTrees
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

        public TreeNode? MergeTrees(TreeNode? root1,
                                    TreeNode? root2)
        {
            if (root1 == null && root2 == null)
                return null;
            if (root1 == null)
                return root2;
            if (root2 == null)
                return root1;

            return new TreeNode(root1.val + root2.val, 
                                MergeTrees(root1.left, root2.left), 
                                MergeTrees(root1.right, root2.right));
        }
    }
}