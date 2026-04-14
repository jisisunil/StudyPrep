public class Solution {

    public string Encode(IList<string> strs) {
     StringBuilder encoded = new StringBuilder();
     foreach(string str in strs)
     {
        encoded.Append(str.Length).Append('#').Append(str);
     }
     return encoded.ToString();

    }
    //4#neet4#code4#love3#you
    public List<string> Decode(string s) {         
        int i=0;
        List<string> decoded = new List<string>();
        while(i<s.Length)
        {
            int index=i;
            while(index<s.Length&& s[index]!='#')
            {
                index++;
            }
            int length = int.Parse(s.Substring(i, index-i));
            i=index+1;
            string str = s.Substring(i,length);
            decoded.Add(str);
            i+=length;
        }
        return decoded;
   }
}
