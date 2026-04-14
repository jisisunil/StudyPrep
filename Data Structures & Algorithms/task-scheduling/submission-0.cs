public class Solution {
    public int LeastInterval(char[] tasks, int n) {

        int[] freq= new int[26];

        for(int i=0;i<tasks.Length;i++)
        {
            freq[tasks[i]-'A']++;
        }

        PriorityQueue<int,int> pq= new PriorityQueue<int,int>();

        foreach(int f in freq)
        {
            if(f>0)
            {
            pq.Enqueue(f,-f);
            }
        }
        
        int time=0;
        while(pq.Count>0)
        {
                int slots= n+1;
                List<int> readd= new List<int>();
                
            
                while(slots>0 && pq.Count>0)
                {

                    int cnt = pq.Dequeue();
                    cnt--;
                    if(cnt>0)
                    {
                        readd.Add(cnt);
                    }
                    slots--;
                    time++;

                }

                foreach(int cnt in readd)
                {
                    pq.Enqueue(cnt,-cnt);
                }

                if(pq.Count>0 && slots>0)
                {
                    time+=slots;
                }
        }
return time;

        
    }
}
