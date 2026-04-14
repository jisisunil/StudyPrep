public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {

        int[] parent = new int[edges.Length+1];
        int[] rank = new int[edges.Length+1];

        for(int i=0;i<parent.Length;i++)
        {
            parent[i] = i;
            rank[i] =1;
        }

        foreach(var edge in edges)
        {
            if(!Union(edge[0], edge[1], parent, rank))
            {
                return edge;
            }
        }

        return new int[0];
        
    }


    private bool Union(int u, int v, int[] parent, int[] rank)
    {
        int rootu = Find(u, parent);
        int rootv= Find(v, parent);

        if(rootu==rootv) return false;//cycle detected

        if(rank[rootu]>rank[rootv])
        {
            parent[rootv]= rootu;
            rank[rootu]+=rank[rootv];

        }
        else
        {
            parent[rootu]=rootv;
            rank[rootv]+=rank[rootu];
        }       

        return true;
    }

    private int Find(int node, int[] parent)
    {
        if(parent[node]!=node)
        {
            parent[node]= Find(parent[node],parent);
        }
        return parent[node];
    }
}
