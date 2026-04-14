public class Solution {
    /*dp[i] = number of ways to decode prefix ending at i
    Key rule
If you use "XY" as one letter, then you have consumed two characters at once.
That means:The decoding must have already finished at position i-2
You cannot attach "XY" to something that already used Y or X
So the only valid previous decodings are those that end at i-2.*/
    public int NumDecodings(string s) {

        if(s[0] =='0') return 0;
        int prev2=1;  //dp[i-2] empty string has 1 way to decode;
        int prev1=1;  //dp[i-1]  dp[0] is 1 because First character is guaranteed non-zero (we checked s[0] != '0')

       for(int i=1;i<s.Length;i++)
       {
            int current =0;

            if(s[i]!='0')
            {
                current+=prev1;
            }

            var two = (s[i-1]-'0')*10+(s[i]-'0');

            if(two>=10 && two<=26)
            {
                current +=prev2;
            }

            prev2=prev1;
            prev1=current;
       }
        return prev1;//prev1 now means number of ways to decode the full string
        
    }
}
