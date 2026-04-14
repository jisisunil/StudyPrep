public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
        char[] merged = new char[word1.Length+word2.Length];

        int left1=0;
        int left2=0;
        int runner=0;
        while(left1<word1.Length && left2<word2.Length)
        {
            merged[runner++]=word1[left1++];
            merged[runner++]=word2[left2++];
        }

        while(left1<word1.Length)
        {
            merged[runner++]=word1[left1++];
        }
        while(left2<word2.Length)
        {
            merged[runner++]=word2[left2++];
        }

        return new string(merged);
    }
}