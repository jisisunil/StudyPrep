public class Solution {
    public int LengthOfLIS(int[] nums) {
        
        if(nums==null || nums.Length==0) return 0;
        int n= nums.Length;
        int[] dp=new int[n];
        for(int i=0;i<n;i++)
        {
            dp[i]=1;
        }

        int maxLen=1;
        for(int i=1;i<n;i++)
        {
            for(int j=0;j<i;j++)
            {
                if(nums[j]<nums[i])
                {
                    dp[i]=Math.Max(dp[i],dp[j]+1);
                }
            }
            maxLen=Math.Max(maxLen, dp[i]);
        }
        return maxLen;
    }
}
