public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count=0;
        int maxCount=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==1)
            {
                count++;
                maxCount=Math.Max(maxCount, count);
            }
            else
            {
                count=0;
            }
        }

        return Math.Max(maxCount, count);
    }
}