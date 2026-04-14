public class Solution {
     Dictionary<int, List<int>>adj;

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        if (prerequisites == null || prerequisites.Length == 0)
        return true;
        if(prerequisites.Length==1 && prerequisites[0][0]!= prerequisites[0][1])
        {
            return true;
        }

        adj = new Dictionary<int, List<int>>(numCourses);
        for (int i = 0; i < numCourses; i++) adj[i] = new List<int>();
        foreach(var pre in prerequisites)
        {
            var course =pre[0];
            var precourse = pre[1];
            adj[precourse].Add(course);
        }

        int[] visited = new int[numCourses];
        for(int i=0;i<numCourses;i++)
        {
            if(HasCycle(i,visited))
            {
                return false;
            }
        }
        return true;


    }

    private bool HasCycle(int course, int[] visited)
    {
        if(visited[course] == 1)
        {
            return true;
        }
        if(visited[course] ==2) return false;

        visited[course]=1;
        if(adj.ContainsKey(course))
        {
        foreach(int nei in adj[course])
        {
            if(HasCycle(nei, visited))
            {
                return true;
            }
        }
        }

        visited[course] =2;
        return false;
    }
}
