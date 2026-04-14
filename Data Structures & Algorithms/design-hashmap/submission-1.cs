public class MyHashMap {
    int[] hash = new int[1_000_001];
    public MyHashMap() {
        for(int i=0;i<hash.Length;i++)
        {
            hash[i]=-1;
        }
    }
    
    public void Put(int key, int value) {
        hash[key]=value;
    }
    
    public int Get(int key) {
        return hash[key];
    }
    
    public void Remove(int key) {
        hash[key]=-1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */