public class Solution {
    Dictionary<int,List<int>> graph;
    public bool ValidTree(int n, int[][] edges) {
        if(edges.Length!=n-1) return false;
        graph= new Dictionary<int,List<int>>();

        for(int i=0;i<n;i++)
        {
            graph[i]= new List<int>();
        }
        foreach(var edge in edges)
        {
            int u= edge[0];
            int v=edge[1];

            graph[u].Add(v);
            graph[v].Add(u);
        }

        HashSet<int> visited = new HashSet<int>();
        
        
            if(HasCycle(0,-1, visited)) return false;
        
        return visited.Count==n;
        
    }


    private bool HasCycle(int node, int parent, HashSet<int> visited)
    {
        visited.Add(node);
        foreach(var neighbor in graph[node])
        {
            if(neighbor==parent)
            {
                continue;
            }
            if(visited.Contains(neighbor)||HasCycle(neighbor, node, visited)) return true;
        }

        
        return false;
    }
}
