public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stk= new Stack<int>();
        foreach(string token in tokens)
        {
            if(token=="+"||token=="-"||token=="*"||token=="/")
            {
                if(stk.Count<2)
                {
                    return -1;
                }
                int op2= stk.Pop();
                int op1= stk.Pop();
                int result =-1;
                switch(token)
                {
                    case "+":
                        result = op1+op2;
                        break;
                    case "-":
                        result= op1-op2;
                        break;
                    case "*":
                        result= op1*op2;
                        break;
                    case "/":
                        result= op1/op2;
                        break;
                    default:
                        return -1;
                        break;
                }
                stk.Push(result);
            }
            else
            {
                stk.Push(int.Parse(token));
            }
        }

        if(stk.Count!=1)
        {
            return -1;
        }
        return stk.Pop();
    }
}
