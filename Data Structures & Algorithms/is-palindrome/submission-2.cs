public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length==1)
        {
            return true;
        }


        int left=0;
        int right = s.Length-1;

        while(left<=right)
        {
            while(left<right && !Char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while(left<right && !Char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if(!Char.ToLower(s[left]).Equals(Char.ToLower(s[right])))
            {
                return false;
            }
            left++;
            right--;

        }
        return true;
    }
}
