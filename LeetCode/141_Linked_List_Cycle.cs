/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;
        ListNode fast = head;
        ListNode slow = head;

        while (slow.next != null)
        {
            if (fast != null)
                fast = fast.next;
            if (fast != null)
                fast = fast.next;
            slow = slow.next;
            if (fast == slow)
                return true;
        }
        return false;
    }
}