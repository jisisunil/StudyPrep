public class Solution {

    Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        if(prerequisites.Length==1 && prerequisites[0][0]!=prerequisites[0][1] ) return true;
        foreach(var pre in prerequisites)
        {
            int course = pre[0];
            int preCourse = pre[1];

            if(!graph.ContainsKey(preCourse))
            {
                graph[preCourse] = new List<int>();
            }
            graph[preCourse].Add(course);

        }   
        int[] visited = new int[numCourses];

        for(int i=0;i<numCourses;i++)
        {
            if(hasCycle(i, visited)) return false;
        }
        return true;
    }

    private bool hasCycle(int courseNum, int[] visited)
    {
        if(visited[courseNum] == 1) return true;

        if(visited[courseNum] == 2) return false;
        visited[courseNum] = 1;
        if(graph.ContainsKey(courseNum))
        {
            foreach(var neighbor in graph[courseNum])
            {
                if(hasCycle(neighbor, visited)) return true;
            }
        }
        visited[courseNum] = 2;
        return false;
    }
}
