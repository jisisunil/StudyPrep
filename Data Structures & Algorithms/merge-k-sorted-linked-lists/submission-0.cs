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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;

        var pq = new PriorityQueue<ListNode, int>();

        foreach (var node in lists) {
            if (node != null)
                pq.Enqueue(node, node.val);
        }

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (pq.Count > 0) {
            var smallest = pq.Dequeue();
            current.next = smallest;
            current = current.next;

            if (smallest.next != null)
                pq.Enqueue(smallest.next, smallest.next.val);
        }

        return dummy.next;
    }
}
