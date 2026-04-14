public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();
        for(int i=0;i<temperatures.Length;i++)
        {

            while(stack.Count>0 && temperatures[stack.Peek()]<temperatures[i])
            {
                int idx = stack.Pop();
                result[idx]=i-idx;
            }
            stack.Push(i);
        }
        return result;

    }
}
