public class Solution {
    private HashSet<(int,int)> visited ;
    public int IslandPerimeter(int[][] grid) {
        visited = new HashSet<(int,int)>();
        int result=0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {// compute once from the first land cell
                if(grid[i][j] ==1)
                {
                    return dfs(grid, i,j);
                }
            }
        }
        return 0;
    }

    private int dfs(int[][] grid, int row, int col)
    {
         // hit water or boundary -> contributes 1 edge to perimeter
        if(row<0 || row >= grid.Length || col<0|| col >= grid[0].Length|| grid[row][col]==0)
        {
            return 1;
        }

        if(visited.Contains((row,col)))
        {
            return 0;
        }

        visited.Add((row,col));
        int perim = dfs(grid,row, col+1)+dfs(grid, row, col-1)+dfs(grid, row+1,col)+dfs(grid, row-1, col);
        return perim;
    }
}