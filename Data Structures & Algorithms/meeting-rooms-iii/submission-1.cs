public class Solution {
    public int MostBooked(int n, int[][] meetings) {

        PriorityQueue<int,int> freerooms= new PriorityQueue<int,int>();
        PriorityQueue<(long endtime,int roomId),(long,int)> busyrooms = new PriorityQueue<(long endtime,int roomId),(long,int)>();
        Array.Sort(meetings, (a,b)=>a[0].CompareTo(b[0]));

        for(int i=0;i<n;i++)
        {
            freerooms.Enqueue(i,i);
        }
        int[] usageCount = new int[n];
        foreach(var meeting in meetings)
        {
            long start = meeting[0];
            long end = meeting[1];
            long duration = end-start;

            while(busyrooms.Count> 0 && busyrooms.Peek().endtime<=start)
            {
                var finished = busyrooms.Dequeue();
                freerooms.Enqueue(finished.roomId, finished.roomId);
            }
          
            if(freerooms.Count>0)
            {
                var room= freerooms.Dequeue();

                busyrooms.Enqueue((start+duration, room), (start+duration, room));
                usageCount[room]++;
            }
            else
            {
                //delayed 

                var delayed = busyrooms.Dequeue();
                var newEnd=delayed.endtime+duration;
                busyrooms.Enqueue((newEnd, delayed.roomId),(newEnd, delayed.roomId));
                usageCount[delayed.roomId]++;

            }
        }
        int result =0;
        for(int i=1;i<n;i++)
        {
            if(usageCount[i]>usageCount[result])
            {
                result=i;
            }
        }
        return result;        
        
    }
}