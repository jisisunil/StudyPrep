public class FreqStack {

    Dictionary<int,int> freq ;
    Dictionary<int, Stack<int>> group;
    int maxFreq;
    public FreqStack() {
        freq = new Dictionary<int,int>();
        group= new Dictionary<int, Stack<int>>();
        maxFreq=0;
    }
    
    public void Push(int val) {

        if(!freq.ContainsKey(val))
        {
            freq[val]=0;
        }
        freq[val]++;

        int frequency = freq[val];

        if(!group.ContainsKey(frequency))
        {
            group[frequency]= new Stack<int>();
        }
        group[frequency].Push(val);

        if(frequency>maxFreq)
        {
            maxFreq = frequency;
        }
        
    }
    
    public int Pop() {

        var groupStack = group[maxFreq];

        int val = groupStack.Pop();
        freq[val]--;
        if(groupStack.Count==0)
        {
            group.Remove(maxFreq);
            maxFreq--;
        }
        return val;
        
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */