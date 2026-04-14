public class Solution {
    Dictionary<char, HashSet<char>> graph = new();
    List<char> result = new();

    public string foreignDictionary(string[] words)
    {
        // nodes
        foreach (var word in words)
            foreach (var c in word)
                graph.TryAdd(c, new HashSet<char>());

        // edges from first difference of adjacent words
        for (int i = 0; i < words.Length - 1; i++)
        {
            string w1 = words[i];
            string w2 = words[i + 1];

            // invalid prefix case: longer before its exact prefix
            if (w1.Length > w2.Length && w1.StartsWith(w2))
                return "";

            int len = Math.Min(w1.Length, w2.Length);
            for (int j = 0; j < len; j++)
            {
                if (w1[j] != w2[j])
                {
                    graph[w1[j]].Add(w2[j]); // add edge a -> b
                    break; // only first differing char matters
                }
            }
        }

        // DFS with 3-state visited
        var visited = new Dictionary<char, int>(); // 0=unvisited,1=visiting,2=visited
        foreach (var node in graph.Keys)
        {
            if (!visited.ContainsKey(node))
            {
                if (HasCycle(node, visited)) return "";
            }
        }

        result.Reverse();
        return new string(result.ToArray());
    }

    private bool HasCycle(char node, Dictionary<char, int> visited)
    {
        if (visited.TryGetValue(node, out int state))
        {
            if (state == 1) return true;   // back-edge → cycle
            if (state == 2) return false;  // already processed
        }

        visited[node] = 1; // visiting
        foreach (char nei in graph[node])
        {
            if (HasCycle(nei, visited)) return true;
        }

        visited[node] = 2; // visited
        result.Add(node);  // post-order
        return false;
    }
}