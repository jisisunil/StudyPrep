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
    public List<int> RightSideView(TreeNode root) {
        List<int> result = new List<int>();
        if(root==null) return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count > 0)
        {
            TreeNode rightMostNode = null;
            int size = queue.Count;
            for(int i=0;i<size;i++)
            {
                var node = queue.Dequeue();
                rightMostNode = node;
                
                if(node.left!=null)
                {
                    queue.Enqueue(node.left);
                }
                if(node.right!=null)
                {
                    queue.Enqueue(node.right);
                }
            }

            if(rightMostNode !=null)
            {
                result.Add(rightMostNode.val);
            }
        }
        return result;
    }
}
