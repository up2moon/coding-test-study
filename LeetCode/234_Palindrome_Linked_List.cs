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
    public bool IsPalindrome(ListNode head)
    {
        if (head.next == null)
            return true;
        ListNode fast = head;
        ListNode slow = head;
        ListNode prev = null;
        ListNode temp;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;

            temp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = temp;
        }
        if (fast != null)
            slow = slow.next;
        while (prev != null && slow != null)
        {
            if (prev.val != slow.val)
                return false;
            prev = prev.next;
            slow = slow.next;
        }
        return true;
    }
}