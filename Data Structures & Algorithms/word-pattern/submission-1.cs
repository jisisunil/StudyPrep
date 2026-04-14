public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char,string> patternMap = new Dictionary<char,string>();
        Dictionary<string, char> sMap = new Dictionary<string,char>();
        string[] strs = s.Split(' ');
        if(pattern.Length!=strs.Length) return false;
        for(int i=0;i<pattern.Length;i++)
        {
            if(patternMap.ContainsKey(pattern[i]) )
            {
                if(patternMap[pattern[i]]!= strs[i])
                {
                    return false;
                }
            }
            else
            {
                patternMap[pattern[i]]=strs[i];
            }
            
            if(sMap.ContainsKey(strs[i]))
            {
                if(sMap[strs[i]]!= pattern[i])
                {
                    return false;
                }
            }
            else
            {
                sMap[strs[i]] = pattern[i];
            }


        }
        return true;
    }
}