public class MyHashSet {
    private const int BucketSize=10000;
    private List<int>[] buckets;
    public MyHashSet() {
        buckets = new List<int>[BucketSize];
        for(int i=0;i<BucketSize;i++)
        {
            buckets[i] = new List<int>();
        }
    }

    
    public void Add(int key) {
        
        int hash = key%BucketSize;
        if(!buckets[hash].Contains(key))
        {
            buckets[hash].Add(key);
        }

    }
    
    public void Remove(int key) {
        int hash = key%BucketSize;
        if(buckets[hash].Contains(key))
        {
            buckets[hash].Remove(key);
        }
        
    }
    
    public bool Contains(int key) {
        int hash = key%BucketSize;
        return buckets[hash].Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */