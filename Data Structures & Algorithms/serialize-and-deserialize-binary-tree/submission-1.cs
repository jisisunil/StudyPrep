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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        if(root==null) return "null";
        StringBuilder sb = new StringBuilder();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count>0)
        {
            var node = q.Dequeue();
            if(node!=null)
            {
                sb.Append(node.val).Append(',');
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }
            else
            {
                sb.Append("null,");
            }

        }
        return sb.ToString();
        
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {

        if(data=="null") return null;

        var nodes = data.Split(",");
        TreeNode root = new TreeNode(int.Parse(nodes[0]));
        Queue<TreeNode> q= new Queue<TreeNode>();
        q.Enqueue(root);
        int i=1;
        while(q.Count>0)
        {
            var node = q.Dequeue();
            if(nodes[i]!="null")
            {
                node.left = new TreeNode(int.Parse(nodes[i]));
                q.Enqueue(node.left);               
                
            }
            i++;
            if(nodes[i]!="null")
            {
                node.right = new TreeNode(int.Parse(nodes[i]));
                q.Enqueue(node.right);
            }
            i++;
        }
        return root;
    }
}
