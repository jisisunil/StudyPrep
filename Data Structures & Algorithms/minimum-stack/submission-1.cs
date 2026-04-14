public class MinStack {
    private Stack<(int val, int min)> st = new Stack<(int, int)>();

    public void Push(int val) {
        int curMin = st.Count == 0 ? val : Math.Min(val, st.Peek().min);
        st.Push((val, curMin));
    }
    public void Pop() => st.Pop();
    public int Top() => st.Peek().val;
    public int GetMin() => st.Peek().min;
}