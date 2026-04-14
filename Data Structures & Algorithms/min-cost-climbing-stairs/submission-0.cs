public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n=cost.Length;
        if(n==1) return cost[0];
        int first= cost[0];
        int second = cost[1];
        for(int i=2;i<n;i++)
        {
            int current = cost[i]+Math.Min(first,second);
            first = second;
            second = current;
        }
        return Math.Min(first,second);
    }
}
