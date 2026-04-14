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
    public ListNode ReverseKGroup(ListNode head, int k) {

        if (head == null) return null;

            ListNode current = head;
            ListNode runner = head;
            
            ListNode prev = null;
            int i = 0;
            int n=0;
       
        
            while (n < k && runner != null)
            {
                runner=runner.next;
                n++;
            }
        
            if(n!=k) return current;
        
            while (i < k && current != null)
            {
                ListNode nextPtr = current.next;
                current.next = prev;
                prev = current;
                current = nextPtr;
                i++;
            }

        
            head.next=ReverseKGroup(current, k);

            return prev;
        
    }
        
    
}
