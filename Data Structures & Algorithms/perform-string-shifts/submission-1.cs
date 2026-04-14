public class Solution {
    public string StringShift(string s, int[][] shift) {
        //net shift
        int netshift=0;
        int n=s.Length;
        foreach(var op in shift)
        {
            if(op[0]==0)
            {
                netshift-=op[1];
            }
            else
            {
                netshift+=op[1];
            }

        }
        //normalise
        //Modulo removes redundant full rotations and keeps only the effective shift
        //“Since shifting by n results in the same string, I reduce netShift using modulo to get the effective rotation.”
        netshift%=n;
        if(netshift<0)
        {
            //“After modulo, the shift can be negative. 
            //A negative shift represents a left rotation, 
            //so I convert it into an equivalent right rotation by adding the string length. This lets me handle only one direction.”
            netshift+=n;
        }
        //now perform right shift
        return s.Substring(n-netshift)+s.Substring(0,n-netshift);
    }
}
