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
    
    public bool CanAttendMeetings(List<Interval> intervals) {
        if (intervals == null || intervals.Count <= 1)
            return true; 
        intervals.Sort((a,b)=>a.start.CompareTo(b.start));

        var prev = intervals[0];

        for(int i=1;i<intervals.Count;i++)
        {
            var current = intervals[i];
            if(prev.end>current.start)
            {
                return false;
            }

            prev=current;
        }
        return true;
    }
}
