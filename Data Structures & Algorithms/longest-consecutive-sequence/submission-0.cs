public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);

        int maxLength =0;
        foreach(int num in set)
        {
            if(!set.Contains(num-1))
            {
                int currentNum = num;
                int currentStreak =1;

                while(set.Contains(currentNum+1))
                {
                    currentNum++;
                    currentStreak++;
                }

                maxLength = Math.Max(maxLength, currentStreak);
            }
        }

        return maxLength;
    }
}
