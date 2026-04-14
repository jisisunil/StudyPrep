public class PrefixTree {
    TrieNode root = null;
    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode node = root;

        foreach(var c in word)
        {
            if(!node.Children.ContainsKey(c))
            {
                node.Children[c] = new TrieNode();
            }
            node = node.Children[c];
        }
        node.isEndofWord=true;
    }
    
    public bool Search(string word) {
        TrieNode node = root;
        foreach(char c in word)
        {
            if(!node.Children.ContainsKey(c))
            {
                return false;
            }
            node = node.Children[c];
        }
        return node!=null && node.isEndofWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode node=root;

        foreach(char c in prefix)
        {
            if(!node.Children.ContainsKey(c))
            {
                return false;
            }
            node = node.Children[c];
        }

        return node!=null;
    }
}


public class TrieNode
{
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public bool isEndofWord=false;
}
