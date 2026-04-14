public class Solution {
    public char FindTheDifference(string s, string t) {
        if(s=="") return t[0];

        int[] scnt = new int[26];
        for(int i=0;i<s.Length;i++)
        {
            scnt[s[i]-'a']++;
        }

        for(int i=0;i<t.Length;i++)
        {
            if(--scnt[t[i]-'a'] <0)
                return t[i];
        }
        return ' ';
    }
}