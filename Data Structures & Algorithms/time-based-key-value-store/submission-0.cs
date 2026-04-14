public class TimeMap {
    Dictionary<string, List<(int ts, string val)>> map ;
    public TimeMap() {
        map= new Dictionary<string,List<(int,string)>>();
        
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key))
        {
           map[key] = new List<(int, string)>();
        }
        map[key].Add((timestamp,value));
    }
    
    public string Get(string key, int timestamp) {
        if(!map.ContainsKey(key)) return "";
        var values = map[key];
        string result="";
        int left = 0;
        int right = values.Count-1;
        while(left<=right)
        {
            int mid = left+(right-left)/2;
            if(values[mid].ts <= timestamp)
            {
                result = values[mid].val;
                left = mid+1;
            }
            else
            {
                right= mid-1;
            }
        }


        return result;
    }
}
