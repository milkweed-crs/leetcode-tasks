namespace LeetCode_Tasks
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int x)
        {
            val = x;
        }
    }
    //https://leetcode.com/problems/delete-node-in-a-linked-list/submissions/
    public class DeleteNodeInALinkedList
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}