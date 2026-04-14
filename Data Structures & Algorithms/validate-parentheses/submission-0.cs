public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new Stack<char>();

        for(int i=0;i<s.Length;i++)
        {
            char c= s[i];
            if(c=='[')
            {
                stk.Push(']');
            }
            else if(c=='(')
            {
                stk.Push(')');
            }
            else if(c=='{')
            {
                stk.Push('}');
            }
            else
            {
                if(stk.Count==0 || stk.Pop()!=c)
                {
                    return false;
                }
            }            
            
            
        }
        return stk.Count==0;
    }
}
