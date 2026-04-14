public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        int[] count = new int[26];
        int[] windowmap= new int[26];

        for(int i=0;i<s1.Length;i++)
        {

            count[s1[i]-'a']++;
        }

        int left=0;

        for(int right=0;right<s2.Length;right++)
        {
            windowmap[s2[right]-'a']++;

            if(right-left+1>s1.Length)
            {
                windowmap[s2[left]-'a']--;
                left++;
            }

            if(AreEqual(count,windowmap))
            {
                return true;
            }
        }
        return false;
    }

    private bool AreEqual(int[]cnt, int[] windowmap)
    {
        for(int i=0;i<26;i++)
        {
            if(cnt[i]!=windowmap[i]) return false;
        }
        return true;
    }
}
