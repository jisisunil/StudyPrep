public class Solution {
    public int LastStoneWeight(int[] stones) {

        
        //PriorityQueue<int,int> pq = new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=>b.CompareTo(a)));
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
        foreach(int stone in stones)
        {
            pq.Enqueue(stone,-stone);
        }

        while(pq.Count>1)
        {
            int first = pq.Dequeue();
            int second = pq.Dequeue();

            if(second<first)
            {
                int newwt = first-second;
                pq.Enqueue(newwt, -newwt);
            }
            
        }
        //if there are no stones in the priority queue, this will throw zne xception , to avoid that add an entry
        pq.Enqueue(0,0);
        return pq.Peek();
    }
}
