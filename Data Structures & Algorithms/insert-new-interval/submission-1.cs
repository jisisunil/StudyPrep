public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> result= new List<int[]>();
        if(intervals.Length==0)
        {
            result.Add(newInterval);
            return result.ToArray();
        }
        foreach(var interval in intervals)
        {
            var current = interval;
            if(current[1]< newInterval[0])
            {
                result.Add(current);
            }
            else if(current[0]>newInterval[1])
            {
                result.Add(newInterval);
                newInterval = current;

            }
            else
            {
                newInterval[0]=Math.Min(current[0], newInterval[0]);
                newInterval[1] = Math.Max(current[1],newInterval[1]);               
            }
        }
        result.Add(newInterval);
        return result.ToArray();
        
    }
}
