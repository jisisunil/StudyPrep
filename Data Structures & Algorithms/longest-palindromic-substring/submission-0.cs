public class Solution {
    public string LongestPalindrome(string s) {
        if(string.IsNullOrEmpty(s)) return "";
        int start=0;
        int maxLen=0;

        for(int i=0;i<s.Length;i++)
        {
            ExpandAroundCenter(s, i, i, ref start, ref maxLen);
            ExpandAroundCenter(s, i,i+1, ref start, ref maxLen);
        }

        return s.Substring(start, maxLen);
    }

    private void ExpandAroundCenter(string s, int left, int right, ref int start, ref int maxLen)
    {

        while(left>=0 && right<s.Length && s[left]==s[right])
        {
            int len= right-left+1;
            if(len>maxLen)
            {
                maxLen=len;
                start =left;
            }
            left--;
            right++;
        }
    }
}
