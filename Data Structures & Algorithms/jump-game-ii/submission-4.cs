public class Solution {
    public int Jump(int[] nums) {
        
        int maxReach=0;
        int currentend=0;
        int jumps=0;
        for(int i=0;i<nums.Length-1;i++)
        {

            maxReach=Math.Max(maxReach,i+nums[i]);

            if(i==currentend)
            {
                jumps++;
                currentend=maxReach;

                if(currentend>nums.Length-1)
                {
                    return jumps;
                }
            }
        }
        return jumps;
    }
}
