public class MyHashMap
{
    private const double LoadFactorThreshold = 0.75;

    private List<KeyValuePair<int, int>>[] buckets;
    private int size;

    public MyHashMap(int capacity = 16)
    {
        buckets = new List<KeyValuePair<int, int>>[capacity];
        for (int i = 0; i < capacity; i++)
        {
            buckets[i] = new List<KeyValuePair<int, int>>();
        }
        size = 0;
    }

    private int GetIndex(int key)
    {
        int hash = key.GetHashCode() & 0x7fffffff;
        return hash % buckets.Length;
    }

    public void Put(int key, int value)
    {
        int index = GetIndex(key);
        var bucket = buckets[index];

        for (int i = 0; i < bucket.Count; i++)
        {
            if (bucket[i].Key == key)
            {
                bucket[i] = new KeyValuePair<int, int>(key, value);
                return;
            }
        }

        bucket.Add(new KeyValuePair<int, int>(key, value));
        size++;

        if ((double)size / buckets.Length > LoadFactorThreshold)
        {
            Resize();
        }
    }

    public int Get(int key)
    {
        int index = GetIndex(key);
        var bucket = buckets[index];

        foreach (var pair in bucket)
        {
            if (pair.Key == key)
            {
                return pair.Value;
            }
        }

        return -1;
    }

    public void Remove(int key)
    {
        int index = GetIndex(key);
        var bucket = buckets[index];

        for (int i = 0; i < bucket.Count; i++)
        {
            if (bucket[i].Key == key)
            {
                bucket.RemoveAt(i);
                size--;
                return;
            }
        }
    }

    private void Resize()
    {
        int newCapacity = buckets.Length * 2;
        var newBuckets = new List<KeyValuePair<int, int>>[newCapacity];

        for (int i = 0; i < newCapacity; i++)
        {
            newBuckets[i] = new List<KeyValuePair<int, int>>();
        }

        foreach (var bucket in buckets)
        {
            foreach (var pair in bucket)
            {
                int newIndex = (pair.Key.GetHashCode() & 0x7fffffff) % newCapacity;
                newBuckets[newIndex].Add(pair);
            }
        }

        buckets = newBuckets;
    }
}


/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */