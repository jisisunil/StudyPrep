public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        

        List<(int position,double time)> cars = new List<(int, double)>();

        for(int i=0;i<position.Length;i++)
        {
            double time = (double)(target-position[i])/speed[i];
            cars.Add((position[i],time));
        }
        
        
    
        Stack<double> stk = new Stack<double>();
        //sort desc

        cars.Sort((a,b)=>b.position.CompareTo(a.position));

        foreach(var car in cars)
        {
            if(stk.Count==0 || car.time > stk.Peek())
            {
                stk.Push(car.time);
            }
        }
        return stk.Count();
    }
}
