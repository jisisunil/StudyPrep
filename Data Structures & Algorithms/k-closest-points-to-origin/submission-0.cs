public class Solution {
    public int[][] KClosest(int[][] points, int k) {

        PriorityQueue<(int x, int y, int dist), int> maxHeap = new PriorityQueue<(int x, int y, int dist),int>();

        foreach(int[] point in points)
        {
            int x = point[0];
            int y = point[1];

            int distance = x*x+y*y;

            maxHeap.Enqueue((x,y,distance), -distance);
            if(maxHeap.Count>k)
            {
                maxHeap.Dequeue();
            }
        }
        List<int[]> result = new List<int[]>();

        while(maxHeap.Count>0)
        {
            var point = maxHeap.Dequeue();
            result.Add(new int[]{point.x,point.y});
        }
        return result.ToArray();
        
    }
}
