public class MyHashSet {
    double LoadFactorThreshold = 0.75;
    List<int>[] buckets;
    int size;

    public MyHashSet(int capacity=16) {

        buckets = new List<int>[capacity];
        for(int i=0;i<capacity;i++)
        {
            buckets[i] = new List<int>();
        }
        size=0;
    }

    private int GetIndex(int key)
    {
        int hash = key.GetHashCode() & 0x7fffffff;//gethashcode returns signed integer, & 0x7fffffff is a bit-level operation to make the hash non-negative.
        return hash%buckets.Length;
    }

    private void Resize()
    {
        int newCapapcity = 2*buckets.Length;

        List<int>[] newBuckets = new List<int>[newCapapcity];

        for(int i=0;i<newCapapcity;i++)
        {
            newBuckets[i]= new List<int>();
        }
    // rehash existing keys
        foreach (var bucket in buckets)
        {
            foreach (int key in bucket)
            {
                int newIndex = (key.GetHashCode() & 0x7fffffff) % newCapapcity;
                newBuckets[newIndex].Add(key);
            }
        }
        buckets = newBuckets;
    }
    
    public void Add(int key) {

        int hash = GetIndex(key);
        if(!buckets[hash].Contains(key))
        {
            buckets[hash].Add(key);
            size++;

            if((double)size/buckets.Length > LoadFactorThreshold)
            {
                Resize();
            }
        }
    }
    
    public void Remove(int key) {
        int hash = GetIndex(key);
        if(buckets[hash].Contains(key))
        {
            buckets[hash].Remove(key);
            size--;
        }
    }
    
    public bool Contains(int key) {
        int hash = GetIndex(key);
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