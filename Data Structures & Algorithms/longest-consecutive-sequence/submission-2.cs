public class Solution {
    public int LongestConsecutive(int[] nums) {
        

        if(nums.Length==0) return 0;

        HashSet<int> set = new HashSet<int>(nums);
        int maxLen=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(!set.Contains(nums[i]-1))
            {
                int currentNum = nums[i];
                int currentstreak=1;

                while(set.Contains(currentNum+1))
                {
                    currentNum++;
                    currentstreak++;
                    
                }
                maxLen=Math.Max(maxLen, currentstreak);
            }
        }
        return maxLen;
    }
}
