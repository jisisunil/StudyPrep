public class Solution {
    public int Rob(int[] nums) {
        
        int n = nums.Length;

        if(n==1) return nums[0];

        if(n==2) return Math.Max(nums[0], nums[1]);

        int prev2= 0;

        int prev1 = 0;

        foreach(var num in nums)
        {
            int current = Math.Max(prev1, prev2+num);
            prev2=prev1;
            prev1=current;
        }
        
        return prev1;
    }
}
