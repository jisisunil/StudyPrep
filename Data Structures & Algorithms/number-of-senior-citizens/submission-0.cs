public class Solution {
    public int CountSeniors(string[] details) {
        

        int count=0;

        for(int i=0;i<details.Length;i++)
        {
            string s = details[i].Substring(11,2);
            int digit = int.Parse(s);
            if(digit>60)
            {
                count++;
            }
        }
        return count;
    }
}