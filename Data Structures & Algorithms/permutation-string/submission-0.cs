public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length>s2.Length) return false;
        int[] s1count = new int[26];
        int[] s2count = new int[26];

        for(int i=0;i<s1.Length;i++)
        {
            s1count[s1[i]-'a']++;
            s2count[s2[i]-'a']++;
        }

        int matches=0;

        for(int i=0;i<26;i++)
        {
            if(s1count[i]==s2count[i])
            {
                matches++;
            }
        }

        if(matches == 26) return true;
        int l=0;
        for(int i=s1.Length;i<s2.Length;i++)
        {
            if(matches==26) return true;

            s2count[s2[i]-'a']++;
            if(s1count[s2[i]-'a']==s2count[s2[i]-'a'])
            {
                matches++;
            }
            else if(s1count[s2[i]-'a']+1 == s2count[s2[i]-'a'])
            {
                matches--;
            }

            s2count[s2[l]-'a']--;
            if(s1count[s2[l]-'a']==s2count[s2[l]-'a'])
            {
                matches++;
            }
            else if(s1count[s2[l]-'a']-1 == s2count[s2[l]-'a'])
            {
                matches--;
            }
            l++;

        }
        return matches==26;
    }
}
