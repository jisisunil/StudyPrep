public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26];
        int left =0;
        int right=0;
        int maxLen=0;
        int maxCount=0;
        while(right<s.Length)
        {
            count[s[right]-'A']++;
            maxCount = Math.Max(maxCount, count[s[right]-'A']);

               if((right-left+1)-maxCount> k)
               {
                count[s[left]-'A']--;
                left++;
               }
               maxLen=Math.Max(maxLen, right-left+1);
               right++;
        }
        return maxLen;
    }
}
