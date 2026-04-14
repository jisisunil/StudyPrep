public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string,List<string>>();

        foreach(var str in strs)
        {
            int[] cnt = new int[26];

            for(int i=0;i<str.Length;i++)
            {
                cnt[str[i]-'a']++;
            }

            string key= string.Join(',',cnt);

            if(!map.ContainsKey(key))
            {
                map[key]= new List<string>();
            }
            map[key].Add(str);
        }

        return new List<List<string>>(map.Values);
    }
}
