public class Solution {
    public int MaxDifference(string s) {
        
        int[] frequency = new int[26];
        foreach(var c in s)
        {
            frequency[c-'a']++;
        }
        int maxOddFreq=int.MinValue;
        int minEvenFreq=int.MaxValue;
        foreach(var freq in frequency)
        {
            if(freq==0) continue;
               if(freq%2==1)
               {
                maxOddFreq = Math.Max(maxOddFreq, freq);
               }
               else
               {
                minEvenFreq = Math.Min(minEvenFreq, freq);
               }
        }

        if(maxOddFreq==int.MinValue || minEvenFreq == int.MaxValue)
        {
            return -1;
        }
        return maxOddFreq-minEvenFreq;
    }
}