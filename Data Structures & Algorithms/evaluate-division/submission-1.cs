public class Solution {
    public double[] CalcEquation(List<List<string>> equations, double[] values, List<List<string>> queries) {

        var graph = new Dictionary<string, List<(string next, double weight)>>();

        for(int i=0;i<equations.Count;i++)
        {
            var a = equations[i][0];
            if(!graph.ContainsKey(a))
            {
                graph[a]= new List<(string, double)>();
            }
            var b =  equations[i][1];
            if(!graph.ContainsKey(b))
            {
                graph[b] = new List<(string, double)>();
            }
            var val = values[i];
            graph[a].Add((b, val));
            graph[b].Add((a, 1/val));
        }

        var result = new double[queries.Count];

        for(int i=0;i<queries.Count;i++)
        {
            var start = queries[i][0];
            var end = queries[i][1];
            result[i]=Evaluate(start, end, graph);
        }
        
        return result;
    }


    private double Evaluate(string start, string end, Dictionary<string, List<(string, double)>> graph)
    {

        if(!graph.ContainsKey(start)|| !graph.ContainsKey(end))
        {
            return -1.0;
        }

        if(start==end)
        {
            return 1.0;
        }

        Queue<(string, double)> q= new Queue<(string node, double weight)>();
        HashSet<string> visited= new HashSet<string>();

        q.Enqueue((start,1.0));
        visited.Add(start);
        while(q.Count>0)
        {
            var (node, weight) = q.Dequeue();

            foreach(var (next,val) in graph[node])
            {
                if(visited.Contains(next)) continue;
                if(next==end)
                {
                    return val*weight;
                }
                q.Enqueue((next,val*weight));
                visited.Add(next);
            }
        }

       return -1.0;


    }
}