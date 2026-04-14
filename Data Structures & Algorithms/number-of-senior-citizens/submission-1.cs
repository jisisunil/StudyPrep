public class Solution {
    public int CountSeniors(string[] details) {
        

        int count=0;

        for(int i=0;i<details.Length;i++)
        {
            string s = details[i].Substring(11,2);
            int num=0;

            for(int j=0;j<s.Length;j++)
            {
                num=num*10+(s[j]-'0');
            }

            if(num>60)
            {
                count++;
            }
        }
        return count;
    }
}