public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] cnt = new int[26];
        if(s.Length!=t.Length) return false;
        for(int i=0;i<s.Length;i++)
        {
            cnt[s[i]-'a']++;
            cnt[t[i]-'a']--;
        }

        for(int i=0;i<26;i++)
        {
            if(cnt[i]!=0)
                return false;
        }
        return true;
    }
}
