public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {        
     int n=queries.Length;
     int[] result = new int[n];
     PriorityQueue<(int length, int right), int> pq = new PriorityQueue<(int,int),int>();
     Array.Sort(intervals, (a,b)=>a[0].CompareTo(b[0]));
     (int val,int index)[] sortedQueries = new (int val, int index)[n];
     for(int i=0;i<n;i++)
     {
        sortedQueries[i]=(queries[i],i);
     }
     Array.Sort(sortedQueries,(a,b)=>a.val.CompareTo(b.val));
     int ptr=0;
     foreach(var (q,idx) in sortedQueries)
     {       
        while(ptr<intervals.Length && intervals[ptr][0]<=q)
        {
            int left = intervals[ptr][0];
            int right = intervals[ptr][1];
            int length = right-left+1;

            pq.Enqueue((length, right),length);
            ptr++;
        }

        while(pq.Count>0 && pq.Peek().right<q)
        {
            pq.Dequeue();
        }
        

        result[idx]=pq.Count>0?pq.Peek().length:-1;
    }
    return result;
    }
}
