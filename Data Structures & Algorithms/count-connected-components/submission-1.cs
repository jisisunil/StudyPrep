public class Solution {
    public int CountComponents(int n, int[][] edges) {

        int[] parent = new int[n];
        int[] size = new int[n];

        for(int i=0;i<n;i++)
        {
            parent[i]=i;
            size[i]=1;
        }

        int cnt=n;
        foreach(var edge in edges)
        {
            var u = edge[0];
            var v = edge[1];

            if(Union(u, v, parent, size))
            {
                cnt--;
            }
        }
        return cnt;

    }

    private bool Union(int u, int v, int[] parent, int[] size)
    {
        var rootu= Find(u,parent);
        var rootv= Find(v,parent);
        if(rootu==rootv) return false;
        
        if(size[rootu]>size[rootv])
        {
            parent[rootv] = rootu;
            size[rootu]+=size[rootv];
        }
        else
        {
            parent[rootu]=rootv;
            size[rootv]+=size[rootu];
        }
        return true;       

    }

    private int Find(int node, int[] parent)
    {
        if(node!=parent[node])
        {
            parent[node]=Find(parent[node], parent);
        }
        return parent[node];
    }
}
