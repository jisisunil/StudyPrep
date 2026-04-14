public class MedianFinder {
     PriorityQueue<int,int> maxHeap;
     PriorityQueue<int,int> minHeap;
    public MedianFinder() {
        maxHeap = new PriorityQueue<int,int>();
        minHeap= new PriorityQueue<int,int>();
    }
    
    public void AddNum(int num) {        
        maxHeap.Enqueue(num,-num);

        if(maxHeap.Count>0&&minHeap.Count>0&& maxHeap.Peek()>minHeap.Peek()){
            int moved = maxHeap.Dequeue();
            minHeap.Enqueue(moved,moved);
        }

        if(maxHeap.Count>minHeap.Count+1)
        {
            int moved = maxHeap.Dequeue();
            minHeap.Enqueue(moved, moved);

        }
        else if (minHeap.Count> maxHeap.Count)
        {
            int moved = minHeap.Dequeue();
            maxHeap.Enqueue(moved,-moved);
        }
        
    }
    
    public double FindMedian() {
        if(maxHeap.Count>minHeap.Count)
        {
            return maxHeap.Peek();
        }
        else
        {
            return (maxHeap.Peek()+minHeap.Peek())/2.0;
        }
    }
}
