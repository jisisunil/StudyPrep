public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0) return false;
        if(x==0) return true;
        int num=0;
        int original=x;
        while(x>0)
        {
            int digit= x%10;
            x=x/10;
            num=num*10+digit;
        }

        if(num==original) return true;
        return false;
    }
}