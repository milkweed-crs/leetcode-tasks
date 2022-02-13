using System.Collections.Generic;
using System.Linq;
using LeetCode_Tasks.CommonDataStructures;

namespace LeetCode_Tasks
{
    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode? root)
        {
            var stack = new Stack<TreeNode>();
            var result = new List<int>();
            if (root == null)
                return result;

            var current = root;
            
            while (current != null || stack.Any())
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                result.Add(current.Val);
                current = current.right;
            }

            return result;
        }
    }
}