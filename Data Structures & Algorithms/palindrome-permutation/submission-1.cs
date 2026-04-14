public class Solution {
    public bool CanPermutePalindrome(string s) {
        int[] cnt= new int[26];
        for(int i=0;i<s.Length;i++)
        {
            cnt[s[i]-'a']++;
        }
        int oddCount=0;
        foreach(int count in cnt)
        {
            if(count%2!=0)
            {
                oddCount++;
            }
        }
        return oddCount<=1;
    }
}
