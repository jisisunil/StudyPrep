public class Solution {
    public bool CheckInclusion(string s1, string s2) {
       if(s1.Length>s2.Length) return false;
        int[] need= new int[26];
        int[] have = new int[26];
        
        for(int i=0;i<s1.Length;i++)
        {
            need[s1[i]-'a']++;
            have[s2[i]-'a']++;
        }
        
        int matches=0;
        for(int i=0;i<26;i++)
        {
            if(need[i]==have[i])
            {
                matches++;
            }
        }
        
        if(matches==26)
        {
            return true;
        }
        int left=0;
        for(int right= s1.Length;right<s2.Length;right++)
        {
            have[s2[right]-'a']++;
            if(have[s2[right]-'a'] == need[s2[right]-'a'] )
            {
                matches++;
            }
            else if(have[s2[right]-'a'] == need[s2[right]-'a']+1)
            {
                matches--;
            }
            
            have[s2[left]-'a']--;
            
            if(have[s2[left]-'a']==need[s2[left]-'a'])
            {
                matches++;
            }
            else if(have[s2[left]-'a']==need[s2[left]-'a']-1)
            {
                matches--;
            }
            
            left++;
            
            if(matches==26) return true;
        }
        return matches==26;

    }
}
