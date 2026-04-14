public class MedianFinder
{
    PriorityQueue<int, int> maxHeap;
    PriorityQueue<int, int> minHeap;

    public MedianFinder()
    {
        maxHeap = new PriorityQueue<int, int>(); // max heap using -priority
        minHeap = new PriorityQueue<int, int>(); // min heap
    }

    public void AddNum(int num)
    {
        // Step 1: add to maxHeap
        maxHeap.Enqueue(num, -num);

        // Step 2: move largest from maxHeap → minHeap
        int moved = maxHeap.Dequeue();
        minHeap.Enqueue(moved, moved);

        // Step 3: balance size
        if (minHeap.Count > maxHeap.Count)
        {
            int back = minHeap.Dequeue();
            maxHeap.Enqueue(back, -back);
        }
    }

    public double FindMedian()
    {
        if (maxHeap.Count > minHeap.Count)
        {
            return maxHeap.Peek();
        }
        else
        {
            return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
        }
    }
}
