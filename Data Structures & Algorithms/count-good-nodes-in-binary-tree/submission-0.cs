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
    public int GoodNodes(TreeNode root) {

        if(root==null) return 0;
        return dfs(root, root.val);
        
    }


    private int dfs(TreeNode root, int max)
    {
        if(root==null) return 0;

        int result = (root.val>=max)?1:0;
        max = Math.Max(max, root.val);
        result+=dfs(root.left, max);
        result+=dfs(root.right, max);
        return result;
    }
}
