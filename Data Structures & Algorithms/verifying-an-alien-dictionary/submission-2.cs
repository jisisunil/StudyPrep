public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        int[] charorder= new int[26];
        for(int i=0;i<order.Length;i++)
        {
            charorder[order[i]-'a']=i;
        }

        for(int i=1;i<words.Length;i++)
        {
            bool isvalid = CheckAlienSorted(words[i-1], words[i], charorder);
            if(!isvalid) return false;
        }

        return true;
    }

    private bool CheckAlienSorted(string w1, string w2, int[] charorder)
    {
            int minlen = Math.Min(w1.Length, w2.Length);
            if(w1.Length > w2.Length && w1.StartsWith(w2)) return false;
            for(int j=0;j<minlen;j++)
            {
                if(w1[j]!=w2[j])
                {
                    if(charorder[w1[j]-'a'] > charorder[w2[j]-'a'])
                    { 
                        return false;
                    }
                    else return true;
                }
            } 

        return true;
    }
}
        
    

    
         

