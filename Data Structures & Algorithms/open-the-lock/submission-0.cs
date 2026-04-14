public class Solution {
    public int OpenLock(string[] deadends, string target) {

        HashSet<string> deads = new HashSet<string>(deadends);

        if(deads.Contains("0000")) return -1;
        
        Queue<(string state, int steps)> q= new Queue<(string state, int steps)>();
        HashSet<string> visited = new HashSet<string>();

        q.Enqueue(("0000",0));

        while(q.Count>0)
        {
            var (current, steps) = q.Dequeue();

            if(current == target) return steps;
            visited.Add(current);
            foreach(string neighbor in GetNextStates(current))
            {
                if(!visited.Contains(neighbor) && !deads.Contains(neighbor))
                {
                    q.Enqueue((neighbor, steps+1));
                    visited.Add(neighbor);
                }
            }
        }
        return-1;        
    }

    private List<string> GetNextStates(string current)
    {
        var result = new List<string>();
        char[] chars = current.ToCharArray();
        for(int i=0;i<chars.Length;i++)
        {
            var original = chars[i];
            chars[i]=original=='9'?'0':(char)(original+1);
            result.Add(new string(chars));
            chars[i]=original=='0'?'9':(char)(original-1);
            result.Add(new string(chars));
            chars[i]=original;
        }
        return result;
    }
}