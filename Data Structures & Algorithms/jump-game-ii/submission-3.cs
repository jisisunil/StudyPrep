public class Solution {
    public int Jump(int[] nums) {
        
        int currentend =0;
        int farthest=0;
        int jumps =0;
        for(int i=0;i<nums.Length-1;i++)
        {
            farthest = Math.Max(farthest, i+nums[i]);

            if(i==currentend)
            {
                jumps++;
                currentend = farthest;

                if(currentend> nums.Length-1)
                    return jumps;
            }
        }
        return jumps;
    }
}
