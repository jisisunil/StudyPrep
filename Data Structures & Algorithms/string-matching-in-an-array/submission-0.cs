public class Solution {
    public List<string> StringMatching(string[] words) {
        List<string> result = new List<string>();
        Array.Sort(words, (a,b)=>a.Length.CompareTo(b.Length));

        for(int i=0;i<words.Length;i++)
        {
            for(int j=i+1;j<words.Length;j++)
            {
                if(words[j].Contains(words[i]))
                {
                    result.Add(words[i]);
                    break;
                }
            }
        }
        return result;
    }
}