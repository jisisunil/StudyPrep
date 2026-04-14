public class Solution
{
    class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public string word = null;   // store full word at terminal node
    }

    public List<string> FindWords(char[][] board, string[] words)
    {
        var result = new List<string>();
        var root = BuildTrie(words);

        int rows = board.Length;
        int cols = board[0].Length;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                DFS(board, r, c, root, result);
            }
        }

        return result;
    }

    private TrieNode BuildTrie(string[] words)
    {
        var root = new TrieNode();

        foreach (var word in words)
        {
            var node = root;
            foreach (char ch in word)
            {
                if (!node.children.ContainsKey(ch))
                    node.children[ch] = new TrieNode();

                node = node.children[ch];
            }

            node.word = word; // mark end of word
        }

        return root;
    }

    private void DFS(char[][] board, int r, int c, TrieNode node, List<string> result)
    {
        char ch = board[r][c];

        if (!node.children.ContainsKey(ch))
            return;

        node = node.children[ch];

        // Found a word
        if (node.word != null)
        {
            result.Add(node.word);
            node.word = null; // avoid duplicates
        }

        // Mark visited
        board[r][c] = '#';

        int[][] directions = new int[][]
        {
            new int[]{0,1},
            new int[]{0,-1},
            new int[]{1,0},
            new int[]{-1,0}
        };

        foreach (var dir in directions)
        {
            int newR = r + dir[0];
            int newC = c + dir[1];

            if (newR >= 0 && newR < board.Length &&
                newC >= 0 && newC < board[0].Length &&
                board[newR][newC] != '#')
            {
                DFS(board, newR, newC, node, result);
            }
        }

        // Backtrack
        board[r][c] = ch;

        // Optional pruning: remove leaf nodes
        if (node.children.Count == 0)
        {
            // This requires parent tracking to fully prune,
            // omitted here for clarity (core solution still optimal).
        }
    }
}
