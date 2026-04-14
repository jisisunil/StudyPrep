public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s is null && t is null) return true;

        if(s is null || t is null) return false;

        if(s.Length!=t.Length) return false;

        int[] cnt = new int[26];

        for(int i=0;i<s.Length;i++)
        {
            cnt[s[i]-'a']++;
            cnt[t[i]-'a']--;
        }
        for(int i=0;i<26;i++)
        {
            if(cnt[i]!=0) return false;
        }

        return true;
    }
}
