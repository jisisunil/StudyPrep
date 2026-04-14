public class Solution {
    //The key idea is to track the furthest index you can reach as you iterate.
    public bool CanJump(int[] nums) {

        int maxReach =0;

        for(int i=0;i<nums.Length;i++)
        {
            if(i> maxReach)
            {
                return false;
            }
            maxReach = Math.Max(maxReach, i+nums[i]);
            if(maxReach>nums.Length-1)
            {
                return true;
            }

           
        }

        return true;
        
    }
}
