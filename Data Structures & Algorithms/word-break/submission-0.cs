public class Solution {
    private HashSet<string> wordSet;
    private HashSet<int> invalidPositions;
    public bool WordBreak(string s, List<string> wordDict) {
        wordSet = new HashSet<string>(wordDict);
        invalidPositions = new HashSet<int>();
        return DFS(s,0);    
    }

    private bool DFS(string s, int start)
    {
        if(start == s.Length) return true;

        if(invalidPositions.Contains(start))
        {
            return false;
        }

        for(int end=start+1;end<=s.Length;end++)
        {
            if(wordSet.Contains(s.Substring(start, end-start)) && DFS(s, end))
            {
                return true;
            }
        }

        invalidPositions.Add(start);
        return false;
    }
}
