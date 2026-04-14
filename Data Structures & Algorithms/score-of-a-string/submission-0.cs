public class Solution {
    public int ScoreOfString(string s) {
        int sum=0;
        for(int i=1;i<s.Length;i++)
        {
            int diff = Math.Abs(s[i]-s[i-1]);
            sum+=diff;
        }
        return sum;
    }
}