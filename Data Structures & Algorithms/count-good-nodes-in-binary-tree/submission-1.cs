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

        return dfs(root, root.val);
        
    }

    private int dfs(TreeNode root, int maxsofar)
    {
        if(root == null) return 0;
        int res = (root.val>=maxsofar)?1:0;
        maxsofar = Math.Max(maxsofar, root.val);
        
        res+=dfs(root.left, maxsofar);
        res+=dfs(root.right,maxsofar);
        return res;        
    }
}
