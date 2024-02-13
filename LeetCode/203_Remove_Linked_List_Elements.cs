/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode node;
        ListNode dummy = new ListNode();

        dummy.next = head;
        node = dummy;

        while (node.next != null)
        {
            if (node.next.val == val)
            {
                node.next = node.next.next;
                continue;
            }
            node = node.next;
        }
        return dummy.next;
    }
}