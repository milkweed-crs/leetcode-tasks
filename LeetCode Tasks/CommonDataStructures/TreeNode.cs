namespace LeetCode_Tasks.CommonDataStructures
{
    public class TreeNode
    {
        public int Val;
        public TreeNode? left;
        public TreeNode? right;

        public TreeNode(int val = 0,
                        TreeNode? left = null,
                        TreeNode? right = null)
        {
            Val = val;
            this.left = left;
            this.right = right;
        }
    }
}