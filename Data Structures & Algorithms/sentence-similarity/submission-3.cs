public class Solution {
    public bool AreSentencesSimilar(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs) {
        if(sentence1.Length!=sentence2.Length) return false;
        
        HashSet<string> set = new HashSet<string>();
        foreach(var list in similarPairs)
        {
            //set.Add(list[0]+"#"+list[1]);
            //set.Add(list[1]+"#"+list[0]);

            set.Add(list[0]+list[1]);
            set.Add(list[1]+list[0]);
        }


        for(int i=0;i<sentence1.Length;i++)
        {
            if(sentence1[i]==sentence2[i])
            { 
                continue;
            }
            if(!set.Contains(sentence1[i]+sentence2[i]))
            {
                return false;
            }
        }
        return true;
    }
}
