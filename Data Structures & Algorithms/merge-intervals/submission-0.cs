public class Solution {
    public int[][] Merge(int[][] intervals) {

        if(intervals.Length<=1) return intervals;

        Array.Sort(intervals, (a,b)=>a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();

        int[] prev = intervals[0];

        merged.Add(prev);

        for(int i=1;i<intervals.Length;i++)
        {
            int[] current = intervals[i];

            if(current[0]<=prev[1])
            {
                prev[1] =Math.Max(current[1], prev[1]);
            }
            else
            {
                prev = current;
                merged.Add(prev);
            }
        }
        return merged.ToArray();
    }
}
