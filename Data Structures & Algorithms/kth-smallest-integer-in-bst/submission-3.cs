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
    int cnt=0;
    int result=0;
    public int KthSmallest(TreeNode root, int k) {
        
        Inorder(root, k);
        return result;       
    }

    private void Inorder(TreeNode root, int k)
    {
        if(root == null || cnt>=k) return;
        Inorder(root.left,k);
        cnt++;
        if(cnt==k)
        {
            result=root.val;
            return;
        }
        Inorder(root.right,k);
    }
}
