public class Solution {
    public int NumIslands(char[][] grid) {
        

        int rows = grid.Length;
        int cols = grid[0].Length;
        int num=0;
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                if(grid[i][j]=='1')
                {
                    num++;

                    dfs(grid, i, j);
                }
            }
        }
        return num;
    }

    private void dfs(char[][] grid, int row, int col)
    {
        if(row<0 || row>=grid.Length || col<0|| col>=grid[0].Length||grid[row][col]!='1')
        {
            return;
        }
        grid[row][col]='0';

        dfs(grid, row+1,col);
        dfs(grid, row-1,col);
        dfs(grid, row, col+1);
        dfs(grid, row, col-1);
    }
}
