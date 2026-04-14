public class Solution {
    public int OrangesRotting(int[][] grid) {
        
        int m= grid.Length;
        int n= grid[0].Length;
        Queue<(int,int)> q= new Queue<(int,int)>();
        int freshoranges =0;
        int[][] directions = new int[4][] { new int[]{-1,0}, new int[] {1,0}, new int[]{0, -1}, new int[]{0,1}};
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]==2)
                {
                    //enqueue row,col positions
                    q.Enqueue((i,j));
                }
                if(grid[i][j] ==1)
                {
                    freshoranges++;
                }
            }
        }

        if(freshoranges==0) return 0;
        int level=-1;
        while(q.Count>0)
        {
            int count = q.Count;
            level++;
            while(count > 0)
            {
                var pos = q.Dequeue();
                for(int i=0;i<directions.Length;i++)
                {
                    int newRow = pos.Item1+ directions[i][0];
                    int newCol = pos.Item2+directions[i][1];

                    if(newRow <0 || newRow >= m || newCol <0|| newCol >=n|| grid[newRow][newCol]==2||grid[newRow][newCol]==0)
                    {
                        continue;
                    }
                    grid[newRow][newCol] =2;
                    freshoranges--;
                    q.Enqueue((newRow,newCol));
                }
                count--;
            }

        }

        return freshoranges==0?level:-1;
    }
}
