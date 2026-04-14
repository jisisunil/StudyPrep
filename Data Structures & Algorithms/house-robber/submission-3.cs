public class Solution {
    public int Rob(int[] nums) {
        
        int n = nums.Length;

        if(n==1) return nums[0];

        if(n==2) return Math.Max(nums[0], nums[1]);

        int prev2= nums[0];

        int prev1 = Math.Max(nums[0], nums[1]);

        for(int i=2;i<n;i++)
        {
            int current = Math.Max(prev1, // skip current house
                                prev2+nums[i]); //rob current house

            prev2=prev1;
            prev1=current;

        }
        return prev1;
    }
}
