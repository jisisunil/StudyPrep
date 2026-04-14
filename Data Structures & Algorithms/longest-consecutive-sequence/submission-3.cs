public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums==null || nums.Length==0) return 0;

        HashSet<int> set = new HashSet<int>(nums);
        int maxLen=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(!set.Contains(nums[i]-1))
            {
                int currentnum = nums[i];
                int currentStreak=1;

                while(set.Contains(currentnum+1))
                {
                    currentnum++;
                    currentStreak++;
                }

                maxLen=Math.Max(maxLen, currentStreak);
            }


        }
        return maxLen;

    }
}
