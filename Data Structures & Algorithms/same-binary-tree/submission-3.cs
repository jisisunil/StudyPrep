/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // If both nodes are null, they are identical
        if (p == null && q == null)
            return true;

        // If one is null or values differ, not the same
        if (p == null || q == null || p.val != q.val)
            return false;

        // Recursively check left and right subtrees
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
