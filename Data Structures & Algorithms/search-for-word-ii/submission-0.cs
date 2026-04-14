public class Solution {
    HashSet<string> result ;
    public List<string> FindWords(char[][] board, string[] words) {
     result = new HashSet<string>();
     Trie trie = new Trie();
     foreach(var word in words)
     {
        trie.Insert(word);
     }

     TrieNode root = trie.GetRoot();
     for(int i=0;i<board.Length;i++)
     {
        for(int j=0;j<board[0].Length;j++)
        {
            int index = board[i][j]-'a';
            if(root.children[index]!=null)
            {
                backtrack(board, i, j, root);
            }
        }
     }
     return new List<string>(result);

    }

    private void backtrack(char[][] board, int row, int col, TrieNode root)
    {
        if (row < 0 || col < 0 || row >= board.Length || col >= board[0].Length || board[row][col] == '#')
            return;
        char letter = board[row][col];
        int index = letter-'a';

        TrieNode current = root.children[index];
        if(current==null) return;

        if(current.word!=null)
        {
            result.Add(current.word);
            current.word=null;
        }

        board[row][col]='#';
        backtrack(board, row+1, col, current);
        backtrack(board, row-1, col, current);
        backtrack(board, row, col+1, current);
        backtrack(board, row, col-1, current);
        board[row][col]=letter;

    }
}

public class TrieNode
{
    public TrieNode[] children = new TrieNode[26];
    public string word = null;
}


public class Trie
{
    TrieNode root = null;
    public Trie()
    {
        root = new TrieNode();

    }

    public void Insert(string word)
    {
        TrieNode node=root;
       
        foreach(var c in word)
        {
            int index = c-'a';
            if(node.children[index]==null)
            {
                node.children[index] = new TrieNode();
            }
            node= node.children[index];
        }
        node.word = word;
    }

    public TrieNode GetRoot()
    {
        return root;
    }
}