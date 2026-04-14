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
    Dictionary<int,int> inorderIndexMap = new Dictionary<int,int>();
    int preOrderIndex;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        preOrderIndex=0;
        for(int i=0;i<inorder.Length;i++)
        {
            inorderIndexMap[inorder[i]]=i;
        }        
        return ConstructTree(preorder, 0, preorder.Length-1);
    }
    private TreeNode ConstructTree(int[] preorder, int left, int right)
    {
        if(left>right)
        {
            return null;
        }
        int rootValue = preorder[preOrderIndex++];
        TreeNode root = new TreeNode(rootValue);

        root.left = ConstructTree(preorder, left, inorderIndexMap[rootValue]-1);
        root.right=ConstructTree(preorder, inorderIndexMap[rootValue]+1, right);
        return root;
    }
}
