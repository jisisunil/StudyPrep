public class Solution {  
    public List<string> GenerateParenthesis(int n) {

        List<string> result= new List<string>();
        backtrack(n, result, 0,0,"");
        return result;

    }


    private void backtrack(int max, List<string> result, int open, int close, string current)
    {
        if(current.Length==2*max)
        {
            result.Add(current);
            return;
        }
        if(open<max)
        {
            backtrack(max, result, open+1, close, current+'(');
        }

        if(close<open)
        {
            backtrack(max, result, open, close+1, current+')');
        }
       
    }
}
