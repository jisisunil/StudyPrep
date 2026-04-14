/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution {
    public Node Construct(int[][] grid) {

        return DFS(grid, grid.Length,0,0);
        
    }


    private Node DFS(int[][] grid, int n, int row, int col)
    {
        if (IsUniform(grid,n, row, col)) {
            return new Node(grid[row][col] == 1, true);
        }
        int half=n/2;

        Node topLeft = DFS(grid, half, row,col);
        Node topRight = DFS(grid, half, row, col+half);
        Node bottomLeft = DFS(grid, half, row+half, col);
        Node bottomRight = DFS(grid, half, row+half, col+half);

        return new Node(false, false, topLeft, topRight, bottomLeft, bottomRight);
    }

    private bool IsUniform(int[][] grid, int n, int row, int col)
    {
        for(int i=0;i<n ;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[row][col]!=grid[row+i][col+j])
                {
                    return false;
                }
            }
        }

        return true;

    }
}