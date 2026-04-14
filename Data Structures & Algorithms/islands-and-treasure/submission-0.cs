public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        int m= grid.Length;
        int n = grid[0].Length;
        Queue<(int,int)> q= new Queue<(int,int)>();
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]== 0)
                {
                    q.Enqueue((i,j));
                }

            }
        }

        if(q.Count == 0) return;
        int [][] directions = new int[4][]{ new int[] {-1,0}, new int[] {1,0}, new int[] {0,-1}, new int[] {0,1}};
        while(q.Count>0)
        {
            var pos = q.Dequeue();
            int row = pos.Item1;
            int col = pos.Item2;

            for(int i=0;i<directions.Length;i++)
            {
                int newRow = row+directions[i][0];
                int newCol = col+directions[i][1];

                if(newRow <0 || newRow >= m||newCol <0 || newCol>=n||grid[newRow][newCol]!=int.MaxValue)
                {
                    continue;
                }
                q.Enqueue((newRow,newCol));
                grid[newRow][newCol] = grid[row][col]+1;
            }
        }
    }
}
