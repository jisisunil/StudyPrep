public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> result = new List<List<string>>();
        List<string> current = new List<string>();
        dfs(s,0,current, result);
        return result;
    }


    private void dfs(string s,int start,List<string> current, List<List<string>> result)
    {
        if(start==s.Length)
        {
            result.Add(new List<string>(current));
            return;
        }

        for(int end = start ; end<s.Length;end++)
        {
            if(!ispalindrome(s, start, end)) continue;
            current.Add(s.Substring(start,end-start+1));
            dfs(s, end+1, current, result);
            current.RemoveAt(current.Count-1);
        }
    }

    private bool ispalindrome(string s, int start, int end)
    {
        while(start<end)
        {
            if(s[start++]!=s[end--]) return false;
        }
        return true;
    }
}
