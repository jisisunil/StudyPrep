/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {

        if(intervals == null || intervals.Count==0)
        {
            return 0;
        }

        intervals.Sort((a,b)=>a.start.CompareTo(b.start));

        

        PriorityQueue<int,int> pq= new PriorityQueue<int,int>();

        foreach(var interval in intervals)
        {
            var start = interval.start;
            var end = interval.end;
            if(pq.Count>0 && pq.Peek()<=start)
            {
                var entry = pq.Dequeue();

            }
            pq.Enqueue(end,end);
        }
        return pq.Count;
    }
}
