public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {

        Stack<int> stk = new Stack<int>();
        int[] result = new int[temperatures.Length];
        for(int i=0;i<temperatures.Length; i++)
        {
            while(stk.Count>0 && temperatures[stk.Peek()]<temperatures[i])
            {
                int index=stk.Pop();
                result[index]=i-index;
            }

            stk.Push(i);
        }
        return result;
    }
}
