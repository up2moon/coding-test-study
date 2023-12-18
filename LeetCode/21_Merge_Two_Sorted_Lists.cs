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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode head, node;

        if(list1 == null)
            return list2;
        if(list2 == null)
            return list1;

        if(list1.val < list2.val)
        {
            head = list1;
            list1 = list1.next;
        }
        else   
        {
            head = list2;
            list2 = list2.next;
        }

        node = head;

        while(true)
        {
            if(list1 == null)
            {
                node.next = list2;
                return head;
            }
            if(list2 == null)
            {
                node.next = list1;
                return head;
            }

            if(list1.val < list2.val)
            {
                node.next = list1;
                list1 = list1.next;
            }
            else
            {
                node.next = list2;
                list2 = list2.next;
            }
            node = node.next;
        }
        return head;
    }
}