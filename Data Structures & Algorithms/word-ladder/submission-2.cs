public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> wordSet = new HashSet<string>(wordList);

        if(!wordSet.Contains(endWord)) return 0;

        Queue<(string word, int steps)> q = new Queue<(string word, int steps)>();
        q.Enqueue((beginWord,1));

        while(q.Count>0)
        {
            var (word, steps) = q.Dequeue();
            if(word==endWord) return steps;
            char[] chars = word.ToCharArray();
            for(int i=0;i<chars.Length;i++)
            {
                char original = chars[i];
                for(char c='a';c<='z';c++)
                {
                    if(c==original) continue;
                    chars[i]=c;
                    var newword = new string(chars);
                    if(wordSet.Contains(newword))
                    {
                        q.Enqueue((newword, steps+1));
                        wordSet.Remove(newword);
                    }
                }
                chars[i]=original;
            }
        }
        return 0;
        
    }
}
