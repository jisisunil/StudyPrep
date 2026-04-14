public class Solution {
    public int CountSubstrings(string s) {
        
        int count=0;

        for(int i=0;i<s.Length;i++)
        {
            count+=ExpandAroundCenter(s, i,i);
            count+=ExpandAroundCenter(s, i, i+1);
        }
        return count;
    }

    private int ExpandAroundCenter(string s, int left, int right)
    {
        int count=0;
        while(left>=0 && right<s.Length&& s[left]==s[right])
        {
            count++;
            left--;
            right++;
        }
        return count;
    }
}
