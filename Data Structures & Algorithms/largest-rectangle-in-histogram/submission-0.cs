public class Solution {
    public int LargestRectangleArea(int[] heights) {
        

        Stack<int> stk= new Stack<int>();
        int n= heights.Length;
        int maxArea=0;

        for(int i=0;i<=n;i++)
        {
            int curHeight=(i==n)?0:heights[i];

            while(stk.Count>0 && curHeight<heights[stk.Peek()])
            {
                int topIndex= stk.Pop();
                int height = heights[topIndex];

                int leftIndex = (stk.Count==0)?-1:stk.Peek();

                int width= i-leftIndex-1;
                int area = height*width;
                maxArea = Math.Max(maxArea, area);
            }
            stk.Push(i);
        }
        return maxArea;
    }
}
