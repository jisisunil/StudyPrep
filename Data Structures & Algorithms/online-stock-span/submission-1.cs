public class StockSpanner {

Stack<(int price,int cnt)> stk1;
    public StockSpanner() {
        stk1= new Stack<(int,int)>();
    }
    
    public int Next(int price) {
        int span=1;

        while(stk1.Count >0 && stk1.Peek().price<= price)
        {
            span+=stk1.Pop().cnt;
        }

        stk1.Push((price,span));
        return span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */