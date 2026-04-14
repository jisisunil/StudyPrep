public class Solution {
     List<string> result = new List<string>();
         Dictionary<char, string> directory = new Dictionary<char, string>() {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }};
    public List<string> LetterCombinations(string digits) {
       

        if(digits.Length!=0)
        dfs(digits, 0,"");
        return result;
    }

    private void dfs(string digits, int index, string newword)
    {
        if(index==digits.Length)
        {
            result.Add(newword);
            return;
        }
        string letters = directory[digits[index]];
        for(int i=0;i<letters.Length;i++)
        {
            char letter = letters[i];
            dfs(digits, index+1, newword+letter );
        }
    }
}
