public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums==null) return 0;

        HashSet<int> set = new HashSet<int>(nums);
        int maxLen=0;
        foreach(int num in set)
        {
            if(!set.Contains(num-1))
            {
                int currentNum= num;
                int currentStreak =1;
            
            while(set.Contains(currentNum+1))
            {
                currentNum++;
                currentStreak++;
            }
            maxLen= Math.Max(maxLen, currentStreak);
            }
        }
        return maxLen;
    }
}
