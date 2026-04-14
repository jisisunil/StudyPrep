public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stk=new Stack<int>();
        foreach(string op in operations)
        {
            switch(op)
            {
                case "+":
                {
                    int top = stk.Pop();
                    int newScore = top+stk.Peek();
                    stk.Push(top);
                    stk.Push(newScore);
                }
                break;
                case "D":
                {
                    int newScore=2*(stk.Peek());
                    stk.Push(newScore);
                }
                break;
                case "C":
                {
                    stk.Pop();
                }
                break;
                default:
                {
                    stk.Push(int.Parse(op));
                }
                break;

            }
        }
        return stk.Sum();
        
    }
}