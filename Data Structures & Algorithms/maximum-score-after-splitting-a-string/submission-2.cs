public class Solution {
    public int MaxScore(string s) {
        int leftZeroes=0;
        int rightOnes=0;
        int score=0;
        int totalOnes=0;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='1') totalOnes++;
        }

        for(int i=0;i<s.Length-1;i++)
        {
            if(s[i]=='0')
                leftZeroes++;
            
            if(s[i] == '1')
                rightOnes++;
            
            score = Math.Max(score, leftZeroes+totalOnes-rightOnes);
        }
        return score;
        
    }
}