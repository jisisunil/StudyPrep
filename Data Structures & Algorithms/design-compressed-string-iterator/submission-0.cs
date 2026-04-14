public class StringIterator {
    string s;
    int index=0;
    int count=0;
    char currentChar;
    public StringIterator(string compressedString) {
        s= compressedString;
        index=0;
        count=0;
    }

    public char Next() {
        if(!HasNext())
            return ' ';
        if(count==0)
        {
            currentChar = s[index++];
            int  num=0;
            while(index<s.Length && char.IsDigit(s[index]))
            {
                num=num*10+(s[index]-'0');
                index++;
            }

            count=num;

        }
        count--;
        return currentChar;
        
    }

    public bool HasNext() {
        return count>0 || index<s.Length;
    }
}

/**
 * Your StringIterator object will be instantiated and called as such:
 * StringIterator obj = new StringIterator(compressedString);
 * char param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
