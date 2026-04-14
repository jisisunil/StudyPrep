public class LRUCache {

   Dictionary<int, LinkedListNode<(int,int)>> dict = new Dictionary<int, LinkedListNode<(int,int)>>();
            LinkedList<(int,int)> lastUsedKeys = new LinkedList<(int,int)>();
    
            int Capacity;
    
            public LRUCache(int capacity)
            {
                Capacity = capacity;
            }
    
            public int Get(int key)
            {
                //case 1: Not present return -1
                if (!dict.TryGetValue(key, out var node))
                    return -1;
                
                lastUsedKeys.Remove(node);
                lastUsedKeys.AddLast(node);
                return node.Value.Item2;
            }
    
            public void Put(int key, int value)
            {
                //case 1 if it exists already remove 
                if (dict.TryGetValue(key, out var node))
                    lastUsedKeys.Remove(node);
               
                //case 2: Not exists but already met capacity
                //Remove the oldest/Least recently used which is at the first
                else if (dict.Count >= Capacity)
                {
                    dict.Remove(lastUsedKeys.First.Value.Item1);
                    lastUsedKeys.RemoveFirst();
                }

                //case 3: Capacity not met and its not present.Add to the end 
                lastUsedKeys.AddLast((key, value));
                dict[key] = lastUsedKeys.Last;
            }
}
