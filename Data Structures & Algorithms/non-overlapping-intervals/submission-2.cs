public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if(intervals.Length<2) return 0;

        Array.Sort(intervals,(a,b)=>a[1].CompareTo(b[1]));

        int[] prev= intervals[0];
        int overlap=0;
        for(int i=1;i<intervals.Length;i++)
        {
            int[] current = intervals[i];

            if(current[0]>=prev[1])
            {
                prev = current;
            }
            else
            {
                overlap++;
            }
        }
        return overlap;
    }
}
