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

public class Solution {
    public void ReorderList(ListNode head) {
        ListNode slow=head;
        ListNode fast = head;

        while(fast!=null && fast.next!=null)
        {
            slow=slow.next;
            fast= fast.next.next;
        }

        ListNode current = slow.next;
        ListNode prev = Reverse(current);
        slow.next=null;

        ListNode first = head;
        ListNode second= prev;

        while(second!=null)
        {
            ListNode t1= first.next;
            ListNode t2= second.next;
            first.next=second;
            second.next=t1;

            first =t1;
            second=t2;
        }


    }

    private ListNode Reverse(ListNode current1)
    {
        ListNode prev=null;
        ListNode current = current1;

        while(current!=null)
        {
            ListNode next= current.next;

            current.next = prev;
            prev=current;
            current= next;
        }
        return prev;
    }
}
