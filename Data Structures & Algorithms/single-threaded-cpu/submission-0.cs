public class Solution {
    public int[] GetOrder(int[][] tasks) {

        int n=tasks.Length;
        int[][] indexedTasks = new int[n][];

        for(int i=0;i<n;i++)
        {
            indexedTasks[i] = new int[] {tasks[i][0], tasks[i][1], i};
        }

        Array.Sort(indexedTasks, (a,b)=>a[0].CompareTo(b[0]));


        var pq = new PriorityQueue<int[], (int, int)>();
        int taskIndex=0;
        int currentTime=0;
        List<int> result = new List<int>();
        //for(int i=0;i<n;i++)
        while (result.Count < n)
        {

            while(taskIndex<n && indexedTasks[taskIndex][0]<=currentTime)
            {
                var t= indexedTasks[taskIndex];

                pq.Enqueue(t,(t[1],t[2]));

                taskIndex++;
            }

            if(pq.Count==0)
            {
                currentTime=indexedTasks[taskIndex][0];
                continue;
            }


            var task= pq.Dequeue();
            currentTime+=task[1];
            result.Add(task[2]);
        }

        return result.ToArray();
        
    }
}