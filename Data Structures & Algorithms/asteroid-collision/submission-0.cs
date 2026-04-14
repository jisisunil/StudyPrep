public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        

        Stack<int> stk = new Stack<int>();
        
        foreach(int ast in asteroids)
        {
            bool destroyed=false;;
            while(stk.Count>0 && stk.Peek()>0 && ast<0)
            {
                int top = stk.Peek();
                if(Math.Abs(top)<Math.Abs(ast))
                {
                    stk.Pop();
                    continue;
                }
                else if(Math.Abs(top) == Math.Abs(ast))
                {
                    stk.Pop();
                    destroyed=true;
                    break;
                }
                else
                {
                    destroyed=true;
                    break;
                }
            }
            if(!destroyed)
            {
                stk.Push(ast);
            }
        }
        return stk.Reverse().ToArray();
    }
}