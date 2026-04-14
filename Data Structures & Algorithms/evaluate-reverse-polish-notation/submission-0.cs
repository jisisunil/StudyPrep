public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stk = new Stack<int>();
        if (tokens == null || tokens.Length == 0) {
            return 0;
        }
 
        foreach(string token in tokens){
            if(token=="+"|| token=="-"||token=="*"||token=="/"){
                if(stk.Count<2)
                    throw new InvalidOperationException("Invalid RPN expression: not enough operands for operator.");
 
                // The order is crucial: the first popped is operand2, the second is operand1.
                int operand2 = stk.Pop();
                int operand1 = stk.Pop();
                int result;
                switch(token){
                    case "+":
                        result=operand1+operand2;
                        break;
                    case "-":
                        result=operand1-operand2;
                        break;
                    case "*":
                        result=operand1*operand2;
                        break;
                    case "/":
                        result=operand1/operand2;
                        break;
                    default:
                        throw new ArgumentException("Invalid operator.");
                }
                stk.Push(result);
            }
            else{
                // Handle the edge case of an invalid number format.
                if (int.TryParse(token, out int number)) {
                    stk.Push(number);
                } else {
                    throw new ArgumentException("Invalid token in expression: " + token);
                }
            }
        }
 
        if (stk.Count != 1) {
            throw new InvalidOperationException("Invalid RPN expression: too many operands.");
        }
       
        return stk.Pop();
    }
}
