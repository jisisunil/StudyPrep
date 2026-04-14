public class WordDictionary {
    TrieNode root;
    public WordDictionary() {
        root=new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode node = root;
        foreach(char c in word)
        {
            if(!node.children.ContainsKey(c))
            {
                node.children[c] = new TrieNode();
            }
            node = node.children[c];
        }

        node.isEndOfWord = true;
    }
    
    public bool Search(string word) {
        return SearchRecursive(word, 0, root);
        
    }

    private bool SearchRecursive(string word, int index, TrieNode node)
    {
        if(node == null) return false;
        if(index==word.Length) return node.isEndOfWord;        

        char c = word[index];

        if(c=='.')
        {
            foreach(var child in node.children.Values)
            {
                if(SearchRecursive(word, index+1, child))
                {
                    return true; 
                }
            }
            return false;
        }
        else
        {
            if(!node.children.ContainsKey(c))
                return false;
            return SearchRecursive(word, index+1, node.children[c]);
        }
    }
}

public class TrieNode
{
    public Dictionary<char, TrieNode> children = new Dictionary<char,TrieNode>();
    public bool isEndOfWord = false;
}