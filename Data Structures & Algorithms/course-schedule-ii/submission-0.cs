public class Solution {
    Dictionary<int,List<int>> graph;
    List<int> result;
    public int[] FindOrder(int numCourses, int[][] prerequisites) {

        graph = new Dictionary<int,List<int>>();

        for(int i=0;i<numCourses;i++)
        {
            graph[i] = new List<int>();
        }

        foreach(var pre in prerequisites)
        {
            int course = pre[0];
            int precourse = pre[1];

            graph[precourse].Add(course);
        }

        int[] state = new int[numCourses];
        result = new List<int>();
        for(int i=0;i<numCourses;i++)
        {
            if(HasCycle(i, state)) return Array.Empty<int>();
        }
        result.Reverse();
        return result.ToArray();
        
    }

    private bool HasCycle(int course, int[] state)
    {
        if(state[course]==1) return true;
        if(state[course]==2) return false;

        state[course]=1;
        if(graph.ContainsKey(course))
        {
            foreach(var neighbor in graph[course])
            {
                if(HasCycle(neighbor, state)) return true;
            }
        }

        state[course]=2;
        result.Add(course);
        return false;
    }
}
