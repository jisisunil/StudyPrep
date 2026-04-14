public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        bool hasX=false, hasY=false,hasZ=false;
        foreach(var t in triplets)
        {
            if(t[0]>target[0] || t[1]>target[1] ||t[2] > target[2])
            {
                continue;
            }
            if(t[0] == target[0])
            {
                hasX=true;
            }
            if(t[1] == target[1])
            {
                hasY=true;
            }
            if(t[2] == target[2])
            {
                hasZ= true;
            }
        }
        return hasX && hasY && hasZ;

    }
}
