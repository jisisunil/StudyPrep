/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    Dictionary<Node,Node> map = new Dictionary<Node,Node>();    
    public Node CloneGraph(Node node) {
        if(node is null) return null;
        if(map.ContainsKey(node))
        {
            return map[node];
        }

        var clone = new Node(node.val);
        map[node] = clone;

        foreach(var neighbor in node.neighbors)
        {
            clone.neighbors.Add(CloneGraph(neighbor));
        }

        return clone;
    }
}
