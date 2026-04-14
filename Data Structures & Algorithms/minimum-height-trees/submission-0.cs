public class Solution {
    public List<int> FindMinHeightTrees(int n, int[][] edges) {
        if(n==1)
        {
            return new List<int>{0};            
        }

        Dictionary<int, List<int>> adjlist = new Dictionary<int,List<int>>();

        for(int i=0;i<n;i++)
        {
            adjlist[i] = new List<int>();
        }

        int[] degree = new int[n];

        foreach(var edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            adjlist[u].Add(v);
            adjlist[v].Add(u);

            degree[u]++;
            degree[v]++;
        }
        Queue<int> q= new Queue<int>();
        for(int i=0;i<n;i++)
        {
            if(degree[i]==1)
            {
                q.Enqueue(i);
            }
        }

        if(q.Count<=0) return q.ToList();

        int remainingnodes=n;

        while(remainingnodes>2)
        {
            int size = q.Count();
            remainingnodes-=size;
            for(int i=0;i<size;i++)
            {
                int leaf = q.Dequeue();

                foreach(var nei in adjlist[leaf])
                {
                    degree[nei]--;

                    if(degree[nei]==1)
                    {
                        q.Enqueue(nei);
                    }
                }
            }
        }

        return q.ToList();
    }
}