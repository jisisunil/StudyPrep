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

        /*
        The goal is for slow to stop at the node before the start of 
        the second half (so we can split the list cleanly).
        Case 1: Even number of nodes

1 → 2 → 3 → 4
Initial: slow = 1, fast = 1
After 1st iteration: slow = 2, fast = 3
Check next: fast.next.next is null (3.next.next → null), so stop.
Now:
slow is at node 2, which is the end of the first half.
We can safely split into:
first half: 1 → 2
second half: 3 → 4
✅ Perfect for our reorder logic.
Case 2: Odd number of nodes
1 → 2 → 3 → 4 → 5
Initial: slow = 1, fast = 1
After 1st iteration: slow = 2, fast = 3
After 2nd iteration: slow = 3, fast = 5
Next iteration would fail because fast.next == null
So slow ends at node 3, again marking the end of the first half.
✅ Split:
first half: 1 → 2 → 3
second half: 4 → 5
💡 In short:We add fast.next.next != null so that:We stop one step earlier, 
leaving slow at the last node of the first half.
It prevents fast from advancing into a null reference.
It works uniformly for both odd and even length lists.*/
        
        //Find middle of the list with fast/slow pointers.
        ListNode slow=head;
        ListNode fast = head;
        while(fast!=null && fast.next!=null && fast.next.next!=null)
        {
            slow=slow.next;
            fast= fast.next.next;
        }

        //reverse the second half

        ListNode prev=null;
        ListNode current = slow.next;

        while(current!=null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        //split the list
        slow.next = null;
        //Merge the two halves by alternating nodes.
        ListNode first = head;
        ListNode  second = prev;

        while(second!=null)
        {
            ListNode t1 = first.next;
            ListNode t2= second.next;

            first.next = second;
            second.next = t1;

            first=t1;
            second = t2;
        }

    }
}
