public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {

        int n = hand.Length;
        if(n%groupSize !=0)
        {
            return false;
        }

        SortedDictionary<int,int> counts = new SortedDictionary<int,int>();
        foreach(var card in hand)
        {
            if(!counts.TryAdd(card,1))
            {
                counts[card]++;
            }
        }

        while(counts.Count>0)
        {
            int start = counts.First().Key;
            for(int i=0;i<groupSize;i++)
            {
                int need = start+i;

                if(!counts.TryGetValue(need, out int c)) return false;

                if(c==1)
                {
                    counts.Remove(need);
                }
                else { counts[need]--;}
            }
        }

        return true;
        
    }
}
