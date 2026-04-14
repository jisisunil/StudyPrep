public class Solution {
    public int MaxNumberOfBalloons(string text) {
        
        int[] tcnt = new int[26];

        foreach(var c in text)
        {
            tcnt[c-'a']++;
        }

        string word="balloon";
        int[] bcnt=new int[26];
        foreach(var c in word)
        {
            bcnt[c-'a']++;
        }
        int result = int.MaxValue;
        for(int i=0;i<26;i++)
        {
            if(bcnt[i]>0)
                result= Math.Min(result, tcnt[i]/bcnt[i]);
        }

        return result;

    }
}