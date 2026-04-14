public class MyQueue {
    Stack<int> stk1;
    Stack<int> stk2;        
    public MyQueue() {
        stk1=new Stack<int>();
        stk2= new Stack<int>();
    }
    
    public void Push(int x) {
        stk1.Push(x);
    }
    
    public int Pop() {
        Move();
        return stk2.Pop();
    }
    
    public int Peek() {
        Move();
        return stk2.Peek();
    }
    
    public bool Empty() {
        return stk1.Count==0 && stk2.Count==0;
    }

    private void Move()
    {
        if(stk2.Count==0)
        {
            while(stk1.Count>0)
            {
                stk2.Push(stk1.Pop());
            }
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */