public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new List<int[]>();

        if(intervals.Length==0)
        {
            result.Add(newInterval);
             return result.ToArray();
           
        }

        foreach(int[] interval in intervals)
        {
            int[] currentInterval = interval;

            if(currentInterval[1]<newInterval[0])
            {
                result.Add(currentInterval);
            }
            else if(currentInterval[0]>newInterval[1])
            {
                result.Add(newInterval);
                newInterval=currentInterval;
            }
            else
            {
                newInterval[0]= Math.Min(currentInterval[0], newInterval[0]);
                newInterval[1] = Math.Max(currentInterval[1], newInterval[1]);
            }

        }

          result.Add(newInterval);
          return result.ToArray();
        
    }
}
