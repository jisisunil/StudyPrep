public class Solution {
    public int LengthOfLongestSubstring(string s) {


        HashSet<char> set= new HashSet<char>();
        int maxLen=0;
        int left=0;
        for(int right=0;right<s.Length;right++)
        {
            while(set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLen=Math.Max(maxLen, right-left+1);
        }
        return maxLen;
    }
}
