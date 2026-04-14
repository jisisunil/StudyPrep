public class Solution {
    public int Rob(int[] nums) {
        int n=nums.Length;
        if(nums.Length==1) return nums[0];
        if(nums.Length==2) return Math.Max(nums[0],nums[1]);
        int excludeFirst= RobHelper(nums, 1, n-1);
        int excludeLast=RobHelper(nums, 0, n-2);
        return Math.Max(excludeFirst,excludeLast);
    }


    private int RobHelper(int[] nums, int first, int last)
    {
        int prev2= 0;
        int prev1= 0;

        for(int i=first;i<=last;i++)
        {
            int current = Math.Max(prev1, prev2+nums[i]);
            prev2=prev1;
            prev1=current;
        }
        return prev1;

    }
}
