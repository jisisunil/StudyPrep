public class Solution {
    public bool ValidPalindrome(string s) {
        if(s.Length==1) return true;
        int left=0;
        int right= s.Length-1;

        while(left<right)
        {
            if(s[left]!=s[right])
            {
                return CheckPalindrome(s, left+1, right) || CheckPalindrome(s,left, right-1);
            }
            left++;
            right--;
        }
        return true;        
    }
    private bool CheckPalindrome(string s, int left, int right)
    {
        while(left<right)
        {
            if(s[left]!=s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}