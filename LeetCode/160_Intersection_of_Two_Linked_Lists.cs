/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int aCount = 1;
        int bCount = 1;
        int aTailVal = 0;
        int bTailVal = 0;
        ListNode nodeA = headA;
        ListNode nodeB = headB;

        do
        {
            if (nodeA.next != null)
            {
                nodeA = nodeA.next;
                ++aCount;
                aTailVal = nodeA.val;
            }
        } while (nodeA.next != null);
        do
        {
            if (nodeB.next != null)
            {
                nodeB = nodeB.next;
                ++bCount;
                bTailVal = nodeB.val;
            }
        } while (nodeB.next != null);

        if (nodeA != nodeB)
            return null;

        nodeA = headA;
        nodeB = headB;

        if (aCount > bCount)
        {
            for (int i = 0; i < aCount - bCount; ++i)
                nodeA = nodeA.next;
        }
        else if (aCount < bCount)
        {
            for (int i = 0; i < bCount - aCount; ++i)
                nodeB = nodeB.next;
        }

        while (nodeA != nodeB)
        {
            nodeA = nodeA.next;
            nodeB = nodeB.next;
        }

        return nodeA;
    }
}