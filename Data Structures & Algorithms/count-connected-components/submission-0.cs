public class Solution {
    Dictionary<int,List<int>> graph;
    public int CountComponents(int n, int[][] edges) {
        graph = new Dictionary<int,List<int>>();

        for(int i=0;i<n;i++)
        {
            graph[i]= new List<int>();
        }

        foreach(var edge in edges)
        {
            int u = edge[0];
            int v= edge[1];
            graph[u].Add(v);
            graph[v].Add(u);
        }
        HashSet<int> visited = new HashSet<int>();
        int cnt=0;
        for(int i=0;i<n;i++)
        {
            if(!visited.Contains(i))
            {
            cnt++;
            }
            dfs(i, visited);
        }
        return cnt;
    }

    private void dfs(int i, HashSet<int> visited)
    {
        visited.Add(i);

        foreach(var neighbor in graph[i])
        {
            if(!visited.Contains(neighbor))
            {
            dfs(neighbor, visited);
            }
        }
    }
}
