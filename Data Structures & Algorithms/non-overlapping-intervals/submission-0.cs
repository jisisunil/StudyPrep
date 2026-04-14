public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if(intervals.Length==0) return 0;

        Array.Sort(intervals, (a,b)=>a[1].CompareTo(b[1]));

        int prevEnd = intervals[0][1];
        int overlap=0;
        for(int i=1;i<intervals.Length;i++)
        {
            int currentStart = intervals[i][0];

            if(currentStart>=prevEnd)
            {
                prevEnd = intervals[i][1];
            }
            else
            {
                overlap++;
            }
        }
        return overlap;
    }
}
