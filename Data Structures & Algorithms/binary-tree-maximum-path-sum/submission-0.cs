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
    int best = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        dfs(root);
        return best;
    }

    private int dfs(TreeNode root)
    {
        if(root==null) return 0;
        int leftgain = dfs(root.left);
        int rightgain = dfs(root.right);

        leftgain = Math.Max(leftgain, 0);
        rightgain = Math.Max(rightgain, 0);

        int currentPathSum = root.val+leftgain+rightgain;
        best = Math.Max(best, currentPathSum);
        return root.val+Math.Max(leftgain,rightgain);
    }
}
