public class Solution {
    public int CalculateTime(string keyboard, string word) {
        
        int[] indexMap = new int[26];

        for(int i=0;i<keyboard.Length;i++)
        {
            indexMap[keyboard[i]-'a']=i;
        }
        int current=0;
        int total=0;

        foreach(var c in word)
        {
            int target = indexMap[c-'a'];
            total+=Math.Abs(current-target);
            current=target;
        }
        return total;

    }
}
