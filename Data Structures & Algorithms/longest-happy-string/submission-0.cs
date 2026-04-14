public class Solution {
    public string LongestDiverseString(int a, int b, int c) {
        var pq = new PriorityQueue<(char c, int frequency),int>();

        if(a>0) pq.Enqueue(('a',a),-a);
        if(b>0) pq.Enqueue(('b', b),-b);
        if(c>0) pq.Enqueue(('c',c), -c);
        var sb = new StringBuilder();
        while (pq.Count > 0) {
            var first = pq.Dequeue();

            var len = sb.Length;

            if(len>=2 && sb[len-1]==first.c && sb[len-2]==first.c)
            {
                //append the next character

                if(pq.Count==0) break;

                var second= pq.Dequeue();
                sb.Append(second.c);
                second.frequency--;
                if(second.frequency>0)
                {
                    pq.Enqueue(second, -second.frequency);
                }

                pq.Enqueue(first, -first.frequency);

            }
            else
            {    
                sb.Append(first.c);
                first.frequency--;
                if(first.frequency>0)
                {
                    pq.Enqueue(first, -first.frequency);
                }
            }          

        }
        return sb.ToString();
    }
}