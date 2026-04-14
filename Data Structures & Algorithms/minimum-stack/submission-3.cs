public class MinStack {
    private Stack<(int val, int min)> stack;
    public MinStack() {
        stack = new Stack<(int val, int min)>();
    }
    
    public void Push(int val) {
        
        int currentMin = stack.Count==0?val: Math.Min(val, stack.Peek().min);
        stack.Push((val,currentMin));
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().val;
    }

    public int GetMin() {
        return stack.Peek().min;
    }
}
