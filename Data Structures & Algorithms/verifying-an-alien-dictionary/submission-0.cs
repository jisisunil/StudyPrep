public class Solution {
     int[] charorder = new int[26];
    public bool IsAlienSorted(string[] words, string order) {
       
        for(int i=0;i<order.Length;i++)
        {
            charorder[order[i]-'a'] =i;
        }

        for(int i=0;i<words.Length-1;i++)
        {
            if(!CompareWordOrder(words[i], words[i+1]))
                return false;

        }
        return true;
        
    }


    private bool CompareWordOrder(string word1, string word2)
    {
        int minLength = Math.Min(word1.Length, word2.Length);

        for(int i=0;i<minLength;i++)
        {
            if(word1[i]!=word2[i])
            {
                if(charorder[word1[i]-'a'] > charorder[word2[i]-'a'])
                {
                    return false;
                }
                else return true;
            }
        }

        if(word1.Length > word2.Length)
        {
            return false;
        }
        return true;

    }
}