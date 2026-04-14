public class Solution {
    public string ReorganizeString(string s) {
        var frequency = new Dictionary<char, int>();
        foreach (char c in s) {
            frequency[c] = frequency.GetValueOrDefault(c, 0) + 1;
        }

        // Max-heap via negative frequency
        var pq = new PriorityQueue<(char c, int frequency), int>();
        foreach (var entry in frequency) {
            pq.Enqueue((entry.Key, entry.Value), -entry.Value);
        }

        var sb = new StringBuilder();

        while (pq.Count > 1) {
            var first = pq.Dequeue();
            var second = pq.Dequeue();

            sb.Append(first.c);
            sb.Append(second.c);

            if (--first.frequency > 0)
                pq.Enqueue(first, -first.frequency);

            if (--second.frequency > 0)
                pq.Enqueue(second, -second.frequency);
        }

        if (pq.Count > 0) {
            var last = pq.Dequeue();
            if (last.frequency > 1) return string.Empty;
            sb.Append(last.c);
        }

        return sb.ToString();
    }
}
