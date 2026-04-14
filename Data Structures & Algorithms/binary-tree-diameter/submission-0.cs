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
    int maxDiameter=0;
    public int DiameterOfBinaryTree(TreeNode root) {

        
        dfs(root);
        return maxDiameter;

        
    }

    private int dfs(TreeNode root)
    {
        if(root==null) return 0;
        int left = dfs(root.left);
        int right = dfs(root.right);

        maxDiameter = Math.Max(maxDiameter, left+right);
        return Math.Max(left,right)+1;
    }
}
