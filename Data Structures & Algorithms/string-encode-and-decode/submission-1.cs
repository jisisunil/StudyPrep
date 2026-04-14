public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var str in strs)
        {
            sb.Append(str.Length).Append("#").Append(str);
        }
        return sb.ToString();
        
    }

    public List<string> Decode(string s) {
        List<string> decoded=new List<string>();

        int i=0;
        while(i<s.Length)
        {
            int index=i;

            while(index<s.Length && s[index]!='#')
            {
                index++;
            }

            int length = int.Parse(s.Substring(i, index-i));
            
            i=index+1;

            string str = s.Substring(i, length);

            decoded.Add(str);

            i+=length;
        }

        return decoded;

   }
}
