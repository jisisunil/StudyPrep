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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root==null) return null;
        if(key < root.val)
        {
            root.left =  DeleteNode(root.left, key);
        }
        else if(key > root.val)
        {
            root.right= DeleteNode(root.right, key);
        }
        else
        {
            /*
            Now we must handle three cases:
            Node has no children (leaf)
            Node has one child
            Node has two children ← this is your question*/
            if(root.left == null) return root.right;
            if(root.right == null) return root.left;

            var current = root.right;
            while(current.left!=null)
            {
                current = current.left;
            }
            root.val= current.val;
            root.right=DeleteNode(root.right, root.val);

        }
        return root;
        
    }
}