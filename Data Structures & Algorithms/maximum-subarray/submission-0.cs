public class Solution {
    public int MaxSubArray(int[] nums) {
        int currentSum = nums[0];

        int maxsum = nums[0];

        for(int i=1;i<nums.Length;i++)
        {
            currentSum = Math.Max(nums[i], currentSum+nums[i]);
            maxsum = Math.Max(maxsum, currentSum);
        }
        return maxsum;
    }
}
