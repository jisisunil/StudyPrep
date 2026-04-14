public class Solution {
    public int CountCharacters(string[] words, string chars) {
        
        //List<char> set = new List<char>(chars);
  
        int totalCount=0;
        foreach(var word in words)
        {
            int count=0;
            List<char> set = new List<char>(chars);
            foreach(var c in word)
            {
                if(!set.Contains(c)) 
                    {
                        count=0;
                        break;
                    }
                set.Remove(c);
                count++;
            }

            totalCount+=count;
            
        }
        return totalCount;
    }
}