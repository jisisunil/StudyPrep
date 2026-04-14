public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> wordSet = new HashSet<string>(wordList);
        if(!wordSet.Contains(endWord)) return 0;
        Queue<string> q = new Queue<string>();
        q.Enqueue(beginWord);
        int steps =1;
        while(q.Count>0)
        {
            int size = q.Count;
            for(int s=0;s<size;s++)
            {
                var word = q.Dequeue();
                var chars = word.ToCharArray();
                for(int i=0;i<chars.Length;i++)
                {
                    char original = chars[i];
                    for(char c = 'a'; c<='z'; c++)
                    {
                        if(c == original)
                        {
                            continue;
                        }

                        chars[i] = c;
                        string next = new string(chars);
                        if(next == endWord) return steps+1;
                        if(wordSet.Remove(next))
                        {
                            q.Enqueue(next);
                        }
                    }
                    chars[i]=original;
                }                 
            }
            steps++;           
        }
        return 0;        
    }
}
