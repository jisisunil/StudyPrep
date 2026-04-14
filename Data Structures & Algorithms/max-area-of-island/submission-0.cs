public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {

        int maxArea=0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                if(grid[i][j]==1)
                {
                    maxArea = Math.Max(maxArea, dfs(grid, i,j));
                }
            }
        }
        return maxArea;
        
    }

    private int dfs(int[][] grid, int row, int col)
    {
        if(row<0 || row >=grid.Length || col<0||col>=grid[0].Length||grid[row][col]==0)
        {
            return 0;
        }
        grid[row][col]=0;
        return 1+dfs(grid, row-1, col)+
        dfs(grid, row+1, col)+
        dfs(grid, row, col-1)+
        dfs(grid, row, col+1);
    }
}
