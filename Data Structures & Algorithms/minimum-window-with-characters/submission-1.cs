public class Solution {
    public string MinWindow(string t, string s) {
        int minLength=int.MaxValue;
        if(t.Length<s.Length) return "";
        Dictionary<char, int> need = new Dictionary<char,int>();
        Dictionary<char, int> have = new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++)
        {
            if(!need.ContainsKey(s[i]))
            {
                need[s[i]]=0;
            }
            need[s[i]]++;
        }

        int matches =0;
        int left=0;
        int minstart =0;

        for(int right=0;right<t.Length;right++)
        {

            if(need.ContainsKey(t[right]))
            {
                if(!have.ContainsKey(t[right]))
                {
                    have[t[right]]=0;
                }
                have[t[right]]++;
                if(need[t[right]]== have[t[right]])
                {
                    matches++;
                }
            }

            while(matches==need.Count)
            {
                if(right-left+1<minLength)
                {
                    minLength = right-left+1;
                    minstart = left;
                }
                char leftchar = t[left];

                if(need.ContainsKey(leftchar))
                {
                    have[leftchar]--;                    

                    if(have[leftchar]<need[leftchar])
                    {
                        matches--;
                    }
                }
                left++;

            }
        }
        return minLength==int.MaxValue?"":t.Substring(minstart,minLength);

    }
}
