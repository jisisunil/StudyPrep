public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
        Dictionary<char,char> smap= new Dictionary<char,char>();
        Dictionary<char,char> tmap= new Dictionary<char,char>();

        for(int i=0;i<s.Length;i++)
        {
            if(smap.ContainsKey(s[i]))
            {
                if(smap[s[i]]!=t[i])
                {
                    return false;
                }
            }
            else
            {
                smap[s[i]]=t[i];
            }

            if(tmap.ContainsKey(t[i]))
            {
                if(tmap[t[i]]!=s[i])
                {
                    return false;
                }
            }
            else
            {
                tmap[t[i]] = s[i];
            }
        }
        return true;
    }
}