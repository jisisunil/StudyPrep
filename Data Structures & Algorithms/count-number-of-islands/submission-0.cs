public class Solution {
    public int NumIslands(char[][] grid) {
        

        int m = grid.Length;
        int n = grid[0].Length;
        int numIslands=0;
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]=='1')
                {
                    numIslands++;
                    dfs(grid,i,j);
                }
            }
        }
        return numIslands;
    }

    private void dfs(char[][] grid, int row, int col)
    {
        if(row<0 || row>=grid.Length)
        {
            return;
        }
        if(col<0 || col>= grid[0].Length)
        {
            return;
        }
        if(grid[row][col]!='1')
        {
            return;
        }
        grid[row][col]='0';

        dfs(grid, row-1,col);
        dfs(grid, row+1, col);
        dfs(grid, row, col-1);
        dfs(grid, row, col+1);
    }
}
