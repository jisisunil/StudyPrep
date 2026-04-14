public class Solution {
    public string DecodeString(string s) {
        Stack<int> cnt=new Stack<int>();
        Stack<StringBuilder> sbStack= new Stack<StringBuilder>();

        int currentNum=0;
        StringBuilder currentStr=new StringBuilder();
        foreach(var c in s)
        {
            if(Char.IsDigit(c))
            {
                currentNum= currentNum*10+(c-'0');
            }
            else if(c=='[')
            {
                cnt.Push(currentNum);
                sbStack.Push(currentStr);

                currentNum=0;
                currentStr= new StringBuilder();
            }
            else if(c==']')
            {
                int k=cnt.Pop();
                var prev = sbStack.Pop();
                for(int i=0;i<k;i++)
                {
                    prev.Append(currentStr);
                }
                currentStr =prev;
            }
            else
            {
                currentStr.Append(c);
            }
        }

        return currentStr.ToString();
    }
}