public class Solution {
    public int LengthOfLastWord(string s) {

        int right = s.Length-1;
        int length=0;
        while(right>=0 && s[right]==' ')
        {
            right--;
        }
        while(right>=0&&s[right]!=' ')
        {
            right--;
            length++;
        }

        return length;
        
    }
}