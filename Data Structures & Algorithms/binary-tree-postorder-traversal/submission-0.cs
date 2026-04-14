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
    //add root,right,left, then you get the reversed order becos of linkedlist add first.
    public List<int> PostorderTraversal(TreeNode root) {       

        LinkedList<int> lst = new LinkedList<int>();
        if(root==null) return lst.ToList();
        Stack<TreeNode> stk= new Stack<TreeNode>();
        stk.Push(root);

        while(stk.Count>0)
        {
            TreeNode node = stk.Pop();
            lst.AddFirst(node.val);
            if(node.left!=null)
            {
                stk.Push(node.left);
            }
            if(node.right!=null)
            {
                stk.Push(node.right);
            } 
        }
        return lst.ToList();
    }
}