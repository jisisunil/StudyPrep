public class Solution {
    public bool CheckInclusion(string s1, string s2) {
       if(s1.Length > s2.Length) return false;
       int left=0;
       int[] s1cnt= new int[26];
       int[] s2cnt = new int[26];

       for(int i=0;i<s1.Length;i++)
       {
           s1cnt[s1[i]-'a']++;
       }

        for(int right=0;right<s2.Length;right++)
        {
            s2cnt[s2[right]-'a']++;
            if((right-left+1)>s1.Length)
            {
                s2cnt[s2[left]-'a']--;
                left++;
            }
            if(AreEqual(s1cnt, s2cnt)) return true;

        }
        return false;
    }


    private bool AreEqual(int[] s1cnt, int[] s2cnt)
    {
        for(int i=0;i<26;i++)
        {
            if(s1cnt[i]!=s2cnt[i])
            {
                return false;
            }
        }
        return true;
    }
}
